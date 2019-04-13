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
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }
        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiThucDon();
            disend(false);
            bingding();
        }
        int flag = 0;
        public static uctLoaiThucDon uctLTD = new uctLoaiThucDon();


        // khai báo hàm hiển thiej DSKV để đổ dữ liệu vào
        public void HienThiDanhSachLoaiThucDon()
        {
            // trỏ tới data khuc vực
            dgvLoaiThucDon.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            dgvLoaiThucDon.BorderStyle = BorderStyle.Fixed3D;
            dgvLoaiThucDon.RowHeadersVisible = false;
        }


        // hàm trỏ đến data trên datagridview
        void bingding()
        {
            txtIDLoaiThucDon.DataBindings.Clear();
            txtIDLoaiThucDon.DataBindings.Add("Text", dgvLoaiThucDon.DataSource, "IdLoaiThucDon");
            txtTenLoaiThucDon.DataBindings.Clear();
            txtTenLoaiThucDon.DataBindings.Add("Text", dgvLoaiThucDon.DataSource, "TenLoaiThucDon");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvLoaiThucDon.DataSource, "DienGiai");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvLoaiThucDon.DataSource, "TrangThai");

        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            txtIDLoaiThucDon.Enabled = e;
            txtTenLoaiThucDon.Enabled = e;
            txtDienGiai.Enabled = e;
            cmbTrangThai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        // hàm load giới tính nhân viên
        void loadcontrol()
        {
            // load tên khu vực và trạng thái
            // tạo 1 hàm để trả về tên khu vực, dùng proc đã tạo trong sql
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Ngừng hoạt động");
        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            txtIDLoaiThucDon.Text = Models.connection.ExcuteScalar(string.Format("SELECT IdLoaiThucDon = dbo.FCgetIdLoaiThucDon()")); // id tự động tăng
            loadcontrol();// gọi nó vào cho nó load giới tính
            txtTenLoaiThucDon.Text = "";
            txtDienGiai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            disend(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            disend(true);// lúc này các nút thêm, sửa, xóa sẽ ẩn, chỉ còn nút lưu và hủy
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idLoaiThucDon = "";
            try
            {
                idLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.DeleteLoaiThucDon(idLoaiThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachLoaiThucDon();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại ");
                }
            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             string idLoaiThucDon= "";
            try
            {
                idLoaiThucDon = txtIDLoaiThucDon.Text;
            }
            catch (Exception)
            {
            }
            string tenLoaiThucDon = "";
            try
            {
                tenLoaiThucDon = txtTenLoaiThucDon.Text;
            }
            catch (Exception)
            {
            }
            string dienGiai = "";
            try
            {
                dienGiai = txtDienGiai.Text;
            }
            catch (Exception)
            {
            }
            string trangThai = "";
            try
            {
                trangThai = cmbTrangThai.Text;
            }
            catch (Exception)
            {
            }
            if (flag == 0)
            {
                // thêm mới 
                if (tenLoaiThucDon== "")
                {
                    MessageBox.Show("Hãy nhập tên loại thực đơn");
                }
                else
                {
                    int i = 0;
                    i = Controllers.LoaiThucDonCtrl.IntsertLoaiThucDon(idLoaiThucDon, tenLoaiThucDon, dienGiai, trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công ");
                        HienThiDanhSachLoaiThucDon();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại ");
                    }
                }
            }
            else
            {
                //sửa
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.UpdateLoaiThucDon(idLoaiThucDon,tenLoaiThucDon, dienGiai, trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công ");
                    HienThiDanhSachLoaiThucDon();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }

            uctLoaiThucDon_Load(sender, e);
        
        }

        private void uctLoaiThucDon_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiThucDon();
            disend(false);
            bingding();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctLoaiThucDon_Load(sender, e);
            disend(false);
        }

    }
}
