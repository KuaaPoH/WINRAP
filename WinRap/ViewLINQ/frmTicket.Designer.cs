namespace WinRap.ViewLINQ
{
    partial class frmTicket
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMovie = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboShowtime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblShowtime = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁN VÉ - CHỌN LỊCH CHIẾU";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnTiepTuc);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 638);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(950, 80);
            this.pnlActions.TabIndex = 1;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiepTuc.Animated = true;
            this.btnTiepTuc.BorderRadius = 8;
            this.btnTiepTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTiepTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTiepTuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(750, 20);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(170, 40);
            this.btnTiepTuc.TabIndex = 0;
            this.btnTiepTuc.Text = "TIẾP TỤC CHỌN GHẾ";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.flpMovies);
            this.pnlContent.Controls.Add(this.lblMovie);
            this.pnlContent.Controls.Add(this.dtpDate);
            this.pnlContent.Controls.Add(this.lblDate);
            this.pnlContent.Controls.Add(this.cboShowtime);
            this.pnlContent.Controls.Add(this.lblShowtime);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContent.Size = new System.Drawing.Size(950, 578);
            this.pnlContent.TabIndex = 2;
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.Location = new System.Drawing.Point(35, 147);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Size = new System.Drawing.Size(885, 280);
            this.flpMovies.TabIndex = 7;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMovie.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovie.Location = new System.Drawing.Point(35, 122);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(88, 19);
            this.lblMovie.TabIndex = 6;
            this.lblMovie.Text = "Chọn phim:";
            // 
            // dtpDate
            // 
            this.dtpDate.BorderRadius = 8;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(35, 60);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(400, 36);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(35, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Chọn ngày:";
            // 
            // cboShowtime
            // 
            this.cboShowtime.BackColor = System.Drawing.Color.Transparent;
            this.cboShowtime.BorderRadius = 8;
            this.cboShowtime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboShowtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShowtime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboShowtime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboShowtime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboShowtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboShowtime.ItemHeight = 30;
            this.cboShowtime.Location = new System.Drawing.Point(35, 470);
            this.cboShowtime.Name = "cboShowtime";
            this.cboShowtime.Size = new System.Drawing.Size(400, 36);
            this.cboShowtime.TabIndex = 5;
            // 
            // lblShowtime
            // 
            this.lblShowtime.AutoSize = true;
            this.lblShowtime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblShowtime.ForeColor = System.Drawing.Color.DimGray;
            this.lblShowtime.Location = new System.Drawing.Point(35, 445);
            this.lblShowtime.Name = "lblShowtime";
            this.lblShowtime.Size = new System.Drawing.Size(120, 19);
            this.lblShowtime.TabIndex = 4;
            this.lblShowtime.Text = "Chọn suất chiếu:";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 718);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnTiepTuc;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboShowtime;
        private System.Windows.Forms.Label lblShowtime;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;
        private System.Windows.Forms.Label lblMovie;
    }
}
