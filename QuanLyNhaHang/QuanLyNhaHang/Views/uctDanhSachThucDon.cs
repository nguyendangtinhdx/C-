using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang.Views
{
    public partial class uctDanhSachThucDon : UserControl
    {
        public uctDanhSachThucDon()
        {
            InitializeComponent();
        }

        int flag = 0;
        public static uctThucDon uctTD = new uctThucDon();


        // khai báo hàm hiển thiej DSKV để đổ dữ liệu vào
        public void HienThiDanhSachThucDon()
        {
            // trỏ tới data khuc vực
            dgvThucDon.DataSource = Models.ThucDonMod.FillDataSetThucDon().Tables[0];
            dgvThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvThucDon.RowHeadersVisible = false;
        }


        // hàm trỏ đến data trên datagridview


        // hàm dis and các buttun khi load lên

        // hàm load giới tính nhân viên


        // hàm xóa dữ liệu ở text box lúc nhấn vào button
 

        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uctDanhSachThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThucDon();
        }
    }
}
