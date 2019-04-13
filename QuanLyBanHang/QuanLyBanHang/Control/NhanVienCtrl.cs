using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Object;
using QuanLyBanHang.Model;
namespace QuanLyBanHang.Control
{
    class NhanVienCtrl
    {
        NhanVienMod nvMod = new NhanVienMod();
        public DataTable getData()
        {
            return nvMod.GetData();
        }
        public bool upData(NhanVienObj nvObj)
        {
            return nvMod.AddData(nvObj);
        }
        public bool upData(NhanVienObj nvObj)
        {
            return nvMod.UpData(nvObj);
        }
        public bool deData(string ma)
        {
            return nvMod.DelData(ma);
        }
    }
}

