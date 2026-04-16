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
    public partial class frmRoomConfig : Form
    {
        public frmRoomConfig()
        {
            InitializeComponent();
        }

        private async void frmRoomConfig_Load(object sender, EventArgs e)
        {
            await LoadRoomGridAsync();
        }

        private async Task LoadRoomGridAsync()
        {
            try
            {
                using (var db = new DataContext())
                {
                    var data = await db.PhongChieus.Select(p => new
                    {
                        p.MaPhong,
                        p.TenPhong,
                        p.LoaiPhong,
                        p.TrangThai,
                        p.MoTaKyThuat
                    }).OrderBy(p => p.MaPhong).ToListAsync();

                    // Khởi tạo cột thủ công để đảm bảo Width 40 cho ID
                    if (dgvRooms.Columns.Count == 0)
                    {
                        dgvRooms.AutoGenerateColumns = false;
                        dgvRooms.Columns.Clear();

                        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaPhong", DataPropertyName = "MaPhong", HeaderText = "ID", Width = 40, ReadOnly = true });
                        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenPhong", DataPropertyName = "TenPhong", HeaderText = "Tên phòng", Width = 150 });
                        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { Name = "LoaiPhong", DataPropertyName = "LoaiPhong", HeaderText = "Loại", Width = 80 });
                        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", DataPropertyName = "TrangThai", HeaderText = "Trạng thái", Width = 100 });
                        dgvRooms.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTaKyThuat", DataPropertyName = "MoTaKyThuat", HeaderText = "Ghi chú kỹ thuật", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                    }

                    dgvRooms.DataSource = data;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                txtName.Text = row.Cells["TenPhong"].Value?.ToString();
                cboType.SelectedItem = row.Cells["LoaiPhong"].Value?.ToString();
                cboStatus.SelectedItem = row.Cells["TrangThai"].Value?.ToString();
                txtNote.Text = row.Cells["MoTaKyThuat"].Value?.ToString();
                
                btnSave.Tag = row.Cells["MaPhong"].Value;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa từ danh sách!");
                return;
            }

            int id = (int)btnSave.Tag;
            try
            {
                using (var db = new DataContext())
                {
                    var room = await db.PhongChieus.FindAsync(id);
                    if (room != null)
                    {
                        room.TenPhong = txtName.Text.Trim();
                        room.LoaiPhong = cboType.SelectedItem?.ToString();
                        room.TrangThai = cboStatus.SelectedItem?.ToString();
                        room.MoTaKyThuat = txtNote.Text.Trim();

                        await db.SaveChangesAsync();
                        MessageBox.Show("Cập nhật thành công!");
                        await LoadRoomGridAsync();
                        ClearForm();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtNote.Clear();
            cboType.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            btnSave.Tag = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Instance.container(new frmRoom());
        }
    }
}
