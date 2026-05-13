using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WinRap.Model;

namespace WinRap.ViewLINQ
{
    public partial class frmTicket : Form
    {
        private DataContext db = new DataContext();
        private int selectedMovieId = -1;
        private Guna2GradientPanel selectedMovieCard = null;

        public frmTicket()
        {
            InitializeComponent();
        }

        private async void frmTicket_Load(object sender, EventArgs e)
        {
            dtpFilterDate.Value = DateTime.Now;
            await LoadMoviesByDateAsync(dtpFilterDate.Value, txtSearchMovie.Text.Trim());
        }

        private async void dtpFilterDate_ValueChanged(object sender, EventArgs e)
        {
            await LoadMoviesByDateAsync(dtpFilterDate.Value, txtSearchMovie.Text.Trim());
            cboShowtime.Items.Clear();
            selectedMovieId = -1;
        }

        private async void txtSearchMovie_TextChanged(object sender, EventArgs e)
        {
            await LoadMoviesByDateAsync(dtpFilterDate.Value, txtSearchMovie.Text.Trim());
            cboShowtime.Items.Clear();
            selectedMovieId = -1;
        }

        private async Task LoadMoviesByDateAsync(DateTime date, string keyword)
        {
            flpMovies.Controls.Clear();
            
    
            Label lblLoading = new Label { Text = "Đang tải dữ liệu...", AutoSize = true, Location = new Point(35, 10) };
            flpMovies.Controls.Add(lblLoading);

            try
            {
        
                var listMovies = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        var query = (from sc in context.SuatChieus
                                     join p in context.Phims on sc.MaPhim equals p.MaPhim
                                     where sc.NgayChieu == date.Date && sc.TrangThai == true
                                     select p).Distinct();

                        if (!string.IsNullOrEmpty(keyword))
                        {
                            query = query.Where(p => p.TenPhim.ToLower().Contains(keyword.ToLower()));
                        }

                        return query.ToList();
                    }
                });

                flpMovies.Controls.Clear();

                if (listMovies.Count == 0)
                {
                    flpMovies.Controls.Add(new Label { Text = "Không có phim nào phù hợp điều kiện tìm kiếm.", AutoSize = true });
                    return;
                }

                foreach (var phim in listMovies)
                {
                    CreateMovieCard(phim.MaPhim, phim.TenPhim, phim.HinhAnh);
                }
            }
            catch (Exception ex)
            {
                flpMovies.Controls.Clear();
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message + "\n\nVui lòng kiểm tra lại SQL Server và Chuỗi kết nối trong App.config.");
            }
        }

        private void CreateMovieCard(int id, string title, string imgPath)
        {
            Guna2GradientPanel card = new Guna2GradientPanel();
            card.Size = new Size(180, 310);
            card.BorderRadius = 15;
            card.FillColor = Color.White;
            card.FillColor2 = Color.White;
            card.Margin = new Padding(15);
            card.Cursor = Cursors.Hand;
            card.Tag = id;

         
            card.ShadowDecoration.Enabled = true;
            card.ShadowDecoration.BorderRadius = 15;
            card.ShadowDecoration.Depth = 5;
            card.ShadowDecoration.Color = Color.FromArgb(100, 0, 0, 0);

            Guna2PictureBox pic = new Guna2PictureBox();
            pic.Size = new Size(180, 260);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = DockStyle.Top;
            pic.Cursor = Cursors.Hand;
            pic.BorderRadius = 15;
            pic.CustomizableEdges.BottomLeft = false;
            pic.CustomizableEdges.BottomRight = false;
            
            if (!string.IsNullOrEmpty(imgPath))
            {
                try {
                    string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    string fullPath = Path.Combine(projectPath, imgPath);
                    if (File.Exists(fullPath))
                    {
                        using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            if (pic.Image != null) pic.Image.Dispose();
                            pic.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        pic.BackColor = Color.FromArgb(242, 245, 250);
                    }
                } catch {
                    pic.BackColor = Color.FromArgb(242, 245, 250);
                }
            }
            else
            {
                pic.BackColor = Color.FromArgb(242, 245, 250);
            }

            Label lbl = new Label();
            lbl.Text = title;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(64, 64, 64);
            lbl.Cursor = Cursors.Hand;

            EventHandler cardClick = (s, e) => {
                SelectMovie(card, id);
            };

            card.Click += cardClick;
            pic.Click += cardClick;
            lbl.Click += cardClick;

            card.Controls.Add(lbl);
            card.Controls.Add(pic);
            flpMovies.Controls.Add(card);
        }

        private async void SelectMovie(Guna2GradientPanel card, int movieId)
        {
            if (selectedMovieCard != null)
            {
                selectedMovieCard.BorderThickness = 0;
                selectedMovieCard.FillColor = Color.White;
                selectedMovieCard.FillColor2 = Color.White;
            }

            selectedMovieId = movieId;
            selectedMovieCard = card;
            selectedMovieCard.BorderThickness = 2;
            selectedMovieCard.BorderColor = Color.FromArgb(94, 148, 255);
            selectedMovieCard.FillColor = Color.FromArgb(240, 245, 255);
            selectedMovieCard.FillColor2 = Color.FromArgb(240, 245, 255);

            await LoadShowtimesAsync(movieId, dtpFilterDate.Value);
        }

        private async Task LoadShowtimesAsync(int movieId, DateTime date)
        {
            cboShowtime.Items.Clear();
            try
            {
                var listSC = await Task.Run(() => {
                    using (var context = new DataContext())
                    {
                        return (from sc in context.SuatChieus
                                join p in context.PhongChieus on sc.MaPhong equals p.MaPhong
                                where sc.MaPhim == movieId && sc.NgayChieu == date.Date && sc.TrangThai == true
                                orderby sc.GioBatDau
                                select new {
                                    ID = sc.MaSuatChieu,
                                    Gio = sc.GioBatDau,
                                    TenPhong = p.TenPhong
                                })
                                .ToList();
                    }
                });

                foreach (var sc in listSC)
                {
                    string hienThi = sc.Gio.ToString(@"hh\:mm") + " - " + sc.TenPhong;
                    cboShowtime.Items.Add(new { ID = sc.ID, Text = hienThi });
                }
                
                cboShowtime.DisplayMember = "Text";
                cboShowtime.ValueMember = "ID";
                if (cboShowtime.Items.Count > 0) cboShowtime.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải suất chiếu: " + ex.Message);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (selectedMovieId == -1)
            {
                MessageBox.Show("Vui lòng chọn phim trước!");
                return;
            }

            if (cboShowtime.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!");
                return;
            }

            var selectedSC = (dynamic)cboShowtime.SelectedItem;
            int maSuatChieu = selectedSC.ID;

            frmMain.Instance.container(new frmSeatLayout(maSuatChieu));
        }
    }
}
