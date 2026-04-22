using System;
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
    }
}
