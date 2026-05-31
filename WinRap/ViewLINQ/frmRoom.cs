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

        private async void txtSearch_TextChanged(object sender, EventArgs e)
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
                await LoadRoomCardsAsync(txtSearch.Text.Trim());
            }
            finally 
            {
                this.ResumeLayout();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            await LoadDataAsync();
        }

        private async Task LoadRoomCardsAsync(string search = "")
        {
            try
            {
                flpRooms.Controls.Clear();
                DateTime now = DateTime.Now;
                string searchLower = search.ToLower();

                using (var db = new DataContext())
                {
                    var roomsQuery = db.PhongChieus.AsQueryable();
                    if (!string.IsNullOrEmpty(search))
                    {
                        roomsQuery = roomsQuery.Where(r => r.TenPhong.ToLower().Contains(searchLower));
                    }

                    var rooms = await roomsQuery.ToListAsync();

                    foreach (var room in rooms)
                    {
                        var currentShow = await db.SuatChieus
                            .Where(s => s.MaPhong == room.MaPhong && s.NgayChieu == now.Date && s.GioKetThuc > now.TimeOfDay)
                            .OrderBy(s => s.GioBatDau).FirstOrDefaultAsync();

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
            ucRoomCard card = new ucRoomCard();
            card.SetData(maPhong, name, type, totalSeats, soldSeats, currentMovie, status, statusColor, startTime, endTime);
            card.ViewDetailClick += (s, ev) => {
                frmRoomEdit frm = new frmRoomEdit(maPhong);
                frmMain.Instance.container(frm);
            };
            flpRooms.Controls.Add(card);
        }
    }
}