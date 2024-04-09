using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNET
{
    public partial class Computer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public Computer()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MAMT as[Mã máy tính],TENMAYTINH as[Tên máy tính], TRANGTHAI as[Trạng thái máy] ,p.TENPHONG as[Tên phòng] from MayKhach mk join PHONG p on p.MAPHONG=mk.MAPHONG where MAMT like '%"+txttimkiem.Text+"%' or TENMAYTINH like N'%"+txttimkiem.Text+"%' or TRANGTHAI like N'%"+txttimkiem.Text+"%' or p.TENPHONG like N'%"+txttimkiem.Text+"%' ";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvmaykhach.DataSource = table;
        }

        private void Computer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet11.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLQNDataSet11.PHONG);
            con = new SqlConnection(str);
            con.Open();
            loaddata();
            cbbmp_SelectedIndexChanged(sender, e);
        }
        int i;
        private void dgvmaykhach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvmaykhach.CurrentRow.Index;
            if (i < dgvmaykhach.Rows.Count - 1)
            {
                txtmt.Text = dgvmaykhach.Rows[i].Cells[0].Value.ToString();
                txttenmay.Text = dgvmaykhach.Rows[i].Cells[1].Value.ToString();
                cbbtt.Text = dgvmaykhach.Rows[i].Cells[2].Value.ToString();
                txttenphong.Text = dgvmaykhach.Rows[i].Cells[3].Value.ToString();
            }
        }

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MAPHONG from PHONG WHERE TENPHONG=N'" + txttenphong.Text + "'";
            string map = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    map = reader["MAPHONG"].ToString();

                }
            }
            cbbmp.SelectedIndex = cbbmp.FindStringExact(map);
        }

        private void cbbmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENPHONG from PHONG WHERE MAPHONG=N'" + cbbmp.Text + "'";
            string tenp = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tenp = reader["TENPHONG"].ToString();

                }
            }
            txttenphong.Text = tenp;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into MAYKHACH values('" + txtmt.Text + "','" + txttenmay.Text + "','" + cbbtt.Text + "','" + cbbmp.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE MAYKHACH SET MAMT='"+txtmt.Text+"',TENMAYTINH='"+txttenmay.Text+"', TRANGTHAI='"+cbbtt.Text+"',MAPHONG='"+cbbmp.Text+"' WHERE MAMT='"+ dgvmaykhach.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM MAYKHACH WHERE MAMT='" + dgvmaykhach.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
