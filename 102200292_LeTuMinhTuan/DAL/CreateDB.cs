using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _102200292_LeTuMinhTuan.DAL
{
    public class CreateDB : DropCreateDatabaseIfModelChanges<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "JV", TenHocPhan = "Lap trinh Java" });
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "NET", TenHocPhan = "Lap trinh .NET" });
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "TRR", TenHocPhan = "Toan roi rac" });
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "XSTK", TenHocPhan = "Xac xuat thong ke" });
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "MMT", TenHocPhan = "Mang may tinh" });
            context.HocPhans.Add(new tHocPhan { MaHocPhan = "CNPM", TenHocPhan = "Cong nghe phan mem" });

            context.SinhViens.Add(new tSinhVien { MaSinhVien = "102", TenSinhVien = "Nguyen Van A", GioiTinh = true, DiemBaiTap = 7, DiemGiuaKi = 7, DiemCuoiKi = 7, LopSinhHoat = "20T", NgayThi = new DateTime(2022, 6, 22)});
            context.SinhViens.Add(new tSinhVien { MaSinhVien = "103", TenSinhVien = "Nguyen Van B", GioiTinh = false, DiemBaiTap = 7, DiemGiuaKi = 5, DiemCuoiKi = 8, LopSinhHoat = "20T", NgayThi = new DateTime(2022, 6, 12) });
            context.SinhViens.Add(new tSinhVien { MaSinhVien = "104", TenSinhVien = "Tran Van A", GioiTinh = true, DiemBaiTap = 6, DiemGiuaKi = 8, DiemCuoiKi = 7, LopSinhHoat = "19T", NgayThi = new DateTime(2022, 6, 3) });
            context.SinhViens.Add(new tSinhVien { MaSinhVien = "105", TenSinhVien = "Tran Van B", GioiTinh = true, DiemBaiTap = 8, DiemGiuaKi = 9, DiemCuoiKi = 10, LopSinhHoat = "18T", NgayThi = new DateTime(2022, 5, 5) });
        }
    }
}
