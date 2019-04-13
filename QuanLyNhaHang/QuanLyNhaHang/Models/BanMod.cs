using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang.Models
{
    class BanMod
    {
        protected string IDBan { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string TenBan { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }

        // Hàm khởi tạo (Hàm constructor)
        public BanMod(string IdBan)
        {
            IDBan = IdBan;
        }
        public BanMod() { } // hàm này không có đối số
        public BanMod(string idBan, string tenKhuVuc,string tenBan, string dienGiai, string trangThai)
        {
            IDBan = idBan;
            TenKhuVuc = tenKhuVuc;
            TenBan = tenBan;
            DienGiai = dienGiai;
            TrangThai = trangThai;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertBan()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdBan", "@TenKhuVuc","@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IDBan, TenKhuVuc,TenBan, DienGiai, TrangThai};
            i = Models.connection.Excute_Sql("spInsertBan", CommandType.StoredProcedure,paras,values);
            return i;
        }
        // Hàm update 
        public int UpdateBan()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IDBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteBan()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdBan"};
            object[] values = new object[1] { IDBan};
            i = Models.connection.Excute_Sql("spDeleteBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetBan()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBanGoiMon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetViewDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetTenBan()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetTenBan", CommandType.StoredProcedure);
        }

        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetBanByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[]values = new object[1]{IDBan};
            ds = Models.connection.FillDataSet("spgetBanByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
