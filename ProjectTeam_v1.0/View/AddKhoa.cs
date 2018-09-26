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
    public partial class AddKhoa : Form
    {
        public static Manager_BLL BLL;
        public AddKhoa()
        {
            InitializeComponent();
            BLL = new Manager_BLL();
        }

        private void btDongy_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa();
            k.MaKhoa = txtMakhoa.Text;
            k.TenKhoa = txtTenKhoa.Text;
            BLL.AddKhoa_BLL(k);
            MessageBox.Show("Thêm thành công!");
            txtMakhoa.ResetText();
            txtTenKhoa.ResetText();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtMakhoa.ResetText();
            txtTenKhoa.ResetText();
        }
    }
}
