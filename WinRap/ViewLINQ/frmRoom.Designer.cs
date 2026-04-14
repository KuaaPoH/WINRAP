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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTabConfig = new Guna.UI2.WinForms.Guna2Button();
            this.btnTabMonitor = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlMainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlConfig = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlConfigFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveAll = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfigHint = new System.Windows.Forms.Label();
            this.pnlMonitor = new Guna.UI2.WinForms.Guna2Panel();
            this.flpRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlConfigFooter.SuspendLayout();
            this.pnlMonitor.SuspendLayout();
            this.SuspendLayout();

            // pnlTopHeader
            this.pnlTopHeader.BackColor = System.Drawing.Color.White;
            this.pnlTopHeader.Controls.Add(this.btnTabConfig);
            this.pnlTopHeader.Controls.Add(this.btnTabMonitor);
            this.pnlTopHeader.Controls.Add(this.btnRefresh);
            this.pnlTopHeader.Controls.Add(this.txtSearch);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Height = 65;

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(20, 15);
            this.txtSearch.Size = new System.Drawing.Size(250, 35);
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.PlaceholderText = "Tìm phòng...";

            // btnTabMonitor
            this.btnTabMonitor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabMonitor.Checked = true;
            this.btnTabMonitor.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnTabMonitor.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTabMonitor.CheckedState.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnTabMonitor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabMonitor.FillColor = System.Drawing.Color.White;
            this.btnTabMonitor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabMonitor.ForeColor = System.Drawing.Color.Gray;
            this.btnTabMonitor.Location = new System.Drawing.Point(290, 15);
            this.btnTabMonitor.Name = "btnTabMonitor";
            this.btnTabMonitor.Size = new System.Drawing.Size(130, 35);
            this.btnTabMonitor.Text = "GIÁM SÁT RẠP";
            this.btnTabMonitor.Click += new System.EventHandler(this.btnTab_Click);

            // btnTabConfig
            this.btnTabConfig.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTabConfig.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnTabConfig.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTabConfig.CheckedState.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnTabConfig.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTabConfig.FillColor = System.Drawing.Color.White;
            this.btnTabConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabConfig.ForeColor = System.Drawing.Color.Gray;
            this.btnTabConfig.Location = new System.Drawing.Point(420, 15);
            this.btnTabConfig.Name = "btnTabConfig";
            this.btnTabConfig.Size = new System.Drawing.Size(150, 35);
            this.btnTabConfig.Text = "CẤU HÌNH PHÒNG";
            this.btnTabConfig.Click += new System.EventHandler(this.btnTab_Click);

            // btnRefresh
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(980, 15);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(242, 245, 250);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(94, 148, 255);
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // pnlMainContainer
            this.pnlMainContainer.Controls.Add(this.pnlMonitor);
            this.pnlMainContainer.Controls.Add(this.pnlConfig);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 65);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1100, 665);

            // pnlConfig (Panel thay thế Tab Cấu hình)
            this.pnlConfig.Controls.Add(this.dgvRooms);
            this.pnlConfig.Controls.Add(this.pnlConfigFooter);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(0, 0);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.BackColor = System.Drawing.Color.White;
            this.pnlConfig.Visible = false;

            // pnlMonitor (Panel thay thế Tab Giám sát)
            this.pnlMonitor.Controls.Add(this.flpRooms);
            this.pnlMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMonitor.Location = new System.Drawing.Point(0, 0);
            this.pnlMonitor.Name = "pnlMonitor";
            this.pnlMonitor.BackColor = System.Drawing.Color.FromArgb(242, 245, 250);

            // flpRooms
            this.flpRooms.AutoScroll = true;
            this.flpRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpRooms.Padding = new System.Windows.Forms.Padding(15);

            // dgvRooms
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRooms.ThemeStyle.RowsStyle.Height = 35;

            // pnlConfigFooter
            this.pnlConfigFooter.Controls.Add(this.btnSaveAll);
            this.pnlConfigFooter.Controls.Add(this.lblConfigHint);
            this.pnlConfigFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConfigFooter.Height = 60;

            // btnSaveAll & lblConfigHint (Giữ nguyên)
            this.btnSaveAll.Location = new System.Drawing.Point(20, 10);
            this.btnSaveAll.Size = new System.Drawing.Size(180, 40);
            this.btnSaveAll.BorderRadius = 8;
            this.btnSaveAll.FillColor = System.Drawing.Color.FromArgb(0, 184, 152);
            this.btnSaveAll.Text = "Lưu cấu hình";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);

            this.lblConfigHint.Location = new System.Drawing.Point(210, 22);
            this.lblConfigHint.AutoSize = true;
            this.lblConfigHint.ForeColor = System.Drawing.Color.Gray;
            this.lblConfigHint.Text = "* Chỉnh sửa trực tiếp trên bảng và nhấn Lưu.";

            // frmRoom
            this.ClientSize = new System.Drawing.Size(1100, 730);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.pnlTopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlConfigFooter.ResumeLayout(false);
            this.pnlConfigFooter.PerformLayout();
            this.pnlMonitor.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel pnlTopHeader;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnTabMonitor;
        private Guna.UI2.WinForms.Guna2Button btnTabConfig;
        private Guna.UI2.WinForms.Guna2Panel pnlMainContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlMonitor;
        private Guna.UI2.WinForms.Guna2Panel pnlConfig;
        private System.Windows.Forms.FlowLayoutPanel flpRooms;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRooms;
        private Guna.UI2.WinForms.Guna2Panel pnlConfigFooter;
        private Guna.UI2.WinForms.Guna2Button btnSaveAll;
        private System.Windows.Forms.Label lblConfigHint;
    }
}