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
    public partial class uctSearchNhanVien : UserControl
    {
        public uctSearchNhanVien()
        {
            InitializeComponent();
        }
        void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("Id Nhân viên");
            cmbFind.Items.Add("Tên Nhân viên");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                if (cmbFind.Text == "Id Nhân viên")
                {
                    string idNhanVien = txtFind.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSetSearchNhanVienByIdNhanVien(idNhanVien).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDanhSachNhanVien.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Id '" + txtFind.Text + "' không có trong dữ liệu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string tenNhanVien = txtFind.Text;
                    DataTable dt = new DataTable();
                    dt = Controllers.NhanVienCtrl.FillDataSetSearchNhanVienByTenNhanVien(tenNhanVien).Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dgvDanhSachNhanVien.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Tên '" + txtFind.Text + "' không có trong dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void uctSearchNhanVien_Load(object sender, EventArgs e)
        {
            cmbFind.Text = "Id Nhân viên"; // hiển thị lên id Nhân viên khi load form
            loadcontrol();
        }
        // tìm kiếm theo kiểu google
        private void btnFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (cmbFind.Text == "Id Nhân viên")
            {
                string idNhanVien = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSetSearchNhanVienByIdNhanVien(idNhanVien).Tables[0];
                dgvDanhSachNhanVien.DataSource = dt;
            }
            else
            {
                string tenNhanVien = txtFind.Text.ToString();
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSetSearchNhanVienByTenNhanVien(tenNhanVien).Tables[0];
            }
        }
    }
}
