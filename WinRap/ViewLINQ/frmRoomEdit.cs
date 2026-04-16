using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;
using System.Data.Entity;
using Guna.UI2.WinForms;

namespace WinRap.ViewLINQ
{
    public partial class frmRoomEdit : Form
    {
        private int _maPhong;
        private int _rows = 10;
        private int _cols = 12;
        private int? _maSuatChieuHienTai = null;
        private Timer _refreshTimer;

        // Bảng màu Lotte chuẩn
        private readonly Color clrGheThuong = Color.FromArgb(74, 101, 114); 
        private readonly Color clrGheVip = Color.FromArgb(231, 76, 60);     
        private readonly Color clrGheDaBan = Color.FromArgb(149, 165, 166); 
        private readonly Color clrGheDangChon = Color.FromArgb(94, 148, 255);

        // Dictionary để truy xuất Button nhanh qua mã ghế (Vd: "A1")
        private Dictionary<string, Guna2Button> _seatButtons = new Dictionary<string, Guna2Button>();
        private bool _isDataLoaded = false;

        public frmRoomEdit(int maPhong)
        {
            InitializeComponent();
            _maPhong = maPhong;
            this.DoubleBuffered = true;
            InitLegend();
            
            pnlSeatPreview.SizeChanged += (s, e) => {
                if (_isDataLoaded) RepositionSeats();
            };

            // Khởi tạo Timer để cập nhật Real-time mỗi 5 giây
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 5000;
            _refreshTimer.Tick += async (s, e) => await UpdateRealtimeStatus();
        }

        private async void frmRoomEdit_Load(object sender, EventArgs e)
        {
            await LoadRoomData();
            _isDataLoaded = true;
            GenerateSeatsFromDB(); 
            _refreshTimer.Start();
        }

        private void InitLegend()
        {
            pnlLegend.Controls.Clear();
            AddLegendItem(clrGheThuong, "Ghế thường", 300);
            AddLegendItem(clrGheVip, "Ghế VIP", 450);
            AddLegendItem(clrGheDaBan, "Đã có khách", 600);
        }

        private void AddLegendItem(Color color, string text, int x)
        {
            Guna2CirclePictureBox dot = new Guna2CirclePictureBox { Size = new Size(14, 14), FillColor = color, Location = new Point(x, 28) };
            Label lbl = new Label { Text = text, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(x + 22, 25), AutoSize = true };
            pnlLegend.Controls.Add(dot);
            pnlLegend.Controls.Add(lbl);
        }

        private async Task LoadRoomData()
        {
            try
            {
                using (var db = new DataContext())
                {
                    var room = await db.PhongChieus.FindAsync(_maPhong);
                    if (room != null)
                    {
                        lblTitle.Text = "GIÁM SÁT & CẤU HÌNH SƠ ĐỒ GHẾ - " + room.TenPhong.ToUpper();
                        _rows = room.SoHang ?? 10;
                        _cols = room.SoCot ?? 12;

                        // Tìm suất chiếu đang diễn ra hoặc sắp diễn ra gần nhất
                        DateTime now = DateTime.Now;
                        var showtime = await db.SuatChieus
                            .Include(s => s.Phim)
                            .Where(s => s.MaPhong == _maPhong && s.NgayChieu == now.Date && s.GioKetThuc > now.TimeOfDay)
                            .OrderBy(s => s.GioBatDau)
                            .FirstOrDefaultAsync();

                        if (showtime != null)
                        {
                            _maSuatChieuHienTai = showtime.MaSuatChieu;
                            lblScreenText.Text = $"PHIM: {showtime.Phim.TenPhim.ToUpper()} ({showtime.GioBatDau:hh\\:mm} - {showtime.GioKetThuc:hh\\:mm})";
                        }
                        else
                        {
                            lblScreenText.Text = "MÀN HÌNH CHÍNH (CHƯA CÓ SUẤT CHIẾU)";
                            _maSuatChieuHienTai = null;
                        }
                    }
                }
            }
            catch { }
        }

        private void GenerateSeatsFromDB()
        {
            pnlSeatPreview.Controls.Clear();
            _seatButtons.Clear();
            pnlSeatPreview.SuspendLayout();

            using (var db = new DataContext())
            {
                // Lấy danh sách ghế thực tế trong DB
                var listGhe = db.Ghes.Where(g => g.MaPhong == _maPhong).ToList();

                // Nếu chưa có ghế nào trong DB, tự động tạo mới theo layout
                if (listGhe.Count == 0)
                {
                    listGhe = InitializeSeatsInDB();
                }

                foreach (var ghe in listGhe)
                {
                    string seatCode = ghe.TenGhe;
                    Guna2Button btn = new Guna2Button {
                        Text = seatCode,
                        Size = new Size(45, 40),
                        BorderRadius = 4,
                        Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                        ForeColor = Color.White,
                        Cursor = Cursors.Hand,
                        Tag = ghe, // Lưu object ghe để xử lý Click
                        FillColor = ghe.MaLoaiGhe == 2 ? clrGheVip : clrGheThuong
                    };

                    btn.Click += BtnSeat_Click;
                    _seatButtons.Add(seatCode, btn);
                    pnlSeatPreview.Controls.Add(btn);
                }
            }

            pnlSeatPreview.ResumeLayout();
            RepositionSeats();
            
            // Cập nhật trạng thái đã bán ngay lập tức
            _ = UpdateRealtimeStatus();
        }

        private List<tblGhe> InitializeSeatsInDB()
        {
            List<tblGhe> newSeats = new List<tblGhe>();
            using (var db = new DataContext())
            {
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                for (int i = 0; i < _rows; i++)
                {
                    for (int j = 1; j <= _cols; j++)
                    {
                        string seatCode = alpha[i].ToString() + j.ToString();
                        var ghe = new tblGhe {
                            MaPhong = _maPhong,
                            TenGhe = seatCode,
                            Hang = alpha[i].ToString(),
                            Cot = j,
                            MaLoaiGhe = 1 // Mặc định là ghế thường
                        };
                        db.Ghes.Add(ghe);
                        newSeats.Add(ghe);
                    }
                }
                db.SaveChanges();
            }
            return newSeats;
        }

        private async void BtnSeat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            tblGhe ghe = btn.Tag as tblGhe;

            // Nếu ghế đã bán thì không cho đổi loại trong chế độ giám sát (tùy chọn)
            if (btn.FillColor == clrGheDaBan)
            {
                MessageBox.Show("Ghế này đã có khách đặt, không thể thay đổi loại ghế lúc này!", "Thông báo");
                return;
            }

            // Đổi loại ghế: Thường (1) <-> VIP (2)
            int newType = (ghe.MaLoaiGhe == 2) ? 1 : 2;
            
            try {
                using (var db = new DataContext()) {
                    var seatInDb = await db.Ghes.FindAsync(ghe.MaGhe);
                    if (seatInDb != null) {
                        seatInDb.MaLoaiGhe = newType;
                        ghe.MaLoaiGhe = newType; // Cập nhật local object
                        await db.SaveChangesAsync();
                        
                        // Cập nhật giao diện
                        btn.FillColor = (newType == 2) ? clrGheVip : clrGheThuong;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Lỗi cập nhật loại ghế: " + ex.Message);
            }
        }

        private async Task UpdateRealtimeStatus()
        {
            if (_maSuatChieuHienTai == null) return;

            try
            {
                using (var db = new DataContext())
                {
                    // Lấy danh sách mã ghế đã bán của suất chiếu hiện tại
                    var soldSeats = await db.Ves
                        .Where(v => v.MaSuatChieu == _maSuatChieuHienTai && v.TrangThai != "Đã hủy")
                        .Select(v => v.Ghe.TenGhe)
                        .ToListAsync();

                    foreach (var entry in _seatButtons)
                    {
                        string seatCode = entry.Key;
                        Guna2Button btn = entry.Value;
                        tblGhe ghe = btn.Tag as tblGhe;

                        if (soldSeats.Contains(seatCode))
                        {
                            btn.FillColor = clrGheDaBan;
                            btn.Enabled = false; // Vô hiệu hóa khi đã bán
                        }
                        else
                        {
                            btn.Enabled = true;
                            btn.FillColor = (ghe.MaLoaiGhe == 2) ? clrGheVip : clrGheThuong;
                        }
                    }
                }
            }
            catch { }
        }

        private void RepositionSeats()
        {
            if (pnlSeatPreview.Controls.Count == 0) return;

            int seatW = 45;
            int seatH = 40;
            int margin = 6;
            
            int totalGridWidth = _cols * (seatW + margin) - margin;
            int startX = (pnlSeatPreview.Width - totalGridWidth) / 2;
            if (startX < 20) startX = 20;
            int startY = 20;

            pnlSeatPreview.SuspendLayout();
            // Sắp xếp lại dựa trên Hang và Cot trong Tag
            foreach (Control ctrl in pnlSeatPreview.Controls)
            {
                if (ctrl is Guna2Button btn && btn.Tag is tblGhe ghe)
                {
                    int rowIndex = ghe.Hang[0] - 'A';
                    int colIndex = (ghe.Cot ?? 1) - 1;
                    btn.Location = new Point(startX + colIndex * (seatW + margin), startY + rowIndex * (seatH + margin));
                }
            }
            pnlSeatPreview.ResumeLayout();

            pnlScreenLine.Left = (pnlScreenArea.Width - pnlScreenLine.Width) / 2;
            lblScreenText.Left = (pnlScreenArea.Width - lblScreenText.Width) / 2;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _refreshTimer.Stop();
            _refreshTimer.Dispose();
            base.OnFormClosing(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain.Instance.container(new frmRoom());
        }
    }
}