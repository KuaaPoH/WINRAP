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

namespace WinRap.ViewLINQ
{
    public partial class frmRoom : Form
    {
        private Timer updateTimer;

        public frmRoom()
        {
            InitializeComponent();
            
            // Khởi tạo Timer để cập nhật thời gian còn lại mỗi phút
            updateTimer = new Timer();
            updateTimer.Interval = 60000; // 60 giây
            updateTimer.Tick += (s, e) => LoadRoomCards();
            updateTimer.Start();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            LoadRoomCards();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRoomCards();
        }

        private void LoadRoomCards()
        {
            flpRooms.Controls.Clear();
            DateTime now = DateTime.Now;
            
           
            AddRoomCard("Phòng 01", "IMAX", 120, 85, "Kung Fu Panda 4", "Đang chiếu", Color.FromArgb(0, 184, 148), now.AddMinutes(-45), now.AddMinutes(45));
            AddRoomCard("Phòng 02", "2D", 80, 42, "Mai (2024)", "Đang chiếu", Color.FromArgb(0, 184, 148), now.AddMinutes(-90), now.AddMinutes(10));
            AddRoomCard("Phòng 03", "3D", 64, 0, "N/A", "Bảo trì", Color.FromArgb(255, 82, 82), null, null);
            AddRoomCard("Phòng 04", "2D", 80, 78, "Dune: Part Two", "Đang chiếu", Color.FromArgb(0, 184, 148), now.AddMinutes(-10), now.AddMinutes(110));
            AddRoomCard("Phòng 05", "2D", 80, 12, "Gặp Lại Chị Bầu", "Sắp chiếu", Color.FromArgb(255, 159, 67), now.AddMinutes(30), now.AddMinutes(150));
            AddRoomCard("Phòng 06", "3D", 48, 48, "Exhuma: Quật Mộ Trùng Tang", "Hết vé", Color.FromArgb(94, 148, 255), now.AddMinutes(-120), now.AddMinutes(-5));
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

            // Tên phòng
            Label lblName = new Label { Text = name, Font = new Font("Segoe UI", 13F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 12), AutoSize = true };

            // Loại phòng (Badge)
            Label lblType = new Label { Text = type, Font = new Font("Segoe UI", 8F, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.FromArgb(94, 148, 255), Padding = new Padding(5, 2, 5, 2), Location = new Point(210, 15), AutoSize = true };

            // Phim đang chiếu
            Label lblMovieTitle = new Label { Text = "🎬 " + (currentMovie == "N/A" ? "(Trống)" : currentMovie), Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = currentMovie == "N/A" ? Color.Silver : Color.FromArgb(94, 148, 255), Location = new Point(15, 45), Size = new Size(240, 25) };

            // Tính toán thời gian còn lại và màu sắc tương ứng
            string remainingText = "";
            Color remainingColor = Color.FromArgb(255, 82, 82); // Mặc định là màu đỏ cho "Còn ...p"

            if (endTime.HasValue)
            {
                TimeSpan remaining = endTime.Value - DateTime.Now;
                if (remaining.TotalMinutes > 0 && startTime.Value <= DateTime.Now)
                {
                    remainingText = $"⏳ Còn {Math.Ceiling(remaining.TotalMinutes)}p";
                    remainingColor = Color.FromArgb(255, 82, 82); 
                }
                else if (remaining.TotalMinutes <= 0 && startTime.Value <= DateTime.Now)
                {
                    remainingText = "✅ Đã hết phim";
                    remainingColor = Color.FromArgb(0, 184, 152); 
                }
                else if (startTime.Value > DateTime.Now)
                {
                    remainingText = $"🕒 Bắt đầu sau {Math.Ceiling((startTime.Value - DateTime.Now).TotalMinutes)}p";
                    remainingColor = Color.FromArgb(255, 159, 67);
                }
            }

            Label lblRemaining = new Label { Text = remainingText, Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = remainingColor, Location = new Point(150, 75), Size = new Size(110, 20), TextAlign = ContentAlignment.MiddleRight };

            // Thông tin vé
            int percentage = totalSeats > 0 ? (soldSeats * 100 / totalSeats) : 0;
            Label lblTicketInfo = new Label { Text = $"Vé: {soldSeats}/{totalSeats}", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 80), AutoSize = true };

            // ProgressBar
            Guna2ProgressBar pbOccupancy = new Guna2ProgressBar { Size = new Size(240, 10), Location = new Point(15, 105), BorderRadius = 5, Value = percentage, FillColor = Color.FromArgb(242, 245, 250), ProgressColor = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255), ProgressColor2 = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255) };

            // Trạng thái (Dot + Label)
            Guna2CirclePictureBox dot = new Guna2CirclePictureBox { Size = new Size(8, 8), FillColor = statusColor, Location = new Point(18, 135) };
            Label lblStatus = new Label { Text = status, Font = new Font("Segoe UI", 8.5F, FontStyle.Italic), ForeColor = statusColor, Location = new Point(30, 132), AutoSize = true };

            // Nút "Chi tiết"
            Guna2Button btnConfig = new Guna2Button { Text = "Xem sơ đồ & Lịch chiếu", Size = new Size(240, 35), Location = new Point(15, 175), BorderRadius = 8, FillColor = Color.FromArgb(242, 245, 250), ForeColor = Color.FromArgb(94, 148, 255), Font = new Font("Segoe UI", 9F, FontStyle.Bold) };
            btnConfig.HoverState.FillColor = Color.FromArgb(94, 148, 255);
            btnConfig.HoverState.ForeColor = Color.White;

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
