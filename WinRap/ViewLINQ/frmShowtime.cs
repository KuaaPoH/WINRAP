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
using System.Data.Entity;

namespace WinRap.ViewLINQ
{
    public partial class frmShowtime : Form
    {
        private bool isAdding = false;

        public frmShowtime()
        {
            InitializeComponent();
        }

        private async void frmShowtime_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await LoadComboboxAsync();
            SwitchMode(false);
        }

        private async Task LoadComboboxAsync()
        {
            try
            {
                using (var db = new DataContext())
                {
                    var phims = await db.Phims.ToListAsync();
                    if (phims.Count > 0)
                    {
                        cboMovie.DataSource = null;
                        cboMovie.DisplayMember = "TenPhim";
                        cboMovie.ValueMember = "MaPhim";
                        cboMovie.DataSource = phims;
                    }

                    var phongs = await db.PhongChieus.ToListAsync();
                    if (phongs.Count > 0)
                    {
                        cboRoom.DataSource = null;
                        cboRoom.DisplayMember = "TenPhong";
                        cboRoom.ValueMember = "MaPhong";
                        cboRoom.DataSource = phongs;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message);
            }
        }

        private async Task LoadDataAsync()
        {
            try
            {
                using (var db = new DataContext())
                {
                    var data = await db.SuatChieus
                        .Include(s => s.Phim)
                        .Include(s => s.PhongChieu)
                        .OrderByDescending(s => s.NgayChieu)
                        .ThenBy(s => s.GioBatDau)
                        .Select(s => new
                        {
                            s.MaSuatChieu,
                            TenPhim = s.Phim.TenPhim,
                            TenPhong = s.PhongChieu.TenPhong,
                            s.NgayChieu,
                            s.GioBatDau,
                            GiaVe = s.GiaVeCoBan
                        })
                        .ToListAsync();

                    dgvShowtime.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void SwitchMode(bool isEditMode)
        {
            btnThem.Visible = !isEditMode;
            btnSua.Visible = !isEditMode;
            btnXoa.Visible = !isEditMode;
            btnLamMoi.Visible = !isEditMode;

            btnLuu.Visible = isEditMode;
            btnQuayLai.Visible = isEditMode;

            dgvShowtime.Enabled = !isEditMode;
        }

        private void ResetInputs()
        {
            if (cboMovie.Items.Count > 0) cboMovie.SelectedIndex = 0;
            if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtStartTime.Text = "";
            txtPrice.Text = "0";
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
            await LoadComboboxAsync();
        }

        private void dgvShowtime_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvShowtime.Rows[e.RowIndex];
                    int maSC = Convert.ToInt32(row.Cells["MaSuatChieu"].Value);

                    using (var db = new DataContext())
                    {
                        var sc = db.SuatChieus.Find(maSC);
                        if (sc != null)
                        {
                            cboMovie.SelectedValue = sc.MaPhim;
                            cboRoom.SelectedValue = sc.MaPhong;
                            dtpDate.Value = sc.NgayChieu;
                            txtStartTime.Text = sc.GioBatDau.ToString(@"hh\:mm");
                            txtPrice.Text = string.Format("{0:N0}", sc.GiaVeCoBan);
                        }
                    }
                }
                catch { }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetInputs();
            SwitchMode(true);
            txtStartTime.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần sửa!");
                return;
            }
            isAdding = false;
            SwitchMode(true);
            txtStartTime.Focus();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            SwitchMode(false);
            if (dgvShowtime.CurrentRow != null)
            {
                dgvShowtime_CellEnter(null, new DataGridViewCellEventArgs(0, dgvShowtime.CurrentRow.Index));
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMovie.SelectedValue == null || cboRoom.SelectedValue == null || string.IsNullOrEmpty(txtStartTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!TimeSpan.TryParse(txtStartTime.Text, out TimeSpan gioBatDau))
            {
                MessageBox.Show("Giờ bắt đầu không đúng định dạng (HH:mm)!");
                return;
            }

            try
            {
                string priceText = txtPrice.Text.Replace(".", "").Replace(",", "").Replace(" ", "");
                if (!decimal.TryParse(priceText, out decimal giaVe))
                {
                    MessageBox.Show("Giá vé không hợp lệ!");
                    return;
                }

                using (var db = new DataContext())
                {
                    int maPhim = (int)cboMovie.SelectedValue;
                    int maPhong = (int)cboRoom.SelectedValue;
                    DateTime ngayChieu = dtpDate.Value.Date;

                    var phim = await db.Phims.FindAsync(maPhim);
                    if (phim == null) return;
                    
                    TimeSpan duration = TimeSpan.FromMinutes(phim.ThoiLuong + 15);
                    TimeSpan gioKetThucRaw = gioBatDau.Add(duration);
                    TimeSpan gioKetThuc = gioKetThucRaw.Days > 0 
                        ? new TimeSpan(gioKetThucRaw.Hours, gioKetThucRaw.Minutes, gioKetThucRaw.Seconds)
                        : gioKetThucRaw;

                    int currentMaSC = isAdding ? -1 : (int)dgvShowtime.SelectedRows[0].Cells["MaSuatChieu"].Value;
                    
                    var suatChieus = await db.SuatChieus
                        .Where(s => s.MaPhong == maPhong && s.NgayChieu == ngayChieu && s.MaSuatChieu != currentMaSC)
                        .ToListAsync();

                    bool biTrung = false;
                    DateTime dtStartNew = ngayChieu.Add(gioBatDau);
                    DateTime dtEndNew = ngayChieu.Add(gioKetThucRaw);

                    foreach (var s in suatChieus)
                    {
                        DateTime dtStartOld = s.NgayChieu.Add(s.GioBatDau);
                        TimeSpan durationOld = s.GioKetThuc >= s.GioBatDau 
                            ? s.GioKetThuc.Value - s.GioBatDau 
                            : s.GioKetThuc.Value.Add(TimeSpan.FromDays(1)) - s.GioBatDau;
                        DateTime dtEndOld = dtStartOld.Add(durationOld);

                        if (dtStartNew < dtEndOld && dtStartOld < dtEndNew)
                        {
                            biTrung = true;
                            break;
                        }
                    }

                    if (biTrung)
                    {
                        MessageBox.Show("Phòng này đã có lịch chiếu khác chồng chéo thời gian!");
                        return;
                    }

                    if (isAdding)
                    {
                        var sc = new tblSuatChieu
                        {
                            MaPhim = maPhim,
                            MaPhong = maPhong,
                            NgayChieu = ngayChieu,
                            GioBatDau = gioBatDau,
                            GioKetThuc = gioKetThuc,
                            GiaVeCoBan = giaVe,
                            TrangThai = true
                        };
                        db.SuatChieus.Add(sc);
                    }
                    else
                    {
                        var sc = await db.SuatChieus.FindAsync(currentMaSC);
                        sc.MaPhim = maPhim;
                        sc.MaPhong = maPhong;
                        sc.NgayChieu = ngayChieu;
                        sc.GioBatDau = gioBatDau;
                        sc.GioKetThuc = gioKetThuc;
                        sc.GiaVeCoBan = giaVe;
                    }

                    await db.SaveChangesAsync();
                    MessageBox.Show(isAdding ? "Thêm mới thành công!" : "Cập nhật thành công!");
                    
                    SwitchMode(false);
                    await LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                string msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi hệ thống: " + msg);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count > 0)
            {
                int maSC = Convert.ToInt32(dgvShowtime.SelectedRows[0].Cells["MaSuatChieu"].Value);
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa suất chiếu mã {maSC}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (var db = new DataContext())
                        {
                            var item = await db.SuatChieus.FindAsync(maSC);
                            if (item != null)
                            {
                                db.SuatChieus.Remove(item);
                                await db.SaveChangesAsync();
                                MessageBox.Show("Đã xóa suất chiếu thành công!");
                                await LoadDataAsync();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần xóa!");
            }
        }
    }
}
