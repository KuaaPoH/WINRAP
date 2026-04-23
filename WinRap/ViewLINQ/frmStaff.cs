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
    public partial class frmStaff : Form
    {
       
        private DataContext db = new DataContext();

        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.AllowUserToAddRows = false;
            LoadGridData();
        }

        private void LoadGridData()
        {
            try
            {
             
                db = new DataContext();
                
                string keyword = txtSearch.Text.Trim().ToLower();
                int filterIndex = cboFilterRole.SelectedIndex;

              
                var query = from p in db.NguoiDungs select p;

             
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(p => p.HoTen.ToLower().Contains(keyword) || p.TenDangNhap.ToLower().Contains(keyword));
                }

               
                if (filterIndex == 1) 
                    query = query.Where(p => p.Quyen == "Quản trị viên");
                else if (filterIndex == 2) 
                    query = query.Where(p => p.Quyen == "Nhân viên");

                var result = query.ToList();
                dgvStaff.DataSource = result;
                lblTotalCount.Text = $"Tổng: {result.Count:00} nhân viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmStaffNew frm = new frmStaffNew())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadGridData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvStaff.CurrentRow.Cells["MaNguoiDung"].Value;
            using (frmStaffEdit frm = new frmStaffEdit(id))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadGridData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvStaff.CurrentRow.Cells["MaNguoiDung"].Value;
                    var nv = db.NguoiDungs.SingleOrDefault(u => u.MaNguoiDung == id);

                    if (nv != null)
                    {
                        db.NguoiDungs.Remove(nv);
                        db.SaveChanges();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGridData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void cboFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cboFilterRole.SelectedIndex = 0;
            LoadGridData();
        }
    }
}
