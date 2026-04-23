using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmStaffNew : Form
    {
      
        private DataContext db = new DataContext();

        public frmStaffNew()
        {
            InitializeComponent();
        }

        private string GetMD5(string str)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] fromData = Encoding.UTF8.GetBytes(str);
                byte[] targetData = md5.ComputeHash(fromData);
                StringBuilder byte2String = new StringBuilder();
                for (int i = 0; i < targetData.Length; i++)
                    byte2String.Append(targetData[i].ToString("x2"));
                return byte2String.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông báo");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo");
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo");
                txtPassword.Focus();
                return;
            }

            string username = txtUsername.Text.Trim();

            try
            {
             
                bool isExisted = db.NguoiDungs.Any(u => u.TenDangNhap == username);
                if (isExisted)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Thông báo");
                    txtUsername.Focus();
                    return;
                }

              
                tblNguoiDung newUser = new tblNguoiDung();
                newUser.TenDangNhap = username;
                newUser.MatKhau = GetMD5(txtPassword.Text);
                newUser.HoTen = txtHoTen.Text.Trim();
                newUser.SoDienThoai = txtSDT.Text.Trim();
                newUser.Quyen = cboChucVu.Text;
                newUser.TrangThai = cboTrangThai.Text == "Hoạt động";

                db.NguoiDungs.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Thêm mới nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
