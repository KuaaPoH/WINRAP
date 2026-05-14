namespace WinRap.ViewLINQ
{
    partial class ucRoomCard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.card = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblTicketInfo = new System.Windows.Forms.Label();
            this.pbOccupancy = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.dot = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).BeginInit();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.BorderRadius = 15;
            this.card.Controls.Add(this.lblName);
            this.card.Controls.Add(this.lblType);
            this.card.Controls.Add(this.lblMovieTitle);
            this.card.Controls.Add(this.lblRemaining);
            this.card.Controls.Add(this.lblTicketInfo);
            this.card.Controls.Add(this.pbOccupancy);
            this.card.Controls.Add(this.dot);
            this.card.Controls.Add(this.lblStatus);
            this.card.Controls.Add(this.btnView);
            this.card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card.FillColor = System.Drawing.Color.White;
            this.card.FillColor2 = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(10, 10);
            this.card.Name = "card";
            this.card.ShadowDecoration.BorderRadius = 15;
            this.card.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.card.ShadowDecoration.Depth = 15;
            this.card.ShadowDecoration.Enabled = true;
            this.card.ShadowDecoration.Parent = this.card;
            this.card.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5);
            this.card.Size = new System.Drawing.Size(270, 230);
            this.card.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(15, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(117, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Room Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(200, 15);
            this.lblType.Name = "lblType";
            this.lblType.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lblType.Size = new System.Drawing.Size(41, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMovieTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblMovieTitle.Location = new System.Drawing.Point(15, 45);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(240, 25);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "🎬 Movie Title";
            // 
            // lblRemaining
            // 
            this.lblRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.lblRemaining.Location = new System.Drawing.Point(150, 75);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(110, 20);
            this.lblRemaining.TabIndex = 3;
            this.lblRemaining.Text = "⏳ Còn 0p";
            this.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTicketInfo
            // 
            this.lblTicketInfo.AutoSize = true;
            this.lblTicketInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTicketInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTicketInfo.Location = new System.Drawing.Point(15, 80);
            this.lblTicketInfo.Name = "lblTicketInfo";
            this.lblTicketInfo.Size = new System.Drawing.Size(59, 15);
            this.lblTicketInfo.TabIndex = 4;
            this.lblTicketInfo.Text = "Vé: 0/100";
            // 
            // pbOccupancy
            // 
            this.pbOccupancy.BackColor = System.Drawing.Color.Transparent;
            this.pbOccupancy.BorderRadius = 5;
            this.pbOccupancy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.pbOccupancy.Location = new System.Drawing.Point(15, 105);
            this.pbOccupancy.Name = "pbOccupancy";
            this.pbOccupancy.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbOccupancy.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pbOccupancy.ShadowDecoration.Parent = this.pbOccupancy;
            this.pbOccupancy.Size = new System.Drawing.Size(240, 10);
            this.pbOccupancy.TabIndex = 5;
            this.pbOccupancy.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.pbOccupancy.Value = 50;
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Transparent;
            this.dot.FillColor = System.Drawing.Color.Green;
            this.dot.Location = new System.Drawing.Point(18, 135);
            this.dot.Name = "dot";
            this.dot.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dot.ShadowDecoration.Parent = this.dot;
            this.dot.Size = new System.Drawing.Size(8, 8);
            this.dot.TabIndex = 6;
            this.dot.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(30, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BorderRadius = 8;
            this.btnView.CheckedState.Parent = this.btnView;
            this.btnView.CustomImages.Parent = this.btnView;
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnView.HoverState.Parent = this.btnView;
            this.btnView.Location = new System.Drawing.Point(15, 175);
            this.btnView.Name = "btnView";
            this.btnView.ShadowDecoration.Parent = this.btnView;
            this.btnView.Size = new System.Drawing.Size(240, 35);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Giám sát ghế";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ucRoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.card);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucRoomCard";
            this.Size = new System.Drawing.Size(290, 250);
            this.card.ResumeLayout(false);
            this.card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel card;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblTicketInfo;
        private Guna.UI2.WinForms.Guna2ProgressBar pbOccupancy;
        private Guna.UI2.WinForms.Guna2CirclePictureBox dot;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnView;
    }
}
