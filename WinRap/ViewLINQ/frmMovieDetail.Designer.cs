namespace WinRap.ViewLINQ
{
    partial class frmMovieDetail
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
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThaiValue = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.picPoster = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPoster = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtDienVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDienVien = new System.Windows.Forms.Label();
            this.txtDaoDien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDaoDien = new System.Windows.Forms.Label();
            this.txtThoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.txtTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.txtTenPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(152)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.lblTrangThaiValue);
            this.pnlContent.Controls.Add(this.lblTrangThai);
            this.pnlContent.Controls.Add(this.btnDong);
            this.pnlContent.Controls.Add(this.picPoster);
            this.pnlContent.Controls.Add(this.lblPoster);
            this.pnlContent.Controls.Add(this.txtMoTa);
            this.pnlContent.Controls.Add(this.lblMoTa);
            this.pnlContent.Controls.Add(this.txtDienVien);
            this.pnlContent.Controls.Add(this.lblDienVien);
            this.pnlContent.Controls.Add(this.txtDaoDien);
            this.pnlContent.Controls.Add(this.lblDaoDien);
            this.pnlContent.Controls.Add(this.txtThoiLuong);
            this.pnlContent.Controls.Add(this.lblThoiLuong);
            this.pnlContent.Controls.Add(this.txtTheLoai);
            this.pnlContent.Controls.Add(this.lblTheLoai);
            this.pnlContent.Controls.Add(this.txtTenPhim);
            this.pnlContent.Controls.Add(this.lblTenPhim);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 690);
            this.pnlContent.TabIndex = 1;
            // 
            // lblTrangThaiValue
            // 
            this.lblTrangThaiValue.AutoSize = true;
            this.lblTrangThaiValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThaiValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(152)))));
            this.lblTrangThaiValue.Location = new System.Drawing.Point(125, 480);
            this.lblTrangThaiValue.Name = "lblTrangThaiValue";
            this.lblTrangThaiValue.Size = new System.Drawing.Size(84, 19);
            this.lblTrangThaiValue.TabIndex = 18;
            this.lblTrangThaiValue.Text = "Đang chiếu";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 480);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(79, 19);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // btnDong
            // 
            this.btnDong.Animated = true;
            this.btnDong.BorderRadius = 8;
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(265, 530);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // picPoster
            // 
            this.picPoster.BorderRadius = 10;
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPoster.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.picPoster.ImageRotate = 0F;
            this.picPoster.Location = new System.Drawing.Point(360, 215);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(260, 200);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 13;
            this.picPoster.TabStop = false;
            // 
            // lblPoster
            // 
            this.lblPoster.AutoSize = true;
            this.lblPoster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPoster.ForeColor = System.Drawing.Color.DimGray;
            this.lblPoster.Location = new System.Drawing.Point(360, 190);
            this.lblPoster.Name = "lblPoster";
            this.lblPoster.Size = new System.Drawing.Size(56, 19);
            this.lblPoster.TabIndex = 12;
            this.lblPoster.Text = "Poster:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 8;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(30, 340);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(300, 110);
            this.txtMoTa.TabIndex = 11;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(30, 315);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(52, 19);
            this.lblMoTa.TabIndex = 10;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtDienVien
            // 
            this.txtDienVien.BorderRadius = 8;
            this.txtDienVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDienVien.DefaultText = "";
            this.txtDienVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDienVien.Location = new System.Drawing.Point(30, 215);
            this.txtDienVien.Multiline = true;
            this.txtDienVien.Name = "txtDienVien";
            this.txtDienVien.PasswordChar = '\0';
            this.txtDienVien.PlaceholderText = "";
            this.txtDienVien.ReadOnly = true;
            this.txtDienVien.SelectedText = "";
            this.txtDienVien.Size = new System.Drawing.Size(300, 80);
            this.txtDienVien.TabIndex = 9;
            // 
            // lblDienVien
            // 
            this.lblDienVien.AutoSize = true;
            this.lblDienVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDienVien.ForeColor = System.Drawing.Color.DimGray;
            this.lblDienVien.Location = new System.Drawing.Point(30, 190);
            this.lblDienVien.Name = "lblDienVien";
            this.lblDienVien.Size = new System.Drawing.Size(78, 20);
            this.lblDienVien.TabIndex = 8;
            this.lblDienVien.Text = "Diễn viên:";
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.BorderRadius = 8;
            this.txtDaoDien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDaoDien.DefaultText = "";
            this.txtDaoDien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDaoDien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDaoDien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDaoDien.Location = new System.Drawing.Point(360, 145);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.PasswordChar = '\0';
            this.txtDaoDien.PlaceholderText = "";
            this.txtDaoDien.ReadOnly = true;
            this.txtDaoDien.SelectedText = "";
            this.txtDaoDien.Size = new System.Drawing.Size(260, 36);
            this.txtDaoDien.TabIndex = 7;
            // 
            // lblDaoDien
            // 
            this.lblDaoDien.AutoSize = true;
            this.lblDaoDien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDaoDien.ForeColor = System.Drawing.Color.DimGray;
            this.lblDaoDien.Location = new System.Drawing.Point(360, 120);
            this.lblDaoDien.Name = "lblDaoDien";
            this.lblDaoDien.Size = new System.Drawing.Size(73, 19);
            this.lblDaoDien.TabIndex = 6;
            this.lblDaoDien.Text = "Đạo diễn:";
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BorderRadius = 8;
            this.txtThoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiLuong.DefaultText = "";
            this.txtThoiLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtThoiLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThoiLuong.Location = new System.Drawing.Point(30, 145);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.PasswordChar = '\0';
            this.txtThoiLuong.PlaceholderText = "";
            this.txtThoiLuong.ReadOnly = true;
            this.txtThoiLuong.SelectedText = "";
            this.txtThoiLuong.Size = new System.Drawing.Size(300, 36);
            this.txtThoiLuong.TabIndex = 5;
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblThoiLuong.ForeColor = System.Drawing.Color.DimGray;
            this.lblThoiLuong.Location = new System.Drawing.Point(30, 120);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(86, 19);
            this.lblThoiLuong.TabIndex = 4;
            this.lblThoiLuong.Text = "Thời lượng:";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.BorderRadius = 8;
            this.txtTheLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTheLoai.DefaultText = "";
            this.txtTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTheLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTheLoai.Location = new System.Drawing.Point(360, 75);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.PasswordChar = '\0';
            this.txtTheLoai.PlaceholderText = "";
            this.txtTheLoai.ReadOnly = true;
            this.txtTheLoai.SelectedText = "";
            this.txtTheLoai.Size = new System.Drawing.Size(260, 36);
            this.txtTheLoai.TabIndex = 3;
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTheLoai.ForeColor = System.Drawing.Color.DimGray;
            this.lblTheLoai.Location = new System.Drawing.Point(360, 50);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(66, 19);
            this.lblTheLoai.TabIndex = 2;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BorderRadius = 8;
            this.txtTenPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenPhim.DefaultText = "";
            this.txtTenPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPhim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenPhim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenPhim.Location = new System.Drawing.Point(30, 75);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.PasswordChar = '\0';
            this.txtTenPhim.PlaceholderText = "";
            this.txtTenPhim.ReadOnly = true;
            this.txtTenPhim.SelectedText = "";
            this.txtTenPhim.Size = new System.Drawing.Size(300, 36);
            this.txtTenPhim.TabIndex = 1;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTenPhim.ForeColor = System.Drawing.Color.DimGray;
            this.lblTenPhim.Location = new System.Drawing.Point(30, 50);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(75, 19);
            this.lblTenPhim.TabIndex = 0;
            this.lblTenPhim.Text = "Tên phim:";
            // 
            // frmMovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovieDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết phim";
            this.Load += new System.EventHandler(this.frmMovieDetail_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private System.Windows.Forms.Label lblTenPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtTenPhim;
        private Guna.UI2.WinForms.Guna2TextBox txtTheLoai;
        private System.Windows.Forms.Label lblTheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtThoiLuong;
        private System.Windows.Forms.Label lblThoiLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtDaoDien;
        private System.Windows.Forms.Label lblDaoDien;
        private Guna.UI2.WinForms.Guna2TextBox txtDienVien;
        private System.Windows.Forms.Label lblDienVien;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2PictureBox picPoster;
        private System.Windows.Forms.Label lblPoster;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private System.Windows.Forms.Label lblTrangThaiValue;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
