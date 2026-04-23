using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmCustomer : Form
    {
        DataContext db = new DataContext();

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.AllowUserToAddRows = false;
            LoadGridData();
        }

        private void LoadGridData()
        {
            try
            {
                db = new DataContext();
                
                var data = from k in db.KhachHangs select k;
                
                dgvCustomer.DataSource = data.ToList();
                
                lblTotalCount.Text = "Tổng: " + dgvCustomer.Rows.Count.ToString() + " khách hàng";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmCustomerNew frm = new frmCustomerNew())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadGridData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null) return;
            int maKH = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["MaKhachHang"].Value);
            using (frmCustomerEdit frm = new frmCustomerEdit(maKH))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadGridData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null) return;
            int maKH = Convert.ToInt32(dgvCustomer.CurrentRow.Cells["MaKhachHang"].Value);
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var kh = db.KhachHangs.SingleOrDefault(u => u.MaKhachHang == maKH);
                if (kh != null)
                {
                    db.KhachHangs.Remove(kh);
                    db.SaveChanges();
                    LoadGridData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void cboFilterTier_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}
