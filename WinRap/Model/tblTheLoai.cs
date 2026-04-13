using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblTheLoai")]
    public class tblTheLoai
    {
        public tblTheLoai()
        {
            Phims = new HashSet<tblPhim>();
        }

        [Key]
        public int MaTheLoai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTheLoai { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        public virtual ICollection<tblPhim> Phims { get; set; }
    }
}
