using System;
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
    public partial class frmStaffNew : Form
    {
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

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string quyen = cboChucVu.Text;
            string sdt = txtSDT.Text.Trim();
            bool trangThai = cboTrangThai.Text == "Hoạt động";

            try
            {
                bool exists = await Task.Run(() => {
                    using (var db = new DataContext())
                        return db.NguoiDungs.Any(p => p.TenDangNhap == username);
                });

                if (exists)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    return;
                }

                await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        var nv = new tblNguoiDung
                        {
                            HoTen = hoTen,
                            TenDangNhap = username,
                            MatKhau = GetMD5(password),
                            Quyen = quyen,
                            SoDienThoai = sdt,
                            TrangThai = trangThai
                        };
                        db.NguoiDungs.Add(nv);
                        db.SaveChanges();
                    }
                });

                MessageBox.Show("Thêm nhân viên thành công!");
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
            this.Close();
        }
    }
}
