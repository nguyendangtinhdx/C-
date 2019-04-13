using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Controllers
{
    class BanCtrl
    {
        public static DataSet FillDataSetgetBanByIdBan(string idBan)
        {
            try
            {
                Models.BanMod ban= new Models.BanMod(idBan);
                return ban.FillDataSetgetBanByIdBan();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Thêm
        public static int IntsertBan(string idBan, string tenKhuVuc, string tenBan,string dienGiai, string trangThai)
        {
            try
            {
                Models.BanMod ban = new Models.BanMod(idBan, tenKhuVuc,tenBan, dienGiai, trangThai);
                return ban.InsertBan();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateBan(string idBan, string tenKhuVuc, string tenBan, string dienGiai, string trangThai)
        {
            try
            {
                Models.BanMod ban = new Models.BanMod(idBan, tenKhuVuc, tenBan, dienGiai, trangThai);
                return ban.UpdateBan();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteBan(string idBan)
        {
            try
            {
                Models.BanMod ban = new Models.BanMod(idBan);
                return ban.DeleteBan();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
