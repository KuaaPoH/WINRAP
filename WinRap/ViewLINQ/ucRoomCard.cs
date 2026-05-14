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
    public partial class ucRoomCard : UserControl
    {
        public int MaPhong { get; set; }
        public event EventHandler ViewDetailClick;

        public ucRoomCard()
        {
            InitializeComponent();
        }

        public void SetData(int maPhong, string name, string type, int totalSeats, int soldSeats, string currentMovie, string status, Color statusColor, DateTime? startTime, DateTime? endTime)
        {
            this.MaPhong = maPhong;
            lblName.Text = name;
            lblType.Text = type;
            lblMovieTitle.Text = "🎬 " + (currentMovie == "N/A" ? "(Trống)" : currentMovie);
            lblMovieTitle.ForeColor = currentMovie == "N/A" ? Color.Silver : Color.FromArgb(94, 148, 255);

            string remainingText = "";
            Color remainingColor = Color.FromArgb(255, 82, 82);
            if (endTime.HasValue && startTime.HasValue)
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

            lblRemaining.Text = remainingText;
            lblRemaining.ForeColor = remainingColor;

            int percentage = totalSeats > 0 ? (soldSeats * 100 / totalSeats) : 0;
            lblTicketInfo.Text = $"Vé: {soldSeats}/{totalSeats}";

            pbOccupancy.Value = percentage;
            pbOccupancy.ProgressColor = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255);
            pbOccupancy.ProgressColor2 = percentage > 80 ? Color.FromArgb(255, 82, 82) : Color.FromArgb(94, 148, 255);

            dot.FillColor = statusColor;
            lblStatus.Text = status;
            lblStatus.ForeColor = statusColor;

            btnView.Tag = maPhong;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDetailClick?.Invoke(this, e);
        }
    }
}
