using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblGhe")]
    public class tblGhe
    {
        public tblGhe()
        {
            Ves = new HashSet<tblVe>();
        }

        [Key]
        public int MaGhe { get; set; }

        public int? MaPhong { get; set; }

        [Required]
        [StringLength(100)] // Using 100 to be safe, SQL says nvarchar(10) but some models might use more
        public string TenGhe { get; set; }

        public int? MaLoaiGhe { get; set; }

        [StringLength(1)]
        public string Hang { get; set; }

        public int? Cot { get; set; }

        [ForeignKey("MaPhong")]
        public virtual tblPhongChieu PhongChieu { get; set; }

        [ForeignKey("MaLoaiGhe")]
        public virtual tblLoaiGhe LoaiGhe { get; set; }

        public virtual ICollection<tblVe> Ves { get; set; }
    }
}
