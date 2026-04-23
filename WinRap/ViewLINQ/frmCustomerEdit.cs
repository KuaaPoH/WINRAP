using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomerEdit : Form
    {
        private DataContext db = new DataContext();
        private int _maKH;

        public frmCustomerEdit(int id)
        {
            InitializeComponent();
            _maKH = id;
        }

        private void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            try
            {
              
                var kh = db.KhachHangs.SingleOrDefault(u => u.MaKhachHang == _maKH);

                if (kh != null)
                {
                    txtHoTen.Text = kh.HoTen;
                    txtSDT.Text = kh.SoDienThoai;
                    txtEmail.Text = kh.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            try
            {
               
                var kh = db.KhachHangs.SingleOrDefault(u => u.MaKhachHang == _maKH);
                if (kh != null)
                {
                    kh.HoTen = txtHoTen.Text.Trim();
                    kh.SoDienThoai = txtSDT.Text.Trim();
                    kh.Email = txtEmail.Text.Trim();
                    
                    db.SaveChanges();

                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
