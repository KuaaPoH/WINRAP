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
        public frmRoom()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void frmRoom_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn == btnTabConfig)
            {
                frmMain.Instance.container(new frmRoomConfig());
            }
        }

        private async Task LoadDataAsync()
        {
            this.SuspendLayout();
            try 
            {
                await LoadRoomCardsAsync();
            }
            finally 
            {
                this.ResumeLayout();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadRoomCardsAsync()
        {
            try
            {
                flpRooms.Controls.Clear();
                DateTime now = DateTime.Now;

                using (var db = new DataContext())
                {
                    var rooms = await db.PhongChieus.Include(p => p.SuatChieus).ToListAsync();

                    foreach (var room in rooms)
                    {
                        var currentShow = room.SuatChieus
                            .Where(s => s.NgayChieu == now.Date && s.GioKetThuc > now.TimeOfDay)
                            .OrderBy(s => s.GioBatDau).FirstOrDefault();

                        string movieName = "N/A";
                        string status = room.TrangThai ?? "Sẵn sàng";
                        Color statusColor = Color.FromArgb(0, 184, 148);
                        int soldSeats = 0;
                        DateTime? start = null, end = null;

                        if (status == "Bảo trì") statusColor = Color.FromArgb(255, 82, 82);
                        else if (status == "Đang dọn dẹp") statusColor = Color.FromArgb(94, 148, 255);

                        if (currentShow != null)
                        {
                            var phim = await db.Phims.FindAsync(currentShow.MaPhim);
                            movieName = phim?.TenPhim ?? "N/A";
                            start = now.Date.Add(currentShow.GioBatDau);
                            end = now.Date.Add(currentShow.GioKetThuc ?? currentShow.GioBatDau.Add(TimeSpan.FromHours(2)));
                            soldSeats = await db.Ves.CountAsync(v => v.MaSuatChieu == currentShow.MaSuatChieu);
                            if (start <= now && end > now) status = "Đang chiếu";
                            else if (start > now) { status = "Sắp chiếu"; statusColor = Color.FromArgb(255, 159, 67); }
                        }

                        AddRoomCard(room.MaPhong, room.TenPhong, room.LoaiPhong, room.TongSoGhe, soldSeats, movieName, status, statusColor, start, end);
                    }
                }
            }
            catch { }
        }

        private void AddRoomCard(int maPhong, string name, string type, int totalSeats, int soldSeats, string currentMovie, string status, Color statusColor, DateTime? startTime, DateTime? endTime)
        {
            Guna2GradientPanel card = new Guna2GradientPanel { Size = new Size(270, 230), FillColor = Color.White, FillColor2 = Color.White, BorderRadius = 15, Margin = new Padding(15), Cursor = Cursors.Hand };
            card.ShadowDecoration.Enabled = true; card.ShadowDecoration.BorderRadius = 15; card.ShadowDecoration.Depth = 5;

            Label lblName = new Label { Text = name, Font = new Font("Segoe UI", 13F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 12), AutoSize = true };
            Label lblType = new Label { Text = type, Font = new Font("Segoe UI", 8F, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.FromArgb(94, 148, 255), Padding = new Padding(5, 2, 5, 2), Location = new Point(200, 15), AutoSize = true };
            Label lblMovieTitle = new Label { Text = "🎬 " + (currentMovie == "N/A" ? "(Trống)" : currentMovie), Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = currentMovie == "N/A" ? Color.Silver : Color.FromArgb(94, 148, 255), Location = new Point(15, 45), Size = new Size(240, 25) };

            string remainingText = ""; Color remainingColor = Color.FromArgb(255, 82, 82);
            if (endTime.HasValue)
            {
                TimeSpan remaining = endTime.Value - DateTime.Now;
                if (remaining.TotalMinutes > 0 && startTime.Value <= DateTime.Now) remainingText = $"⏳ Còn {Math.Ceiling(remaining.TotalMinutes)}p";
                else if (remaining.TotalMinutes <= 0 && startTime.Value <= DateTime.Now) { remainingText = "✅ Hết phim"; remainingColor = Color.FromArgb(0, 184, 152); }
                else if (startTime.Value > DateTime.Now) { remainingText = $"🕒 {startTime.Value:HH:mm}"; remainingColor = Color.FromArgb(255, 159, 67); }
            }

            Label lblRemaining = new Label { Text = remainingText, Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = remainingColor, Location = new Point(150, 75), Size = new Size(110, 20), TextAlign = ContentAlignment.MiddleRight };
            int percentage = totalSeats > 0 ? (soldSeats * 100 / totalSeats) : 0;
            Label lblTicketInfo = new Label { Text = $"Vé: {soldSeats}/{totalSeats}", Font = new Font("Segoe UI", 9F, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(15, 80), AutoSize = true };

            Guna2ProgressBar pbOccupancy = new Guna2ProgressBar { Size = new Size(240, 10), Location = new Point(15, 105), BorderRadius = 5, Value = percentage, FillColor = Color.FromArgb(242, 245, 250), ProgressColor = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255), ProgressColor2 = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255) };
            Guna2CirclePictureBox dot = new Guna2CirclePictureBox { Size = new Size(8, 8), FillColor = statusColor, Location = new Point(18, 135) };
            Label lblStatus = new Label { Text = status, Font = new Font("Segoe UI", 8.5F, FontStyle.Italic), ForeColor = statusColor, Location = new Point(30, 132), AutoSize = true };
            
            Guna2Button btnView = new Guna2Button { Text = "Giám sát ghế", Size = new Size(240, 35), Location = new Point(15, 175), BorderRadius = 8, FillColor = Color.FromArgb(242, 245, 250), ForeColor = Color.FromArgb(94, 148, 255), Font = new Font("Segoe UI", 9F, FontStyle.Bold), Tag = maPhong };
            btnView.Click += BtnView_Click;

            card.Controls.Add(lblName); card.Controls.Add(lblType); card.Controls.Add(lblMovieTitle); card.Controls.Add(lblRemaining); card.Controls.Add(lblTicketInfo); card.Controls.Add(pbOccupancy); card.Controls.Add(dot); card.Controls.Add(lblStatus); card.Controls.Add(btnView);
            flpRooms.Controls.Add(card);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            int maPhong = (int)((Guna2Button)sender).Tag;
            frmRoomEdit frm = new frmRoomEdit(maPhong); 
            frmMain.Instance.container(frm);
        }
    }
}