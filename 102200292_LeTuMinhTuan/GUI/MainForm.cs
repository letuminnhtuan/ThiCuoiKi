using _102200292_LeTuMinhTuan.BLL;
using _102200292_LeTuMinhTuan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102200292_LeTuMinhTuan.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.cbbHocPhan.Items.Add(new CBBItem { Key = "All", Value = "All" });
            this.cbbHocPhan.Items.AddRange(BLL_QL.Instance.GetCBBHocPhan().ToArray());
        }
        public void LoadData()
        {
            if(this.cbbHocPhan.SelectedIndex >= 0)
            {
                this.dataSV.Rows.Clear();
                string MaHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Key;
                string txtSearch = this.txtSearch.Text;
                foreach(SinhVien i in BLL_QL.Instance.GetDSSV(MaHocPhan, txtSearch))
                {
                    this.dataSV.Rows.Add(i.MaSinhVien, i.MaHocPhan, i.TenSinhVien, i.LopSinhHoat, i.TenHocPhan, i.DiemBaiTap, i.DiemGiuaKi, i.DiemCuoiKi, i.TongKet, i.NgayThi);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
