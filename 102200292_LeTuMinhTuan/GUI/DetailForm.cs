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
    public partial class DetailForm : Form
    {
        public delegate void Del();
        public Del d;
        public int ID { get; set; }
        public DetailForm(int ID)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.cbbHocPhan.Items.AddRange(BLL_QL.Instance.GetCBBHocPhan().ToArray());
            this.ID = ID;
            SetGUI();
        }
        public void SetGUI()
        {
            if(BLL_QL.Instance.GetSinhVien(this.ID) != null)
            {
                SinhVien data = BLL_QL.Instance.GetSinhVien(this.ID);
                this.txtMSSV.Text = data.MaSinhVien;
                this.txtMSSV.Enabled = false;
                this.txtTen.Text = data.TenSinhVien;
                this.cbbLopSH.Text = data.LopSinhHoat;
                this.dateTimePicker1.Value = data.NgayThi;
                this.txtDiemBT.Text = data.DiemBaiTap.ToString();
                this.txtDiemGK.Text = data.DiemGiuaKi.ToString();
                this.txtDiemCK.Text = data.DiemCuoiKi.ToString();
                this.txtTongKet.Text = data.TongKet.ToString();
                if (data.GioiTinh) this.radioMale.Checked = true;
                else this.radioFemale.Checked = true;
                foreach(CBBItem i in this.cbbHocPhan.Items)
                {
                    if (i.Key.Equals(data.MaHocPhan))
                    {
                        this.cbbHocPhan.SelectedItem = i;
                        break;
                    }
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                ID = this.ID,
                MaSinhVien = this.txtMSSV.Text,
                TenSinhVien = this.txtTen.Text,
                LopSinhHoat = this.cbbLopSH.Text,
                MaHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Key,
                TenHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Value,
                GioiTinh = this.radioMale.Checked,
                DiemBaiTap = Convert.ToDouble(this.txtDiemBT.Text),
                DiemGiuaKi = Convert.ToDouble(this.txtDiemGK.Text),
                DiemCuoiKi = Convert.ToDouble(this.txtDiemCK.Text),
                NgayThi = this.dateTimePicker1.Value,
            };
            sv.TongKet = sv.DiemBaiTap * 0.2 + sv.DiemGiuaKi * 0.2 + sv.DiemCuoiKi * 0.3;
            BLL_QL.Instance.AddUpdateSV(sv);
            d();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void NhapDiem(object o, EventArgs e)
        {
            if(this.txtDiemBT.Text != "" && this.txtDiemGK.Text != "" && this.txtDiemCK.Text != "")
            {
                double DiemBaiTap = Convert.ToDouble(this.txtDiemBT.Text);
                double DiemGiuaKi = Convert.ToDouble(this.txtDiemGK.Text);
                double DiemCuoiKi = Convert.ToDouble(this.txtDiemCK.Text);
                double TongKet = DiemBaiTap * 0.2 + DiemGiuaKi * 0.2 + DiemCuoiKi * 0.3;
                this.txtTongKet.Text = TongKet.ToString();
            }
        }
    }
}
