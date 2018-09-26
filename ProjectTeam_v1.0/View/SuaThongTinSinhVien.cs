using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam_v1._0.View
{
    public partial class SuaThongTinSinhVien : Form
    {
        public static Manager_BLL BLL;
        public SuaThongTinSinhVien()
        {
            InitializeComponent();
            BLL = new Manager_BLL();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSinhVien = txtMaSinhVien.Text;
            sv.NienKhoa = int.Parse(cBMaSinhVien.Text);
            sv.TenSinhVien = txtTenSinhVien.Text;
            sv.MaLop = cBLop.Text;
            if (rBNam.Checked == true) sv.GioiTinh = true;
            if (rBNu.Checked == true) sv.GioiTinh = false;
            sv.DanToc = cBDanToc.Text;
            sv.NgaySinh = Convert.ToDateTime(dTNgaySinh.Text);
            sv.QueQuan = cBQueQuan.Text;
            sv.SoDienThoai = txtDienThoai.Text;
            sv.SoCMND = txtCMND.Text;
            sv.TonGiao = cBTonGiao.Text;
            sv.DiaChiTamTru = txtTamTru.Text;
            sv.HoTenNhanThan = txtTenNhanThan.Text;
            sv.QuanHeNhanThan = txtQuanHe.Text;
            sv.DiaChiNhanThan = txtDiaChiNhanThan.Text;
            sv.SoDienThoaiNhanThan = txtDienThoaiNhanThan.Text;
            sv.HoKhau = txtHoKhau.Text;
            BLL.Update_BLL(sv);

        }
    }
}
