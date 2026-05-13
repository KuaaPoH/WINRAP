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
                        try
                        {
                            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                            string path = Path.Combine(projectPath, currentImageName);
                            if (File.Exists(path))
                            {
                                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                                {
                                    if (picPoster.Image != null) picPoster.Image.Dispose();
                                    picPoster.Image = Image.FromStream(stream);
                                    picPoster.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            else picPoster.Image = null;
                        }
                        catch { picPoster.Image = null; }
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
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                ofd.Title = "Chọn ảnh cho phim";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            if (picPoster.Image != null) picPoster.Image.Dispose();
                            picPoster.Image = Image.FromStream(stream);
                            picPoster.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                        string folderPath = Path.Combine(projectPath, "images");

                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string extension = Path.GetExtension(ofd.FileName);
                        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                        string uniqueFileName = timestamp + extension;
                        string destPath = Path.Combine(folderPath, uniqueFileName);
                        File.Copy(ofd.FileName, destPath, true);
                        selectedImagePath = "images/" + uniqueFileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xử lý ảnh: " + ex.Message);
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

          
                string fileName = currentImageName;
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    fileName = selectedImagePath;
                }

               
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
