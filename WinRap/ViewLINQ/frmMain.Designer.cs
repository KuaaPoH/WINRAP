namespace WinRap.ViewLINQ
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnTheLoai = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhim = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichChieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanVe = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnNhanVien);
            this.pnlSidebar.Controls.Add(this.btnTheLoai);
            this.pnlSidebar.Controls.Add(this.btnKhachHang);
            this.pnlSidebar.Controls.Add(this.btnPhong);
            this.pnlSidebar.Controls.Add(this.btnPhim);
            this.pnlSidebar.Controls.Add(this.btnLichChieu);
            this.pnlSidebar.Controls.Add(this.btnBanVe);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSidebar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.White;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 788);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 738);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Animated = true;
            this.btnThongKe.BorderRadius = 10;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnThongKe.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.White;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThongKe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnThongKe.Location = new System.Drawing.Point(12, 472);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(226, 50);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.TextOffset = new System.Drawing.Point(10, 0);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Animated = true;
            this.btnNhanVien.BorderRadius = 10;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNhanVien.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNhanVien.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNhanVien.Location = new System.Drawing.Point(12, 416);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(226, 50);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNhanVien.TextOffset = new System.Drawing.Point(10, 0);
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Animated = true;
            this.btnTheLoai.BorderRadius = 10;
            this.btnTheLoai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTheLoai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnTheLoai.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTheLoai.FillColor = System.Drawing.Color.White;
            this.btnTheLoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTheLoai.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnTheLoai.Location = new System.Drawing.Point(12, 360);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(226, 50);
            this.btnTheLoai.TabIndex = 9;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTheLoai.TextOffset = new System.Drawing.Point(10, 0);
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Animated = true;
            this.btnKhachHang.BorderRadius = 10;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnKhachHang.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhachHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnKhachHang.Location = new System.Drawing.Point(12, 304);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(226, 50);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKhachHang.TextOffset = new System.Drawing.Point(10, 0);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Animated = true;
            this.btnPhong.BorderRadius = 10;
            this.btnPhong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPhong.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPhong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhong.FillColor = System.Drawing.Color.White;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnPhong.Location = new System.Drawing.Point(12, 248);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(226, 50);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Phòng chiếu";
            this.btnPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhong.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.Animated = true;
            this.btnPhim.BorderRadius = 10;
            this.btnPhim.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPhim.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPhim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhim.FillColor = System.Drawing.Color.White;
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPhim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPhim.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnPhim.Location = new System.Drawing.Point(12, 192);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(226, 50);
            this.btnPhim.TabIndex = 3;
            this.btnPhim.Text = "Phim";
            this.btnPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhim.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.Animated = true;
            this.btnLichChieu.BorderRadius = 10;
            this.btnLichChieu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLichChieu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLichChieu.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLichChieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichChieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichChieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichChieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichChieu.FillColor = System.Drawing.Color.White;
            this.btnLichChieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLichChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLichChieu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnLichChieu.Location = new System.Drawing.Point(12, 136);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(226, 50);
            this.btnLichChieu.TabIndex = 2;
            this.btnLichChieu.Text = "Lịch chiếu";
            this.btnLichChieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichChieu.TextOffset = new System.Drawing.Point(10, 0);
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
            // 
            // btnBanVe
            // 
            this.btnBanVe.Animated = true;
            this.btnBanVe.BorderRadius = 10;
            this.btnBanVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBanVe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBanVe.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBanVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanVe.FillColor = System.Drawing.Color.White;
            this.btnBanVe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBanVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBanVe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnBanVe.Location = new System.Drawing.Point(12, 80);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(226, 50);
            this.btnBanVe.TabIndex = 1;
            this.btnBanVe.Text = "Bán vé";
            this.btnBanVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBanVe.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlLogo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 70);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblLogo.Location = new System.Drawing.Point(40, 15);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(132, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "WINRAP";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.ctrlClose);
            this.pnlTopBar.Controls.Add(this.ctrlMaximize);
            this.pnlTopBar.Controls.Add(this.ctrlMinimize);
            this.pnlTopBar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTopBar.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.FillColor = System.Drawing.Color.White;
            this.pnlTopBar.Location = new System.Drawing.Point(250, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(950, 70);
            this.pnlTopBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // ctrlClose
            // 
            this.ctrlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrlClose.IconColor = System.Drawing.Color.Gray;
            this.ctrlClose.Location = new System.Drawing.Point(902, 17);
            this.ctrlClose.Name = "ctrlClose";
            this.ctrlClose.Size = new System.Drawing.Size(35, 35);
            this.ctrlClose.TabIndex = 2;
            // 
            // ctrlMaximize
            // 
            this.ctrlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrlMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ctrlMaximize.IconColor = System.Drawing.Color.Gray;
            this.ctrlMaximize.Location = new System.Drawing.Point(861, 17);
            this.ctrlMaximize.Name = "ctrlMaximize";
            this.ctrlMaximize.Size = new System.Drawing.Size(35, 35);
            this.ctrlMaximize.TabIndex = 1;
            // 
            // ctrlMinimize
            // 
            this.ctrlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ctrlMinimize.IconColor = System.Drawing.Color.Gray;
            this.ctrlMinimize.Location = new System.Drawing.Point(820, 17);
            this.ctrlMinimize.Name = "ctrlMinimize";
            this.ctrlMinimize.Size = new System.Drawing.Size(35, 35);
            this.ctrlMinimize.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pnlMain.Location = new System.Drawing.Point(250, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(950, 718);
            this.pnlMain.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragMode = Guna.UI2.WinForms.Enums.DragMode.Control;
            this.guna2DragControl1.TargetControl = this.pnlTopBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 788);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý rạp chiếu phim - WINRAP";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnBanVe;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnTheLoai;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnPhong;
        private Guna.UI2.WinForms.Guna2Button btnPhim;
        private Guna.UI2.WinForms.Guna2Button btnLichChieu;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMinimize;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
