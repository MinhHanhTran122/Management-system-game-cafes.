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
    public partial class CTSUDUNG : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public CTSUDUNG()
        {
            InitializeComponent();
        }
        private void CTSUDUNG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet5.THANHVIEN' table. You can move, or remove it, as needed.
            this.tHANHVIENTableAdapter.Fill(this.qLQNDataSet5.THANHVIEN);
            // TODO: This line of code loads data into the 'qLQNDataSet4.MAYKHACH' table. You can move, or remove it, as needed.
            this.mAYKHACHTableAdapter.Fill(this.qLQNDataSet4.MAYKHACH);
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }
        void loaddata()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select mk.MAMT as [Mã Máy Tính], mk.TENMAYTINH as [Tên Máy tính], tv.MATAIKHOAN as[Mã tài khoản], tv.TENTAIKHOAN as[Tên tài khoản],FORMAT(GIOBATDAU,'yyyy-MM-dd HH:mm:ss') as[Giờ bắt đầu], FORMAT(GIOKETTHUC,'yyyy-MM-dd HH:mm:ss') as[Giờ kết thúc ] from CTSUDUNG ct join MAYKHACH mk on ct.MAMT=mk.MAMT join THANHVIEN tv on tv.MATAIKHOAN = ct.MATAIKHOAN where mk.MAMT like '%" + txttimkiem.Text+ "%' or mk.TENMAYTINH like N'%"+txttimkiem.Text+ "%' or tv.MATAIKHOAN like '%"+txttimkiem.Text+ "%' or tv.TENTAIKHOAN like N'%"+txttimkiem.Text+ "%' or FORMAT(GIOBATDAU, 'dd/MM/yyyy HH:mm:ss') like '" + txttimkiem.Text+ "%' or FORMAT(GIOKETTHUC, 'dd/MM/yyyy HH:mm:ss') like '" + txttimkiem.Text+ "%' ORDER BY GIOBATDAU ASC ";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvctsudung.DataSource = table;
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }
        int i;
        private void dgvctsudung_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvctsudung.CurrentRow.Index;
            if (i < dgvctsudung.Rows.Count - 1)
            {
                cbbmmt.Text = dgvctsudung.Rows[i].Cells[0].Value.ToString();
                txttmt.Text = dgvctsudung.Rows[i].Cells[1].Value.ToString();
                cbbmtk.Text = dgvctsudung.Rows[i].Cells[2].Value.ToString();
                txtttk.Text = dgvctsudung.Rows[i].Cells[3].Value.ToString();
                txtgiobatdau.Text = dgvctsudung.Rows[i].Cells[4].Value.ToString();
                txtgioketthuc.Text = dgvctsudung.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void cbbmmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENMAYTINH from MAYKHACH WHERE MAMT=N'" + cbbmmt.Text + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txttmt.Text = reader["TENMAYTINH"].ToString();

                }
            }
        }

        private void cbbmtk_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENTAIKHOAN from THANHVIEN WHERE MATAIKHOAN=N'" + cbbmtk.Text + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtttk.Text = reader["TENTAIKHOAN"].ToString();

                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DateTime giobatdau = DateTime.Parse(txtgiobatdau.Text);
            string giobatdau_formatted = giobatdau.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime gioketthuc = DateTime.Parse(txtgioketthuc.Text);
            string gioketthuc_formatted = giobatdau.ToString("yyyy/MM/dd HH:mm:ss");
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO CTSUDUNG VALUES('" + cbbmmt.Text + "','" + cbbmtk.Text + "','" + giobatdau_formatted + "','"+ gioketthuc_formatted + "')";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DateTime giobatdau = DateTime.Parse(txtgiobatdau.Text);
            string giobatdau_formatted = giobatdau.ToString("yyyy/MM/dd HH:mm:ss");
            txtgiobatdau.Text = giobatdau_formatted;
            cmd = con.CreateCommand();
            cmd.CommandText = "delete from CTSUDUNG where MAMT='"+ cbbmmt.Text + "' and MATAIKHOAN='"+ cbbmtk.Text + "' and GIOBATDAU='"+ giobatdau_formatted + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            DateTime giobatdau = DateTime.Parse(txtgiobatdau.Text);
            string giobatdau_formatted = giobatdau.ToString("yyyy/MM/dd HH:mm:ss");
            DateTime gioketthuc = DateTime.Parse(txtgioketthuc.Text);
            string gioketthuc_formatted = giobatdau.ToString("yyyy/MM/dd HH:mm:ss");
            MessageBox.Show(dgvctsudung.Rows[i].Cells[2].Value.ToString());
            cmd = con.CreateCommand();
            cmd.CommandText = "update CTSUDUNG set MAMT = '"+cbbmmt.Text+"', MATAIKHOAN = '"+cbbmtk.Text+"', GIOBATDAU = '"+ giobatdau_formatted + "', GIOKETTHUC = '"+ gioketthuc_formatted + "' where MAMT='"+ dgvctsudung.Rows[i].Cells[0].Value.ToString() + "' and MATAIKHOAN='"+ dgvctsudung.Rows[i].Cells[2].Value.ToString() + "' and GIOBATDAU='"+ dgvctsudung.Rows[i].Cells[4].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }
    }
}
