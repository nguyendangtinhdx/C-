using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLySinhVien
{
    public class Bussines
    {
        ConnectData CON;
        #region Đăng nhập
        public Boolean kiemtradangnhap(string user,string pass)
        {
            CON = new ConnectData();
            DataTable dt = CON.getdata("select * from Users where username = '"+user+"' and password = '"+pass+"' "); // lấy dữ liệu
            Boolean check = false;
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        #region Sinh Viên
        public DataTable getalldatasinhvien()
        {
            CON = new ConnectData();
            DataTable dt = null;
            dt = CON.getdata("SELECT * FROM View_SinhVien");
            return dt;
        }

        #endregion
    }
}
