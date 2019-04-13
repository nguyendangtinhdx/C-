using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyBanHang.Model
{
    class ConnectToSQL
    {
        private SqlConnection Conn;
        private SqlCommand _cmd;
        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        public SqlConnection Connection { get { return Conn; } }
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        string StrCon;

        public ConnectToSQL()
        {
            StrCon = @"Data Source=DESKTOP-FK24324\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            Conn = new SqlConnection(StrCon);
        }
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
