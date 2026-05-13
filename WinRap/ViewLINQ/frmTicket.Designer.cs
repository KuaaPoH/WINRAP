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
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearchMovie = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtpFilterDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.cboShowtime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblShowtime = new System.Windows.Forms.Label();
            this.btnTiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.flpMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.txtSearchMovie);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.dtpFilterDate);
            this.pnlTop.Controls.Add(this.lblFilterDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 70);
            this.pnlTop.TabIndex = 0;
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.BorderRadius = 8;
            this.txtSearchMovie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchMovie.DefaultText = "";
            this.txtSearchMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchMovie.Location = new System.Drawing.Point(450, 17);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.PlaceholderText = "Tìm tên phim...";
            this.txtSearchMovie.SelectedText = "";
            this.txtSearchMovie.Size = new System.Drawing.Size(250, 36);
            this.txtSearchMovie.TabIndex = 3;
            this.txtSearchMovie.TextChanged += new System.EventHandler(this.txtSearchMovie_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearch.Location = new System.Drawing.Point(365, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm phim:";
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.BorderRadius = 8;
            this.dtpFilterDate.Checked = true;
            this.dtpFilterDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFilterDate.ForeColor = System.Drawing.Color.White;
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(140, 17);
            this.dtpFilterDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFilterDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(200, 36);
            this.dtpFilterDate.TabIndex = 1;
            this.dtpFilterDate.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            this.dtpFilterDate.ValueChanged += new System.EventHandler(this.dtpFilterDate_ValueChanged);
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilterDate.Location = new System.Drawing.Point(30, 26);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(107, 19);
            this.lblFilterDate.TabIndex = 0;
            this.lblFilterDate.Text = "Lọc theo ngày:";
            // 
            // pnlActions
            // 
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.cboShowtime);
            this.pnlActions.Controls.Add(this.lblShowtime);
            this.pnlActions.Controls.Add(this.btnTiepTuc);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 648);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(950, 70);
            this.pnlActions.TabIndex = 1;
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
            this.cboShowtime.Location = new System.Drawing.Point(160, 17);
            this.cboShowtime.Name = "cboShowtime";
            this.cboShowtime.Size = new System.Drawing.Size(300, 36);
            this.cboShowtime.TabIndex = 5;
            // 
            // lblShowtime
            // 
            this.lblShowtime.AutoSize = true;
            this.lblShowtime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblShowtime.ForeColor = System.Drawing.Color.DimGray;
            this.lblShowtime.Location = new System.Drawing.Point(30, 26);
            this.lblShowtime.Name = "lblShowtime";
            this.lblShowtime.Size = new System.Drawing.Size(120, 19);
            this.lblShowtime.TabIndex = 4;
            this.lblShowtime.Text = "Chọn suất chiếu:";
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
            this.btnTiepTuc.Location = new System.Drawing.Point(750, 15);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(170, 40);
            this.btnTiepTuc.TabIndex = 0;
            this.btnTiepTuc.Text = "TIẾP TỤC CHỌN GHẾ";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.flpMovies);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(950, 578);
            this.pnlContent.TabIndex = 2;
            // 
            // flpMovies
            // 
            this.flpMovies.AutoScroll = true;
            this.flpMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMovies.Location = new System.Drawing.Point(20, 20);
            this.flpMovies.Name = "flpMovies";
            this.flpMovies.Size = new System.Drawing.Size(910, 538);
            this.flpMovies.TabIndex = 7;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 718);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Label lblFilterDate;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchMovie;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnTiepTuc;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2ComboBox cboShowtime;
        private System.Windows.Forms.Label lblShowtime;
        private System.Windows.Forms.FlowLayoutPanel flpMovies;
    }
}