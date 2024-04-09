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
    public partial class NhanVien : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter1.Fill(this.qLQNDataSet.CHUCVU);
            con = new SqlConnection(str);
            con.Open();
            loadnhanvien();

            //load combobox
        }
        void loadnhanvien()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MANV as [Mã Nhân Viên], HO +' '+TEN as [Tên], GIOITINH as [Giới tính],format(NGAYSINH,'dd/MM/yyyy') as [Ngày sinh], DIACHI as [Địa chỉ], DIENTHOAI as [Số điện thoại],CMND, LUONGCOBAN AS [Lương cơ bản], TENCV as [Chức vụ] from NHANVIEN nv join CHUCVU cv on nv.MACV=cv.MACV ";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvnhanvien.DataSource = table;
        }

        private void dgvnhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dgvnhanvien.CurrentRow.Index;
            if(i <dgvnhanvien.Rows.Count-1)
            {
                txtmanv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
                txttennv.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
                txtgioitinh.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
                txtdiachi.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
                txtngaysinh.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
                txtcmnd.Text = dgvnhanvien.Rows[i].Cells[6].Value.ToString();
                txtluong.Text = dgvnhanvien.Rows[i].Cells[7].Value.ToString();
                cbbcv.Text = dgvnhanvien.Rows[i].Cells[8].Value.ToString();
            }    
           
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh = DateTime.ParseExact(txtngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngaysinh_sql = ngaysinh.ToString("yyyy-MM-dd");
            string[] words = txttennv.Text.Split(' ');

            // Tạo chuỗi thứ nhất bằng cách lấy từ đầu tiên và các từ tiếp theo đến từ trước từ cuối cùng
            string firstWords = string.Join(" ", words, 0, words.Length - 1);

            // Lấy từ cuối cùng trong danh sách các từ
            string lastWord = words[words.Length - 1];
            string chucvu="";
            string khu="";
            /* if (cbbcv.Text == "Phục vụ")
                 chucvu = "CV02";
             else if (cbbcv.Text == "Thu ngân")
                 chucvu = "CV01";
             else
                 chucvu = "CV03";*/
            cmd = con.CreateCommand();
            cmd.CommandText = "select MACV from CHUCVU WHERE TEnCV=N'" + cbbcv.Text + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    chucvu = reader["MACV"].ToString();

                }
            }
           /* if (cbbkhu.Text == "01")
                khu = "K01";
            else if (cbbkhu.Text == "02")
                khu = "K02";
            else
                khu = "K03";*/
            cmd = con.CreateCommand();
            cmd.CommandText = "insert into NHANVIEN values('" + txtmanv.Text + "',N'" + firstWords + "',N'" + lastWord + "','" + txtgioitinh.Text + "','" + ngaysinh_sql + "','" + txtdiachi.Text + "','" + txtsdt.Text + "','" + txtcmnd.Text + "','"+txtluong.Text+"','" + chucvu + "')";
            cmd.ExecuteNonQuery();
            loadnhanvien();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh = DateTime.ParseExact(txtngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string ngaysinh_sql = ngaysinh.ToString("yyyy-MM-dd");
            string[] words = txttennv.Text.Split(' ');

            // Tạo chuỗi thứ nhất bằng cách lấy từ đầu tiên và các từ tiếp theo đến từ trước từ cuối cùng
            string firstWords = string.Join(" ", words, 0, words.Length - 1);

            // Lấy từ cuối cùng trong danh sách các từ
            string lastWord = words[words.Length - 1];
            string chucvu="";
            string khu="";
            cmd = con.CreateCommand();
            cmd.CommandText = "select MACV from CHUCVU WHERE TEnCV=N'" + cbbcv.Text + "'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    chucvu = reader["MACV"].ToString();

                }
            }
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE NHANVIEN SET HO = N'" + firstWords + "', TEN = N'" + lastWord + "', GIOITINH = '" + txtgioitinh.Text + "', NGAYSINH = '" + ngaysinh_sql + "', DIACHI = '" + txtdiachi.Text + "', DIENTHOAI = '" + txtsdt.Text + "', CMND = '" + txtcmnd.Text + "', LUONGCOBAN = '" + txtluong.Text + "', MACV = '" + chucvu + "' WHERE MANV = '" + txtmanv.Text + "'";
            cmd.ExecuteNonQuery();
            loadnhanvien();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvnhanvien.CurrentRow.Index;
            if (i < dgvnhanvien.Rows.Count - 1)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NHANVIEN where MANV='"+ dgvnhanvien.Rows[i].Cells[0].Value.ToString()+"'";
                cmd.ExecuteNonQuery();
                loadnhanvien();
            }    

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdiachi.Text = string.Empty;
            txtcmnd.Text = string.Empty;
            txtgioitinh.Text = string.Empty;
            txtluong.Text = string.Empty;
            txtmanv.Text = string.Empty;
            txtsdt.Text = string.Empty;
            txttennv.Text = string.Empty;
            cbbcv.Text = string.Empty;
            txtngaysinh.Text = string.Empty;
        }
    }
}
