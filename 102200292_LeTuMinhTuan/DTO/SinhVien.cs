using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.DTO
{
    public class SinhVien
    {
        public int ID { get; set; }
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string LopSinhHoat { get; set; }
        public bool GioiTinh { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKi { get; set; }
        public double DiemCuoiKi { get; set; }
        public double TongKet { get; set; }
        public DateTime NgayThi { get; set; }
        public string MaHocPhan { get; set; }
        public string TenHocPhan { get; set; }
    }
}
