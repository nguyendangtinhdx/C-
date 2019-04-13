using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Models
{
    class LoaiThucDonMod
    {
        protected string IDLoaiThucDon{ get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }

        // Hàm khởi tạo (Hàm constructor)
        public LoaiThucDonMod(string IdLoaiThucDon)
        {
            IDLoaiThucDon= IdLoaiThucDon;
        }
        public LoaiThucDonMod() { } // hàm này không có đối số
        public LoaiThucDonMod(string idLoaiThucDon, string tenLoaiThucDon, string dienGiai, string trangThai)
        {
            IDLoaiThucDon= idLoaiThucDon;
            TenLoaiThucDon= tenLoaiThucDon;
            DienGiai = dienGiai;
            TrangThai = trangThai;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spInsertLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Hàm update 
        public int UpdateLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IDLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IDLoaiThucDon };
            i = Models.connection.Excute_Sql("spDeleteLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetLoaiThucDon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetLoaiThucDon", CommandType.StoredProcedure);
        }
        public static DataSet getTenLoaiThucDon()
        {
            // return tên khu vực
            return Models.connection.FillDataSet("spgetTenLoaiThucDon", CommandType.StoredProcedure);
        }
        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetBanByIdLoaiThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IDLoaiThucDon };
            ds = Models.connection.FillDataSet("spgetBanByIdLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
