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
   
    public partial class LoaiHang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public LoaiHang()
        {
            InitializeComponent();
          
        }

        private void LoaiHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MALOAIHANG as [Mã Loại], TENLOAIHANG as [Tên Loại] from LOAIHANG where MALOAIHANG like '"+txttimkiem.Text+ "%' or TENLOAIHANG like N'"+txttimkiem.Text+"%'";
            adapter.SelectCommand = cmd;    
            table = new DataTable();
            adapter.Fill(table);
            dgvbangloai.DataSource = table;
        }
        int i;
        private void dgvbangloai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvbangloai.CurrentRow.Index;
            if (i < dgvbangloai.Rows.Count - 1)
            {
                txtmap.Text = dgvbangloai.Rows[i].Cells[0].Value.ToString();
                txttenp.Text = dgvbangloai.Rows[i].Cells[1].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int i = 0; // Initialize 'i' if it's not already defined.

            if (txtmap.Text != dgvbangloai.Rows[i].Cells[0].Value.ToString())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    // Use parameterized query to prevent SQL injection.
                    cmd.CommandText = "INSERT INTO LOAIHANG VALUES(@txtmap, N'@txttenp')";
                    cmd.Parameters.AddWithValue("@txtmap", txtmap.Text);
                    cmd.Parameters.AddWithValue("@txttenp", txttenp.Text);

                    cmd.ExecuteNonQuery();
                }

                loaddata();
            }
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = con.CreateCommand();
                cmd.CommandText = "update LOAIHANG set MALOAIHANG='" + txtmap.Text + "',TENLOAIHANG=N'"+txttenp.Text+ "' where MALOAIHANG='" + dgvbangloai.Rows[i].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
 
                loaddata();
            }
            catch
            {
                MessageBox.Show("Sai sai cái gì đó");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM LOAIHANG WHERE MALOAIHANG  = '" + dgvbangloai.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
