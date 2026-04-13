using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblNguoiDung")]
    public class tblNguoiDung
    {
        public tblNguoiDung()
        {
            Ves = new HashSet<tblVe>();
        }

        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string Quyen { get; set; }

        [StringLength(20)]
        public string SoDienThoai { get; set; }

        public bool? TrangThai { get; set; }

        public virtual ICollection<tblVe> Ves { get; set; }
    }
}
