using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomerNew : Form
    {
        // Khai báo DataContext dùng chung
        private DataContext db = new DataContext();

        public frmCustomerNew()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra trống (Phong cách PDF trang 11)
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            try
            {
                // Thêm mới bằng LINQ đồng bộ
                tblKhachHang kh = new tblKhachHang
                {
                    HoTen = txtHoTen.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiemTichLuy = 0,
                    NgayTao = DateTime.Now
                };

                db.KhachHangs.Add(kh);
                db.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
