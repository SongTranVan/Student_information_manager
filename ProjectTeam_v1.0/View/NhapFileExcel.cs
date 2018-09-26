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
    public partial class NhapFileExcel : Form
    {
        Manager_BLL BLL;
        public NhapFileExcel()
        {
            InitializeComponent();
            BLL = new Manager_BLL();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDuongdan1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.FilterIndex = 1;//tro vao vi tri dau tien cua bo loc
            fileDialog.RestoreDirectory = true;//nho duong dan truy cap dc
            fileDialog.Multiselect = false;//khong cho phep chon nhieu file cung luc
            fileDialog.Title = "Chon file Excel";//tieu de cua hop thoai
            //neu chon file thanh cong
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtduongdan1.Text = fileDialog.FileName;
            }
        }

        private void btImport1_Click(object sender, EventArgs e)
        {
            string path = txtduongdan1.Text;
            if (path == null)
            {
                MessageBox.Show("Chưa chọn file Excel");
            }
            else
            {
                BLL.ReadExcel_SinhVien_BLL(path);
                MessageBox.Show("Thêm thành công");
                txtduongdan1.ResetText();
            }
        }

        private void btDuongdan2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.Filter = "Excel File|*.xls;*.xlsx";//chi lay file dinh dang xls hoac xlsx
            fileDialog.FilterIndex = 1;//tro vao vi tri dau tien cua bo loc
            fileDialog.RestoreDirectory = true;//nho duong dan truy cap dc
            fileDialog.Multiselect = false;//khong cho phep chon nhieu file cung luc
            fileDialog.Title = "Chon file Excel";//tieu de cua hop thoai
            //neu chon file thanh cong
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtduongdan2.Text = fileDialog.FileName;
            }
        }

        private void btImport2_Click(object sender, EventArgs e)
        {
            string path = txtduongdan1.Text;
            if (path == null)
            {
                MessageBox.Show("Chưa chọn file Excel");
            }
            else
            {
                BLL.ReadExcel_KiHoc_BLL(path);
                MessageBox.Show("Thêm thành công");
                txtduongdan2.ResetText();
            }
        }
    }
}
