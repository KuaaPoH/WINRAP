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
    public partial class frmMovieNew : Form
    {
        DataContext db = new DataContext();
        private string selectedImagePath = "";

        public frmMovieNew()
        {
            InitializeComponent();
        }

        private void frmMovieNew_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
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

           
                string fileName = "";
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    fileName = "movie_" + DateTime.Now.Ticks + Path.GetExtension(selectedImagePath);
                    string destPath = Path.Combine(Application.StartupPath, "Posters");
                    if (!Directory.Exists(destPath)) Directory.CreateDirectory(destPath);
                    File.Copy(selectedImagePath, Path.Combine(destPath, fileName), true);
                }

             
                tblPhim phim = new tblPhim
                {
                    TenPhim = txtTenPhim.Text.Trim(),
                    MaTheLoai = (int)cboTheLoai.SelectedValue,
                    ThoiLuong = thoiLuong,
                    DaoDien = txtDaoDien.Text.Trim(),
                    DienVien = txtDienVien.Text.Trim(),
                    MoTa = txtMoTa.Text.Trim(),
                    HinhAnh = fileName,
                    NgayPhatHanh = DateTime.Now,
                    TrangThai = swTrangThai.Checked
                };

                db.Phims.Add(phim);
                db.SaveChanges();

                MessageBox.Show("Thêm phim mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phim: " + ex.Message);
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
