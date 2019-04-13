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
    public partial class uctGoiMon : UserControl
    {
        public uctGoiMon()
        {
            InitializeComponent();
        }
        public static uctGoiMon uctGM = new uctGoiMon();
        
        public DataTable getBan()
        {
            DataTable dt = new DataTable();
            dt = Models.BanMod.FillDataSetDanhSachBanGoiMon().Tables[0];
            return dt;
        }
        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBanGoiMon().Tables[0];
            dvgGoiMon.DataSource = dt;
            return dt;
        }
        public DataTable getBanChuaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBanChuaGoiMon().Tables[0];
            dvgGoiMon.DataSource = dt;
            return dt;
        }

        private void uctGoiMon_Load(object sender, EventArgs e)
        {
            uctDanhSachThucDon uctDSTD = new uctDanhSachThucDon();
            nhung(uctDSTD);
            ShowListView();
            dvgGoiMon.Dock = DockStyle.Fill;
            dvgGoiMon.RowHeadersVisible = false;
            dvgGoiMon.BorderStyle = BorderStyle.Fixed3D;
            lblTongTien.Text = "";
        }

        public void ShowListView()
        {
            lvDanhSachBan.Items.Clear();
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
            DataTable dt2 = new DataTable();
            dt2 = getBanChuaGoi();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[i]["Tên bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt2.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt2.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 0;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
       
        public void BanCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            dvgGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
        }
        public void BanChuaCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanChuaGoi();
            dvgGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên bàn"].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.SubItems.Add(dt.Rows[i]["Id Bàn"].ToString());
                lvDanhSachBan.Items.Add(item);
                item.ImageIndex = 0;
            }
        }
        public void ThemBanMoi()
        {
            uctBan uctban = new uctBan();
            uctban.Show();
        }

        private void thêmBànMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBanMoi();
        }

        private void hiểnThịBanCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanCoNguoi();
        }

        private void hIểnThịBànChưaCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanChuaCoNguoi();
        }

        private void hiểnThịTấtCảCácBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctGoiMon_Load(sender, e);
        }

        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvDanhSachBan_Click(object sender, EventArgs e)
        {
            string Idban = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dvgGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSetgetGoiMonByIdBan(Idban).Tables[0];
            string tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;
            label3.Text = tenBan.ToString();
            label3.Hide();
            tinhtien();
        }
        public void tinhtien()
        {
            try
            {
                int tien = dvgGoiMon.Rows.Count;
                decimal thanhTien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhTien += decimal.Parse(dvgGoiMon.Rows[i].Cells["Thành tiềnn"].Value.ToString());
                }
                // #,### dùng để ngăn cách các ký tự thập phân
                lblTongTien.Text = thanhTien.ToString("#,###") + " VND";
                lblTongTien.ForeColor = SystemColors.HotTrack;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền " + label3.Text + "Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN CỦA " + " [ " + label3.Text + " ] " + " LÀ " + lblTongTien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tinhtien();
                    uctMonDaGoi uctMDG = new uctMonDaGoi();
                    nhung(uctMDG);
                    string Idban = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
                    dvgGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(Idban);
                    uctGoiMon_Load(sender, e);

                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uctGoiMon_Load(sender, e);
            }
        }
        public void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }
        public void nhungFrom(Form frm)
        {
            pnlGoiMon.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(frm);
            pnlGoiMon.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uctDanhSachThucDon uctDSTD = new uctDanhSachThucDon();
            nhung(uctDSTD);
            uctGoiMon_Load(sender, e);
        }

        private void btnGoiMon_Click(object sender, EventArgs e)
        {
            uctMonDaGoi uctMDG = new uctMonDaGoi();
            uctGoiMon_Load(sender, e);
            nhung(uctMDG);
        }




    }
}
