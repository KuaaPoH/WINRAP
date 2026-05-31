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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStat = new Guna.UI2.WinForms.Guna2Button();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
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
            this.dgvMovieRevenue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardTickets.SuspendLayout();
            this.cardCustomers.SuspendLayout();
            this.cardTopMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnStat);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // btnStat
            // 
            this.btnStat.Animated = true;
            this.btnStat.BorderRadius = 10;
            this.btnStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnStat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStat.ForeColor = System.Drawing.Color.White;
            this.btnStat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStat.Location = new System.Drawing.Point(350, 12);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(120, 36);
            this.btnStat.TabIndex = 3;
            this.btnStat.Text = "THỐNG KÊ";
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Animated = true;
            this.dtpTo.BorderRadius = 8;
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(185, 12);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 36);
            this.dtpTo.TabIndex = 2;
            this.dtpTo.Value = new System.DateTime(2026, 12, 31, 0, 0, 0, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Animated = true;
            this.dtpFrom.BorderRadius = 8;
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(20, 12);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 36);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
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
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(950, 180);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.Transparent;
            this.cardRevenue.BorderRadius = 15;
            this.cardRevenue.Controls.Add(this.lblTotalRevenue);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardRevenue.Location = new System.Drawing.Point(20, 20);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(10);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(210, 120);
            this.cardRevenue.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(10, 60);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(190, 30);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0 VND";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Location = new System.Drawing.Point(15, 15);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(126, 17);
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
            this.cardTickets.Location = new System.Drawing.Point(250, 20);
            this.cardTickets.Margin = new System.Windows.Forms.Padding(10);
            this.cardTickets.Name = "cardTickets";
            this.cardTickets.Size = new System.Drawing.Size(210, 120);
            this.cardTickets.TabIndex = 1;
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTickets.ForeColor = System.Drawing.Color.White;
            this.lblTotalTickets.Location = new System.Drawing.Point(10, 50);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(190, 45);
            this.lblTotalTickets.TabIndex = 1;
            this.lblTotalTickets.Text = "0";
            this.lblTotalTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicketTitle
            // 
            this.lblTicketTitle.AutoSize = true;
            this.lblTicketTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketTitle.ForeColor = System.Drawing.Color.White;
            this.lblTicketTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTicketTitle.Name = "lblTicketTitle";
            this.lblTicketTitle.Size = new System.Drawing.Size(117, 17);
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
            this.cardCustomers.Location = new System.Drawing.Point(480, 20);
            this.cardCustomers.Margin = new System.Windows.Forms.Padding(10);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.Size = new System.Drawing.Size(210, 120);
            this.cardCustomers.TabIndex = 2;
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.ForeColor = System.Drawing.Color.White;
            this.lblTotalCustomers.Location = new System.Drawing.Point(10, 50);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(190, 45);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.White;
            this.lblCustomerTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(97, 17);
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
            this.cardTopMovie.Location = new System.Drawing.Point(710, 20);
            this.cardTopMovie.Margin = new System.Windows.Forms.Padding(10);
            this.cardTopMovie.Name = "cardTopMovie";
            this.cardTopMovie.Size = new System.Drawing.Size(210, 120);
            this.cardTopMovie.TabIndex = 3;
            // 
            // lblTopMovie
            // 
            this.lblTopMovie.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopMovie.ForeColor = System.Drawing.Color.White;
            this.lblTopMovie.Location = new System.Drawing.Point(10, 60);
            this.lblTopMovie.Name = "lblTopMovie";
            this.lblTopMovie.Size = new System.Drawing.Size(190, 30);
            this.lblTopMovie.TabIndex = 1;
            this.lblTopMovie.Text = "N/A";
            this.lblTopMovie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopMovieTitle
            // 
            this.lblTopMovieTitle.AutoSize = true;
            this.lblTopMovieTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopMovieTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopMovieTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTopMovieTitle.Name = "lblTopMovieTitle";
            this.lblTopMovieTitle.Size = new System.Drawing.Size(155, 17);
            this.lblTopMovieTitle.TabIndex = 0;
            this.lblTopMovieTitle.Text = "PHIM DOANH THU CAO";
            // 
            // dgvMovieRevenue
            // 
            this.dgvMovieRevenue.AllowUserToAddRows = false;
            this.dgvMovieRevenue.AllowUserToDeleteRows = false;
            this.dgvMovieRevenue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovieRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovieRevenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovieRevenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovieRevenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovieRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMovieRevenue.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovieRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMovieRevenue.EnableHeadersVisualStyles = false;
            this.dgvMovieRevenue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMovieRevenue.Location = new System.Drawing.Point(20, 280);
            this.dgvMovieRevenue.Name = "dgvMovieRevenue";
            this.dgvMovieRevenue.ReadOnly = true;
            this.dgvMovieRevenue.RowHeadersVisible = false;
            this.dgvMovieRevenue.RowTemplate.DividerHeight = 5;
            this.dgvMovieRevenue.RowTemplate.Height = 35;
            this.dgvMovieRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieRevenue.Size = new System.Drawing.Size(910, 410);
            this.dgvMovieRevenue.TabIndex = 2;
            this.dgvMovieRevenue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMovieRevenue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMovieRevenue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMovieRevenue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMovieRevenue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMovieRevenue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvMovieRevenue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMovieRevenue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvMovieRevenue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvMovieRevenue.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvMovieRevenue.ThemeStyle.ReadOnly = true;
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMovieRevenue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGridTitle.Location = new System.Drawing.Point(20, 250);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(201, 21);
            this.lblGridTitle.TabIndex = 3;
            this.lblGridTitle.Text = "DOANH THU THEO PHIM";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 718);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.dgvMovieRevenue);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pnlTop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.cardTickets.ResumeLayout(false);
            this.cardTickets.PerformLayout();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            this.cardTopMovie.ResumeLayout(false);
            this.cardTopMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvMovieRevenue;
        private System.Windows.Forms.Label lblGridTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2Button btnStat;
    }
}
