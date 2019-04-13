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
    public partial class uctMonDaGoi : UserControl
    {
        public uctMonDaGoi()
        {
            InitializeComponent();
        }

        private void uctMonDaGoi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachGoiMon();
            bingding();
            disend(false);
        }

        int flag = 0;
        public static uctBan uctB = new uctBan();


        // khai báo hàm hiển thiej DSKV để đổ dữ liệu vào
        public void HienThiDanhSachGoiMon()
        {
            // trỏ tới data khuc vực
            dvgGoiMon.DataSource = Models.GoiMonMod.FillDataSetGoiMon().Tables[0];
            dvgGoiMon.BorderStyle = BorderStyle.Fixed3D;
            dvgGoiMon.RowHeadersVisible = false;
            dvgGoiMon.Dock = DockStyle.Fill;
        }


        // hàm trỏ đến data trên datagridview
        void bingding()
        {
            cmbIDBan.DataBindings.Clear();
            cmbIDBan.DataBindings.Add("Text", dvgGoiMon.DataSource, "IdBan");
            cmbTenThucDon.DataBindings.Clear();
            cmbTenThucDon.DataBindings.Add("Text", dvgGoiMon.DataSource, "TenThucDon");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dvgGoiMon.DataSource, "DonGiaTon");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dvgGoiMon.DataSource, "SoLuong");
            dtpThoiGian.DataBindings.Clear();
            dtpThoiGian.DataBindings.Add("Text", dvgGoiMon.DataSource, "ThoiGian");

        }

        // hàm dis and các buttun khi load lên
        void disend(bool e)
        {
            cmbIDBan.Enabled = e;
            cmbTenThucDon.Enabled = e;
            txtDonGia.Enabled = e;
            txtSoLuong.Enabled = e;
            dtpThoiGian.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        // hàm load giới tính nhân viên
        void loadcontrolBan()
        {
            cmbIDBan.DataSource = Models.GoiMonMod.FillDataSetgetIdBan().Tables[0];
            // dùng biến TenKhuVuc để hiển thị (lấy giá trị TenKhuVuc)
            cmbIDBan.DisplayMember = "IdBan";
            cmbIDBan.ValueMember = "IdBan";
        }

        void loadcontrolThucDon()
        {
            cmbTenThucDon.DataSource = Models.GoiMonMod.FillDataSetgetDonGiaThucDon().Tables[0];
            // dùng biến TenKhuVuc để hiển thị (lấy giá trị TenKhuVuc)
            cmbTenThucDon.DisplayMember = "TenThucDon";
            cmbTenThucDon.ValueMember = "DonGiaTon";
        }

        // hàm xóa dữ liệu ở text box lúc nhấn vào button
        void clearData()
        {
            loadcontrolBan();
            loadcontrolThucDon();
            txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();
            txtSoLuong.Text = "";
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
            loadcontrolBan();
            loadcontrolThucDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idBan = "";
            try
            {
                idBan = cmbIDBan.Text;
            }
            catch (Exception)
            {
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.DeleteGoiMon(idBan);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công ");
                    HienThiDanhSachGoiMon();
                    uctMonDaGoi_Load(sender, e);
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
                idBan = cmbIDBan.Text;
            }
            catch (Exception)
            {
            }
            string tenThucDon= "";
            try
            {
                tenThucDon = cmbTenThucDon.Text;
            }
            catch (Exception)
            {
            }
            decimal donGiaTon= 0;
            try
            {
                donGiaTon = Convert.ToInt32(txtDonGia.Text);
            }
            catch (Exception)
            {
            }
            int soLuong = 0;
            try
            {
                soLuong = Convert.ToInt32(txtDonGia.Text);
            }
            catch (Exception)
            {
            }
            DateTime thoiGian = DateTime.Now;
            try
            {
            }
            catch (Exception)
            {
            }
            decimal thanhTien= 0;
            try
            {
                thanhTien = Convert.ToInt32(txtDonGia.Text);
            }
            catch (Exception)
            {
            }
            if (flag == 0)
            {
                // thêm mới 
                if (soLuong== 0 || donGiaTon == 0)
                {
                    MessageBox.Show("Hãy nhập thông tin đầy đủ");
                }
                else
                {
                    int i = 0;
                    i = Controllers.GoiMonCtrl.IntsertGoiMon(idBan, tenThucDon,donGiaTon, soLuong, thoiGian,thanhTien);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công ");
                        HienThiDanhSachGoiMon();
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
                i = Controllers.GoiMonCtrl.UpdateGoiMon(idBan, tenThucDon,donGiaTon, soLuong, thoiGian,thanhTien);
                if (i > 0)
                {
                    MessageBox.Show("Sửa thành công ");
                    HienThiDanhSachGoiMon();
                    uctMonDaGoi_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }

            uctMonDaGoi_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
             uctMonDaGoi_Load(sender, e);
            disend(false);
        }

        private void cmbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();
        }

        private void btnLuu_MouseEnter(object sender, EventArgs e)
        {
            btnLuu.ForeColor = Color.Blue;
        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            btnLuu.ForeColor = SystemColors.ControlText;
        }
         // hàm này tương tự hàm dataBingding ơ trên
        private void dvgGoiMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dvgGoiMon.CurrentRow.Index;
            cmbIDBan.Text = dvgGoiMon[0, row].Value.ToString();
            cmbTenThucDon.Text = dvgGoiMon[1, row].Value.ToString();
            txtSoLuong.Text = dvgGoiMon[2, row].Value.ToString();
            txtDonGia.Text = dvgGoiMon[3, row].Value.ToString();
            dtpThoiGian.Text = dvgGoiMon[4, row].Value.ToString();
        }
        // hàm ngăn không cho nhập vào ký tự
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        

    }
}
