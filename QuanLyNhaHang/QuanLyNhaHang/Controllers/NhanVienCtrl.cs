using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyNhaHang.Controllers
{
    class NhanVienCtrl
    {
        public static DataSet FillDataSetgetNhanVienByIdNhanVien(string idNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(idNhanVien);
                return nvien.FillDataSetgetNhanVienByIdNhanVien();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataSet FillDataSetSearchNhanVienByIdNhanVien(string idNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(idNhanVien);
                return nvien.FillDataSetSearchNhanVienByIdNhanVien();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataSet FillDataSetSearchNhanVienByTenNhanVien(string tenNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(tenNhanVien);
                return nvien.FillDataSetSearchNhanVienByTenNhanVien();
            }
            catch (Exception)
            {
                return null;
            }
        }
        // Thêm
        public static int IntsertNhanVien(string idNhanVien, string hoNhanVien, string tenNhanVien, DateTime ngaysinhNhanVien, string gioitinhNhanVien, string emailNhanVien, string dienthoaiNhanVien, string diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod nhanVien = new Models.NhanVienMod(idNhanVien, hoNhanVien, tenNhanVien, ngaysinhNhanVien, gioitinhNhanVien, dienthoaiNhanVien, emailNhanVien, diachiNhanVien);
                return nhanVien.InsertNhanVien();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateNhanVien(string idNhanVien, string hoNhanVien, string tenNhanVien, DateTime ngaysinhNhanVien, string gioitinhNhanVien, string emailNhanVien, string dienthoaiNhanVien, string diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod nhanVien = new Models.NhanVienMod(idNhanVien, hoNhanVien, tenNhanVien, ngaysinhNhanVien, gioitinhNhanVien, dienthoaiNhanVien, emailNhanVien, diachiNhanVien);
                return nhanVien.UpdateNhanVien();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteNhanVien(string idNhanVien)
        {
            try
            {
                Models.NhanVienMod nhanVien = new Models.NhanVienMod(idNhanVien);
                return nhanVien.DeleteNhanVien();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
