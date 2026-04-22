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
    public partial class frmStaffEdit : Form
    {
        // Khai báo DataContext dùng chung
        private DataContext db = new DataContext();
        private int _maNV;

        public frmStaffEdit(int id)
        {
            InitializeComponent();
            _maNV = id;
        }

        private void frmStaffEdit_Load(object sender, EventArgs e)
        {
            LoadStaffData();
        }

        private void LoadStaffData()
        {
            try
            {
                // Tìm nhân viên bằng LINQ đồng bộ (Trang 9 PDF)
                var nv = db.NguoiDungs.SingleOrDefault(u => u.MaNguoiDung == _maNV);

                if (nv != null)
                {
                    txtHoTen.Text = nv.HoTen;
                    cboChucVu.Text = nv.Quyen;
                    txtSDT.Text = nv.SoDienThoai;
                    txtUsername.Text = nv.TenDangNhap;
                    cboTrangThai.Text = nv.TrangThai == true ? "Hoạt động" : "Khóa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Hàm mã hóa MD5 (Trang 10 PDF)
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
            // Kiểm tra trống
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!");
                txtHoTen.Focus();
                return;
            }

            string username = txtUsername.Text.Trim();

            try
            {
                // Cập nhật bằng LINQ đồng bộ (Trang 11 PDF)
                var userUpdate = db.NguoiDungs.SingleOrDefault(u => u.MaNguoiDung == _maNV);
                
                if (userUpdate != null)
                {
                    // Kiểm tra nếu đổi Username thì không được trùng với người khác
                    if (userUpdate.TenDangNhap != username && db.NguoiDungs.Any(u => u.TenDangNhap == username))
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại!");
                        txtUsername.Focus();
                        return;
                    }

                    userUpdate.HoTen = txtHoTen.Text.Trim();
                    userUpdate.TenDangNhap = username;
                    userUpdate.Quyen = cboChucVu.Text;
                    userUpdate.SoDienThoai = txtSDT.Text.Trim();
                    userUpdate.TrangThai = cboTrangThai.Text == "Hoạt động";

                    // Chỉ đổi mật khẩu nếu có nhập mật khẩu mới
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        userUpdate.MatKhau = GetMD5(txtPassword.Text);
                    }
                    
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
