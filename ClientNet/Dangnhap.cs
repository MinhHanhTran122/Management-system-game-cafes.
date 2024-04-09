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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientNet
{
    public partial class Dangnhap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=HOANGSON\\SQLEXPRESS;Initial Catalog=QLQN;Integrated Security=True;MultipleActiveResultSets=true";
        public Dangnhap()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            con.Open();
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from THANHVIEN where TENTAIKHOAN = '" + txttk.Text + "' and MATKHAU = '" + txtmk.Text + "' and TENTAIKHOAN !='user'";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    string tk = txttk.Text;
                    May1 form1 = (May1)Application.OpenForms["May1"];
                    form1.SetValue(tk);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
           
        }
    }
}
