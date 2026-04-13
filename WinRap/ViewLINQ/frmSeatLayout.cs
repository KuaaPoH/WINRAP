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
        }

        private void frmSeatLayout_Load(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void GenerateSeats()
        {
            pnlSeats.Controls.Clear();
            
            int seatWidth = 50;
            int seatHeight = 50;
            int margin = 10;

            // Tính toán để căn giữa sơ đồ ghế
            int totalWidth = cols * (seatWidth + margin);
            int startX = (pnlSeats.Width - totalWidth) / 2;
            if (startX < 20) startX = 20;

            for (int i = 0; i < rows; i++)
            {
                char rowChar = (char)('A' + i);
                for (int j = 1; j <= cols; j++)
                {
                    Guna2Button btnSeat = new Guna2Button();
                    btnSeat.Text = rowChar.ToString() + j.ToString();
                    btnSeat.Size = new Size(seatWidth, seatHeight);
                    btnSeat.Location = new Point(startX + (j - 1) * (seatWidth + margin), i * (seatHeight + margin) + 50);
                    btnSeat.BorderRadius = 5;
                    btnSeat.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    
                    // Giả lập một số ghế đã bán hoặc ghế VIP
                    if ((i == 4 || i == 5) && (j > 3 && j < 10))
                    {
                        btnSeat.FillColor = Color.FromArgb(155, 89, 182); // Ghế VIP (Tím)
                        btnSeat.Tag = "VIP";
                    }
                    else if (i < 2 && j % 3 == 0)
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
