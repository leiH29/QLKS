using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS.All_Control
{
    public partial class UC_AddRoom : UserControl
    {
        ThuVien tv = new ThuVien();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "Select * from rooms";
            DataSet ds = tv.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "" && cboRoomType.Text != "" && cboBedType.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNumber.Text;
                String type = cboRoomType.Text;
                String bed = cboBedType.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo, roomType, bed, price) values ('" + roomno + "', N'" + type + "', N'" + bed + "', '" + price + "')";

                tv.setData(query, "Đã thêm phòng");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            cboRoomType.SelectedIndex = -1;
            cboBedType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
