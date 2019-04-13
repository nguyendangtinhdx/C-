using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang.Models
{
    class ThucDonMod
    {
        protected string IDThucDon{ get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DonViTinh { get; set; }
        protected float SoLuongTon { get; set; }
        protected float DonGiaTon { get; set; }
        protected float TonToiThieu { get; set; }
        protected string TrangThai { get; set; }

        // Hàm khởi tạo (Hàm constructor)
        public ThucDonMod(string IdThucDon)
        {
            IDThucDon= IdThucDon;
        }
        public ThucDonMod() { } // hàm này không có đối số
        public ThucDonMod(string idThucDon, string tenLoaiThucDon, string tenThucDon, string donViTinh, float soLuongTon, float donGiaTon, float tonToiThieu, string trangThai)
        {
            IDThucDon= idThucDon;
            TenLoaiThucDon= tenLoaiThucDon;
            TenThucDon = tenThucDon;
            DonViTinh = donViTinh;
            SoLuongTon = soLuongTon;
            DonGiaTon = donGiaTon;
            TonToiThieu = tonToiThieu;
            TrangThai = trangThai;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertThucDon()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IDThucDon, TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu, TrangThai };
            i = Models.connection.Excute_Sql("spInsertThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Hàm update 
        public int UpdateThucDon()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IDThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IDThucDon };
            i = Models.connection.Excute_Sql("spDeleteThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetThucDon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetBanByIdThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IDThucDon };
            ds = Models.connection.FillDataSet("spgetBanByIdThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
