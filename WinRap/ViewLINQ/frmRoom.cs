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
using System.Data.Entity;

namespace WinRap.ViewLINQ
{
    public partial class frmRoom : Form
    {
        private Timer updateTimer;

        public frmRoom()
        {
            InitializeComponent();
            
            updateTimer = new Timer();
            updateTimer.Interval = 60000; 
            updateTimer.Tick += (s, e) => LoadRoomCardsAsync();
            updateTimer.Start();
        }

        private async void frmRoom_Load(object sender, EventArgs e)
        {
            await CheckAndInitDefaultRooms();
            await LoadRoomCardsAsync();
        }

        private async Task CheckAndInitDefaultRooms()
        {
            try
            {
                using (var db = new DataContext())
                {
                    if (!await db.PhongChieus.AnyAsync())
                    {
                        var defaultRooms = new List<tblPhongChieu>
                        {
                            new tblPhongChieu { TenPhong = "Phòng 01", LoaiPhong = "IMAX", TongSoGhe = 120, SoHang = 10, SoCot = 12, TrangThai = "Hoạt động" },
                            new tblPhongChieu { TenPhong = "Phòng 02", LoaiPhong = "2D", TongSoGhe = 80, SoHang = 8, SoCot = 10, TrangThai = "Hoạt động" },
                            new tblPhongChieu { TenPhong = "Phòng 03", LoaiPhong = "3D", TongSoGhe = 64, SoHang = 8, SoCot = 8, TrangThai = "Bảo trì" },
                            new tblPhongChieu { TenPhong = "Phòng 04", LoaiPhong = "2D", TongSoGhe = 80, SoHang = 8, SoCot = 10, TrangThai = "Hoạt động" },
                            new tblPhongChieu { TenPhong = "Phòng 05", LoaiPhong = "2D", TongSoGhe = 80, SoHang = 8, SoCot = 10, TrangThai = "Hoạt động" },
                            new tblPhongChieu { TenPhong = "Phòng 06", LoaiPhong = "3D", TongSoGhe = 48, SoHang = 6, SoCot = 8, TrangThai = "Hoạt động" }
                        };
                        db.PhongChieus.AddRange(defaultRooms);
                        await db.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo phòng: " + ex.Message);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadRoomCardsAsync();
        }

        private async Task LoadRoomCardsAsync()
        {
            try
            {
                flpRooms.Controls.Clear();
                DateTime now = DateTime.Now;

                using (var db = new DataContext())
                {
                    var rooms = await db.PhongChieus
                        .Include(p => p.SuatChieus)
                        .ToListAsync();

                    foreach (var room in rooms)
                    {
                        // Lấy suất chiếu đang diễn ra hoặc sắp tới gần nhất
                        var currentShow = room.SuatChieus
                            .Where(s => s.NgayChieu == now.Date && s.GioKetThuc > now.TimeOfDay)
                            .OrderBy(s => s.GioBatDau)
                            .FirstOrDefault();

                        string movieName = "N/A";
                        string status = room.TrangThai ?? "Hoạt động";
                        Color statusColor = Color.FromArgb(0, 184, 148); // Green
                        int soldSeats = 0;
                        DateTime? start = null;
                        DateTime? end = null;

                        if (status == "Bảo trì") statusColor = Color.FromArgb(255, 82, 82); // Red

                        if (currentShow != null)
                        {
                            var phim = await db.Phims.FindAsync(currentShow.MaPhim);
                            movieName = phim?.TenPhim ?? "N/A";
                            start = now.Date.Add(currentShow.GioBatDau);
                            end = now.Date.Add(currentShow.GioKetThuc ?? currentShow.GioBatDau.Add(TimeSpan.FromHours(2)));
                            
                            // Giả lập số vé đã bán dựa trên mã suất chiếu (thực tế sẽ đếm từ tblVe)
                            soldSeats = await db.Ves.CountAsync(v => v.MaSuatChieu == currentShow.MaSuatChieu);
                            
                            if (start <= now && end > now) status = "Đang chiếu";
                            else if (start > now) { status = "Sắp chiếu"; statusColor = Color.FromArgb(255, 159, 67); }
                        }

                        AddRoomCard(room.TenPhong, room.LoaiPhong, room.TongSoGhe, soldSeats, movieName, status, statusColor, start, end);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phòng: " + ex.Message);
            }
        }

        private void AddRoomCard(string name, string type, int totalSeats, int soldSeats, string currentMovie, string status, Color statusColor, DateTime? startTime, DateTime? endTime)
        {
            Guna2GradientPanel card = new Guna2GradientPanel();
            card.Size = new Size(270, 230);
            card.FillColor = Color.White;
            card.FillColor2 = Color.White;
            card.BorderRadius = 15;
            card.Margin = new Padding(15);
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.BorderRadius = 15;
            card.ShadowDecoration.Depth = 5;
            card.Cursor = Cursors.Hand;

            Label lblName = new Label { Text = name, Font = new Font("Segoe UI", 13F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 12), AutoSize = true };
            Label lblType = new Label { Text = type, Font = new Font("Segoe UI", 8F, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.FromArgb(94, 148, 255), Padding = new Padding(5, 2, 5, 2), Location = new Point(200, 15), AutoSize = true };
            Label lblMovieTitle = new Label { Text = "🎬 " + (currentMovie == "N/A" ? "(Trống)" : currentMovie), Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = currentMovie == "N/A" ? Color.Silver : Color.FromArgb(94, 148, 255), Location = new Point(15, 45), Size = new Size(240, 25) };

            string remainingText = "";
            Color remainingColor = Color.FromArgb(255, 82, 82);

            if (endTime.HasValue)
            {
                TimeSpan remaining = endTime.Value - DateTime.Now;
                if (remaining.TotalMinutes > 0 && startTime.Value <= DateTime.Now)
                {
                    remainingText = $"⏳ Còn {Math.Ceiling(remaining.TotalMinutes)}p";
                }
                else if (remaining.TotalMinutes <= 0 && startTime.Value <= DateTime.Now)
                {
                    remainingText = "✅ Hết phim";
                    remainingColor = Color.FromArgb(0, 184, 152);
                }
                else if (startTime.Value > DateTime.Now)
                {
                    remainingText = $"🕒 {startTime.Value:HH:mm}";
                    remainingColor = Color.FromArgb(255, 159, 67);
                }
            }

            Label lblRemaining = new Label { Text = remainingText, Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = remainingColor, Location = new Point(150, 75), Size = new Size(110, 20), TextAlign = ContentAlignment.MiddleRight };
            int percentage = totalSeats > 0 ? (soldSeats * 100 / totalSeats) : 0;
            Label lblTicketInfo = new Label { Text = $"Vé: {soldSeats}/{totalSeats}", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 80), AutoSize = true };

            Guna2ProgressBar pbOccupancy = new Guna2ProgressBar { Size = new Size(240, 10), Location = new Point(15, 105), BorderRadius = 5, Value = percentage, FillColor = Color.FromArgb(242, 245, 250), ProgressColor = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255), ProgressColor2 = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255) };
            Guna2CirclePictureBox dot = new Guna2CirclePictureBox { Size = new Size(8, 8), FillColor = statusColor, Location = new Point(18, 135) };
            Label lblStatus = new Label { Text = status, Font = new Font("Segoe UI", 8.5F, FontStyle.Italic), ForeColor = statusColor, Location = new Point(30, 132), AutoSize = true };
            Guna2Button btnConfig = new Guna2Button { Text = "Xem chi tiết", Size = new Size(240, 35), Location = new Point(15, 175), BorderRadius = 8, FillColor = Color.FromArgb(242, 245, 250), ForeColor = Color.FromArgb(94, 148, 255), Font = new Font("Segoe UI", 9F, FontStyle.Bold) };

            card.Controls.Add(lblName);
            card.Controls.Add(lblType);
            card.Controls.Add(lblMovieTitle);
            card.Controls.Add(lblRemaining);
            card.Controls.Add(lblTicketInfo);
            card.Controls.Add(pbOccupancy);
            card.Controls.Add(dot);
            card.Controls.Add(lblStatus);
            card.Controls.Add(btnConfig);
            flpRooms.Controls.Add(card);
        }
    }
}
