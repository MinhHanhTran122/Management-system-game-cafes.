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
    public partial class Frmcapnhap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        int Tong;
        bool b;
        double giothem;
        public Frmcapnhap(string tk, int tong, string sudung,string ngaylap,string ngayhethan)
        {
            
            InitializeComponent();
            txttk.Text = tk;
            txttong.Text = tong.ToString();
            Tong = tong;
            txtsudung.Text = sudung;
            txtconlai.Text = tong.ToString();
            datetimehh.Text=ngayhethan.ToString();
            datetimenc.Text=ngaylap.ToString();
            b=true;
        }
        public Frmcapnhap(string tk,int tong,string sudung,string conlai)
        {
            InitializeComponent();
            txttk.Text= tk;
            txttong.Text=tong.ToString();
            Tong = tong;
            txtsudung.Text= sudung;
            txtconlai.Text= conlai;
            b = false;
        }

        double tonggio;
        double sotienbandau;
        private void btncapnhap_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd hh:mm:ss");
            if (b==true) // nếu bên thành viên nạp tiền thì sẽ cập nhập được ngày hết hạn ngày kết thúc
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "update THANHVIEN set NGAYLAP=@ngaylap ,NGAYHETHAN=@ngayhethan where TENTAIKHOAN='"+txttk.Text+"'";
                cmd.Parameters.AddWithValue("@ngaylap", DateTime.ParseExact(datetimenc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@ngayhethan", DateTime.ParseExact(datetimehh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                cmd.ExecuteNonQuery();
                if (tonggio != Tong)
                {
                    string mataikhoan="";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "select MATAIKHOAN from THANHVIEN where TENTAIKHOAN = '"+txttk.Text+"'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mataikhoan = reader["MATAIKHOAN"].ToString();

                            //lấy mã tài khoản
                        }
                    }
                    if (!string.IsNullOrEmpty(mataikhoan))
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into NAPTIEN values('NV01','"+mataikhoan+"','"+ sqlFormattedDate + "','"+txtsotien.Text+"')";
                        cmd.ExecuteNonQuery();
                        Menu menu = (Menu)Application.OpenForms["Menu"];
                        menu.themgio(giothem);
                    }
                   
                }
                if(!string.IsNullOrEmpty(txtmk.Text))
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update THANHVIEN set MATKHAU='"+txtmk.Text+"' where TENTAIKHOAN='" + txttk.Text + "'";
                    cmd.ExecuteNonQuery();
                }
              
            }
            if(b==false) // nếu bên máy trạm nạp tiền thì mấy cái ngày không cập nhập // bỏ 
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "update THANHVIEN set SOTIENHIENCO='" + sotienbandau.ToString() + "' where TENTAIKHOAN='" + txttk.Text + "'";
                cmd.ExecuteNonQuery();
                if (!string.IsNullOrEmpty(txtmk.Text))
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "update THANHVIEN set MATKHAU='" + txtmk.Text + "' where TENTAIKHOAN='" + txttk.Text + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            this.Close();
           

        }

        private void Frmcapnhap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsotien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsotien.Text))
            {
                txtsotien.Text = "0";
            }
            giothem = Math.Round((double)int.Parse(txtsotien.Text) / 8000 * 60);
            tonggio = Tong + giothem; // tổng của giờ hiện tại + giờ của số tiền
            int digits = -3;
            txttong.Text = tonggio.ToString();
            txtconlai.Text = tonggio.ToString();
        }
    }
}
