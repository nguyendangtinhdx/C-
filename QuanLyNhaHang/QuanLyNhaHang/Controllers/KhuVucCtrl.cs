using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Controllers
{
    class KhuVucCtrl
    {
        public static DataSet FillDataSetgetKhuVucByIdKhuVuc(string idKhuVuc)
        {
            try
            {
                Models.KhuVucMod kvuc = new Models.KhuVucMod(idKhuVuc);
                return kvuc.FillDataSetgetKhuVucByIdKhuVuc();
            }
            catch (Exception)
            {
                return null;
            }
        }
     
        // Thêm
        public static int IntsertKhuVuc(string idKhuVuc, string tenKhuVuc, string dienGiai, string trangThai)
        {
            try
            {
                Models.KhuVucMod khuVuc = new Models.KhuVucMod(idKhuVuc,tenKhuVuc,dienGiai,trangThai);
                return khuVuc.InsertKhuVuc();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateKhuVuc(string idKhuVuc, string tenKhuVuc, string dienGiai, string trangThai)
        {
            try
            {
                Models.KhuVucMod khuVuc= new Models.KhuVucMod(idKhuVuc,tenKhuVuc,dienGiai,trangThai);
                return khuVuc.UpdateKhuVuc();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteKhuVuc(string idKhuVuc)
        {
            try
            {
                Models.KhuVucMod khuVuc= new Models.KhuVucMod(idKhuVuc);
                return khuVuc.DeleteKhuVuc();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
