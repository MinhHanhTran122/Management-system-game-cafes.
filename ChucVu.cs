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
    public partial class ChucVu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public ChucVu()
        {
            InitializeComponent();
        }

        private void ChucVu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT MACV as [Mã chức vụ], TENCV as [Tên chức vụ] FROM CHUCVU where MACV like '%"+ txttimkiem.Text + "%' or TENCV like N'%"+ txttimkiem.Text + "%'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvchucvu.DataSource = table;
        }
        int i;

        private void dgvchucvu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvchucvu.CurrentRow.Index;
            if (i < dgvchucvu.Rows.Count - 1)
            {
                txtmap.Text = dgvchucvu.Rows[i].Cells[0].Value.ToString();
                txttenp.Text = dgvchucvu.Rows[i].Cells[1].Value.ToString();

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO CHUCVU VALUES('" + txtmap.Text + "',N'" + txttenp.Text + "')";
                cmd.ExecuteNonQuery();
                loaddata();
            }
            catch
            {
                MessageBox.Show("Lỗi SQL");
            }
               
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM CHUCVU WHERE MACV  = '" + dgvchucvu.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {

            cmd = con.CreateCommand();
            cmd.CommandText = "update CHUCVU set MACV='" + txtmap.Text + "',TENCV=N'" + txttenp.Text + "' where MACV='" + dgvchucvu.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }
    }
}
