using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinRap.Model
{
    [Table("tblNguoiDung")]
    public class tblNguoiDung
    {
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

        [NotMapped]
        public string TrangThaiDisplay
        {
            get { return TrangThai == true ? "Hoạt động" : "Khóa"; }
        }
    }
}
