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
    public partial class HOADON : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public HOADON()
        {
            InitializeComponent();
        }

        private void HOADON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet7.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLQNDataSet7.NHANVIEN);
            // TODO: This line of code loads data into the 'qLQNDataSet6.MAYKHACH' table. You can move, or remove it, as needed.
            this.mAYKHACHTableAdapter.Fill(this.qLQNDataSet6.MAYKHACH);
            con = new SqlConnection(str);
            con.Open();
            loaddata();
            cbbmmt_SelectedIndexChanged(sender, e);
            cbbmnv_SelectedIndexChanged(sender, e);
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select hd.MAHD as[Mã hóa đơn],mk.TENMAYTINH as[Tên máy tính],nv.HO +' '+nv.TEN as[Tên nhân viên phụ trách], TRANGTHAITT as[Trạng thái thanh toán], Format(NGAY, 'dd-MM-yyyy') as[Ngày lập] FROM HOADON hd join NHANVIEN nv on hd.MANV = nv.MANV join MAYKHACH mk on mk.MAMT = hd.MAMT where hd.MAHD like '%"+txttimkiem.Text+"%' or mk.TENMAYTINH like N'%"+txttimkiem.Text+"%' or nv.HO + ' ' + nv.TEN like N'%"+txttimkiem.Text+"%' or TRANGTHAITT like '%"+txttimkiem.Text+"%' or Format(NGAY, 'dd-MM-yyyy HH:mm:ss') like '%"+txttimkiem.Text+"%'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvhoadon.DataSource = table;
        }

        int i;
        private void dgvhoadon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            i = dgvhoadon.CurrentRow.Index;
            if (i < dgvhoadon.Rows.Count - 1)
            {
                txtmahd.Text = dgvhoadon.Rows[i].Cells[0].Value.ToString();
                txttmt.Text = dgvhoadon.Rows[i].Cells[1].Value.ToString();
                txttnv.Text = dgvhoadon.Rows[i].Cells[2].Value.ToString();
                txttt.Text = dgvhoadon.Rows[i].Cells[3].Value.ToString();
                datetimenl.Text = dgvhoadon.Rows[i].Cells[4].Value.ToString();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void txttmt_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MAMT from MAYKHACH WHERE TENMAYTINH=N'" + txttmt.Text + "'";
            string mamt="Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    mamt = reader["MAMT"].ToString();

                }
            }
            cbbmmt.SelectedIndex = cbbmmt.FindStringExact(mamt);
          
        }

        private void txttnv_TextChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MANV from NHANVIEN WHERE HO +' '+TEN like N'%"+txttnv.Text+"%'";
            string manv = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    manv = reader["MANV"].ToString();

                }
            }
            cbbmnv.SelectedIndex = cbbmnv.FindStringExact(manv);
        }

        private void cbbmmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENMAYTINH from MAYKHACH WHERE MAMT='" + cbbmmt.Text + "'";
            string mamt = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    mamt = reader["TENMAYTINH"].ToString();

                }
            }
            txttmt.Text = mamt;
        }

        private void cbbmnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select HO +' '+TEN as[hoten] from NHANVIEN WHERE MANV='"+cbbmnv.Text+"'";
            string manv = "Null";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    manv = reader["hoten"].ToString();

                }
            }
            txttnv.Text = manv;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaylap = DateTime.ParseExact(datetimenl.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string ngaylap_sql = ngaylap.ToString("yyyy-MM-dd");
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into HOADON values('" + txtmahd.Text + "','" + cbbmmt.Text + "','" + cbbmnv.Text + "','" + txttt.Text + "','" + ngaylap_sql + "')";
                cmd.ExecuteNonQuery();
                loaddata();
            }
            catch
            {
                MessageBox.Show("Có thể bị trùng mã hóa đơn hoặc lỗi sql nào đó");
            }
        
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from HOADON where MAHD='" + dgvhoadon.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = DateTime.ParseExact(datetimenl.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngaylap_sql = ngaylap.ToString("yyyy-MM-dd");
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE HOADON set MAHD='"+txtmahd.Text+"',MAMT='"+cbbmmt.Text+"',MANV='"+cbbmnv.Text+"',TRANGTHAITT='"+txttt.Text+"',NGAY='"+ ngaylap_sql + "' WHERE MAHD='"+ dgvhoadon.Rows[i].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
