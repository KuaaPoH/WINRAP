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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private async void frmThongKe_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = DateTime.Now;
            await LoadStatistics(dtpFrom.Value, dtpTo.Value);
        }

        private async void btnStat_Click(object sender, EventArgs e)
        {
            await LoadStatistics(dtpFrom.Value, dtpTo.Value);
        }

        private async Task LoadStatistics(DateTime fromDate, DateTime toDate)
        {
            try
            {
                // Thống kê cơ bản
                decimal totalRevenue = 0;
                int totalTickets = 0;
                int totalCustomers = 0;
                string topMovieName = "N/A";
                object movieRevenueList = null;

                // Chuẩn hóa ngày
                DateTime start = fromDate.Date;
                DateTime end = toDate.Date.AddDays(1).AddSeconds(-1);

                await Task.Run(() =>
                {
                    using (var db = new DataContext())
                    {
                        // 1. Tổng doanh thu và Tổng số vé (Lọc theo ngày)
                        var tickets = db.Ves.Where(v => v.NgayDat >= start && v.NgayDat <= end).ToList();
                        totalRevenue = tickets.Sum(v => v.TongTien);
                        totalTickets = tickets.Count;

                        // 2. Tổng số khách hàng (Toàn bộ)
                        totalCustomers = db.KhachHangs.Count();

                        // 3. Phim doanh thu cao nhất & Danh sách doanh thu theo phim (Lọc theo ngày)
                        var movieGroup = db.Ves
                            .Where(v => v.NgayDat >= start && v.NgayDat <= end)
                            .Join(db.SuatChieus, v => v.MaSuatChieu, sc => sc.MaSuatChieu, (v, sc) => new { v.TongTien, sc.MaPhim })
                            .GroupBy(x => x.MaPhim)
                            .Select(g => new
                            {
                                MaPhim = g.Key,
                                Revenue = g.Sum(x => x.TongTien),
                                TicketCount = g.Count()
                            })
                            .ToList();

                        var movieRevenueData = movieGroup
                            .Join(db.Phims, rg => rg.MaPhim, p => p.MaPhim, (rg, p) => new
                            {
                                TenPhim = p.TenPhim,
                                SoVeDaBan = rg.TicketCount,
                                DoanhThu = rg.Revenue
                            })
                            .OrderByDescending(x => x.DoanhThu)
                            .ToList();

                        movieRevenueList = movieRevenueData;

                        var topMovie = movieRevenueData.FirstOrDefault();
                        if (topMovie != null)
                        {
                            topMovieName = topMovie.TenPhim;
                        }
                    }
                });

                // Cập nhật giao diện
                lblTotalRevenue.Text = string.Format("{0:N0} VND", totalRevenue);
                lblTotalTickets.Text = totalTickets.ToString();
                lblTotalCustomers.Text = totalCustomers.ToString();
                lblTopMovie.Text = topMovieName;

                // Cập nhật Grid
                dgvMovieRevenue.DataSource = movieRevenueList;
                if (dgvMovieRevenue.Columns["TenPhim"] != null) dgvMovieRevenue.Columns["TenPhim"].HeaderText = "Tên Phim";
                if (dgvMovieRevenue.Columns["SoVeDaBan"] != null) dgvMovieRevenue.Columns["SoVeDaBan"].HeaderText = "Số vé đã bán";
                if (dgvMovieRevenue.Columns["DoanhThu"] != null)
                {
                    dgvMovieRevenue.Columns["DoanhThu"].HeaderText = "Doanh thu";
                    dgvMovieRevenue.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message);
            }
        }
    }
}
