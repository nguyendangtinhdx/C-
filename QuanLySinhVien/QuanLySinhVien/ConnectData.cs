using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public class ConnectData
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FK24324\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        // hàm mở kết nối
        private void connopen()
        {
            if (conn.State == ConnectionState.Closed) // nếu connect đóng
            {
                conn.Open();
            }
        }
        private void connclose()
        {
            if (conn.State == ConnectionState.Open) // nếu connect mở
            {
                conn.Close();
            }
        }

        // lấy dữ liệu
        public DataTable getdata(string cmd)
        {
            try
            {
                connopen();
                SqlCommand cmds = new SqlCommand(cmd, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                connclose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        // hàm thực thi dữ liệu
        public Boolean excutedata(string cmd)
        {
            try
            {
                connopen();
                SqlCommand cmds = new SqlCommand(cmd, conn);
                cmds.ExecuteNonQuery();
                connclose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

    }
}
