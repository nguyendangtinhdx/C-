using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang.Models
{
    class KhuVucMod
    {
        protected string IDKhuVuc { get; set; }
        protected string TenKhuVuc { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }

        // Hàm khởi tạo (Hàm constructor)
        public KhuVucMod(string IdKhuVuc)
        {
            IDKhuVuc = IdKhuVuc;
        }
        public KhuVucMod() { } // hàm này không có đối số
        public KhuVucMod(string idKhuVuc, string tenKhuVuc, string dienGiai, string trangThai)
        {
            IDKhuVuc = idKhuVuc;
            TenKhuVuc = tenKhuVuc;
            DienGiai = dienGiai;
            TrangThai = trangThai;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertKhuVuc()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDKhuVuc, TenKhuVuc, DienGiai, TrangThai};
            i = Models.connection.Excute_Sql("spInsertKhuVuc", CommandType.StoredProcedure,paras,values);
            return i;
        }
        // Hàm update 
        public int UpdateKhuVuc()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDKhuVuc, TenKhuVuc, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteKhuVuc()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdKhuVuc"};
            object[] values = new object[1] { IDKhuVuc};
            i = Models.connection.Excute_Sql("spDeleteKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetKhuVuc()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetKhuVuc", CommandType.StoredProcedure);
        }
        // lấy dữ liệu ra để đổ vào cmbTenKhuVuc
        public static DataSet getTenKhuVuc()
        {
            // return tên khu vực
            return Models.connection.FillDataSet("spgetTenKhuVuc", CommandType.StoredProcedure);
        }
         
     
        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetKhuVucByIdKhuVuc()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhuVuc" };
            object[]values = new object[1]{IDKhuVuc};
            ds = Models.connection.FillDataSet("spgetKhuVucByIdKhuVuc", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
