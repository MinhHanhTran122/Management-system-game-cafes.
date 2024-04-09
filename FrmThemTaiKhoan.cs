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

namespace QUANLYQUANNET
{
    public partial class FrmThemTaiKhoan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        int Tong=0;
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            datetimenc.Value = now;
            txtsudung.Text = "0";
        }
        double tongtien;
        DateTime now = DateTime.Now;
        private void btncapnhap_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd hh:mm:ss");
            if (string.IsNullOrEmpty(txttk.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                
            }
            else
            {
                if (string.IsNullOrEmpty(txtmk.Text))
                {
                    txtmk.Text = "1";
                }
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into THANHVIEN values ('" + txttk.Text + "','" + txtmk.Text + "',0,@ngaylap,@ngayhethan,N'Hoi vien')";
                cmd.Parameters.AddWithValue("@ngaylap", DateTime.ParseExact(datetimenc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                cmd.Parameters.AddWithValue("@ngayhethan", DateTime.ParseExact(datetimehh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                cmd.ExecuteNonQuery();
                if (tongtien != Tong)
                {
                    string mataikhoan = "";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "select MATAIKHOAN from THANHVIEN where TENTAIKHOAN = '" + txttk.Text + "'";
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
                        cmd.CommandText = "insert into NAPTIEN values('NV01','" + mataikhoan + "','" + sqlFormattedDate + "','" + txtsotien.Text + "')";
                        cmd.ExecuteNonQuery();
                    }

                }
                this.Close();
            }

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
            tongtien = Tong + Math.Round((double)int.Parse(txtsotien.Text) / 8000 * 60); // tổng của giờ hiện tại + giờ của số tiền
            txttong.Text = tongtien.ToString();
            txtconlai.Text = tongtien.ToString();
        }
    }
}
