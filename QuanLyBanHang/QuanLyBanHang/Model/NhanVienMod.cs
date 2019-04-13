using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanHang.Object;

namespace QuanLyBanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT * FROM NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "INSERT INTO NhanVien VALUES('" + nvObj.MaNhanVien + "','" + nvObj.TenNhanVien + "', '" + nvObj.GioiTinh+ "', CONVERT(DATE,'" + nvObj.NamSinh.ToShortDateString() + "',103), '" + nvObj.DiaChi + "', '" + nvObj.Sdt + "', '" + nvObj.MatKhau + "' )";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdateData(NhanVienObj nvObj)
        {
            cmd.CommandText = "UPDATE NhanVien SET TenNV = '" + nvObj.TenNhanVien + "', SET GioiTinh ='" + nvObj.GioiTinh + "', NamSinh = CONVERT(DATE,'" + nvObj.NamSinh.ToShortDateString() + "',103), DiaChi = '" + nvObj.DiaChi + "', Sdt = '" + nvObj.Sdt + "', MatKhau = '" + nvObj.MatKhau + "' WHERE MaNV = '"+nvObj.MaNhanVien+"' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DeleteData(String ma)
        {
            cmd.CommandText = "DELETE NhanVien WHERE MaNV = '" + ma + "'  ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        internal bool UpData(NhanVienObj nvObj)
        {
            throw new NotImplementedException();
        }

        internal object DelData(string ma)
        {
            throw new NotImplementedException();
        }
    }
}
