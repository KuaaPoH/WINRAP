using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblLoaiGhe")]
    public class tblLoaiGhe
    {
        public tblLoaiGhe()
        {
            Ghes = new HashSet<tblGhe>();
        }

        [Key]
        public int MaLoaiGhe { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiGhe { get; set; }

        public decimal? GiaPhuThu { get; set; }

        public virtual ICollection<tblGhe> Ghes { get; set; }
    }
}
