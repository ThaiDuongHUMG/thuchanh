using System.ComponentModel.DataAnnotations;

namespace thuchanh.Models{
public class LopHoc {
    [Key]
    [Display(Name = "Mã Sinh Viên")]
    public string MaSinhVien { get; set; }
    [Display(Name = "Họ và tên")]
    public string HoTen { get; set; }
    [Display(Name = "Mã Lớp")]
    public string MaLop { get; set; }
}

}    
    
    