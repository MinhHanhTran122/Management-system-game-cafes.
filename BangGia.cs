using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYQUANNET
{
    public partial class BangGia : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public BangGia()
        {
            InitializeComponent();
        }

        private void BangGia_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MAPHONG as [Mã Phòng], TENPHONG as [Tên Phòng], SOTIEN as [Giá\\Giờ (VND)] from Phong where MAPHONG like '"+txttimkiem.Text+ "%' or TENPHONG like N'"+txttimkiem.Text+ "%' or SOTIEN like '"+txttimkiem.Text+"%' ";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvbanggia.DataSource = table;
        }
        int i;
        private void dgvbanggia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            i = dgvbanggia.CurrentRow.Index;
            if (i < dgvbanggia.Rows.Count - 1)
            {
                txtmap.Text = dgvbanggia.Rows[i].Cells[0].Value.ToString();
                txttenp.Text = dgvbanggia.Rows[i].Cells[1].Value.ToString();
                txtgia.Text = dgvbanggia.Rows[i].Cells[2].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmap.Text != dgvbanggia.Rows[i].Cells[0].Value.ToString())
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update PHONG set MAPHONG='" + txtmap.Text + "' where MAPHONG='" + dgvbanggia.Rows[i].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                }
                if (txttenp.Text != dgvbanggia.Rows[i].Cells[1].Value.ToString())
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update PHONG set TENPHONG=N'" + txttenp.Text + "' where MAPHONG='" + dgvbanggia.Rows[i].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                }
                if (txtgia.Text != dgvbanggia.Rows[i].Cells[2].Value.ToString())
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update PHONG set SOTIEN='" + txtgia.Text + "' where MAPHONG='" + dgvbanggia.Rows[i].Cells[0].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                }
                loaddata();
            }
            catch
            {
                MessageBox.Show("Bạn nhấn lộn nút bạn ơi");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmap.Text != dgvbanggia.Rows[i].Cells[0].Value.ToString())
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO PHONG VALUES('"+txtmap.Text+"',N'"+txttenp.Text+"','"+txtgia.Text+"')";
                cmd.ExecuteNonQuery();
                loaddata();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM PHONG WHERE MAPHONG  = '"+dgvbanggia.Rows[i].Cells[0].Value.ToString()+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        /* private void dgvbanggia_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {

         }*/
    }
}
