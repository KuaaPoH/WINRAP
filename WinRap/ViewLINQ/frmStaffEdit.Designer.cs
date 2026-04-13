namespace WinRap.ViewLINQ
{
    partial class frmStaffEdit
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // Header
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(400, 60);
            // Title
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "CẬP NHẬT NHÂN VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // Fields (Tương tự New nhưng nút màu Cam)
            this.txtHoTen.Location = new System.Drawing.Point(40, 80);
            this.txtHoTen.Size = new System.Drawing.Size(320, 36);
            this.txtHoTen.PlaceholderText = "Họ tên...";
            this.txtHoTen.BorderRadius = 8;

            this.cboChucVu.Location = new System.Drawing.Point(40, 130);
            this.cboChucVu.Size = new System.Drawing.Size(320, 36);
            this.cboChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            this.cboChucVu.BorderRadius = 8;

            this.txtSDT.Location = new System.Drawing.Point(40, 180);
            this.txtSDT.Size = new System.Drawing.Size(320, 36);
            this.txtSDT.PlaceholderText = "Số điện thoại...";
            this.txtSDT.BorderRadius = 8;

            this.txtUsername.Location = new System.Drawing.Point(40, 230);
            this.txtUsername.Size = new System.Drawing.Size(320, 36);
            this.txtUsername.PlaceholderText = "Tên đăng nhập...";
            this.txtUsername.BorderRadius = 8;

            this.txtPassword.Location = new System.Drawing.Point(40, 280);
            this.txtPassword.Size = new System.Drawing.Size(320, 36);
            this.txtPassword.PlaceholderText = "Mật khẩu (để trống nếu không đổi)...";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.BorderRadius = 8;

            this.cboTrangThai.Location = new System.Drawing.Point(40, 330);
            this.cboTrangThai.Size = new System.Drawing.Size(320, 36);
            this.cboTrangThai.Items.AddRange(new object[] { "Hoạt động", "Khóa" });
            this.cboTrangThai.BorderRadius = 8;

            this.btnLuu.Location = new System.Drawing.Point(40, 400);
            this.btnLuu.Size = new System.Drawing.Size(150, 45);
            this.btnLuu.Text = "CẬP NHẬT";
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(210, 400);
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.Text = "HỦY";
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmStaffEdit_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2ComboBox cboChucVu;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}
