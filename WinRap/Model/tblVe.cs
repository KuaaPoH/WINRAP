using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblVe")]
    public class tblVe
    {
        [Key]
        public int MaVe { get; set; }

        public int? MaSuatChieu { get; set; }

        public int? MaGhe { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaNguoiDung { get; set; }

        public DateTime? NgayDat { get; set; }

        [Required]
        public decimal TongTien { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }
    }
}
