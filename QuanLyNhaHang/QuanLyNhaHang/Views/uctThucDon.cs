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
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
        void bingding()
        {
            txtIDThucDon.DataBindings.Clear();
            txtIDThucDon.DataBindings.Add("Text", dgvThucDon.DataSource, "IdThucDon");
            cmbTenLoaiThucDon.DataBindings.Clear();
            cmbTenLoaiThucDon.DataBindings.Add("Text", dgvThucDon.DataSource, "TenLoaiThucDon");
            txtTenThucDon.DataBindings.Clear();
            txtTenThucDon.DataBindings.Add("Text", dgvThucDon.DataSource, "TenThucDon");
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.Add("Text", dgvThucDon.DataSource, "DonViTinh");
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dgvThucDon.DataSource, "SoLuongTon");
            txtDonGiaTon.DataBindings.Clear();
            txtDonGiaTon.DataBindings.Add("Text", dgvThucDon.DataSource, "DonGiaTon");
            txtTonToiThieu.DataBindings.Clear();
            txtTonToiThieu.DataBindings.Add("Text", dgvThucDon.DataSource, "TonToiThieu");
            cmbTrangThai.DataBindings.Clear();
            cmbTrangThai.DataBindings.Add("Text", dgvThucDon.DataSource, "TrangThai");

        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            txtIDThucDon.Enabled = e;
            cmbTenLoaiThucDon.Enabled = e;
            txtTenThucDon.Enabled = e;
            txtDonViTinh.Enabled = e;
            txtSoLuongTon.Enabled = e;
            txtDonGiaTon.Enabled = e;
            txtTonToiThieu.Enabled = e;
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

            cmbTenLoaiThucDon.DataSource = Models.LoaiThucDonMod.getTenLoaiThucDon().Tables[0];
            // dùng biến TenKhuVuc để hiển thị (lấy giá trị TenKhuVuc)
            cmbTenLoaiThucDon.DisplayMember = "TenLoaiThucDon";
        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            txtIDThucDon.Text = Models.connection.ExcuteScalar(string.Format("SELECT IdThucDon = dbo.FCgetIdThucDon()")); // id tự động tăng
            loadcontrol();// gọi nó vào cho nó load giới tính
            txtTenThucDon.Text = "";
            txtDonViTinh.Text = "";
        }

        private void uctThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThucDon();
            disend(false);
            bingding();
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
            string idThucDon = "";
            try
            {
                idThucDon = txtIDThucDon.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThucDonCtrl.DeleteThucDon(idThucDon);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachThucDon();
                    uctThucDon_Load(sender, e);
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
            string idThucDon = "";
            try
            {
                idThucDon = txtIDThucDon.Text;
            }
            catch (Exception)
            {
            }
            string tenLoaiThucDon = "";
            try
            {
                tenLoaiThucDon = cmbTenLoaiThucDon.Text;
            }
            catch (Exception)
            {
            }
            string tenThucDon = "";
            try
            {
                tenThucDon = txtTenThucDon.Text;
            }
            catch (Exception)
            {
            }
            string donViTinh = "";
            try
            {
                donViTinh = txtDonViTinh.Text;
            }
            catch (Exception)
            {
            }
            float soLuongTon = 0;
            try
            {
                soLuongTon = Convert.ToInt32(txtSoLuongTon.Text);
            }
            catch (Exception)
            {
            }
            float donGiaTon = 0;
            try
            {
                donGiaTon = Convert.ToInt32(txtDonGiaTon.Text);
            }
            catch (Exception)
            {
            }
            float tonToiThieu = 0;
            try
            {
                tonToiThieu = Convert.ToInt32(txtTonToiThieu.Text);
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
                if (tenThucDon == "")
                {
                    MessageBox.Show("Hãy nhập tên thực đơn");
                }
                else
                {
                    int i = 0;
                    i = Controllers.ThucDonCtrl.IntsertThucDon(idThucDon, tenLoaiThucDon, tenThucDon, donViTinh, soLuongTon, donGiaTon, tonToiThieu, trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công ");
                        HienThiDanhSachThucDon();
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
                i = Controllers.ThucDonCtrl.UpdateThucDon(idThucDon, tenLoaiThucDon, tenThucDon, donViTinh, soLuongTon, donGiaTon, tonToiThieu, trangThai);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công ");
                    HienThiDanhSachThucDon();
                    uctThucDon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }

            uctThucDon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctThucDon_Load(sender, e);
            disend(false);
        }

    }
}
