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
                    DiemBaiTap = i.DiemBaiTap,
                    DiemGiuaKi = i.DiemGiuaKi,
                    DiemCuoiKi = i.DiemCuoiKi,
                    LopSinhHoat = i.SinhVien.LopSinhHoat,
                    GioiTinh = i.SinhVien.GioiTinh,
                    NgayThi = i.NgayThi,
                    MaHocPhan = i.MaHocPhan,
                    TenHocPhan = i.HocPhan.TenHocPhan,
                };
                sv.TongKet = sv.DiemBaiTap * 0.2 + sv.DiemGiuaKi * 0.2 + sv.DiemCuoiKi * 0.3;
                data.Add(sv);
            }
            return data;
        }
        public SinhVien GetSinhVien(string MaSinhVien, string MaHocPhan)
        {
            var data = db.SV_HPs.Where(p => p.MaSinhVien.Equals(MaSinhVien) && p.MaHocPhan.Equals(MaHocPhan)).FirstOrDefault();
            SinhVien sv = null;
            if(data != null)
            {
                sv = new SinhVien
                {
                    MaSinhVien = data.MaSinhVien,
                    TenSinhVien = data.SinhVien.TenSinhVien,
                    GioiTinh = data.SinhVien.GioiTinh,
                    DiemBaiTap = data.DiemBaiTap,
                    DiemGiuaKi = data.DiemGiuaKi,
                    DiemCuoiKi = data.DiemCuoiKi,
                    LopSinhHoat = data.SinhVien.LopSinhHoat,
                    NgayThi = data.NgayThi,
                    MaHocPhan = data.MaHocPhan,
                    TenHocPhan = data.HocPhan.TenHocPhan,
                    TongKet = data.DiemBaiTap * 0.2 + data.DiemGiuaKi * 0.2 + data.DiemCuoiKi * 0.3,
                };
            }
            return sv;
        }
        public void AddUpdateSV(SinhVien data)
        {
            if (GetSinhVien(data.MaSinhVien, data.MaHocPhan) != null) UpdateSV(data);
            else AddSV(data);
        }
        public void AddSV(SinhVien data)
        {
            tSinhVien sv = new tSinhVien
            {
                MaSinhVien = data.MaSinhVien,
                TenSinhVien = data.TenSinhVien,
                GioiTinh = data.GioiTinh,
                LopSinhHoat = data.LopSinhHoat,
            };
            tSV_HP sv_hp = new tSV_HP
            {
                MaHocPhan = data.MaHocPhan,
                MaSinhVien = data.MaSinhVien,
                DiemBaiTap = data.DiemBaiTap,
                DiemGiuaKi = data.DiemGiuaKi,
                DiemCuoiKi = data.DiemCuoiKi,
                NgayThi = data.NgayThi,
            };
            db.SinhViens.Add(sv);
            db.SV_HPs.Add(sv_hp);
            db.SaveChanges();
        }
        public void UpdateSV(SinhVien data)
        {
            var SV = db.SinhViens.Find(data.MaSinhVien);
            SV.TenSinhVien = data.TenSinhVien;
            SV.GioiTinh = data.GioiTinh;
            SV.LopSinhHoat = data.LopSinhHoat;
            var SV_HP = db.SV_HPs.Where(p => p.MaSinhVien.Equals(data.MaSinhVien) && p.MaHocPhan.Equals(data.MaHocPhan)).FirstOrDefault();
            SV_HP.DiemBaiTap = data.DiemBaiTap;
            SV_HP.DiemGiuaKi = data.DiemGiuaKi;
            SV_HP.DiemCuoiKi = data.DiemCuoiKi;
            SV_HP.NgayThi = data.NgayThi;
            SV_HP.MaHocPhan = data.MaHocPhan;
            db.SaveChanges();
        }
        public void DeleteSV(string MaSinhVien, string MaHocPhan)
        {

        }
    }
}
