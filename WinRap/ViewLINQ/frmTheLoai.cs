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
    public partial class frmTheLoai : Form
    {
        private DataContext db = new DataContext();

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = db.TheLoais.Select(t => new { t.MaTheLoai, t.TenTheLoai }).ToList();
                dgvTheLoai.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvTheLoai_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenTheLoai.Text = dgvTheLoai.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                return;
            }

            try
            {
                tblTheLoai tl = new tblTheLoai { TenTheLoai = tenTL };
                db.TheLoais.Add(tl);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thể loại thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 0) return;

            int id = (int)dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value;
            string tenTL = txtTenTheLoai.Text.Trim();

            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Tên thể loại không được để trống!");
                return;
            }

            try
            {
                var tl = db.TheLoais.Find(id);
                if (tl != null)
                {
                    tl.TenTheLoai = tenTL;
                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedRows.Count == 0) return;

            int id = (int)dgvTheLoai.SelectedRows[0].Cells["MaTheLoai"].Value;
            string tenTL = dgvTheLoai.SelectedRows[0].Cells["TenTheLoai"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{tenTL}'?\nLưu ý: Các phim thuộc thể loại này có thể bị ảnh hưởng.", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var tl = db.TheLoais.Find(id);
                    if (tl != null)
                    {
                        db.TheLoais.Remove(tl);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Đã xóa thể loại thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa thể loại này (có thể do đang có phim thuộc thể loại này).\nChi tiết: " + ex.Message);
                }
            }
        }
    }
}
