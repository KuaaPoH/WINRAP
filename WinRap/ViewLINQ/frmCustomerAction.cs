using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomerAction : Form
    {
        private DataContext db = new DataContext();
        private int customerID = -1;
        private bool isEdit = false;

        public frmCustomerAction()
        {
            InitializeComponent();
            this.lblTitle.Text = "THÊM KHÁCH HÀNG MỚI";
            this.isEdit = false;
        }

        public frmCustomerAction(int id)
        {
            InitializeComponent();
            this.customerID = id;
            this.isEdit = true;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            var kh = db.KhachHangs.Find(customerID);
            if (kh != null)
            {
                txtHoTen.Text = kh.HoTen;
                txtSDT.Text = kh.SoDienThoai;
                txtEmail.Text = kh.Email;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isEdit)
                {
                    var kh = db.KhachHangs.Find(customerID);
                    if (kh != null)
                    {
                        kh.HoTen = txtHoTen.Text.Trim();
                        kh.SoDienThoai = txtSDT.Text.Trim();
                        kh.Email = txtEmail.Text.Trim();
                    }
                }
                else
                {
                    var kh = new tblKhachHang
                    {
                        HoTen = txtHoTen.Text.Trim(),
                        SoDienThoai = txtSDT.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        DiemTichLuy = 0,
                        NgayTao = DateTime.Now
                    };
                    db.KhachHangs.Add(kh);
                }

                db.SaveChanges();
                MessageBox.Show(isEdit ? "Cập nhật thành công!" : "Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
