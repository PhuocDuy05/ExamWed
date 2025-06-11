using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExamWeb_PhamHuynhAnh.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng nhập Tựa đề!")]
        public string TuaDe { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Diễn viên!")]
        public string DienVien { get; set; }
        public bool TrongNuoc { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Giá vé!")]
        [Range(1000, 1000000, ErrorMessage = "Giá vé phải từ 1.000 đến 1.000.000 VNĐ")]
        public double GiaVe { get; set; }     
        public int ThoiLuong { get; set; }
    }
}
