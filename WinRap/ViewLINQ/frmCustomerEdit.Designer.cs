namespace WinRap.ViewLINQ
{
    partial class frmCustomerEdit
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 60);
            this.pnlHeader.TabIndex = 0;
            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // Controls (Tương tự New nhưng nút màu Cam)
            this.lblHoTen.Location = new System.Drawing.Point(40, 80);
            this.lblHoTen.Size = new System.Drawing.Size(100, 20);
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.DimGray;

            this.txtHoTen.Location = new System.Drawing.Point(40, 105);
            this.txtHoTen.Size = new System.Drawing.Size(320, 36);
            this.txtHoTen.BorderRadius = 8;

            this.lblSDT.Location = new System.Drawing.Point(40, 155);
            this.lblSDT.Size = new System.Drawing.Size(100, 20);
            this.lblSDT.Text = "SĐT:";
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.DimGray;

            this.txtSDT.Location = new System.Drawing.Point(40, 180);
            this.txtSDT.Size = new System.Drawing.Size(320, 36);
            this.txtSDT.BorderRadius = 8;

            this.lblEmail.Location = new System.Drawing.Point(40, 230);
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;

            this.txtEmail.Location = new System.Drawing.Point(40, 255);
            this.txtEmail.Size = new System.Drawing.Size(320, 36);
            this.txtEmail.BorderRadius = 8;

            this.btnLuu.Location = new System.Drawing.Point(40, 320);
            this.btnLuu.Size = new System.Drawing.Size(150, 45);
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.Text = "CẬP NHẬT";
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(210, 320);
            this.btnHuy.Size = new System.Drawing.Size(150, 45);
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCustomerEdit_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}
