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
    public partial class Dangnhap : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        bool rememberUsername=false;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Dangnhap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            checkBox1.Checked = Properties.Settings.Default.RememberUsername;
            if (checkBox1.Checked == true)
            {
                txttaikhoan.Text = Properties.Settings.Default.RememberName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandText = "select * from ThanhVien where TenTaiKhoan = '"+txttaikhoan.Text+"' and MATKHAU='"+txtpass.Text+"' and MATAIKHOAN in (1,2);";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    Properties.Settings.Default.RememberName = txttaikhoan.Text;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi bạn ơi? kết nối kiểu gì đấy?");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rememberUsername = checkBox1.Checked;
            Properties.Settings.Default.RememberUsername = rememberUsername;
            Properties.Settings.Default.Save();
        }
    }
}
