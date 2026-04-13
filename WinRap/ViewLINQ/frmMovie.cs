using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmMovie : Form
    {
        private List<object> originalList = new List<object>();

        public frmMovie()
        {
            InitializeComponent();
        }

        private async void frmMovie_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await LoadGenresAsync();
        }

        private async Task LoadGenresAsync()
        {
            try
            {
                var genres = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        var list = context.TheLoais.ToList();
                        var result = list.Select(g => new { g.MaTheLoai, g.TenTheLoai }).ToList();
                        result.Insert(0, new { MaTheLoai = 0, TenTheLoai = "--- Tất cả thể loại ---" });
                        return result;
                    }
                });

                cboFilterGenre.DataSource = genres;
                cboFilterGenre.DisplayMember = "TenTheLoai";
                cboFilterGenre.ValueMember = "MaTheLoai";
            }
            catch { }
        }

        public async Task LoadDataAsync()
        {
            try
            {
                var listPhim = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return context.Phims.Select(p => new
                        {
                            p.MaPhim,
                            p.TenPhim,
                            TenTheLoai = p.TheLoai.TenTheLoai,
                            p.ThoiLuong,
                            p.DaoDien,
                            p.DienVien,
                            p.MoTa,
                            p.HinhAnh,
                            p.MaTheLoai,
                            TrangThaiDisplay = p.TrangThai == true ? "Đang chiếu" : "Ngừng chiếu"
                        }).ToList();
                    }
                });

                originalList = listPhim.Cast<object>().ToList();
                dgvMovie.DataSource = listPhim;
                lblTotalCount.Text = $"Tổng: {listPhim.Count:00} phim";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách phim: " + ex.Message);
            }
        }

        private void ShowOverlay(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = this.ClientSize; 
            childForm.Location = new Point(0, 0);
            childForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            this.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmMovieNew();
            frm.FormClosed += async (s, args) => {
                if (frm.DialogResult == DialogResult.OK)
                {
                    await LoadDataAsync();
                }
            };
            ShowOverlay(frm);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvMovie.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phim cần sửa!");
                return;
            }

            int maPhim = (int)dgvMovie.CurrentRow.Cells["MaPhim"].Value;
            var frm = new frmMovieEdit(maPhim);
            frm.FormClosed += async (s, args) => {
                if (frm.DialogResult == DialogResult.OK)
                {
                    await LoadDataAsync();
                }
            };
            ShowOverlay(frm);
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMovie.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phim cần xóa!");
                    return;
                }

                int maPhim = (int)dgvMovie.CurrentRow.Cells["MaPhim"].Value;

                if (MessageBox.Show("Bạn có chắc muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await Task.Run(() => {
                        using (var context = new DataContext())
                        {
                            var phim = context.Phims.Find(maPhim);
                            if (phim != null)
                            {
                                context.Phims.Remove(phim);
                                context.SaveChanges();
                            }
                        }
                    });
                    MessageBox.Show("Xóa phim thành công!");
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvMovie.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phim để xem chi tiết!");
                return;
            }

            int maPhim = (int)dgvMovie.CurrentRow.Cells["MaPhim"].Value;
            var frm = new frmMovieDetail(maPhim);
            ShowOverlay(frm);
        }

        private void FilterData()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            int genreId = 0;
            if (cboFilterGenre.SelectedValue != null && cboFilterGenre.SelectedValue is int)
            {
                genreId = (int)cboFilterGenre.SelectedValue;
            }

            var filteredList = originalList.Where(p => {
                var type = p.GetType();
                string tenPhim = type.GetProperty("TenPhim")?.GetValue(p)?.ToString().ToLower() ?? "";
                string daoDien = type.GetProperty("DaoDien")?.GetValue(p)?.ToString().ToLower() ?? "";
                int maTL = (int)(type.GetProperty("MaTheLoai")?.GetValue(p) ?? 0);

                bool matchKeyword = string.IsNullOrEmpty(keyword) || tenPhim.Contains(keyword) || daoDien.Contains(keyword);
                bool matchGenre = genreId == 0 || maTL == genreId;

                return matchKeyword && matchGenre;
            }).ToList();

            dgvMovie.DataSource = filteredList;
            lblTotalCount.Text = $"Tổng: {filteredList.Count:00} phim";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cboFilterGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
