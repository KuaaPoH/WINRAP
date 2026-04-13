using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WinRap.ViewLINQ
{
    public partial class frmShowtime : Form
    {
        public frmShowtime()
        {
            InitializeComponent();
            LoadDummyData();
        }

        private void LoadDummyData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSuatChieu");
            dt.Columns.Add("TenPhim");
            dt.Columns.Add("TenPhong");
            dt.Columns.Add("NgayChieu");
            dt.Columns.Add("GioBatDau");
            dt.Columns.Add("GiaVe");

            dt.Rows.Add("SC001", "Dune: Part Two", "P01 (IMAX)", "09/04/2026", "19:00", "120000");
            dt.Rows.Add("SC002", "Kung Fu Panda 4", "P02", "09/04/2026", "14:30", "85000");
            dt.Rows.Add("SC003", "Exhuma: Quật Mộ Trùng Tang", "P03", "09/04/2026", "21:00", "95000");
            dt.Rows.Add("SC004", "Dune: Part Two", "P01 (IMAX)", "10/04/2026", "15:00", "120000");

            dgvShowtime.DataSource = dt;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDummyData();
        }

        private void dgvShowtime_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvShowtime.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txtMovie.Text = row.Cells["TenPhim"].Value.ToString();
                txtRoom.Text = row.Cells["TenPhong"].Value.ToString();

                // Đổ dữ liệu vào DateTimePicker
                if (DateTime.TryParse(row.Cells["NgayChieu"].Value.ToString(), out DateTime ngayChieu))
                {
                    dtpDate.Value = ngayChieu;
                }

                // Đổ dữ liệu vào TextBox giờ và giá
                txtStartTime.Text = row.Cells["GioBatDau"].Value.ToString();
                txtPrice.Text = row.Cells["GiaVe"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count > 0)
            {
                string maSC = dgvShowtime.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString();
                // Logic cập nhật vào CSDL sẽ viết ở đây
                MessageBox.Show($"Đang thực hiện sửa suất chiếu {maSC}. Tính năng đang phát triển!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvShowtime.SelectedRows.Count > 0)
            {
                string maSC = dgvShowtime.SelectedRows[0].Cells["MaSuatChieu"].Value.ToString();
                if (MessageBox.Show($"Bạn có chắc chắn muốn xóa suất chiếu {maSC}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Logic xóa khỏi CSDL sẽ viết ở đây
                    MessageBox.Show("Đã xóa suất chiếu thành công (giả lập)!");
                    LoadDummyData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn suất chiếu cần xóa!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở form thêm mới suất chiếu (Bạn cần tạo form frmAddShowtime)
            // frmAddShowtime frm = new frmAddShowtime();
            // frm.ShowDialog();
            MessageBox.Show("Sẽ mở form Thêm suất chiếu mới!", "Thông báo");
        }
    }
}
