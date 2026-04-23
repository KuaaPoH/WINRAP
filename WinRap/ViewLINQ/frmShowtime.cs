using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinRap.Model;
using System.Data.Entity;

namespace WinRap.ViewLINQ
{
    public partial class frmShowtime : Form
    {
       
        DataContext db = new DataContext();
        bool AddNew = false;

        public frmShowtime()
        {
            InitializeComponent();
        }

        private void frmShowtime_Load(object sender, EventArgs e)
        {
            LoadGridData();
            LoadCombobox();
            SwitchMode(false);
        }

        private void LoadCombobox()
        {
            try
            {
                var phims = db.Phims.Where(p => p.TrangThai == true).ToList();
                cboMovie.DataSource = phims;
                cboMovie.DisplayMember = "TenPhim";
                cboMovie.ValueMember = "MaPhim";

                var phongs = db.PhongChieus.Where(p => p.TrangThai == "Sẵn sàng").ToList();
                cboRoom.DataSource = phongs;
                cboRoom.DisplayMember = "TenPhong";
                cboRoom.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message);
            }
        }

        private void LoadGridData()
        {
            try
            {
               
                var data = (from s in db.SuatChieus
                           join p in db.Phims on s.MaPhim equals p.MaPhim
                           join r in db.PhongChieus on s.MaPhong equals r.MaPhong
                           select new
                           {
                               s.MaSuatChieu,
                               TenPhim = p.TenPhim,
                               TenPhong = r.TenPhong,
                               s.NgayChieu,
                               s.GioBatDau,
                               GiaVe = s.GiaVeCoBan
                           })
                           .OrderByDescending(x => x.NgayChieu)
                           .ToList();

                dgvShowtime.DataSource = data;
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
            
            cboMovie.Enabled = isEditMode;
            cboRoom.Enabled = isEditMode;
            dtpDate.Enabled = isEditMode;
            txtStartTime.ReadOnly = !isEditMode;
            txtPrice.ReadOnly = !isEditMode;
        }

        private void ResetInputs()
        {
            if (cboMovie.Items.Count > 0) cboMovie.SelectedIndex = 0;
            if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
            txtStartTime.Text = "";
            txtPrice.Text = "0";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadGridData();
            LoadCombobox();
        }

        private void dgvShowtime_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvShowtime.Rows[e.RowIndex];
                    int maSC = Convert.ToInt32(row.Cells["MaSuatChieu"].Value);

                    var sc = db.SuatChieus.SingleOrDefault(u => u.MaSuatChieu == maSC);
                    if (sc != null)
                    {
                        cboMovie.SelectedValue = sc.MaPhim;
                        cboRoom.SelectedValue = sc.MaPhong;
                        dtpDate.Value = sc.NgayChieu;
                        txtStartTime.Text = sc.GioBatDau.ToString(@"hh\:mm");
                        txtPrice.Text = string.Format("{0:N0}", sc.GiaVeCoBan);
                    }
                }
                catch { }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddNew = true;
            ResetInputs();
            SwitchMode(true);
            txtStartTime.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần sửa!");
                return;
            }
            AddNew = false;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStartTime.Text))
            {
                MessageBox.Show("Vui lòng nhập giờ bắt đầu!");
                txtStartTime.Focus();
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
                decimal giaVe = decimal.Parse(priceText);

                int maPhim = (int)cboMovie.SelectedValue;
                int maPhong = (int)cboRoom.SelectedValue;
                DateTime ngayChieu = dtpDate.Value.Date;

                var phim = db.Phims.Find(maPhim);
                TimeSpan duration = TimeSpan.FromMinutes(phim.ThoiLuong + 15);
                TimeSpan gioKetThuc = gioBatDau.Add(duration);
                if (gioKetThuc.Days > 0) gioKetThuc = new TimeSpan(gioKetThuc.Hours, gioKetThuc.Minutes, gioKetThuc.Seconds);

             
                int currentMaSC = AddNew ? -1 : (int)dgvShowtime.CurrentRow.Cells["MaSuatChieu"].Value;
                var suatChieus = db.SuatChieus
                    .Where(s => s.MaPhong == maPhong && s.NgayChieu == ngayChieu && s.MaSuatChieu != currentMaSC)
                    .ToList();

                bool biTrung = false;
                DateTime dtStartNew = ngayChieu.Add(gioBatDau);
                DateTime dtEndNew = ngayChieu.Add(gioBatDau.Add(duration));

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

               
                if (AddNew)
                {
                    tblSuatChieu sc = new tblSuatChieu();
                    sc.MaPhim = maPhim;
                    sc.MaPhong = maPhong;
                    sc.NgayChieu = ngayChieu;
                    sc.GioBatDau = gioBatDau;
                    sc.GioKetThuc = gioKetThuc;
                    sc.GiaVeCoBan = giaVe;
                    sc.TrangThai = true;

                    db.SuatChieus.Add(sc);
                }
                else
                {
                    var sc = db.SuatChieus.SingleOrDefault(u => u.MaSuatChieu == currentMaSC);
                    if (sc != null)
                    {
                        sc.MaPhim = maPhim;
                        sc.MaPhong = maPhong;
                        sc.NgayChieu = ngayChieu;
                        sc.GioBatDau = gioBatDau;
                        sc.GioKetThuc = gioKetThuc;
                        sc.GiaVeCoBan = giaVe;
                    }
                }

                db.SaveChanges();
                MessageBox.Show(AddNew ? "Thêm mới thành công!" : "Cập nhật thành công!");
                
                SwitchMode(false);
                LoadGridData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.CurrentRow != null)
            {
                int maSC = Convert.ToInt32(dgvShowtime.CurrentRow.Cells["MaSuatChieu"].Value);
                if (MessageBox.Show("Bạn có muốn xóa suất chiếu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    try
                    {
                        
                        var item = db.SuatChieus.SingleOrDefault(u => u.MaSuatChieu == maSC);
                        if (item != null)
                        {
                            db.SuatChieus.Remove(item);
                            db.SaveChanges();
                            MessageBox.Show("Đã xóa thành công!");
                            LoadGridData();
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
}
