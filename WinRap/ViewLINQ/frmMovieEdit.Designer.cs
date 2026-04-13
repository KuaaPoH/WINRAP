namespace WinRap.ViewLINQ
{
    partial class frmMovieEdit
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
            this.swTrangThai = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonAnh = new Guna.UI2.WinForms.Guna2Button();
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
            this.cboTheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
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
            this.lblTitle.Text = "SỬA THÔNG TIN PHIM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.swTrangThai);
            this.pnlContent.Controls.Add(this.lblTrangThai);
            this.pnlContent.Controls.Add(this.btnHuy);
            this.pnlContent.Controls.Add(this.btnLuu);
            this.pnlContent.Controls.Add(this.btnChonAnh);
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
            this.pnlContent.Controls.Add(this.cboTheLoai);
            this.pnlContent.Controls.Add(this.lblTheLoai);
            this.pnlContent.Controls.Add(this.txtTenPhim);
            this.pnlContent.Controls.Add(this.lblTenPhim);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1000, 690);
            this.pnlContent.TabIndex = 1;
            // 
            // swTrangThai
            // 
            this.swTrangThai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swTrangThai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.swTrangThai.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swTrangThai.Location = new System.Drawing.Point(125, 480);
            this.swTrangThai.Name = "swTrangThai";
            this.swTrangThai.Size = new System.Drawing.Size(35, 20);
            this.swTrangThai.TabIndex = 18;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 480);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(89, 19);
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Đang chiếu:";
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(335, 530);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Animated = true;
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(195, 530);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Cập nhật";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Animated = true;
            this.btnChonAnh.BorderRadius = 8;
            this.btnChonAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnChonAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnChonAnh.Location = new System.Drawing.Point(360, 420);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(260, 30);
            this.btnChonAnh.TabIndex = 14;
            this.btnChonAnh.Text = "Thay đổi Poster";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
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
            this.txtMoTa.PlaceholderText = "Nhập mô tả...";
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
            this.txtDienVien.PlaceholderText = "Diễn viên...";
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
            this.lblDienVien.Size = new System.Drawing.Size(76, 19);
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
            this.txtDaoDien.PlaceholderText = "Đạo diễn...";
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
            this.txtThoiLuong.PlaceholderText = "Số phút...";
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
            // cboTheLoai
            // 
            this.cboTheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboTheLoai.BorderRadius = 8;
            this.cboTheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTheLoai.ItemHeight = 30;
            this.cboTheLoai.Location = new System.Drawing.Point(360, 75);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(260, 36);
            this.cboTheLoai.TabIndex = 3;
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
            this.txtTenPhim.PlaceholderText = "Tên phim...";
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
            // frmMovieEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovieEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa phim";
            this.Load += new System.EventHandler(this.frmMovieEdit_Load);
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
        private Guna.UI2.WinForms.Guna2ComboBox cboTheLoai;
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
        private Guna.UI2.WinForms.Guna2Button btnChonAnh;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2ToggleSwitch swTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
    }
}
