using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyNhaHang.Controllers
{
    class ThucDonCtrl
    {
        public static DataSet FillDataSetgetBanByIdThucDon(string idThucDon)
        {
            try
            {
                Models.ThucDonMod thucdon = new Models.ThucDonMod(idThucDon);
                return thucdon.FillDataSetgetBanByIdThucDon();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Thêm
        public static int IntsertThucDon(string idThucDon, string tenLoaiThucDon,string tenThucDon,string donViTinh,float soLuongTon, float donGiaTon,float tonToiThieu, string trangThai)
        {
            try
            {
                Models.ThucDonMod thucdon = new Models.ThucDonMod(idThucDon, tenLoaiThucDon, tenThucDon,donViTinh,soLuongTon,donGiaTon, tonToiThieu, trangThai);
                return thucdon.InsertThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // cập nhật
        public static int UpdateThucDon(string idThucDon, string tenLoaiThucDon, string tenThucDon, string donViTinh, float soLuongTon, float donGiaTon, float tonToiThieu, string trangThai)
        {
            try
            {
                Models.ThucDonMod thucdon = new Models.ThucDonMod(idThucDon, tenLoaiThucDon, tenThucDon, donViTinh, soLuongTon, donGiaTon, tonToiThieu, trangThai);
                return thucdon.UpdateThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Xóa
        public static int DeleteThucDon(string idThucDon)
        {
            try
            {
                Models.ThucDonMod thucdon = new Models.ThucDonMod(idThucDon);
                return thucdon.DeleteThucDon();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
