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
    public partial class BangDIeuKhien : Form
    {
        public BangDIeuKhien()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitbdk_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không ?", "Quit", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void BangDIeuKhien_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            btnthemphong.PerformClick();
        }
    }
}
