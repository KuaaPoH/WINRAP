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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // Giả lập dữ liệu thống kê
            lblTotalRevenue.Text = "25,500,000 VND";
            lblTotalTickets.Text = "342";
            lblTotalCustomers.Text = "128";
            lblTopMovie.Text = "Dune: Part Two";
        }
    }
}
