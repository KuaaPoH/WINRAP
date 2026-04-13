using System;
using System.Data.Entity;
using System.Linq;

namespace WinRap.Model
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=MyConnectionString")
        {
        }

        public virtual DbSet<tblPhim> Phims { get; set; }
        public virtual DbSet<tblSuatChieu> SuatChieus { get; set; }
        public virtual DbSet<tblPhongChieu> PhongChieus { get; set; }
        public virtual DbSet<tblNguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<tblKhachHang> KhachHangs { get; set; }
        public virtual DbSet<tblTheLoai> TheLoais { get; set; }
        public virtual DbSet<tblGhe> Ghes { get; set; }
        public virtual DbSet<tblLoaiGhe> LoaiGhes { get; set; }
        public virtual DbSet<tblVe> Ves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Cấu hình bổ sung nếu cần thiết
            base.OnModelCreating(modelBuilder);
        }
    }
}
