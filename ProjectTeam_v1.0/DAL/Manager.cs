namespace ProjectTeam_v1._0
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Manager : DbContext
    {
        // Your context has been configured to use a 'Manager' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProjectTeam_v1._0.DAL.Manager' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Manager' 
        // connection string in the application configuration file.
        public Manager()
            : base("name=Manager")
        {
            Database.SetInitializer<Manager>(new DataInitializer());
        }
        public class DataInitializer: CreateDatabaseIfNotExists<Manager>
        {
            protected override void Seed(Manager context)
            {
                context.Khoas.Add(new Khoa { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin" });
                context.Lops.Add(new Lop { MaLop = "CNTT_L01", TenLop = "Lop 1", MaKhoa = "CNTT", TenGiaoVien = "Bui Thanh Son" });
                context.SinhViens.Add(new SinhVien { MaSinhVien = "111", MaLop = "CNTT_L01", TenSinhVien = "Tống Văn Đạt", GioiTinh = true, DanToc = "Kinh", TonGiao = "Không", SoCMND = "201744285", SoDienThoai = "013123124", QueQuan = "Đà Nẵng", DiaChiTamTru = "Trần Cao Vân", NgaySinh = new DateTime(1997, 09, 03), NienKhoa = 2015, HoTenNhanThan = "Nguyen Van A", QuanHeNhanThan = "Bố", DiaChiNhanThan = "Trần Cao Vân", SoDienThoaiNhanThan = "0906857885"});
                context.KiHocs.Add(new KiHoc { Ki = "1", MaSinhVien = "111", DiemRenLuyen = 90, DiemTrungBinh = 9.2, CoDuocHocBong = true });
                context.SaveChanges();
            }
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<KiHoc> KiHocs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}