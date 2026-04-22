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
    public partial class frmTheLoai : Form
    {
        // 1. Khai báo DataContext dùng chung cho Form
        DataContext db = new DataContext();
        bool AddNew = false;
        private List<object> originalList = new List<object>();

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgvTheLoai.AutoGenerateColumns = false;
            dgvTheLoai.AllowUserToAddRows = false;
            LoadGridData();
            setControl(false);
        }

        private void setControl(bool isEdit)
        {
            btnThem.Visible = !isEdit;
            btnSua.Visible = !isEdit;
            btnXoa.Visible = !isEdit;
            
            btnLuu.Visible = isEdit;
            btnKhongLuu.Visible = isEdit;

            // Sử dụng Enabled thay vì ReadOnly để textbox đổi sang màu xám như frmShowtime
            txtTenTheLoai.Enabled = isEdit;
            dgvTheLoai.Enabled = !isEdit;
        }

        private void LoadGridData()
        {
            try
            {
                // Làm mới context để lấy dữ liệu mới nhất
                db = new DataContext();
                var list = db.TheLoais.Select(t => new { t.MaTheLoai, t.TenTheLoai }).ToList();
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
            var filteredList = originalList.Where(p => {
                var type = p.GetType();
                string tenTL = type.GetProperty("TenTheLoai")?.GetValue(p)?.ToString().ToLower() ?? "";
                return string.IsNullOrEmpty(keyword) || tenTL.Contains(keyword);
            }).ToList();

            dgvTheLoai.DataSource = filteredList;
            lblTotalCount.Text = $"Tổng: {filteredList.Count:00} thể loại";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void dgvTheLoai_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu trực tiếp từ Grid đổ vào TextBox
                txtTenTheLoai.Text = dgvTheLoai.Rows[e.RowIndex].Cells["TenTheLoai"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddNew = true;
            setControl(true);
            txtTenTheLoai.Clear();
            txtTenTheLoai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa!");
                return;
            }
            AddNew = false;
            setControl(true);
            txtTenTheLoai.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null) return;

            int id = (int)dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value;
            string tenTL = dgvTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{tenTL}'?", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    // Tìm và xóa bằng LINQ
                    var tl = db.TheLoais.SingleOrDefault(u => u.MaTheLoai == id);
                    if (tl != null)
                    {
                        // Kiểm tra ràng buộc thực tế trong DB
                        bool hasMovies = db.Phims.Any(p => p.MaTheLoai == id);
                        if (hasMovies)
                        {
                            MessageBox.Show("Không thể xóa thể loại này vì đang có phim thuộc thể loại này!", "Cảnh báo");
                            return;
                        }

                        db.TheLoais.Remove(tl);
                        db.SaveChanges();
                        
                        LoadGridData();
                        txtTenTheLoai.Clear();
                        MessageBox.Show("Đã xóa thể loại thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            setControl(false);
            if (dgvTheLoai.CurrentRow != null)
            {
                dgvTheLoai_CellEnter(null, new DataGridViewCellEventArgs(0, dgvTheLoai.CurrentRow.Index));
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                txtTenTheLoai.Focus();
                return;
            }

            try
            {
                if (AddNew)
                {
                    // Kiểm tra trùng tên
                    if (db.TheLoais.Any(t => t.TenTheLoai == tenTL))
                    {
                        MessageBox.Show("Tên thể loại này đã tồn tại!");
                        txtTenTheLoai.Focus();
                        return;
                    }

                    // Thêm mới bằng LINQ đồng bộ
                    tblTheLoai tl = new tblTheLoai { TenTheLoai = tenTL };
                    db.TheLoais.Add(tl);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thể loại thành công!");
                }
                else
                {
                    int id = (int)dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value;
                    // Tìm đối tượng bằng LINQ và cập nhật
                    var tl = db.TheLoais.SingleOrDefault(u => u.MaTheLoai == id);
                    if (tl != null)
                    {
                        // Kiểm tra trùng tên với các bản ghi khác
                        if (tl.TenTheLoai != tenTL && db.TheLoais.Any(t => t.TenTheLoai == tenTL && t.MaTheLoai != id))
                        {
                            MessageBox.Show("Tên thể loại mới đã tồn tại!");
                            txtTenTheLoai.Focus();
                            return;
                        }

                        tl.TenTheLoai = tenTL;
                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                setControl(false);
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
    }
}
