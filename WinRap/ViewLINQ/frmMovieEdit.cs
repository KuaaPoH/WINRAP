using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmMovieEdit : Form
    {
        DataContext db = new DataContext();
        private int _maPhim;
        private string selectedImagePath = "";
        private string currentImageName = "";

        public frmMovieEdit(int maPhim)
        {
            InitializeComponent();
            _maPhim = maPhim;
        }

        private void frmMovieEdit_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadMovieData();
        }

        private void LoadTheLoai()
        {
            try
            {
                var listTheLoai = db.TheLoais.Select(t => new { t.MaTheLoai, t.TenTheLoai }).ToList();
                cboTheLoai.DataSource = listTheLoai;
                cboTheLoai.DisplayMember = "TenTheLoai";
                cboTheLoai.ValueMember = "MaTheLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thể loại: " + ex.Message);
            }
        }

        private void LoadMovieData()
        {
            try
            {
                // Tìm phim đồng bộ (Trang 9 PDF)
                var phim = db.Phims.SingleOrDefault(p => p.MaPhim == _maPhim);

                if (phim != null)
                {
                    txtTenPhim.Text = phim.TenPhim;
                    cboTheLoai.SelectedValue = phim.MaTheLoai;
                    txtThoiLuong.Text = phim.ThoiLuong.ToString();
                    txtDaoDien.Text = phim.DaoDien;
                    txtDienVien.Text = phim.DienVien;
                    txtMoTa.Text = phim.MoTa;
                    swTrangThai.Checked = phim.TrangThai ?? false;
                    currentImageName = phim.HinhAnh;

                    if (!string.IsNullOrEmpty(currentImageName))
                    {
                        string path = Path.Combine(Application.StartupPath, "Posters", currentImageName);
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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    try
                    {
                        using (var temp = Image.FromFile(selectedImagePath))
                        {
                            picPoster.Image = new Bitmap(temp);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phim!");
                    txtTenPhim.Focus();
                    return;
                }

                if (!int.TryParse(txtThoiLuong.Text, out int thoiLuong) || thoiLuong <= 0)
                {
                    MessageBox.Show("Thời lượng phải là số nguyên dương!");
                    return;
                }

                // Xử lý ảnh
                string fileName = currentImageName;
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    fileName = "movie_" + DateTime.Now.Ticks + Path.GetExtension(selectedImagePath);
                    string destPath = Path.Combine(Application.StartupPath, "Posters");
                    if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                    File.Copy(selectedImagePath, Path.Combine(destPath, fileName), true);
                }

                // Cập nhật bằng LINQ đồng bộ (Trang 11 PDF)
                var phim = db.Phims.SingleOrDefault(p => p.MaPhim == _maPhim);
                if (phim != null)
                {
                    phim.TenPhim = txtTenPhim.Text.Trim();
                    phim.MaTheLoai = (int)cboTheLoai.SelectedValue;
                    phim.ThoiLuong = thoiLuong;
                    phim.DaoDien = txtDaoDien.Text.Trim();
                    phim.DienVien = txtDienVien.Text.Trim();
                    phim.MoTa = txtMoTa.Text.Trim();
                    phim.HinhAnh = fileName;
                    phim.TrangThai = swTrangThai.Checked;
                    
                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phim: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            this.Parent?.Controls.Remove(this);
        }
    }
}
