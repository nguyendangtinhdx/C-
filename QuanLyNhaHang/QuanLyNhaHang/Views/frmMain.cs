using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct,byte typeControl, string tenTab)
        {
            // kiểm tra sự tồn tại trang này
            for(int i=0;i<TabHienThi.TabPages.Count;i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        // đóng tab hiện tại
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        //đóng tất cả các tab
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }

        }
        // nút thoát
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không ?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctNhanVien.uctNV, 4, "Quản lý nhân viên");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhuVuc.uctKV, 4, "Hệ thống khu vực");
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctBan.uctB, 5, "Danh sách bàn");
        }

        private void loạiThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctLoaiThucDon.uctLTD, 4, "Danh sách loại thực đơn");
        }

        private void thựcĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThucDon.uctTD, 8, "Danh sách thực đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctGoiMon.uctGM, 4, "Gọi món");
        }
    }
}
