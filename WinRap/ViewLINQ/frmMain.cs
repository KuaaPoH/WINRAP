using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WinRap.ViewLINQ
{
    public partial class frmMain : Form
    {
        public static frmMain Instance;
        public frmMain()
        {
            InitializeComponent();
            Instance = this;
        }

        public void container(object _form)
        {
            if (pnlMain.Controls.Count > 0) pnlMain.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(fm);
            pnlMain.Tag = fm;
            fm.Show();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "BÁN VÉ";
            container(new frmTicket());
        }

        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "LỊCH CHIẾU";
            container(new frmShowtime());
        }

        private void btnPhim_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ PHIM";
            container(new frmMovie());
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ THỂ LOẠI";
            container(new frmTheLoai());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ PHÒNG CHIẾU";
            container(new frmRoom());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "KHÁCH HÀNG";
            container(new frmCustomer());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "THỐNG KÊ DOANH THU";
            container(new frmThongKe());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            container(new frmStaff());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                // TODO: Hiển thị lại Form Đăng nhập
            }
        }
    }
}
