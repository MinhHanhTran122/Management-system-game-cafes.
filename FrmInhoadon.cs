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
    public partial class FrmInhoadon : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        string tenmay;
        public FrmInhoadon(string tenmay)
        {
            InitializeComponent();
            this.tenmay = tenmay;
        }

        private void FrmInhoadon_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loadhoadon();
            label3.Text = "Máy tính: " + tenmay;
        }
        void loadhoadon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select ROW_NUMBER() OVER (ORDER BY m.tenhang) AS STT, m.TENHANG as [Tên hàng], ct.SOLUONG as[Số lượng], m.DONGIA as[Đơn giá], (ct.SOLUONG*m.DONGIA) as [Thành tiền]\r\nfrom HOADON hd join CTHOADON ct on hd.MAHD=ct.MAHD join MAYKHACH mk on hd.MAMT=mk.MAMT join MENU m on m.MAHANG=ct.MAHANG where TENMAYTINH=N'"+tenmay+"' and TRANGTHAITT like 'Chua%'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvHoadon.DataSource = table;
            int sotien=0;
            for(int i = 0; i < dgvHoadon.Rows.Count-1; i++)
            {
                sotien+= Convert.ToInt32(dgvHoadon.Rows[i].Cells[4].Value.ToString());
            }
            txttong.Text = sotien.ToString();
        }

        private void XuatHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
