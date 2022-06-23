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
                    this.dataSV.Rows.Add(i.ID, i.TenSinhVien, i.LopSinhHoat, i.TenHocPhan, i.DiemBaiTap, i.DiemGiuaKi, i.DiemCuoiKi, i.TongKet, i.NgayThi);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DetailForm f = new DetailForm(0);
            f.d = new DetailForm.Del(LoadData);
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dataSV.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(this.dataSV.SelectedRows[0].Cells["colID"].Value.ToString());
                DetailForm f = new DetailForm(ID);
                f.d = new DetailForm.Del(LoadData);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dataSV.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(this.dataSV.SelectedRows[0].Cells["colID"].Value.ToString());
                BLL_QL.Instance.DeleteSV(ID);
                LoadData();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(this.cbbSort.SelectedIndex >= 0)
            {
                this.dataSV.Rows.Clear();
                string txtSort = this.cbbSort.Text;
                string MaHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Key;
                string txtSearch = this.txtSearch.Text;
                foreach (SinhVien i in BLL_QL.Instance.SortDSSV(txtSort, MaHocPhan, txtSearch))
                {
                    this.dataSV.Rows.Add(i.ID, i.TenSinhVien, i.LopSinhHoat, i.TenHocPhan, i.DiemBaiTap, i.DiemGiuaKi, i.DiemCuoiKi, i.TongKet, i.NgayThi);
                }
            }
        }
    }
}
