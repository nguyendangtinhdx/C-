using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Controllers
{
    class GoiMonCtrl
    {
        public static DataSet FillDataSetgetGoiMonByIdBan(string idBan)
        {
            try
            {
                Models.GoiMonMod ban = new Models.GoiMonMod(idBan);
                return ban.FillDataSetgetGoiMonByIdBan();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Thêm
        public static int IntsertGoiMon(string idBan, string tenThucDon, decimal donGiaTon, int soLuong, DateTime thoiGian, decimal thanhTien)
        {
            try
            {
                Models.GoiMonMod goimon = new Models.GoiMonMod(idBan, tenThucDon, donGiaTon, soLuong, thoiGian,thanhTien);
                return goimon.InsertGoiMon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateGoiMon(string idBan, string tenThucDon, decimal donGiaTon, int soLuong, DateTime thoiGian, decimal thanhTien)
        {
            try
            {
                Models.GoiMonMod goimon = new Models.GoiMonMod(idBan, tenThucDon, donGiaTon, soLuong, thoiGian, thanhTien);
                return goimon.UpdateGoiMon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteGoiMon(string idBan)
        {
            try
            {
                Models.GoiMonMod goimon = new Models.GoiMonMod(idBan);
                return goimon.DeleteGoiMon();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
