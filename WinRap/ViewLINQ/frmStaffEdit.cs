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
    public partial class frmStaffEdit : Form
    {
        private int _id;

        public frmStaffEdit(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmStaffEdit_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var nv = await Task.Run(() => {
                    using (var db = new DataContext())
                        return db.NguoiDungs.Find(_id);
                });

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
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
            string hoTen = txtHoTen.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string quyen = cboChucVu.Text;
            string sdt = txtSDT.Text.Trim();
            bool trangThai = cboTrangThai.Text == "Hoạt động";

            try
            {
                await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        var nv = db.NguoiDungs.Find(_id);
                        if (nv != null)
                        {
                            if (nv.TenDangNhap != username && db.NguoiDungs.Any(p => p.TenDangNhap == username))
                            {
                                throw new Exception("Tên đăng nhập đã tồn tại!");
                            }

                            nv.HoTen = hoTen;
                            nv.TenDangNhap = username;
                            nv.Quyen = quyen;
                            nv.SoDienThoai = sdt;
                            nv.TrangThai = trangThai;
                            if (!string.IsNullOrEmpty(password))
                                nv.MatKhau = GetMD5(password);
                            
                            db.SaveChanges();
                        }
                    }
                });

                MessageBox.Show("Cập nhật thành công!");
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
