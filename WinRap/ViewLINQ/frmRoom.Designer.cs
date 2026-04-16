namespace WinRap.ViewLINQ
{
    partial class frmRoom
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
            this.pnlTopHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTabConfig = new Guna.UI2.WinForms.Guna2Button();
            this.btnTabMonitor = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMonitor = new Guna.UI2.WinForms.Guna2Panel();
            this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.btnTabConfig);
            this.pnlTopHeader.Controls.Add(this.btnTabMonitor);
            this.pnlTopHeader.Controls.Add(this.btnRefresh);
            this.pnlTopHeader.Controls.Add(this.txtSearch);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(1100, 65);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // btnTabConfig
            // 
            this.btnTabConfig.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabConfig.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTabConfig.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTabConfig.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTabConfig.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabConfig.FillColor = System.Drawing.Color.White;
            this.btnTabConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabConfig.ForeColor = System.Drawing.Color.Gray;
            this.btnTabConfig.Location = new System.Drawing.Point(420, 15);
            this.btnTabConfig.Name = "btnTabConfig";
            this.btnTabConfig.Size = new System.Drawing.Size(150, 35);
            this.btnTabConfig.TabIndex = 3;
            this.btnTabConfig.Text = "CẤU HÌNH PHÒNG";
            this.btnTabConfig.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnTabMonitor
            // 
            this.btnTabMonitor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabMonitor.Checked = true;
            this.btnTabMonitor.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTabMonitor.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTabMonitor.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTabMonitor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabMonitor.FillColor = System.Drawing.Color.White;
            this.btnTabMonitor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabMonitor.ForeColor = System.Drawing.Color.Gray;
            this.btnTabMonitor.Location = new System.Drawing.Point(290, 15);
            this.btnTabMonitor.Name = "btnTabMonitor";
            this.btnTabMonitor.Size = new System.Drawing.Size(130, 35);
            this.btnTabMonitor.TabIndex = 2;
            this.btnTabMonitor.Text = "GIÁM SÁT RẠP";
            this.btnTabMonitor.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRefresh.Location = new System.Drawing.Point(980, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Location = new System.Drawing.Point(20, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tìm phòng...";
            this.txtSearch.Size = new System.Drawing.Size(250, 35);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.pnlMonitor);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 65);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1100, 665);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // pnlMonitor
            // 
            this.pnlMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlMonitor.Controls.Add(this.flpRooms);
            this.pnlMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMonitor.Location = new System.Drawing.Point(0, 0);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.Size = new System.Drawing.Size(1100, 665);
            this.pnlMonitor.TabIndex = 0;
            // 
            // flpRooms
            // 
            this.flpRooms.AutoScroll = true;
            this.flpRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRooms.Location = new System.Drawing.Point(0, 0);
            this.flpRooms.Name = "flpRooms";
            this.flpRooms.Padding = new System.Windows.Forms.Padding(15);
            this.flpRooms.Size = new System.Drawing.Size(1100, 665);
            this.flpRooms.TabIndex = 0;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 730);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlTopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoom";
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMonitor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopHeader;
        private Guna.UI2.WinForms.Guna2Button btnTabConfig;
        private Guna.UI2.WinForms.Guna2Button btnTabMonitor;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlMonitor;
        private System.Windows.Forms.FlowLayoutPanel flpRooms;
    }
}
