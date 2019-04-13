using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Models
{
    class GoiMonMod
    {
        protected string IDBan { get; set; }
        protected string TenThucDon{ get; set; }
        protected decimal DonGiaTon { get; set; }
        protected int SoLuong { get; set; }
        protected DateTime ThoiGian{ get; set; }
        protected decimal ThanhTien{ get; set; }

        // Hàm khởi tạo (Hàm constructor)
        public GoiMonMod(string IdBan)
        {
            IDBan = IdBan;
        }
        public GoiMonMod() { } // hàm này không có đối số
        public GoiMonMod(string idBan, string tenThucDon,decimal donGiaTon,int soLuong, DateTime thoiGian, decimal thanhTien)
        {
            IDBan = idBan;
            TenThucDon= tenThucDon;
            DonGiaTon = donGiaTon;
            SoLuong = soLuong;
            ThoiGian = thoiGian;
            ThanhTien = thanhTien;
        }
        // khai báo hàm thêm sửa xóa
        public int InsertGoiMon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon","@DonGiaTon", "@SoLuong", "@ThoiGian","@ThanhTien" };
            object[] values = new object[6] { IDBan, TenThucDon,DonGiaTon, SoLuong, ThoiGian,ThanhTien};
            i = Models.connection.Excute_Sql("spInsertGoiMon", CommandType.StoredProcedure,paras,values);
            return i;
        }
        // Hàm update 
        public int UpdateGoiMon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon","@DonGiaTon", "@SoLuong", "@ThoiGian","@ThanhTien" };
            object[] values = new object[6] { IDBan, TenThucDon,DonGiaTon, SoLuong, ThoiGian,ThanhTien};
            i = Models.connection.Excute_Sql("spInsertGoiMon", CommandType.StoredProcedure,paras,values);
            return i;
        }
        // delete - chỉ truyền vào 1 thông số
        public int DeleteGoiMon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdBan"};
            object[] values = new object[1] { IDBan};
            i = Models.connection.Excute_Sql("spDeleteGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // khởi tạo hàm dataset để load "nhân viên"
        public static DataSet FillDataSetGoiMon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBanGoiMon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBanChuaGoiMon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        }
    

        // get nhan vien by IDNhanVien
        public DataSet FillDataSetgetGoiMonByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[]values = new object[1]{IDBan};
            ds = Models.connection.FillDataSet("spgetGoiMonByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }

        public static DataSet FillDataSetSumThanhTien()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetSumThanhTien", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetgetTenThucDon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetTenThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetgetIdBan()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetgetMonDaGoi()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetXemGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetgetDonGiaThucDon()
        {
            // ta gọi thủ tục getKhuVuc nảy đã gọi ra
            return Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }

    }
}
