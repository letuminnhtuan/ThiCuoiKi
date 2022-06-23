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
        public DetailForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien
            {
                MaSinhVien = this.txtMSSV.Text,
                TenSinhVien = this.txtTen.Text,
                LopSinhHoat = this.cbbLopSH.Text,
                MaHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Key,
                TenHocPhan = ((CBBItem)this.cbbHocPhan.SelectedItem).Value,
                GioiTinh = this.radioMale.Checked,
                DiemBaiTap = Convert.ToDouble(this.txtDiemBT.Text),
                DiemGiuaKi = Convert.ToDouble(this.txtDiemBT.Text),
            }
        }
    }
}
