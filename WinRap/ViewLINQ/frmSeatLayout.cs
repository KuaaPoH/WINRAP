using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmSeatLayout : Form
    {
        private DataContext db = new DataContext();
        private int _maSuatChieu;
        private int _maPhong;
        private decimal _giaGoc;
        private List<int> selectedSeatIds = new List<int>();
        private decimal totalPrice = 0;
        private Timer _refreshTimer;

        private readonly Color clrGheThuong = Color.FromArgb(74, 101, 114); 
        private readonly Color clrGheVip = Color.FromArgb(231, 76, 60);     
        private readonly Color clrGheDaBan = Color.FromArgb(149, 165, 166); 
        private readonly Color clrGheDangChon = Color.FromArgb(94, 148, 255);

        private Dictionary<int, Guna2Button> _seatButtons = new Dictionary<int, Guna2Button>();
        private Dictionary<string, Label> _rowLabels = new Dictionary<string, Label>();
        private bool _isDataLoaded = false;

        public frmSeatLayout(int maSuatChieu)
        {
            InitializeComponent();
            _maSuatChieu = maSuatChieu;
            this.DoubleBuffered = true;

            var sc = db.SuatChieus.Find(_maSuatChieu);
            if (sc != null)
            {
                _maPhong = sc.MaPhong ?? 0;
                _giaGoc = sc.GiaVeCoBan;
                var room = db.PhongChieus.Find(_maPhong);
                lblRoomInfo.Text = $"PHÒNG: {room?.TenPhong} - SƠ ĐỒ GHẾ";
            }

            pnlSeats.SizeChanged += (s, e) => {
                if (_isDataLoaded) RepositionSeats();
            };

        
            _refreshTimer = new Timer();
            _refreshTimer.Interval = 5000;
            _refreshTimer.Tick += async (s, e) => await UpdateRealtimeStatus();

            InitLegendColors();
        }

        private void InitLegendColors()
        {
            guna2CircleButton1.FillColor = clrGheThuong;
            guna2CircleButton2.FillColor = clrGheVip;
            guna2CircleButton3.FillColor = clrGheDaBan;
            guna2CircleButton4.FillColor = clrGheDangChon;
        }

        private async void frmSeatLayout_Load(object sender, EventArgs e)
        {
            await GenerateSeatsAsync();
            _isDataLoaded = true;
            _refreshTimer.Start();
        }

        private async Task GenerateSeatsAsync()
        {
            pnlSeats.Controls.Clear();
            _seatButtons.Clear();
            _rowLabels.Clear();

            try
            {
                var listGhe = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return (from g in context.Ghes
                                join l in context.LoaiGhes on g.MaLoaiGhe equals l.MaLoaiGhe
                                where g.MaPhong == _maPhong
                                select new {
                                    g.MaGhe,
                                    g.TenGhe,
                                    g.Hang,
                                    g.Cot,
                                    g.MaLoaiGhe,
                                    l.TenLoaiGhe,
                                    l.GiaPhuThu
                                }).ToList();
                    }
                });

                pnlSeats.SuspendLayout();

              
                var distinctRows = listGhe.Select(g => g.Hang).Distinct().OrderBy(h => h).ToList();
                foreach (var hang in distinctRows)
                {
                    Label lblHang = new Label();
                    lblHang.Text = hang;
                    lblHang.AutoSize = false;
                    lblHang.Size = new Size(30, 38);
                    lblHang.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    lblHang.ForeColor = Color.DimGray;
                    lblHang.TextAlign = ContentAlignment.MiddleCenter;
                    _rowLabels.Add(hang, lblHang);
                    pnlSeats.Controls.Add(lblHang);
                }

                foreach (var ghe in listGhe)
                {
                    Guna2Button btnSeat = new Guna2Button();
                    btnSeat.Text = ghe.Cot.ToString(); 
                    btnSeat.Size = new Size(38, 38);
                    btnSeat.BorderRadius = 5;
                    btnSeat.Font = new Font("Segoe UI", 6.5f, FontStyle.Bold);
                    btnSeat.Padding = new Padding(0);
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Tag = ghe;

                    btnSeat.FillColor = ghe.MaLoaiGhe == 2 ? clrGheVip : clrGheThuong;

                    btnSeat.Click += BtnSeat_Click;
                    _seatButtons.Add(ghe.MaGhe, btnSeat);
                    pnlSeats.Controls.Add(btnSeat);
                }
                pnlSeats.ResumeLayout();
                RepositionSeats();
                await UpdateRealtimeStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sơ đồ ghế: " + ex.Message);
            }
        }

        private void RepositionSeats()
        {
            if (_seatButtons.Count == 0) return;

            int seatWidth = 38;
            int seatHeight = 38;
            int margin = 6;
            int rowLabelWidth = 40;

            var listGhe = _seatButtons.Values.Select(b => (dynamic)b.Tag).ToList();
            int maxCol = listGhe.Max(g => (int)(g.Cot ?? 1));
            int totalWidth = maxCol * (seatWidth + margin) - margin + rowLabelWidth;
            int startX = (pnlSeats.Width - totalWidth) / 2;
            if (startX < 20) startX = 20;

            int startY = 20;

            pnlSeats.SuspendLayout();

           
            foreach (var entry in _rowLabels)
            {
                int rowIdx = entry.Key[0] - 'A';
                entry.Value.Location = new Point(startX, startY + rowIdx * (seatHeight + margin));
                entry.Value.Size = new Size(rowLabelWidth - 10, seatHeight);
            }

           
            foreach (var btn in _seatButtons.Values)
            {
                dynamic ghe = btn.Tag;
                int x = startX + rowLabelWidth + ((ghe.Cot ?? 1) - 1) * (seatWidth + margin);
                int rowIdx = ghe.Hang[0] - 'A';
                int y = startY + rowIdx * (seatHeight + margin);
                btn.Location = new Point(x, y);
            }
            pnlSeats.ResumeLayout();
            
            pnlScreenLine.Left = (pnlScreenArea.Width - pnlScreenLine.Width) / 2;
            lblScreenText.Left = (pnlScreenArea.Width - lblScreenText.Width) / 2;
        }

        private async Task UpdateRealtimeStatus()
        {
            try
            {
                var soldSeats = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return context.Ves
                            .Where(v => v.MaSuatChieu == _maSuatChieu && v.TrangThai != "Đã hủy")
                            .Select(v => v.MaGhe)
                            .ToList();
                    }
                });

                foreach (var entry in _seatButtons)
                {
                    int maGhe = entry.Key;
                    Guna2Button btn = entry.Value;
                    dynamic ghe = btn.Tag;

                    if (soldSeats.Contains(maGhe))
                    {
                        btn.FillColor = clrGheDaBan;
                        btn.Enabled = false;
                        if (selectedSeatIds.Contains(maGhe))
                        {
                            selectedSeatIds.Remove(maGhe);
                            totalPrice -= (_giaGoc + (ghe.GiaPhuThu ?? 0));
                            lblTotalPrice.Text = string.Format("{0:N0} VND", totalPrice);
                        }
                    }
                    else if (!selectedSeatIds.Contains(maGhe))
                    {
                        btn.Enabled = true;
                        btn.FillColor = ghe.MaLoaiGhe == 2 ? clrGheVip : clrGheThuong;
                    }
                }
            }
            catch { }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            dynamic ghe = btn.Tag;
            int maGhe = ghe.MaGhe;
            decimal giaVe = _giaGoc + (ghe.GiaPhuThu ?? 0);

            if (selectedSeatIds.Contains(maGhe)) 
            {
                selectedSeatIds.Remove(maGhe);
                totalPrice -= giaVe;
                btn.FillColor = ghe.MaLoaiGhe == 2 ? clrGheVip : clrGheThuong;
            }
            else 
            {
                selectedSeatIds.Add(maGhe);
                totalPrice += giaVe;
                btn.FillColor = clrGheDangChon;
            }

            lblTotalPrice.Text = string.Format("{0:N0} VND", totalPrice);
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedSeatIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận thanh toán {selectedSeatIds.Count} vé?\nTổng tiền: {lblTotalPrice.Text}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int maNguoiDung = 1; 
                 
                    if (frmMain.Instance != null && !string.IsNullOrEmpty(frmMain.Instance.Username))
                    {
                        var currentUser = db.NguoiDungs.FirstOrDefault(u => u.TenDangNhap == frmMain.Instance.Username);
                        if (currentUser != null)
                        {
                            maNguoiDung = currentUser.MaNguoiDung;
                        }
                    }
                    else 
                    {
                     
                        var firstUser = db.NguoiDungs.FirstOrDefault();
                        if (firstUser != null) maNguoiDung = firstUser.MaNguoiDung;
                    }

                    foreach (int maGhe in selectedSeatIds)
                    {
                        dynamic ghe = _seatButtons[maGhe].Tag;
                        tblVe ve = new tblVe
                        {
                            MaSuatChieu = _maSuatChieu,
                            MaGhe = maGhe,
                            MaNguoiDung = maNguoiDung,
                            MaKhachHang = null, 
                            NgayDat = DateTime.Now,
                            TongTien = _giaGoc + (ghe.GiaPhuThu ?? 0),
                            TrangThai = "Đã bán"
                        };
                        db.Ves.Add(ve);
                    }

                    await db.SaveChangesAsync();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain.Instance.container(new frmTicket());
                }
                catch (Exception ex)
                {
                    string innerError = ex.InnerException != null ? ex.InnerException.Message : "";
                    if (ex.InnerException?.InnerException != null) 
                    {
                        innerError += "\n" + ex.InnerException.InnerException.Message;
                    }
                    MessageBox.Show("Lỗi khi lưu vé: " + ex.Message + "\nChi tiết: " + innerError, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Instance.container(new frmTicket());
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _refreshTimer.Stop();
            _refreshTimer.Dispose();
            base.OnFormClosing(e);
        }
    }
}
