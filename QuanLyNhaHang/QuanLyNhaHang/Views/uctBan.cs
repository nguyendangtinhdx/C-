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
    public partial class uctBan : UserControl
    {
        public uctBan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void uctBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBan();
            disend(false);
            bingding();
        }
        int flag = 0;
        public static uctBan uctB = new uctBan();


        // khai báo hàm hiển thiej DSKV để đổ dữ liệu vào
        public void HienThiDanhSachBan()
        {
            // trỏ tới data khuc vực
            dgvDanhSachBan.DataSource = Models.BanMod.FillDataSetBan().Tables[0];
            dgvDanhSachBan.BorderStyle = BorderStyle.Fixed3D;
            dgvDanhSachBan.RowHeadersVisible = false;
        }


        // hàm trỏ đến data trên datagridview
        void bingding()
        {
            txtIDBan.DataBindings.Clear();
            txtIDBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "IdBan");
            cmbTenKhuVuc.DataBindings.Clear();
            cmbTenKhuVuc.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TenKhuVuc");
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TenBan");
            txtDienGiai.DataBindings.Clear();
            txtDienGiai.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "DienGiai");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TrangThai");

        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            txtIDBan.Enabled = e;
            cmbTenKhuVuc.Enabled = e;
            txtTenBan.Enabled = e;
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
            // gọi lại hàm thông qua KhuVucMod 
            cmbTenKhuVuc.DataSource = Models.KhuVucMod.getTenKhuVuc().Tables[0];
            // dùng biến TenKhuVuc để hiển thị (lấy giá trị TenKhuVuc)
            cmbTenKhuVuc.DisplayMember = "TenKhuVuc";

        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            txtIDBan.Text = Models.connection.ExcuteScalar(string.Format("SELECT IdBan = dbo.FCgetIdBan()")); // id tự động tăng
            loadcontrol();// gọi nó vào cho nó load giới tính
            txtTenBan.Text = "";
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctBan_Load(sender, e);
            disend(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idBan= "";
            try
            {
                idBan = txtIDBan.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BanCtrl.DeleteBan(idBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachBan();
                    uctBan_Load(sender, e);
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
             // khai báo các biến
            string idBan= "";
            try
            {
                idBan = txtIDBan.Text;
            }
            catch (Exception)
            {
            }
            string tenKhuVuc = "";
            try
            {
                tenKhuVuc = cmbTenKhuVuc.Text;
            }
            catch (Exception)
            {
            }
            string tenBan= "";
            try
            {
                tenBan = txtTenBan.Text;
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
                if (tenBan== "")
                {
                    MessageBox.Show("Hãy nhập tên bàn");
                }
                else
                {
                    int i = 0;
                    i = Controllers.BanCtrl.IntsertBan(idBan, tenKhuVuc,tenBan, dienGiai, trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công ");
                        HienThiDanhSachBan();
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
                i = Controllers.BanCtrl.UpdateBan(idBan,tenKhuVuc, tenBan, dienGiai, trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công ");
                    HienThiDanhSachBan();
                    uctBan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }

            uctBan_Load(sender, e);
        }

    }
}
