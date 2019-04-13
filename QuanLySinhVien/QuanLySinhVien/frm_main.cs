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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            loaddatasv();
        }

       
        Bussines BUS;
        private void loaddatasv()
        {
            BUS = new Bussines();
            gridControlSinhVien.DataSource = BUS.getalldatasinhvien();
        }

        private bool kiemtra()
        {
            bool check = false;
            if(txtHo.Text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null 
                || txtTen.text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null ||
                txtTen.text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null || txtTen.text == null ||)
            return check;
        }
    
    }
}
