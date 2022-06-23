using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.DAL
{
    [Table("SV_HP")]
    public class tSV_HP
    {
        [Key]
        public int ID { get; set; }
        public string MaHocPhan { get; set; }
        public string MaSinhVien { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKi { get; set; }
        public double DiemCuoiKi { get; set; }
        public DateTime NgayThi { get; set; }

        [ForeignKey("MaSinhVien")]
        public virtual tSinhVien SinhVien { get; set; }
        [ForeignKey("MaHocPhan")]
        public virtual tHocPhan HocPhan { get; set; }
    }
}
