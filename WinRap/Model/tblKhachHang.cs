using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblKhachHang")]
    public class tblKhachHang
    {
        public tblKhachHang()
        {
            Ves = new HashSet<tblVe>();
        }

        [Key]
        public int MaKhachHang { get; set; }

        [Required]
        [StringLength(150)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? DiemTichLuy { get; set; }

        public DateTime? NgayTao { get; set; }

        public virtual ICollection<tblVe> Ves { get; set; }
    }
}
