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
    public partial class frmStaff : Form
    {
        private DataContext db = new DataContext();
        private List<object> originalList = new List<object>();

        public frmStaff()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                db = new DataContext(); // Refresh context
                var list = db.NguoiDungs.Select(p => new
                {
                    p.MaNguoiDung,
                    p.HoTen,
                    p.Quyen,
                    p.SoDienThoai,
                    p.TenDangNhap,
                    TrangThaiDisplay = p.TrangThai == true ? "Hoạt động" : "Khóa"
                }).ToList();

                originalList = list.Cast<object>().ToList();
                FilterData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void FilterData()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            int filterIndex = cboFilterRole.SelectedIndex;

            var query = originalList.Where(p => {
                var type = p.GetType();
                string hoTen = type.GetProperty("HoTen")?.GetValue(p)?.ToString().ToLower() ?? "";
                string tenDN = type.GetProperty("TenDangNhap")?.GetValue(p)?.ToString().ToLower() ?? "";
                string quyen = type.GetProperty("Quyen")?.GetValue(p)?.ToString() ?? "";

                bool matchKeyword = string.IsNullOrEmpty(keyword) || hoTen.Contains(keyword) || tenDN.Contains(keyword);
                bool matchRole = true;
                if (filterIndex == 1) matchRole = quyen == "Quản trị viên";
                else if (filterIndex == 2) matchRole = quyen == "Nhân viên";

                return matchKeyword && matchRole;
            }).ToList();

            dgvStaff.DataSource = query;
            lblTotalCount.Text = $"Tổng: {query.Count:00} nhân viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmStaffAction frm = new frmStaffAction())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
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
            using (frmStaffAction frm = new frmStaffAction(id))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
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

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgvStaff.CurrentRow.Cells["MaNguoiDung"].Value;
                    tblNguoiDung nv = db.NguoiDungs.Find(id);

                    if (nv != null)
                    {
                        db.NguoiDungs.Remove(nv);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dgvStaff.CurrentRow.Cells["MaNguoiDung"].Value;
            var nv = db.NguoiDungs.Find(id);
            if (nv != null)
            {
                string detail = $"Mã nhân viên: {nv.MaNguoiDung}\n" +
                                $"Họ tên: {nv.HoTen}\n" +
                                $"Chức vụ: {nv.Quyen}\n" +
                                $"Số điện thoại: {nv.SoDienThoai}\n" +
                                $"Tên đăng nhập: {nv.TenDangNhap}\n" +
                                $"Trạng thái: {(nv.TrangThai == true ? "Hoạt động" : "Khóa")}";
                MessageBox.Show(detail, "Chi tiết nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cboFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
