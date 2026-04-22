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

        public DbSet<tblPhim> Phims { get; set; }
        public DbSet<tblSuatChieu> SuatChieus { get; set; }
        public DbSet<tblPhongChieu> PhongChieus { get; set; }
        public DbSet<tblNguoiDung> NguoiDungs { get; set; }
        public DbSet<tblKhachHang> KhachHangs { get; set; }
        public DbSet<tblTheLoai> TheLoais { get; set; }
        public DbSet<tblGhe> Ghes { get; set; }
        public DbSet<tblLoaiGhe> LoaiGhes { get; set; }
        public DbSet<tblVe> Ves { get; set; }
    }
}
