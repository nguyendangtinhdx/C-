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
    public partial class uctNhanVien : UserControl
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        // khai báo biến dể phân biệt lúc Thêm, Sửa
        int flag = 0;
        public static uctNhanVien uctNV = new uctNhanVien();
        private void grQuanLyNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            disend(true);
        }
        // khai báo hàm hiển thiej DSNV để đổ dữ liệu vào
        public void HienThiDanhSachNhanVien()
        {
            // trỏ tới data nhân viên
            dgvDanhSachNhanVien.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDanhSachNhanVien.Dock = DockStyle.Fill;
            dgvDanhSachNhanVien.BorderStyle = BorderStyle.Fixed3D;
            dgvDanhSachNhanVien.RowHeadersVisible = false;
        }
        void nhung(Control ctr)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDSNhanVien.Controls.Add(ctr);
            pnlDSNhanVien.Show();
        }
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
            disend(false);
            bingding();
        }
        // hàm trỏ đến data trên datagridview
        void bingding()
        {
            txtIDNhanVien.DataBindings.Clear();
            txtIDNhanVien.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "IdNhanVien");
            txtHo.DataBindings.Clear();
            txtHo.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "HoLot");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "Ten");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "NgaySinh");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "GioiTinh");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "Email");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhSachNhanVien.DataSource, "DiaChi");

        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            txtHo.Enabled = e;
            txtTen.Enabled = e;
            dtpNgaySinh.Enabled = e;
            cmbGioiTinh.Enabled = e;
            txtDienThoai.Enabled = e;
            txtEmail.Enabled = e;
            txtDiaChi.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        // hàm load giới tính nhân viên
        void loadcontrol()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            txtIDNhanVien.Text = Models.connection.ExcuteScalar(string.Format("SELECT IdNhanVien = dbo.FCgetIdNhanVien()")); // id tự động tăng
            txtHo.Text = "";
            txtTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            loadcontrol();// gọi nó vào cho nó load giới tính

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // load lại 
            uctNhanVien_Load(sender, e);
            disend(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // lúc click sửa ta sẽ mặc định cho flag = 1
            flag = 1;
            disend(true);// lúc này các nút thêm, sửa, xóa sẽ ẩn, chỉ còn nút lưu và hủy
            loadcontrol();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string idNhanVien = "";
            try
            {
                idNhanVien = txtIDNhanVien.Text;
            }
            catch (Exception)
            {
            }
            string hoNhanVien = "";
            try
            {
                hoNhanVien = txtHo.Text;
            }
            catch (Exception)
            {
            }
            string tenNhanVien = "";
            try
            {
                tenNhanVien = txtTen.Text;
            }
            catch (Exception)
            {
            }
            DateTime ngaysinhNhanVien = dtpNgaySinh.Value;
            try
            {
            }
            catch (Exception)
            {
            }
            string gioitinhNhanVien = "";
            try
            {
                gioitinhNhanVien = cmbGioiTinh.Text;
            }
            catch (Exception)
            {
            }
            string emailNhanVien = "";
            try
            {
                emailNhanVien = txtEmail.Text;
            }
            catch (Exception)
            {
            }
            string dienthoaiNhanVien = "";
            try
            {
                dienthoaiNhanVien = txtDienThoai.Text;
            }
            catch (Exception)
            {
            }
            string diachiNhanVien = "";
            try
            {
                diachiNhanVien = txtDiaChi.Text;
            }
            catch (Exception)
            {
            }
            if (flag == 0)
            {
                // thêm mới 
                if (idNhanVien == "" || tenNhanVien == "" || hoNhanVien == ""  )
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin ");
                }
                else
	            {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.IntsertNhanVien(idNhanVien, hoNhanVien, tenNhanVien, ngaysinhNhanVien, gioitinhNhanVien, dienthoaiNhanVien, emailNhanVien, diachiNhanVien);
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
                i = Controllers.NhanVienCtrl.UpdateNhanVien(idNhanVien, hoNhanVien, tenNhanVien, ngaysinhNhanVien, gioitinhNhanVien, dienthoaiNhanVien, emailNhanVien, diachiNhanVien);
                if (i > 0)
	            {
		            MessageBox.Show("Sửa thành công ");
	            }
                else
	            {
                    MessageBox.Show("Sửa thất bại ");
	            }
	        }
            
            uctNhanVien_Load(sender,e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idNhanVien = "";
            try
            {
                idNhanVien = txtIDNhanVien.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctS = new uctSearchNhanVien();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDSNhanVien.Controls.Clear();
            pnlDSNhanVien.BorderStyle = BorderStyle.None;
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
