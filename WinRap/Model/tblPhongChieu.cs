using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblPhongChieu")]
    public class tblPhongChieu
    {
        public tblPhongChieu()
        {
            SuatChieus = new HashSet<tblSuatChieu>();
            Ghes = new HashSet<tblGhe>();
        }

        [Key]
        public int MaPhong { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhong { get; set; }

        [StringLength(20)]
        public string LoaiPhong { get; set; }

        [Required]
        public int TongSoGhe { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int? SoHang { get; set; }

        public int? SoCot { get; set; }

        [StringLength(255)]
        public string MoTaKyThuat { get; set; }

        public int? ThoiGianDonDep { get; set; }

        public virtual ICollection<tblSuatChieu> SuatChieus { get; set; }
        public virtual ICollection<tblGhe> Ghes { get; set; }
    }
}
