namespace WinRap.ViewLINQ
{
    partial class frmRoomEdit
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSeatPreview = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // pnlTitle
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Height = 60;

            // btnBack
            this.btnBack.BorderRadius = 8;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(20, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.Text = " QUAY LẠI";
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Text = "GIÁM SÁT SƠ ĐỒ GHẾ";

            // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlSeatPreview);
            this.pnlContent.Controls.Add(this.lblScreen);
            this.pnlContent.Controls.Add(this.pnlLegend);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);

            // lblScreen
            this.lblScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScreen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblScreen.ForeColor = System.Drawing.Color.Silver;
            this.lblScreen.Text = "MÀN HÌNH CHÍNH";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScreen.Height = 80;

            // pnlSeatPreview
            this.pnlSeatPreview.Dock = System.Windows.Forms.DockStyle.Fill;

            // pnlLegend
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Height = 70;

            // frmRoomEdit
            this.ClientSize = new System.Drawing.Size(1100, 730);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pnlTitle.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSeatPreview;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Panel pnlLegend;
    }
}