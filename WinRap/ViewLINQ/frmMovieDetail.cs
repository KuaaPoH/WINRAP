using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmMovieDetail : Form
    {
       
        DataContext db = new DataContext();
        private int _maPhim;

        public frmMovieDetail(int maPhim)
        {
            InitializeComponent();
            _maPhim = maPhim;
        }

        private void frmMovieDetail_Load(object sender, EventArgs e)
        {
            LoadMovieData();
        }

        private void LoadMovieData()
        {
            try
            {
               
                var movie = (from p in db.Phims
                            join t in db.TheLoais on p.MaTheLoai equals t.MaTheLoai
                            where p.MaPhim == _maPhim
                            select new
                            {
                                p.TenPhim,
                                TenTheLoai = t.TenTheLoai,
                                p.ThoiLuong,
                                p.DaoDien,
                                p.DienVien,
                                p.MoTa,
                                p.TrangThai,
                                p.HinhAnh
                            }).SingleOrDefault();

                if (movie != null)
                {
                    txtTenPhim.Text = movie.TenPhim;
                    txtTheLoai.Text = movie.TenTheLoai;
                    txtThoiLuong.Text = movie.ThoiLuong.ToString() + " phút";
                    txtDaoDien.Text = movie.DaoDien;
                    txtDienVien.Text = movie.DienVien;
                    txtMoTa.Text = movie.MoTa;
                    lblTrangThaiValue.Text = movie.TrangThai == true ? "Đang chiếu" : "Ngừng chiếu";
                    lblTrangThaiValue.ForeColor = movie.TrangThai == true ? Color.FromArgb(0, 184, 152) : Color.Red;

                    if (!string.IsNullOrEmpty(movie.HinhAnh))
                    {
                        string path = Path.Combine(Application.StartupPath, "Posters", movie.HinhAnh);
                        if (File.Exists(path))
                        {
                            using (var temp = Image.FromFile(path))
                            {
                                picPoster.Image = new Bitmap(temp);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin phim: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            
            this.Parent?.Controls.Remove(this);
        }
    }
}
