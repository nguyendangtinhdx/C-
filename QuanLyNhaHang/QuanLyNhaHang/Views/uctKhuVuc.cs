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
    public partial class uctKhuVuc : UserControl
    {
        public uctKhuVuc()
        {
            InitializeComponent();
        }

        int flag = 0;
        public static uctKhuVuc uctKV = new uctKhuVuc();
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            disend(true);
        }
        // khai báo hàm hiển thiej DSKV để đổ dữ liệu vào
        public void HienThiDanhSachKhuVuc()
        {
            // trỏ tới data khuc vực
            dgvThongTinKhuVuc.DataSource = Models.KhuVucMod.FillDataSetKhuVuc().Tables[0];
            dgvThongTinKhuVuc.Dock = DockStyle.Fill;
            dgvThongTinKhuVuc.BorderStyle = BorderStyle.Fixed3D;
            dgvThongTinKhuVuc.RowHeadersVisible = false;
        }
        
        
        // hàm trỏ đến data trên datagridview
        void bingding()
        {
            txtIDKhuVuc.DataBindings.Clear();
            txtIDKhuVuc.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "IdKhuVuc");
            txtTenKhuVuc.DataBindings.Clear();
            txtTenKhuVuc.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "TenKhuVuc");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "DienGiai");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvThongTinKhuVuc.DataSource, "TrangThai");
           
        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            //txtIDKhuVuc.Enabled = e;
            txtTenKhuVuc.Enabled = e;
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
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Ngừng hoạt động");
        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            txtIDKhuVuc.Text = Models.connection.ExcuteScalar(string.Format("SELECT IdKhuVuc = dbo.FCgetIdKhuVuc()")); // id tự động tăng
            txtTenKhuVuc.Text = "";
            txtDienGiai.Text = "";
            loadcontrol();// gọi nó vào cho nó load giới tính

        }

        private void uctKhuVuc_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhuVuc();
            disend(false);
            bingding();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctKhuVuc_Load(sender, e);
            disend(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string idKhuVuc = "";
            try
            {
                idKhuVuc = txtIDKhuVuc.Text;
            }
            catch (Exception)
            {
            }
            string tenKhuVuc = "";
            try
            {
                tenKhuVuc = txtTenKhuVuc.Text;
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
                if (idKhuVuc == "" || tenKhuVuc== "" || dienGiai == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin ");
                }
                else
                {
                    int i = 0;
                    i = Controllers.KhuVucCtrl.IntsertKhuVuc(idKhuVuc, tenKhuVuc, dienGiai, trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công ");
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
                i = Controllers.KhuVucCtrl.UpdateKhuVuc(idKhuVuc,tenKhuVuc, dienGiai, trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công ");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }

            uctKhuVuc_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idKhuVuc = "";
            try
            {
                idKhuVuc = txtIDKhuVuc.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhuVucCtrl.DeleteKhuVuc(idKhuVuc);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachKhuVuc();
                    uctKhuVuc_Load(sender, e);
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
    }
}
