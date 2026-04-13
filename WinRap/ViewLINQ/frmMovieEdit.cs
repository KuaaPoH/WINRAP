using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmMovieEdit : Form
    {
        private int _maPhim;
        private string selectedImagePath = "";
        private string currentImageName = "";

        public frmMovieEdit(int maPhim)
        {
            InitializeComponent();
            _maPhim = maPhim;
        }

        private async void frmMovieEdit_Load(object sender, EventArgs e)
        {
            await LoadTheLoaiAsync();
            await LoadMovieDataAsync();
        }

        private async Task LoadTheLoaiAsync()
        {
            try
            {
                var listTheLoai = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return context.TheLoais.Select(t => new { t.MaTheLoai, t.TenTheLoai }).ToList();
                    }
                });
                cboTheLoai.DataSource = listTheLoai;
                cboTheLoai.DisplayMember = "TenTheLoai";
                cboTheLoai.ValueMember = "MaTheLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thể loại: " + ex.Message);
            }
        }

        private async Task LoadMovieDataAsync()
        {
            try
            {
                var phim = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return context.Phims.Find(_maPhim);
                    }
                });

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

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenPhim.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên phim!");
                    return;
                }

                if (!int.TryParse(txtThoiLuong.Text, out int thoiLuong) || thoiLuong <= 0)
                {
                    MessageBox.Show("Thời lượng phải là số nguyên dương!");
                    return;
                }

                // Lấy dữ liệu từ UI Thread trước khi vào Task.Run
                string tenPhim = txtTenPhim.Text.Trim();
                int maTheLoai = (int)cboTheLoai.SelectedValue;
                string daoDien = txtDaoDien.Text.Trim();
                string dienVien = txtDienVien.Text.Trim();
                string moTa = txtMoTa.Text.Trim();
                bool trangThai = swTrangThai.Checked;

                string fileName = currentImageName;
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    fileName = "movie_" + DateTime.Now.Ticks + Path.GetExtension(selectedImagePath);
                    string destPath = Path.Combine(Application.StartupPath, "Posters");
                    if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                    File.Copy(selectedImagePath, Path.Combine(destPath, fileName), true);
                }

                await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        var phim = context.Phims.Find(_maPhim);
                        if (phim != null)
                        {
                            phim.TenPhim = tenPhim;
                            phim.MaTheLoai = maTheLoai;
                            phim.ThoiLuong = thoiLuong;
                            phim.DaoDien = daoDien;
                            phim.DienVien = dienVien;
                            phim.MoTa = moTa;
                            phim.HinhAnh = fileName;
                            phim.TrangThai = trangThai;
                            context.SaveChanges();
                        }
                    }
                });

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
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            this.Parent?.Controls.Remove(this);
        }
    }
}
