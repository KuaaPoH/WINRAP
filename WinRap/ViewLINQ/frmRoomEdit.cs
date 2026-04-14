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
        private int _rows = 0;
        private int _cols = 0;

        public frmRoomEdit(int maPhong)
        {
            InitializeComponent();
            _maPhong = maPhong;
            InitLegend();
        }

        private async void frmRoomEdit_Load(object sender, EventArgs e)
        {
            await LoadRoomData();
        }

        private void InitLegend()
        {
            pnlLegend.Controls.Clear();
            AddLegendItem(Color.FromArgb(189, 195, 199), "Ghế thường", 300);
            AddLegendItem(Color.FromArgb(155, 89, 182), "Ghế VIP", 450);
            AddLegendItem(Color.FromArgb(255, 82, 82), "Đã có khách", 600);
        }

        private void AddLegendItem(Color color, string text, int x)
        {
            Guna2CirclePictureBox dot = new Guna2CirclePictureBox { Size = new Size(12, 12), FillColor = color, Location = new Point(x, 28) };
            Label lbl = new Label { Text = text, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(x + 18, 25), AutoSize = true };
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
                        lblTitle.Text = "GIÁM SÁT SƠ ĐỒ GHẾ - " + room.TenPhong.ToUpper();
                        
                        _rows = room.SoHang ?? 10;
                        _cols = room.SoCot ?? 12;

                        // Đảm bảo UI đã render xong kích thước Panel trước khi vẽ ghế
                        this.Update(); 
                        GenerateSeatPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message);
            }
        }

        private void GenerateSeatPreview()
        {
            if (_rows <= 0 || _cols <= 0) return;

            pnlSeatPreview.Controls.Clear();
            
            int seatSize = 45; 
            int margin = 8;
            
            if (_cols > 15 || _rows > 12) seatSize = 35;

            // Lấy kích thước thực tế của Panel tại thời điểm này
            int pnlW = pnlSeatPreview.Width;
            int pnlH = pnlSeatPreview.Height;

            // Nếu Panel chưa có kích thước (do chưa hiển thị), thoát ra
            if (pnlW == 0 || pnlH == 0) return;

            int totalW = _cols * (seatSize + margin) - margin;
            int totalH = _rows * (seatSize + margin) - margin;
            
            int startX = (pnlW - totalW) / 2;
            int startY = (pnlH - totalH) / 2;

            if (startX < 20) startX = 20;
            if (startY < 20) startY = 20;

            int vipStartRow = _rows / 3;
            int vipEndRow = vipStartRow + (_rows / 3);
            int vipStartCol = _cols / 4;
            int vipEndCol = _cols - vipStartCol;

            for (int i = 0; i < _rows; i++)
            {
                char rowChar = (char)('A' + i);
                for (int j = 1; j <= _cols; j++)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = rowChar.ToString() + j.ToString();
                    btn.Size = new Size(seatSize, seatSize);
                    btn.Location = new Point(startX + (j - 1) * (seatSize + margin), startY + i * (seatSize + margin));
                    btn.BorderRadius = 6;
                    btn.Font = new Font("Segoe UI", seatSize > 40 ? 8F : 7F, FontStyle.Bold);
                    btn.ForeColor = Color.White;

                    bool isVIP = (i >= vipStartRow && i <= vipEndRow) && (j >= vipStartCol && j <= vipEndCol);
                    bool isSold = (i < 2 && j % 4 == 0) || (i == _rows - 1 && j % 3 == 0);

                    if (isSold)
                    {
                        btn.FillColor = Color.FromArgb(255, 82, 82);
                        btn.Enabled = false;
                    }
                    else if (isVIP)
                    {
                        btn.FillColor = Color.FromArgb(155, 89, 182);
                    }
                    else
                    {
                        btn.FillColor = Color.FromArgb(189, 195, 199);
                    }

                    pnlSeatPreview.Controls.Add(btn);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain.Instance.container(new frmRoom());
        }
    }
}