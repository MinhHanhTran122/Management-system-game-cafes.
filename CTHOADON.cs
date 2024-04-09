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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QUANLYQUANNET
{
    public partial class CTHOADON : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public CTHOADON()
        {
            InitializeComponent();
        }

        private void CTHOADON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet10.MENU' table. You can move, or remove it, as needed.
            this.mENUTableAdapter.Fill(this.qLQNDataSet10.MENU);
            // TODO: This line of code loads data into the 'qLQNDataSet9.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLQNDataSet9.HOADON);
            con = new SqlConnection(str);
            con.Open();
            loaddata();
            cbbmh_SelectedIndexChanged(sender, e);
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select ct.MAHD as[Mã hóa đơn],m.TENHANG as[Tên hàng], SOLUONG as[Số lượng], MUCGIAMGIA as[Giảm giá] from CTHOADON ct join MENU m on ct.MAHANG = m.MAHANG where ct.MAHD like '%"+txttimkiem.Text+"%' or m.TENHANG like '%"+txttimkiem.Text+"%' or SOLUONG like '%"+txttimkiem.Text+"%' or MUCGIAMGIA like '%"+txttimkiem.Text+"%'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvcthoadon.DataSource = table;
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txttenhang_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MAHANG from MENU WHERE TENHANG = N'"+txttenhang.Text+"'";
            string Mahang = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Mahang = reader["MAHANG"].ToString();
                }
            }
            cbbmh.SelectedIndex = cbbmh.FindStringExact(Mahang);
        }
        int i;
        private void dgvcthoadon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvcthoadon.CurrentRow.Index;
            if (i < dgvcthoadon.Rows.Count - 1)
            {
                cbbmhd.SelectedIndex = cbbmhd.FindStringExact(dgvcthoadon.Rows[i].Cells[0].Value.ToString());
                txttenhang.Text = dgvcthoadon.Rows[i].Cells[1].Value.ToString();
                txtsoluong.Text = dgvcthoadon.Rows[i].Cells[2].Value.ToString();
                txtmgg.Text = dgvcthoadon.Rows[i].Cells[3].Value.ToString();
                txtmgg.Text = txtmgg.Text.Replace(",", ".");
            }
        }

        private void cbbmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENHANG from MENU WHERE MAHANG = '" + cbbmh.Text + "'";
            string Tenhang = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Tenhang = reader["TENHANG"].ToString();
                }
            }
            txttenhang.Text = Tenhang;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into CTHOADON values('" + cbbmhd.Text + "','" + cbbmh.Text + "','" + txtsoluong.Text + "','" + txtmgg.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from CTHOADON where MAHD='"+cbbmhd.Text+"' and MAHANG='"+cbbmh.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {

            cmd = con.CreateCommand();
            cmd.CommandText = "select MAHANG from MENU WHERE TENHANG = N'" + dgvcthoadon.Rows[i].Cells[1].Value.ToString() + "'";
            string temp = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    temp = reader["MAHANG"].ToString();
                }
            }
            cmd = con.CreateCommand();
            cmd.CommandText = "update CTHOADON set MAHD = '"+cbbmhd.Text+"', MAHANG = '"+cbbmh.Text+"', SOLUONG = '"+txtsoluong.Text+"', MUCGIAMGIA = '"+txtmgg.Text+"' where MAHD = '"+ dgvcthoadon.Rows[i].Cells[0].Value.ToString() + "' and MAHANG = '"+temp+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }
    }
}
