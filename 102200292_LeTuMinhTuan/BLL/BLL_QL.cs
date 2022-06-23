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
            var list = db.SinhViens.Select(p => p);
            if (!MaHocPhan.Equals("All")) list = list.Where(p => p.HocPhans.Where(c => c.MaHocPhan.Equals(MaHocPhan)).Any());
            if (!txtSearch.Equals("")) list = list.Where(p => p.TenSinhVien.Contains(txtSearch) || p.MaSinhVien.Contains(txtSearch));
            foreach(tSinhVien i in list)
            {
                SinhVien sv = new SinhVien
                {
                    MaSinhVien = i.MaSinhVien,
                    TenSinhVien = i.TenSinhVien,
                    DiemBaiTap = i.DiemBaiTap,
                    DiemGiuaKi = i.DiemGiuaKi,
                    DiemCuoiKi = i.DiemCuoiKi,
                    LopSinhHoat = i.LopSinhHoat,
                    GioiTinh = i.GioiTinh,
                    NgayThi = i.NgayThi,
                };
                sv.TongKet = sv.DiemBaiTap * 0.2 + sv.DiemGiuaKi * 0.2 + sv.DiemCuoiKi * 0.3;
                data.Add(sv);
            }
            return data;
        }
    }
}
