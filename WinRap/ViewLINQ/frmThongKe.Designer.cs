namespace WinRap.ViewLINQ
{
    partial class frmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.cardTickets = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.lblTicketTitle = new System.Windows.Forms.Label();
            this.cardCustomers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.cardTopMovie = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTopMovie = new System.Windows.Forms.Label();
            this.lblTopMovieTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardTickets.SuspendLayout();
            this.cardCustomers.SuspendLayout();
            this.cardTopMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ DOANH THU";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cardRevenue);
            this.flowLayoutPanel1.Controls.Add(this.cardTickets);
            this.flowLayoutPanel1.Controls.Add(this.cardCustomers);
            this.flowLayoutPanel1.Controls.Add(this.cardTopMovie);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 200);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.Transparent;
            this.cardRevenue.BorderRadius = 15;
            this.cardRevenue.Controls.Add(this.lblTotalRevenue);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardRevenue.Location = new System.Drawing.Point(30, 30);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(10);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(200, 120);
            this.cardRevenue.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(10, 60);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(180, 21);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0 VND";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Location = new System.Drawing.Point(15, 15);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(121, 19);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "TỔNG DOANH THU";
            // 
            // cardTickets
            // 
            this.cardTickets.BackColor = System.Drawing.Color.Transparent;
            this.cardTickets.BorderRadius = 15;
            this.cardTickets.Controls.Add(this.lblTotalTickets);
            this.cardTickets.Controls.Add(this.lblTicketTitle);
            this.cardTickets.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.cardTickets.Location = new System.Drawing.Point(250, 30);
            this.cardTickets.Margin = new System.Windows.Forms.Padding(10);
            this.cardTickets.Name = "cardTickets";
            this.cardTickets.Size = new System.Drawing.Size(200, 120);
            this.cardTickets.TabIndex = 1;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalTickets.ForeColor = System.Drawing.Color.White;
            this.lblTotalTickets.Location = new System.Drawing.Point(10, 50);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(180, 37);
            this.lblTotalTickets.TabIndex = 1;
            this.lblTotalTickets.Text = "0";
            this.lblTotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicketTitle
            // 
            this.lblTicketTitle.AutoSize = true;
            this.lblTicketTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTicketTitle.ForeColor = System.Drawing.Color.White;
            this.lblTicketTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTicketTitle.Name = "lblTicketTitle";
            this.lblTicketTitle.Size = new System.Drawing.Size(127, 19);
            this.lblTicketTitle.TabIndex = 0;
            this.lblTicketTitle.Text = "TỔNG VÉ ĐÃ BÁN";
            // 
            // cardCustomers
            // 
            this.cardCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cardCustomers.BorderRadius = 15;
            this.cardCustomers.Controls.Add(this.lblTotalCustomers);
            this.cardCustomers.Controls.Add(this.lblCustomerTitle);
            this.cardCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.cardCustomers.Location = new System.Drawing.Point(470, 30);
            this.cardCustomers.Margin = new System.Windows.Forms.Padding(10);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.Size = new System.Drawing.Size(200, 120);
            this.cardCustomers.TabIndex = 2;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.lblTotalCustomers.Location = new System.Drawing.Point(10, 50);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(180, 37);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.White;
            this.lblCustomerTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(102, 19);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "KHÁCH HÀNG";
            // 
            // cardTopMovie
            // 
            this.cardTopMovie.BackColor = System.Drawing.Color.Transparent;
            this.cardTopMovie.BorderRadius = 15;
            this.cardTopMovie.Controls.Add(this.lblTopMovie);
            this.cardTopMovie.Controls.Add(this.lblTopMovieTitle);
            this.cardTopMovie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.cardTopMovie.Location = new System.Drawing.Point(690, 30);
            this.cardTopMovie.Margin = new System.Windows.Forms.Padding(10);
            this.cardTopMovie.Name = "cardTopMovie";
            this.cardTopMovie.Size = new System.Drawing.Size(200, 120);
            this.cardTopMovie.TabIndex = 3;
            // 
            // lblTopMovie
            // 
            this.lblTopMovie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopMovie.ForeColor = System.Drawing.Color.White;
            this.lblTopMovie.Location = new System.Drawing.Point(10, 60);
            this.lblTopMovie.Name = "lblTopMovie";
            this.lblTopMovie.Size = new System.Drawing.Size(180, 20);
            this.lblTopMovie.TabIndex = 1;
            this.lblTopMovie.Text = "N/A";
            this.lblTopMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopMovieTitle
            // 
            this.lblTopMovieTitle.AutoSize = true;
            this.lblTopMovieTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTopMovieTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopMovieTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTopMovieTitle.Name = "lblTopMovieTitle";
            this.lblTopMovieTitle.Size = new System.Drawing.Size(146, 19);
            this.lblTopMovieTitle.TabIndex = 0;
            this.lblTopMovieTitle.Text = "PHIM DOANH THU CAO";
            // 
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 718);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardTickets.ResumeLayout(false);
            this.cardTickets.PerformLayout();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            this.cardTopMovie.ResumeLayout(false);
            this.cardTopMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel cardRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Guna.UI2.WinForms.Guna2Panel cardTickets;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.Label lblTicketTitle;
        private Guna.UI2.WinForms.Guna2Panel cardCustomers;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblCustomerTitle;
        private Guna.UI2.WinForms.Guna2Panel cardTopMovie;
        private System.Windows.Forms.Label lblTopMovie;
        private System.Windows.Forms.Label lblTopMovieTitle;
    }
}
