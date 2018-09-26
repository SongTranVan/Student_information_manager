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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btthemkhoa_Click(object sender, EventArgs e)
        {
            View.AddKhoa  FAddkhoa = new  View.AddKhoa();
            FAddkhoa.Show();
        }

        private void btThemlop_Click(object sender, EventArgs e)
        {
            View.AddLop FAddlop = new View.AddLop();
            FAddlop.Show();
        }

        private void btEditThongTin_Click(object sender, EventArgs e)
        {
            View.SuaThongTinSinhVien suaThongTinSinhVien = new View.SuaThongTinSinhVien();
            suaThongTinSinhVien.Show();
        }

        private void btDocfileexcel_Click(object sender, EventArgs e)
        {
            View.NhapFileExcel nhapFileExcel = new View.NhapFileExcel();
            nhapFileExcel.Show();
        }
    }
}
