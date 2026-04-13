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
    public partial class frmCustomer : Form
    {
        private DataContext db = new DataContext();
        private int selectedCustomerID = -1;
        private List<tblKhachHang> originalList = new List<tblKhachHang>();

        public frmCustomer()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                db = new DataContext(); // Refresh context
                originalList = db.KhachHangs.ToList();
                FilterData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterData()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            int filterIndex = cboFilterTier.SelectedIndex;

            var query = originalList.Where(k => 
                string.IsNullOrEmpty(keyword) || 
                k.HoTen.ToLower().Contains(keyword) || 
                k.SoDienThoai.Contains(keyword)
            );

            // Lọc theo điểm
            if (filterIndex == 1) // Dưới 1000
                query = query.Where(k => (k.DiemTichLuy ?? 0) < 1000);
            else if (filterIndex == 2) // 1000 - 5000
                query = query.Where(k => (k.DiemTichLuy ?? 0) >= 1000 && (k.DiemTichLuy ?? 0) <= 5000);
            else if (filterIndex == 3) // Trên 5000
                query = query.Where(k => (k.DiemTichLuy ?? 0) > 5000);

            var result = query.ToList();
            dgvCustomer.DataSource = result;
            lblTotalCount.Text = $"Tổng: {result.Count:00} khách hàng";
        }

        private void dgvCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvCustomer.Rows[e.RowIndex];
                selectedCustomerID = Convert.ToInt32(row.Cells["MaKhachHang"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmCustomerAction frm = new frmCustomerAction())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (frmCustomerAction frm = new frmCustomerAction(selectedCustomerID))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var kh = db.KhachHangs.Find(selectedCustomerID);
                    if (kh != null)
                    {
                        if (kh.Ves.Any())
                        {
                            MessageBox.Show("Không thể xóa khách hàng này vì đã có lịch sử đặt vé!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        db.KhachHangs.Remove(kh);
                        db.SaveChanges();
                        MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        selectedCustomerID = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var kh = db.KhachHangs.Find(selectedCustomerID);
            if (kh != null)
            {
                string detail = $"Mã khách hàng: {kh.MaKhachHang}\n" +
                                $"Họ tên: {kh.HoTen}\n" +
                                $"Số điện thoại: {kh.SoDienThoai}\n" +
                                $"Email: {kh.Email}\n" +
                                $"Điểm tích lũy: {kh.DiemTichLuy}";
                MessageBox.Show(detail, "Chi tiết khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cboFilterTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
