using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomerEdit : Form
    {
        private int _id;

        public frmCustomerEdit(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var kh = await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        return db.KhachHangs.Find(_id);
                    }
                });

                if (kh != null)
                {
                    txtHoTen.Text = kh.HoTen;
                    txtSDT.Text = kh.SoDienThoai;
                    txtEmail.Text = kh.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
                        var kh = db.KhachHangs.Find(_id);
                        if (kh != null)
                        {
                            kh.HoTen = hoTen;
                            kh.SoDienThoai = sdt;
                            kh.Email = email;
                            db.SaveChanges();
                        }
                    }
                });

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
