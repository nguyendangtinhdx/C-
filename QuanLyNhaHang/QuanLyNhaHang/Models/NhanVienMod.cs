using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang.Models
{
    class NhanVienMod
    {
        // khai báo các biến và hàm thuộc tính
        protected String IDNhanVien { get; set; }
        protected String HoNV { get; set; }
        protected String TenNV { get; set; }
        protected String TenNVhanVien { get; set; }
        protected DateTime NgaySinhNV { get; set; }
        protected String GioiTinhNV { get; set; }
        protected String DienThoaiNV { get; set; }
        protected String EmailNV { get; set; }
        protected String DiaChiNV { get; set; }
        // Hàm khởi tạo (Hàm constructor)
        public NhanVienMod(string IdNhanVien)
        {
            IDNhanVien = IdNhanVien;
        }
        public NhanVienMod() { } // hàm này không có đối số
        public NhanVienMod(string idNhanVien, string hoNhanVien, string tenNhanVien, DateTime ngaysinhNhanVien, string gioitinhNhanVien, string emailNhanVien, string dienthoaiNhanVien, string diachiNhanVien)
        {
            IDNhanVien = idNhanVien;
            HoNV = hoNhanVien;
            TenNV = tenNhanVien;
            NgaySinhNV = ngaysinhNhanVien;
            GioiTinhNV = gioitinhNhanVien;
            DienThoaiNV = dienthoaiNhanVien;
            EmailNV = emailNhanVien;
            DiaChiNV = diachiNhanVien;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IDNhanVien, HoNV, TenNV, NgaySinhNV, GioiTinhNV, DienThoaiNV, EmailNV, DiaChiNV };
            i = Models.connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure,paras,values);
            return i;
        }
        // Hàm update 
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IDNhanVien, HoNV, TenNV, NgaySinhNV, GioiTinhNV, DienThoaiNV, EmailNV, DiaChiNV };
            i = Models.connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdNhanVien"};
            object[] values = new object[1] { IDNhanVien};
            i = Models.connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetNhanVien()
        {
            // ta gọi thủ tục getNhanVien nảy đã gọi ra
            return Models.connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[]values = new object[1]{IDNhanVien};
            ds = Models.connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // tìm kiếm theo ID
        public DataSet FillDataSetSearchNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IDNhanVien };
            ds = Models.connection.FillDataSet("spSearchNVByIdNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // tìm kiếm theo Tên
        public DataSet FillDataSetSearchNhanVienByTenNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@Ten" };
            object[] values = new object[1] { IDNhanVien };
            ds = Models.connection.FillDataSet("spSearchNVByTenNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
