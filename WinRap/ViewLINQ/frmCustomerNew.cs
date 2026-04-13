using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomerNew : Form
    {
        public frmCustomerNew()
        {
            InitializeComponent();
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        var kh = new tblKhachHang
                        {
                            HoTen = hoTen,
                            SoDienThoai = sdt,
                            Email = email,
                            DiemTichLuy = 0,
                            NgayTao = DateTime.Now
                        };
                        db.KhachHangs.Add(kh);
                        db.SaveChanges();
                    }
                });

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
            this.Close();
        }
    }
}
