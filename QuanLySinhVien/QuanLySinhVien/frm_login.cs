using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        Bussines BUS = new Bussines();
        fucntion fucn = new fucntion();

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (BUS.kiemtradangnhap(txtUsername.Text, fucn.md5(txtPassword.Text)) == true)
            {
                //  MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_main fmain = new frm_main();
                fmain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {

        }




    }
}
