using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhaHang.Controllers
{
    class LoaiThucDonCtrl
    {
        public static DataSet FillDataSetgetBanByIdLoaiThucDon(string idLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonMod loaithucdon = new Models.LoaiThucDonMod(idLoaiThucDon);
                return loaithucdon.FillDataSetgetBanByIdLoaiThucDon();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Thêm
        public static int IntsertLoaiThucDon(string idLoaiThucDon, string tenLoaiThucDon, string dienGiai, string trangThai)
        {
            try
            {
                Models.LoaiThucDonMod loaithucdon = new Models.LoaiThucDonMod(idLoaiThucDon, tenLoaiThucDon, dienGiai, trangThai);
                return loaithucdon.InsertLoaiThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateLoaiThucDon(string idLoaiThucDon, string tenLoaiThucDon, string dienGiai, string trangThai)
        {
            try
            {
                Models.LoaiThucDonMod loaithucdon = new Models.LoaiThucDonMod(idLoaiThucDon, tenLoaiThucDon, dienGiai, trangThai);
                return loaithucdon.UpdateLoaiThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteLoaiThucDon(string idLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonMod loaithucdon = new Models.LoaiThucDonMod(idLoaiThucDon);
                return loaithucdon.DeleteLoaiThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
