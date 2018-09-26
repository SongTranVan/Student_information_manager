using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using XLS = Microsoft.Office.Interop.Excel.Application;

namespace ProjectTeam_v1._0
{
    public class Manager_DAL
    {
        public Manager db;
        public Manager_DAL()
        {
            db = new Manager();
        }

        public bool Check_MSV_DAL(string MaSv)
        {
            var s = db.SinhViens.Where(p => p.MaSinhVien == MaSv).Select(p => p);
            if (s.Any())
            {
                return false;
            }
            else return true;
        }

        public void ReadExcel_SinhVien_DAL(string path)
        {
            string filename = path;
            Excel.Application application = new Excel.Application();
            application.Workbooks.Open(filename);
            foreach (Excel.Worksheet worksheet in application.Worksheets)
            {
                int i = 5;
                while (worksheet.Range["B" + i].Value.ToString() != null)
                {
                    string tmpMsv = worksheet.Range["B" + i].Value.ToString();
                    if (Check_MSV_DAL(tmpMsv) == false)
                    {

                        SinhVien sv = new SinhVien();
                        sv.MaSinhVien = worksheet.Range["B" + i].Value.ToString();
                        sv.TenSinhVien = worksheet.Range["D" + i].Value.ToString();
                        sv.NgaySinh = Convert.ToDateTime(worksheet.Range["E" + i].Value.ToString());
                        if (int.Parse(worksheet.Range["F" + i].Value.ToString()) == 1) sv.GioiTinh = true;
                        if (int.Parse(worksheet.Range["F" + i].Value.ToString()) == 0) sv.GioiTinh = false;
                        sv.DanToc = worksheet.Range["G" + i].Value.ToString();
                        sv.TonGiao = worksheet.Range["H" + i].Value.ToString();
                        sv.SoCMND = worksheet.Range["I" + i].Value.ToString();
                        sv.SoDienThoai = worksheet.Range["J" + i].Value.ToString();
                        sv.QueQuan = worksheet.Range["K" + i].Value.ToString();
                        sv.DiaChiTamTru = worksheet.Range["L" + i].Value.ToString();
                        sv.NienKhoa = int.Parse(worksheet.Range["M" + i].Value.ToString());
                        sv.MaLop = worksheet.Range["C" + i].Value.ToString();
                        sv.HoTenNhanThan = worksheet.Range["N" + i].Value.ToString();
                        sv.SoDienThoaiNhanThan = worksheet.Range["O" + i].Value.ToString();
                        sv.QuanHeNhanThan = worksheet.Range["P" + i].Value.ToString();
                        db.SinhViens.Add(sv);
                        db.SaveChanges();
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        public void ReadExcel_KiHoc_DAL(string path)
        {
            string filename = path;
            Excel.Application application = new Excel.Application();
            application.Workbooks.Open(filename);
            foreach (Excel.Worksheet worksheet in application.Worksheets)
            {
                int i = 2;
                while (worksheet.Range["B" + i].Value != null)
                {
                    string tmpMsv = worksheet.Range["B" + i].Value;
                    if (Check_MSV_DAL(tmpMsv) == false)
                    {

                        KiHoc kh = new KiHoc();
                        kh.MaSinhVien = worksheet.Range["B" + i].Value;
                        kh.Ki = worksheet.Range["C" + i].Value;
                        kh.DiemRenLuyen = double.Parse(worksheet.Range["D" + i].Value.ToString());
                        kh.DiemTrungBinh = double.Parse(worksheet.Range["E" + i].Value.ToString());
                        kh.CoDuocHocBong = bool.Parse(worksheet.Range["F" + i].Value.ToString());
                        db.KiHocs.Add(kh);
                        db.SaveChanges();
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
        public void XuatExcel_DAL(DataGridView g, string duongDan, string tenTap)
        {
            XLS obj = new XLS();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        public void AddKhoa_DAL(Khoa khoa)
        {
            db.Khoas.Add(khoa);
            db.SaveChanges();
        }

        public void AddLop_DAL(Lop lop)
        {
            db.Lops.Add(lop);
            db.SaveChanges();
        }

        public void Update_DAL(SinhVien s)
        {
            var sv = db.SinhViens.Where(p => p.MaSinhVien == s.MaSinhVien).Single();
            sv.TenSinhVien = s.TenSinhVien;
            sv.NienKhoa = s.NienKhoa;
            sv.MaLop = s.MaLop;
            sv.GioiTinh = s.GioiTinh;
            sv.DanToc = s.DanToc;
            sv.NgaySinh = s.NgaySinh;
            sv.QueQuan = s.QueQuan;
            sv.SoDienThoai = s.SoDienThoai;
            sv.SoCMND = s.SoDienThoai;
            sv.TonGiao = s.TonGiao;
            sv.DiaChiTamTru = s.DiaChiTamTru;
            sv.HoTenNhanThan = s.HoTenNhanThan;
            sv.QuanHeNhanThan = s.QuanHeNhanThan;
            sv.DiaChiNhanThan = s.DiaChiNhanThan;
            sv.SoDienThoaiNhanThan = s.SoDienThoaiNhanThan;
            sv.HoKhau = s.HoKhau;
            db.SaveChanges();
           
        }
    }
}
