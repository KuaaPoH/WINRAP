using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblGhe")]
    public class tblGhe
    {
        [Key]
        public int MaGhe { get; set; }

        public int? MaPhong { get; set; }

        [Required]
        [StringLength(100)]
        public string TenGhe { get; set; }

        public int? MaLoaiGhe { get; set; }

        [StringLength(1)]
        public string Hang { get; set; }

        public int? Cot { get; set; }
    }
}
