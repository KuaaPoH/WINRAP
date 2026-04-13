using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmStaffAction : Form
    {
        DataContext db = new DataContext();
        int? staffId = null;

        public frmStaffAction(int? id = null)
        {
            InitializeComponent();
            staffId = id;
            if (staffId != null)
            {
                lblTitle.Text = "CẬP NHẬT NHÂN VIÊN";
                LoadStaffInfo();
            }
            else
            {
                lblTitle.Text = "THÊM NHÂN VIÊN MỚI";
            }
        }

        private void LoadStaffInfo()
        {
            var nv = db.NguoiDungs.Find(staffId);
            if (nv != null)
            {
                txtHoTen.Text = nv.HoTen;
                cboChucVu.Text = nv.Quyen;
                txtSDT.Text = nv.SoDienThoai;
                txtUsername.Text = nv.TenDangNhap;
                txtPassword.PlaceholderText = "Để trống nếu không đổi mật khẩu";
                cboTrangThai.Text = nv.TrangThai == true ? "Hoạt động" : "Khóa";
            }
        }

        private string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (staffId == null) // Thêm mới
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (db.NguoiDungs.Any(p => p.TenDangNhap == txtUsername.Text))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tblNguoiDung nv = new tblNguoiDung();
                nv.HoTen = txtHoTen.Text;
                nv.Quyen = cboChucVu.Text;
                nv.SoDienThoai = txtSDT.Text;
                nv.TenDangNhap = txtUsername.Text;
                nv.MatKhau = GetMD5(txtPassword.Text);
                nv.TrangThai = cboTrangThai.Text == "Hoạt động";

                db.NguoiDungs.Add(nv);
            }
            else // Cập nhật
            {
                tblNguoiDung nv = db.NguoiDungs.Find(staffId);
                if (nv != null)
                {
                    // Kiểm tra username trùng (trường hợp đổi username)
                    if (nv.TenDangNhap != txtUsername.Text && db.NguoiDungs.Any(p => p.TenDangNhap == txtUsername.Text))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    nv.HoTen = txtHoTen.Text;
                    nv.Quyen = cboChucVu.Text;
                    nv.SoDienThoai = txtSDT.Text;
                    nv.TenDangNhap = txtUsername.Text;
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        nv.MatKhau = GetMD5(txtPassword.Text);
                    }
                    nv.TrangThai = cboTrangThai.Text == "Hoạt động";
                }
            }

            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
