using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblPhim")]
    public class tblPhim
    {
        [Key]
        public int MaPhim { get; set; }

        [Required]
        [StringLength(250)]
        public string TenPhim { get; set; }

        public int? MaTheLoai { get; set; }

        [Required]
        public int ThoiLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhatHanh { get; set; }

        [StringLength(150)]
        public string DaoDien { get; set; }

        [StringLength(500)]
        public string DienVien { get; set; }

        public string MoTa { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        public bool? TrangThai { get; set; }

        [ForeignKey("MaTheLoai")]
        public virtual tblTheLoai TheLoai { get; set; }

        public virtual ICollection<tblSuatChieu> SuatChieus { get; set; }
    }
}
