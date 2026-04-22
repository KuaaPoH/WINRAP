using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblLoaiGhe")]
    public class tblLoaiGhe
    {
        [Key]
        public int MaLoaiGhe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiGhe { get; set; }

        public decimal? GiaPhuThu { get; set; }
    }
}
