using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không ?", "Quit", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtxacnhan_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "ntranhieu" &&  txtPassword.Text == "12345678")
            {
                labelSai.Visible = false;
                BangDIeuKhien ds = new BangDIeuKhien();
                this.Hide();
                ds.ShowDialog();
            } else
            {
                labelSai.Visible=true;
                txtPassword.Clear();
            }
        }
    }
}
