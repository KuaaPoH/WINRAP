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
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private async void frmTheLoai_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var list = await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        return db.TheLoais.Select(t => new { t.MaTheLoai, t.TenTheLoai }).ToList();
                    }
                });
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

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTheLoai.Text.Trim();
            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!");
                return;
            }

            try
            {
                await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        tblTheLoai tl = new tblTheLoai { TenTheLoai = tenTL };
                        db.TheLoais.Add(tl);
                        db.SaveChanges();
                    }
                });
                await LoadDataAsync();
                txtTenTheLoai.Clear();
                MessageBox.Show("Thêm thể loại thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null) return;

            int id = (int)dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value;
            string tenTL = txtTenTheLoai.Text.Trim();

            if (string.IsNullOrEmpty(tenTL))
            {
                MessageBox.Show("Tên thể loại không được để trống!");
                return;
            }

            try
            {
                await Task.Run(() => {
                    using (var db = new DataContext())
                    {
                        var tl = db.TheLoais.Find(id);
                        if (tl != null)
                        {
                            tl.TenTheLoai = tenTL;
                            db.SaveChanges();
                        }
                    }
                });
                await LoadDataAsync();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow == null) return;

            int id = (int)dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value;
            string tenTL = dgvTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{tenTL}'?\nLưu ý: Các phim thuộc thể loại này có thể bị ảnh hưởng.", 
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bool success = await Task.Run(() => {
                        using (var db = new DataContext())
                        {
                            var tl = db.TheLoais.Find(id);
                            if (tl != null)
                            {
                                if (tl.Phims.Any()) return false;
                                db.TheLoais.Remove(tl);
                                db.SaveChanges();
                                return true;
                            }
                            return false;
                        }
                    });

                    if (success)
                    {
                        await LoadDataAsync();
                        txtTenTheLoai.Clear();
                        MessageBox.Show("Đã xóa thể loại thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thể loại này vì đang có phim thuộc thể loại này!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
    }
}
