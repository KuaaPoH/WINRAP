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
    public partial class frmSeatLayout : Form
    {
        private int rows = 10;
        private int cols = 12;
        private decimal totalPrice = 0;
        private int selectedCount = 0;
        private decimal seatPrice = 80000; // Giá mặc định

        public frmSeatLayout()
        {
            InitializeComponent();
        }

        public frmSeatLayout(int rows, int cols, string roomName) : this()
        {
            this.rows = rows;
            this.cols = cols;
            lblRoomInfo.Text = "PHÒNG: " + roomName + " - SƠ ĐỒ GHẾ";
            pnlSeats.SizeChanged += (s, e) => GenerateSeats();
        }

        private void frmSeatLayout_Load(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void GenerateSeats()
        {
            if (rows <= 0 || cols <= 0 || pnlSeats.Width <= 0 || pnlSeats.Height <= 0) return;

            pnlSeats.Controls.Clear();
            pnlSeats.Controls.Add(lblScreen); // Giữ lại nhãn màn hình
            
            int seatWidth = 45;
            int seatHeight = 45;
            int margin = 8;

            // Tính toán để căn giữa sơ đồ ghế
            int totalWidth = cols * (seatWidth + margin) - margin;
            int startX = (pnlSeats.Width - totalWidth) / 2;
            if (startX < 20) startX = 20;

            int startY = 70; // Bắt đầu dưới màn hình

            pnlSeats.SuspendLayout();
            for (int i = 0; i < rows; i++)
            {
                char rowChar = (char)('A' + i);
                for (int j = 1; j <= cols; j++)
                {
                    Guna2Button btnSeat = new Guna2Button();
                    btnSeat.Text = rowChar.ToString() + j.ToString();
                    btnSeat.Size = new Size(seatWidth, seatHeight);
                    btnSeat.Location = new Point(startX + (j - 1) * (seatWidth + margin), i * (seatHeight + margin) + startY);
                    btnSeat.BorderRadius = 6;
                    btnSeat.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    btnSeat.Cursor = Cursors.Hand;
                    
                    // Giả lập một số ghế đã bán hoặc ghế VIP
                    if ((i >= rows / 3 && i <= rows * 2 / 3) && (j >= cols / 4 && j <= cols * 3 / 4))
                    {
                        btnSeat.FillColor = Color.FromArgb(155, 89, 182); // Ghế VIP (Tím)
                        btnSeat.Tag = "VIP";
                    }
                    else if (i < 2 && j % 4 == 0)
                    {
                        btnSeat.FillColor = Color.FromArgb(255, 82, 82); // Ghế đã bán (Đỏ)
                        btnSeat.Enabled = false;
                        btnSeat.Tag = "SOLD";
                    }
                    else
                    {
                        btnSeat.FillColor = Color.FromArgb(189, 195, 199); // Ghế thường (Xám)
                        btnSeat.Tag = "NORMAL";
                    }

                    btnSeat.Click += BtnSeat_Click;
                    pnlSeats.Controls.Add(btnSeat);
                }
            }
            pnlSeats.ResumeLayout();
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn.FillColor == Color.FromArgb(94, 148, 255)) // Đang chọn -> Hủy chọn
            {
                if (btn.Tag.ToString() == "VIP") btn.FillColor = Color.FromArgb(155, 89, 182);
                else btn.FillColor = Color.FromArgb(189, 195, 199);
                
                selectedCount--;
                totalPrice -= (btn.Tag.ToString() == "VIP" ? seatPrice + 20000 : seatPrice);
            }
            else // Chọn ghế
            {
                btn.FillColor = Color.FromArgb(94, 148, 255); // Xanh dương (Đang chọn)
                
                selectedCount++;
                totalPrice += (btn.Tag.ToString() == "VIP" ? seatPrice + 20000 : seatPrice);
            }

            lblTotalPrice.Text = string.Format("{0:N0} VND", totalPrice);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Thanh toán thành công " + lblTotalPrice.Text + "! Đang in hóa đơn...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMain.Instance.container(new frmTicket());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Instance.container(new frmTicket());
        }
    }
}
