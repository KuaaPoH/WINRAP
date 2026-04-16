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
            this.pnlSeatPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlScreenArea = new System.Windows.Forms.Panel();
            this.pnlScreenLine = new System.Windows.Forms.Panel();
            this.lblScreenText = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlScreenArea.SuspendLayout();
            this.SuspendLayout();

            // pnlTitle
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Height = 60;

            // btnBack
            this.btnBack.BorderRadius = 8;
            this.btnBack.FillColor = System.Drawing.Color.White;
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

            // pnlScreenArea (Vùng chứa màn hình)
            this.pnlScreenArea.BackColor = System.Drawing.Color.White;
            this.pnlScreenArea.Controls.Add(this.pnlScreenLine);
            this.pnlScreenArea.Controls.Add(this.lblScreenText);
            this.pnlScreenArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScreenArea.Height = 100;

            // pnlScreenLine (Đường line màn hình màu đen)
            this.pnlScreenLine.BackColor = System.Drawing.Color.Black;
            this.pnlScreenLine.Height = 6;
            this.pnlScreenLine.Width = 600;
            this.pnlScreenLine.Location = new System.Drawing.Point(250, 40);

            // lblScreenText (Tên phim hoặc "Màn hình chính")
            this.lblScreenText.AutoSize = true;
            this.lblScreenText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblScreenText.ForeColor = System.Drawing.Color.Black;
            this.lblScreenText.Location = new System.Drawing.Point(450, 55);
            this.lblScreenText.Text = "MÀN HÌNH CHÍNH";

            // pnlLegend
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLegend.Height = 70;
            this.pnlLegend.BackColor = System.Drawing.Color.White;

            // pnlSeatPreview (Vùng chứa ghế - chuyển về Guna2Panel)
            this.pnlSeatPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSeatPreview.BackColor = System.Drawing.Color.White;
            this.pnlSeatPreview.AutoScroll = true;

            // frmRoomEdit
            this.ClientSize = new System.Drawing.Size(1100, 730);
            this.Controls.Add(this.pnlSeatPreview);
            this.Controls.Add(this.pnlScreenArea);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmRoomEdit_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlScreenArea.ResumeLayout(false);
            this.pnlScreenArea.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlSeatPreview;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlScreenArea;
        private System.Windows.Forms.Panel pnlScreenLine;
        private System.Windows.Forms.Label lblScreenText;
    }
}