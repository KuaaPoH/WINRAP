namespace WinRap.ViewLINQ
{
    partial class frmShowtime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInput = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStartTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtMovie = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblTitleInput = new System.Windows.Forms.Label();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.cboFilterRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblFilterRoom = new System.Windows.Forms.Label();
            this.dtpFilterDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.dgvShowtime = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSuatChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInput.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.White;
            this.pnlInput.Controls.Add(this.btnLamMoi);
            this.pnlInput.Controls.Add(this.btnXoa);
            this.pnlInput.Controls.Add(this.btnSua);
            this.pnlInput.Controls.Add(this.btnThem);
            this.pnlInput.Controls.Add(this.txtPrice);
            this.pnlInput.Controls.Add(this.lblPrice);
            this.pnlInput.Controls.Add(this.txtStartTime);
            this.pnlInput.Controls.Add(this.lblStartTime);
            this.pnlInput.Controls.Add(this.dtpDate);
            this.pnlInput.Controls.Add(this.lblDate);
            this.pnlInput.Controls.Add(this.txtRoom);
            this.pnlInput.Controls.Add(this.lblRoom);
            this.pnlInput.Controls.Add(this.txtMovie);
            this.pnlInput.Controls.Add(this.lblMovie);
            this.pnlInput.Controls.Add(this.lblTitleInput);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(300, 718);
            this.pnlInput.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Animated = true;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(155, 551);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 40);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Animated = true;
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(25, 551);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa suất";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.BorderRadius = 8;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(155, 496);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa suất";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Animated = true;
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(25, 496);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm suất";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 8;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(25, 411);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Nhập giá vé...";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(250, 36);
            this.txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrice.Location = new System.Drawing.Point(25, 386);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Giá vé:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.BorderRadius = 8;
            this.txtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartTime.DefaultText = "";
            this.txtStartTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStartTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStartTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStartTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartTime.Location = new System.Drawing.Point(25, 331);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.PlaceholderText = "HH:mm (VD: 19:00)";
            this.txtStartTime.SelectedText = "";
            this.txtStartTime.Size = new System.Drawing.Size(250, 36);
            this.txtStartTime.TabIndex = 8;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblStartTime.Location = new System.Drawing.Point(25, 306);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(91, 19);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Giờ bắt đầu:";
            // 
            // dtpDate
            // 
            this.dtpDate.BorderRadius = 8;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(25, 251);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(250, 36);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(25, 226);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Ngày chiếu:";
            // 
            // txtRoom
            // 
            this.txtRoom.BorderRadius = 8;
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.DefaultText = "";
            this.txtRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoom.Location = new System.Drawing.Point(25, 171);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PlaceholderText = "Phòng chiếu...";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.SelectedText = "";
            this.txtRoom.Size = new System.Drawing.Size(250, 36);
            this.txtRoom.TabIndex = 4;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.DimGray;
            this.lblRoom.Location = new System.Drawing.Point(25, 146);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(94, 19);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Chọn phòng:";
            // 
            // txtMovie
            // 
            this.txtMovie.BorderRadius = 8;
            this.txtMovie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMovie.DefaultText = "";
            this.txtMovie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMovie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMovie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMovie.Location = new System.Drawing.Point(25, 91);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.PlaceholderText = "Tên phim...";
            this.txtMovie.ReadOnly = true;
            this.txtMovie.SelectedText = "";
            this.txtMovie.Size = new System.Drawing.Size(250, 36);
            this.txtMovie.TabIndex = 2;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMovie.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovie.Location = new System.Drawing.Point(25, 66);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(85, 19);
            this.lblMovie.TabIndex = 1;
            this.lblMovie.Text = "Chọn phim:";
            // 
            // lblTitleInput
            // 
            this.lblTitleInput.AutoSize = true;
            this.lblTitleInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTitleInput.Location = new System.Drawing.Point(20, 20);
            this.lblTitleInput.Name = "lblTitleInput";
            this.lblTitleInput.Size = new System.Drawing.Size(157, 25);
            this.lblTitleInput.TabIndex = 0;
            this.lblTitleInput.Text = "LẬP LỊCH CHIẾU";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.cboFilterRoom);
            this.pnlTop.Controls.Add(this.lblFilterRoom);
            this.pnlTop.Controls.Add(this.dtpFilterDate);
            this.pnlTop.Controls.Add(this.lblFilterDate);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(300, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(650, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // cboFilterRoom
            // 
            this.cboFilterRoom.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterRoom.BorderRadius = 8;
            this.cboFilterRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilterRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFilterRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboFilterRoom.ItemHeight = 30;
            this.cboFilterRoom.Location = new System.Drawing.Point(380, 22);
            this.cboFilterRoom.Name = "cboFilterRoom";
            this.cboFilterRoom.Size = new System.Drawing.Size(200, 36);
            this.cboFilterRoom.TabIndex = 3;
            // 
            // lblFilterRoom
            // 
            this.lblFilterRoom.AutoSize = true;
            this.lblFilterRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterRoom.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilterRoom.Location = new System.Drawing.Point(320, 31);
            this.lblFilterRoom.Name = "lblFilterRoom";
            this.lblFilterRoom.Size = new System.Drawing.Size(56, 19);
            this.lblFilterRoom.TabIndex = 2;
            this.lblFilterRoom.Text = "Phòng:";
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.BorderRadius = 8;
            this.dtpFilterDate.Checked = true;
            this.dtpFilterDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtpFilterDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterDate.ForeColor = System.Drawing.Color.White;
            this.dtpFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterDate.Location = new System.Drawing.Point(130, 22);
            this.dtpFilterDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFilterDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(170, 36);
            this.dtpFilterDate.TabIndex = 1;
            this.dtpFilterDate.Value = new System.DateTime(2026, 4, 9, 0, 0, 0, 0);
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilterDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilterDate.Location = new System.Drawing.Point(20, 31);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(107, 19);
            this.lblFilterDate.TabIndex = 0;
            this.lblFilterDate.Text = "Lọc theo ngày:";
            // 
            // dgvShowtime
            // 
            this.dgvShowtime.AllowUserToAddRows = false;
            this.dgvShowtime.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvShowtime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowtime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowtime.ColumnHeadersHeight = 40;
            this.dgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuatChieu,
            this.TenPhim,
            this.TenPhong,
            this.NgayChieu,
            this.GioBatDau,
            this.GiaVe});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowtime.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowtime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvShowtime.Location = new System.Drawing.Point(300, 80);
            this.dgvShowtime.Name = "dgvShowtime";
            this.dgvShowtime.ReadOnly = true;
            this.dgvShowtime.RowHeadersVisible = false;
            this.dgvShowtime.RowTemplate.DividerHeight = 5;
            this.dgvShowtime.RowTemplate.Height = 40;
            this.dgvShowtime.Size = new System.Drawing.Size(650, 638);
            this.dgvShowtime.TabIndex = 2;
            this.dgvShowtime.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowtime.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowtime.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowtime.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowtime.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowtime.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowtime.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvShowtime.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgvShowtime.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowtime.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvShowtime.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvShowtime.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowtime.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvShowtime.ThemeStyle.ReadOnly = true;
            this.dgvShowtime.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowtime.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowtime.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShowtime.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowtime.ThemeStyle.RowsStyle.Height = 40;
            this.dgvShowtime.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowtime.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowtime.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtime_CellEnter);
            // 
            // MaSuatChieu
            // 
            this.MaSuatChieu.DataPropertyName = "MaSuatChieu";
            this.MaSuatChieu.HeaderText = "Mã suất";
            this.MaSuatChieu.Name = "MaSuatChieu";
            this.MaSuatChieu.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            // 
            // NgayChieu
            // 
            this.NgayChieu.DataPropertyName = "NgayChieu";
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // GioBatDau
            // 
            this.GioBatDau.DataPropertyName = "GioBatDau";
            this.GioBatDau.HeaderText = "Bắt đầu";
            this.GioBatDau.Name = "GioBatDau";
            this.GioBatDau.ReadOnly = true;
            // 
            // GiaVe
            // 
            this.GiaVe.DataPropertyName = "GiaVe";
            this.GiaVe.HeaderText = "Giá vé";
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.ReadOnly = true;
            // 
            // frmShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(950, 718);
            this.Controls.Add(this.dgvShowtime);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowtime";
            this.Text = "frmShowtime";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlInput;
        private System.Windows.Forms.Label lblTitleInput;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowtime;
        private Guna.UI2.WinForms.Guna2TextBox txtMovie;
        private System.Windows.Forms.Label lblMovie;
        private Guna.UI2.WinForms.Guna2TextBox txtRoom;
        private System.Windows.Forms.Label lblRoom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2TextBox txtStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.Label lblFilterDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFilterDate;
        private Guna.UI2.WinForms.Guna2ComboBox cboFilterRoom;
        private System.Windows.Forms.Label lblFilterRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuatChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
    }
}
