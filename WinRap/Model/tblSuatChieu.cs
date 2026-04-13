using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblSuatChieu")]
    public class tblSuatChieu
    {
        [Key]
        public int MaSuatChieu { get; set; }

        public int? MaPhim { get; set; }

        public int? MaPhong { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime NgayChieu { get; set; }

        [Required]
        public TimeSpan GioBatDau { get; set; }

        public TimeSpan? GioKetThuc { get; set; }

        [Required]
        public decimal GiaVeCoBan { get; set; }

        public bool? TrangThai { get; set; }

        [ForeignKey("MaPhim")]
        public virtual tblPhim Phim { get; set; }

        [ForeignKey("MaPhong")]
        public virtual tblPhongChieu PhongChieu { get; set; }

        public virtual ICollection<tblVe> Ves { get; set; }
    }
}
