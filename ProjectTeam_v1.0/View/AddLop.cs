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
    public partial class AddLop : Form
    {
        public static Manager_BLL BLL;
        public AddLop()
        {
            InitializeComponent();
            BLL = new Manager_BLL();
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.MaLop = txtMalop.Text;
            lop.MaKhoa = cBMakhoa.Text;
            lop.TenLop = txtTenlop.Text;
            lop.TenGiaoVien = txtTengiaovien.Text;
            BLL.AddLop_BLL(lop);
            MessageBox.Show("Thêm thành công!");
            txtMalop.ResetText();
            txtTenlop.ResetText();
            txtTengiaovien.ResetText();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMalop.ResetText();
            txtTenlop.ResetText();
            txtTengiaovien.ResetText();
        }
    }
}
