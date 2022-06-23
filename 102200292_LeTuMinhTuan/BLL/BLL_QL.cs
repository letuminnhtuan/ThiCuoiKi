using _102200292_LeTuMinhTuan.DAL;
using _102200292_LeTuMinhTuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102200292_LeTuMinhTuan.BLL
{
    public class BLL_QL
    {
        QLSV db;
        private static BLL_QL _Instance;
        public static BLL_QL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new BLL_QL(new QLSV());
                return _Instance;
            }
            private set { }
        }
        private BLL_QL(QLSV db)
        {
            this.db = db;
        }
        public List<CBBItem> GetCBBHocPhan()
        {
            var list = db.HocPhans;
            List<CBBItem> data = new List<CBBItem>();
            foreach(tHocPhan i in list)
            {
                data.Add(new CBBItem { Key = i.MaHocPhan, Value = i.TenHocPhan });
            }
            return data;
        }
        public List<SinhVien> GetDSSV(string MaHocPhan, string txtSearch)
        {
            List<SinhVien> data = new List<SinhVien>();
            var list = db.SV_HPs.Select(p => p);
            if (!MaHocPhan.Equals("All")) list = list.Where(p => p.MaHocPhan.Equals(MaHocPhan));
            if (!txtSearch.Equals("")) list = list.Where(p => p.SinhVien.TenSinhVien.Contains(txtSearch) || p.MaSinhVien.Contains(txtSearch));
            foreach(tSV_HP i in list)
            {
                SinhVien sv = new SinhVien
                {
                    MaSinhVien = i.MaSinhVien,
                    TenSinhVien = i.SinhVien.TenSinhVien,
                    DiemBaiTap = i.SinhVien.DiemBaiTap,
                    DiemGiuaKi = i.SinhVien.DiemGiuaKi,
                    DiemCuoiKi = i.SinhVien.DiemCuoiKi,
                    LopSinhHoat = i.SinhVien.LopSinhHoat,
                    GioiTinh = i.SinhVien.GioiTinh,
                    NgayThi = i.SinhVien.NgayThi,
                    MaHocPhan = i.MaHocPhan,
                    TenHocPhan = i.HocPhan.TenHocPhan,
                };
                sv.TongKet = sv.DiemBaiTap * 0.2 + sv.DiemGiuaKi * 0.2 + sv.DiemCuoiKi * 0.3;
                data.Add(sv);
            }
            return data;
        }
    }
}
