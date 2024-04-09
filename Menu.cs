using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using Button = System.Windows.Forms.Button;

namespace QUANLYQUANNET
{
    public partial class Menu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string str = Properties.Settings.Default.Str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        string trangthai="";
        string Taikhoan="";
        string Tenmay="";
        int Sohoadon=0;
        DateTime now = DateTime.Now;
        public Menu()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        void loadthanhvien()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select TENTAIKHOAN as [Tài khoản],SOTIENHIENCO as [Số tiền],NGAYLAP as [Ngày lập tài khoản],NGAYHETHAN as [Ngày hết hạn] from THANHVIEN WHERE TENTAIKHOAN !='Admin' and TENTAIKHOAN !='user' "; // cái này để ghi lệnh thôi chứ không thực thi được
            adapter.SelectCommand = cmd; // thực thi câu lệnh
            table = new DataTable();
            adapter.Fill(table); // dữ liệu truyền vào table
            dgvthanhivien.DataSource = table; // dgv lấy dữ liệu trong table
            int rowCount = dgvthanhivien.RowCount;
            rowCount--;
            txtbaonhieuhoivien.Text = rowCount.ToString();
        }
        void loadaddmoney()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV ORDER BY THOIGIANNAPTIEN ASC; ";
            // cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV where THOIGIANNAPTIEN >= DATEADD(day, -2, GETDATE()) AND THOIGIANNAPTIEN <= GETDATE() ORDER BY THOIGIANNAPTIEN ASC  ";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvhistorymoney.DataSource = table;
        }
        void loadthongkenaptien()
        {
            DateTime selectedDate = datetimengaybd.Value; // chọn ngày datetimengay dd//mm//yyyy
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            DateTime selectedDate1 = datetimenkt.Value;
            int year1 = selectedDate1.Year; // chọn ra năm
            int month1 = selectedDate1.Month;
            int day1 = selectedDate1.Day;
            day1++;
            cmd = con.CreateCommand();
            //cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV   ";
            cmd.CommandText = "select THOIGIANNAPTIEN as [Thời gian] ,tv.TENTAIKHOAN as [Tên tài khoản],nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV join THANHVIEN tv on tv.MATAIKHOAN=nt.MATAIKHOAN where THOIGIANNAPTIEN between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and( tv.TENTAIKHOAN like'" + txtctnaptien.Text + "%' or nv.TEN like N'" + txtctnaptien.Text + "%' or nt.SOTIEN like '" + txtctnaptien.Text + "%')";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            cmd = con.CreateCommand();
            cmd.CommandText = "select sum(nt.sotien) as TongTien from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV join THANHVIEN tv on tv.MATAIKHOAN=nt.MATAIKHOAN where THOIGIANNAPTIEN between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and( tv.TENTAIKHOAN like'" + txtctnaptien.Text + "%' or nv.TEN like N'" + txtctnaptien.Text + "%' or nt.SOTIEN like '" + txtctnaptien.Text + "%')";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txttongtien.Text = reader["TongTien"].ToString();

                    // lấy số tiền trong tài khoản
                }
            }
            dgvnaptien.DataSource = table;
        }
        void loadthongkemathang()
        {
            DateTime selectedDate = datetimengaybd.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            DateTime selectedDate1 = datetimenkt.Value;
            int year1 = selectedDate1.Year;
            int month1 = selectedDate1.Month;
            int day1 = selectedDate1.Day;
            day1++;
            cmd = con.CreateCommand();
            //cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV   ";
            cmd.CommandText = "select hd.MAHD,hd.ngay as [Thời gian],mk.TENMAYTINH as [Máy tính], mn.TENHANG as [Dịch vụ], ct.SOLUONG as [Số lượng], mn.DONGIA as [Đơn giá], ct.SOLUONG*mn.DONGIA as [Thành tiền] from CTHOADON ct join HOADON hd on ct.MAHD=hd.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG = ct.MAHANG where NGAY between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and TRANGTHAITT='Da thanh toan' and (hd.MAHD like N'"+txtmathang.Text+ "%' or mk.TENMAYTINH like N'"+txtmathang.Text+ "%' or mn.TENHANG like N'"+txtmathang.Text+ "%' or ct.SOLUONG like '"+txtmathang.Text+ "%' or mn.DONGIA like '"+txtmathang.Text+"%')";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            cmd = con.CreateCommand();
            cmd.CommandText = "select sum(ct.SOLUONG*mn.DONGIA) as [Thành tiền] from CTHOADON ct join HOADON hd on ct.MAHD=hd.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG = ct.MAHANG where NGAY between '" + year.ToString() + "-" + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and TRANGTHAITT='Da thanh toan' and (hd.MAHD like N'"+txtmathang.Text+ "%' or mk.TENMAYTINH like N'"+txtmathang.Text+ "%' or mn.TENHANG like N'"+txtmathang.Text+ "%' or ct.SOLUONG like '"+txtmathang.Text+ "%' or mn.DONGIA like '"+txtmathang.Text+"%')";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtdoanhthu.Text = reader["Thành tiền"].ToString();

                    // lấy số tiền trong tài khoản
                }
            }
            dgvmathang.DataSource = table;
        }
        void loadthongkedoanhso()
        {
            DateTime selectedDate = datetimengaybd.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            DateTime selectedDate1 = datetimenkt.Value;
            int year1 = selectedDate1.Year;
            int month1 = selectedDate1.Month;
            int day1 = selectedDate1.Day;
            day1++;
            cmd = con.CreateCommand();
            //cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV   ";
            cmd.CommandText = "select hd.MAHD as[Hóa đơn],TENMAYTINH as [Tên máy tính],mn.TENHANG as[Tên hàng], Ngay,SOLUONG as[Số lượng] from CTHOADON ct join HOADON hd on hd.MAHD=ct.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG=ct.MAHANG where TRANGTHAITT!='Chua phuc vu' and ngay between '" + year.ToString() + " - " + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and (hd.MAHD like '"+txttimkiem.Text+"%' or TENMAYTINH like N'"+txttimkiem.Text+"%' or mn.TENHANG like N'"+txttimkiem.Text+"%' or SOLUONG like '%"+txttimkiem.Text+"%')";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvdoanhso.DataSource = table;
        }
        void loadthongkephongmay()
        {
            DateTime selectedDate = datetimengaybd.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;
            int day = selectedDate.Day;

            DateTime selectedDate1 = datetimenkt.Value;
            int year1 = selectedDate1.Year;
            int month1 = selectedDate1.Month;
            int day1 = selectedDate1.Day;
            day1++;
            cmd = con.CreateCommand();
            //cmd.CommandText = "select FORMAT(THOIGIANNAPTIEN, 'yyyy-MM-dd HH:mm:ss')as [Thời gian] ,nv.TEN as [Người thu],nt.SOTIEN as [Số tiền] from NAPTIEN nt join NHANVIEN nv on nt.MANV=nv.MANV   ";
            cmd.CommandText = "select ROW_NUMBER() OVER (ORDER BY mK.TENMAYTINH) AS STT, mk.TENMAYTINH as[Tên máy], tv.TENTAIKHOAN as[Tài khoản],cts.giobatdau as [Giờ bắt đầu],cts.gioketthuc as [Giờ kết thúc], CAST(DATEDIFF(MINUTE, cts.GIOBATDAU, CTS.GIOKETTHUC) / 60 AS VARCHAR(2)) + ':' +RIGHT('0' + CAST(DATEDIFF(MINUTE, cts.GIOBATDAU, CTS.GIOKETTHUC) % 60 AS VARCHAR(2)), 2) AS [Thời gian],( round(p.SOTIEN*DATEDIFF(MINUTE, cts.GIOBATDAU, CTS.GIOKETTHUC)/60,-3))  as [Số tiền]\r\nfrom MAYKHACH mk join CTSUDUNG cts on mk.MAMT=cts.MAMT join THANHVIEN tv on tv.MATAIKHOAN=cts.MATAIKHOAN join PHONG p on p.MAPHONG=mk.MAPHONG\r\nwhere cts.GIOBATDAU between '" + year.ToString() + " - " + month.ToString() + "-" + day.ToString() + "' and '" + year1.ToString() + "-" + month1.ToString() + "-" + day1.ToString() + "' and (mk.TENMAYTINH like N'"+txttimkiem.Text+"%'  or tv.TENTAIKHOAN like N'"+txttimkiem.Text+"%' )";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvphongmay.DataSource = table;
        }
        void loadmathangchopv()
        {
            //load mặt hàng
            cmd = con.CreateCommand();
            cmd.CommandText = "select hd.MAHD,mk.TENMAYTINH as [Máy tính], mn.TENHANG as [Dịch vụ] , ct.SOLUONG as [Số lượng] from CTHOADON ct join HOADON hd on ct.MAHD=hd.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG = ct.MAHANG where hd.TrangthaiTT like 'Chua phuc vu'"; 
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dvgDichVuCho.DataSource = table;
            cmd = con.CreateCommand();
            cmd.CommandText = "select mk.TENMAYTINH as [Máy tính], mn.TENHANG as [Dịch vụ] , ct.SOLUONG as [Số lượng] from CTHOADON ct join HOADON hd on ct.MAHD=hd.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG = ct.MAHANG where hd.TrangthaiTT like 'Chua phuc vu'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dgvchodv.DataSource = table;

        }
        void loaddivuvuct()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select hd.MAHD,FORMAT(hd.NGAY, 'yyyy-MM-dd HH:mm:ss') as [Thời gian],mk.TENMAYTINH as [Máy tính], mn.TENHANG as [Dịch vụ], ct.SOLUONG as [Số lượng], mn.DONGIA as [Đơn giá], ct.SOLUONG*mn.DONGIA as [Thành tiền] from CTHOADON ct join HOADON hd on ct.MAHD=hd.MAHD join MAYKHACH mk on mk.MAMT=hd.MAMT join MENU mn on mn.MAHANG = ct.MAHANG where hd.TrangthaiTT='Chua thanh toan'";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dvgDichVuCT.DataSource = table;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQNDataSet3.MAYKHACH' table. You can move, or remove it, as needed.
            this.mAYKHACHTableAdapter.Fill(this.qLQNDataSet3.MAYKHACH);
            // TODO: This line of code loads data into the 'qLQNDataSet1.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.qLQNDataSet1.PHONG);
            con = new SqlConnection(str);
            con.Open();
            loadthanhvien();
            loadaddmoney();
            loadmathangchopv();
            loaddivuvuct();
            loadmaytram();
            loadthucan();
            datetimenkt.Value = now;
            label20.Visible = false;
            txttimkiem.Visible = false;
/*            Properties.Settings.Default.MaHD = 10; 
             Properties.Settings.Default.Save();
            Properties.Settings.Default.Landau = true;
            Properties.Settings.Default.Save();*/
            // loadthongkenaptien();
        }
        private void StopTimer()
        {
            timerphut.Stop();
        }
        int ttdichvu = 1;
        void loadthucan()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select Tenhang,SOLUONGTON AS [Số lượng còn],DVT, Dongia from MENU mn join LOAIHANG lh on mn.MALOAIHANG = lh.MALOAIHANG where LH.MALOAIHANG='ML01' and (TENHANG like N'%"+txttk.Text+"%' or SOLUONGTON like '%"+txttk.Text+"%' or DVT like '%"+txttk.Text+"%' or DONGIA like '%"+txttk.Text+"%')";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dvgDichVu1.DataSource = table;
        }
        private void txttk_TextChanged(object sender, EventArgs e)
        {
            if (ttdichvu == 1)
            {
                loadthucan();
            }
            else
            {
                loadnuocuong();
            }    
        }
        private void btnthucan_Click(object sender, EventArgs e)
        {
            loadthucan();
            ttdichvu = 1;
        }
        void loadnuocuong()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select Tenhang, SOLUONGTON AS [Số lượng còn],DVT, Dongia from MENU mn join LOAIHANG lh on mn.MALOAIHANG = lh.MALOAIHANG where LH.MALOAIHANG='ML02' and (TENHANG like N'%"+txttk.Text+"%' or SOLUONGTON like '%"+txttk.Text+"%' or DVT like '%"+txttk.Text+"%' or DONGIA like '%"+txttk.Text+"%')";
            adapter.SelectCommand = cmd;
            table = new DataTable();
            adapter.Fill(table);
            dvgDichVu1.DataSource = table;

        }
        private void btnnuocuong_Click(object sender, EventArgs e)
        {
            loadnuocuong();
            ttdichvu = 2;
        }
        DataTable tablemaytram;
        void loadmaytram()
        {
            tablemaytram = new DataTable();
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT TENMAYTINH as [Tên máy tính], TRANGTHAI As [Trạng thái] from MAYKHACH";
            adapter.SelectCommand = cmd;
            adapter.Fill(tablemaytram);
            tablemaytram.Columns.Add("Tài khoản", typeof(string));
            tablemaytram.Columns.Add("Bắt đầu", typeof(string));
            tablemaytram.Columns.Add("Số phút", typeof(int));
            tablemaytram.Columns.Add("Còn lại", typeof(string));

            //tablemaytram.Rows[2][2] = "VuWibu";
/*            DateTime now = DateTime.Now;
            for (int i = 0; i <= table.Rows.Count - 1; i++)
                tablemaytram.Rows[i][2] = now.ToString("HH:mm");*/
            dgvmaytram.DataSource = tablemaytram;
        }
        int conlai = 0;
        int temptong = 0;
        void Nhandulieu(int hang)
        {

            if (dgvmaytram.Rows[hang].Cells[1].Value.ToString()=="DANG SU DUNG")
            {
                dgvmaytram.Rows[hang].Cells[3].Value = now.ToString("HH:mm");
                dgvmaytram.Rows[hang].Cells[4].Value = 0;
                cmd = con.CreateCommand();
                cmd.CommandText = "select TENTAIKHOAN,SOTIENHIENCO from THANHVIEN WHERE TENTAIKHOAN='" + dgvmaytram.Rows[hang].Cells[2].Value.ToString() + "'";
                int sotien = 0;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sotien = Convert.ToInt32(reader["SOTIENHIENCO"].ToString()); 
                        
                        // lấy số tiền trong tài khoản
                    }
                }
                //vì liên quan đến int nên thực hiện câu lệnh nó khác 1 tí
                cmd = new SqlCommand("select ROUND(CAST(@sotien AS float) / SOTIEN * 60, 0) AS [Tổng giờ] from MAYKHACH mk join PHONG p on mk.MAPHONG=p.MAPHONG  where mk.TENMAYTINH='" + dgvmaytram.Rows[hang].Cells[0].Value.ToString() + "'", con);
                cmd.Parameters.AddWithValue("@sotien", sotien);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        conlai = Convert.ToInt32(reader["Tổng giờ"].ToString());  // lấy giờ còn lại từ hội viên 
                        //ví dụ có 30000 mà phòng vip là 10000 thì tổng phút là 180 tao đặt tên biến là còn lại =))
                    }
                }
                temptong = conlai; // để giữ tổng giờ thôi lúc này phần còn lại vẫn chưa chạy
                timerphut.Start();
                foreach (Socket item in clientlist)
                {
                    SendTime(item,temptong,0,conlai);
                }
                dgvmaytram.Rows[hang].Cells[5].Value = conlai.ToString();
            }
            
        }
        private void timerphut_Tick(object sender, EventArgs e)
        {
            UpdateUsageTime();
        }

        private void UpdateUsageTime()
        {
            for (int i = 0; i < dgvmaytram.Rows.Count - 1; i++)
            {
                if (dgvmaytram.Rows[i].Cells[1].Value.ToString() == "DANG SU DUNG")
                {
                    UpdateTimeValues(i);
                    UpdateRemainingTime();
                    SendTimeToClients(i);
                }
            }
        }

        private void UpdateTimeValues(int rowIndex)
        {
            if (dgvmaytram.Rows[rowIndex].Cells[4].Value != null)
            {
                if (int.TryParse(dgvmaytram.Rows[rowIndex].Cells[4].Value.ToString(), out int phut))
                {
                    phut++;
                    dgvmaytram.Rows[rowIndex].Cells[4].Value = phut;
                    conlai = conlai - 1;
                    dgvmaytram.Rows[rowIndex].Cells[5].Value = conlai;
                }
                else
                {
                    // Handle the case where the value cannot be converted to an integer.
                    // You may log an error, display a message, or take appropriate action.
                }
            }
            else
            {
                // Handle the case where the cell value is null.
                // You may log an error, display a message, or take appropriate action.
            }
        }


        private void UpdateRemainingTime()
        {
            // Add any additional logic related to updating remaining time if needed.
        }

        private void SendTimeToClients(int rowIndex)
        {
            foreach (Socket item in clientlist)
            {
                if (dgvmaytram.Rows[rowIndex].Cells[4].Value != null)
                {
                    if (int.TryParse(dgvmaytram.Rows[rowIndex].Cells[4].Value.ToString(), out int phut))
                    {
                        SendTime(item, temptong, phut, conlai);
                    }
                    else
                    {
                        // Handle the case where the value cannot be converted to an integer.
                        // You may log an error, display a message, or take appropriate action.
                    }
                }
                else
                {
                    // Handle the case where the cell value is null.
                    // You may log an error, display a message, or take appropriate action.
                }
            }
        }



        private void dgvmaytram_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

/*                // Tăng thời gian hiện tại lên 1 phút.
                startTime = startTime.AddMinutes(1);

                // Chuyển đổi thời gian hiện tại thành định dạng "00:00".
                tablemaytram.Rows[1][3] = startTime.ToString("HH:mm");

            // Gán giá trị định dạng thời gian cho ô cột "Bắt đầu" của hàng hiện tại.
                dgvmaytram.DataSource = tablemaytram;*/
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ShowDialog();
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            computer.ShowDialog();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
            Environment.Exit(0);
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void bảngGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangGia bangGia = new BangGia();
            bangGia.ShowDialog();
        }
        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang loaihang = new LoaiHang();
            loaihang.ShowDialog();
        }
        private void cTSUDUNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiHang loaihang = new LoaiHang();
            loaihang.ShowDialog();
        }
        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.ShowDialog();
        }
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOADON hoadon = new HOADON();
            hoadon.ShowDialog();
        }
        private void cTHOADONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTHOADON hoadon = new CTHOADON();
            hoadon.ShowDialog();
        }



        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Phần kết nối mạng 
        /// </summary>
        /*private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientlist)
            {
                Send(item);
            }
            addmess(txtmess.Text);
            txtmess.Clear();
        }*/
        
        IPEndPoint IP;
        Socket server;
        List<Socket> clientlist;
        void Connect()
        {
            clientlist = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP); // ĐANG ĐỢI
            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientlist.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                        IPEndPoint remoteEndPoint = (IPEndPoint)client.RemoteEndPoint;
                        string clientIP = remoteEndPoint.Address.ToString();
                        int clientPort = remoteEndPoint.Port;
                        //MessageBox.Show($"Địa chỉ IP của Client là {clientIP}, cổng là {clientPort}.");
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }

            });
            listen.IsBackground = true;
            listen.Start();

        }
        void close()
        {
            server.Close();
        }
        void SendTime(Socket client,int tongthoigian,int sudung,int conlai)
        {
            string text = "Thoigian" + "," + tongthoigian.ToString()+","+sudung.ToString()+","+conlai.ToString();
            client.Send(Serialize(text));
        }
        List<string> listmahd = new List<string>(); // cách tù nhất để bỏ qua lỗi vì không có thời gian
        List<string> listmamh = new List<string>();
        List<string> listsoluong = new List<string>();
        string tamthoi = "";
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    string temp = message.Split(',')[0];
                    if (temp == "MÁY 1")
                    {
                        Tenmay = temp;
                        trangthai = message.Split(',')[1];
                        Taikhoan = message.Split(',')[2];
                        for (int i = 0; i < dgvmaytram.Rows.Count - 1; i++)
                        {
                            if (dgvmaytram.Rows[i].Cells[0].Value.ToString() == Tenmay)
                            {
                                dgvmaytram.Rows[i].Cells[1].Value = trangthai;
                                dgvmaytram.Rows[i].Cells[2].Value = Taikhoan;
                                dgvmaytram.DataSource = tablemaytram;
                                Nhandulieu(i);
                            }
                        }
                    }
                   

                    if (temp=="HOADON")
                    {
                        DateTime currentDate = DateTime.Now;
                        string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd hh:mm:ss");
                        Sohoadon = Properties.Settings.Default.MaHD;
                        string mahoadon = "HD";
                        if (Sohoadon < 10)
                        {
                            mahoadon = mahoadon + "0" + Sohoadon.ToString();
                        }
                        else
                        {
                            mahoadon = mahoadon + Sohoadon.ToString();
                        }
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into HOADON values ('" + mahoadon + "','MAY1','NV01','Chua phuc vu','" + sqlFormattedDate + "')";
                        cmd.ExecuteNonQuery();
                        tamthoi = mahoadon;  
                        Properties.Settings.Default.MaHD = ++Sohoadon;
                        Properties.Settings.Default.Save();
                    }
                    
                    if (temp == "CTHoadon")
                    {
                        /*string tam = message.Split(',')[1];
                        Properties.Settings.Default.MaHD = int.Parse(tam); // lưu vĩnh viễn mã hóa đơn
                        Properties.Settings.Default.Save();*/
                        string mamh = message.Split(',')[1];
                        string soluong = message.Split(',')[2];
                        listmahd.Add(tamthoi);
                        listmamh.Add(mamh);
                        listsoluong.Add(soluong);
                        
                        /*cmd = con.CreateCommand();
                        cmd.CommandText = "insert into CTHOADON values('HD05','" + mamh + "','" + soluong + "',0,'Chua phuc vu')";
                        cmd.ExecuteNonQuery();*/
                    }    
                }
            }
            catch (Exception)
            {
                clientlist.Remove(client);
                //cần sửa
                client.Close();
            }

        }
        /// <summary>
        /// Phân mảnh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] Serialize(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
          
        }
        /// <summary>
        /// gom mảnh lại
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                return formatter.Deserialize(stream);
            }
            
        }

        private void btnthemmenu_Click(object sender, EventArgs e)
        {
            ThemMenu themmenu = new ThemMenu();
            themmenu.ShowDialog();
        }
        int hangdichvu;
        private void btnsuaM_Click(object sender, EventArgs e)
        {
            try
            {
                SuaMenu suaMenu = new SuaMenu(dvgDichVu1.Rows[hangdichvu].Cells[0].Value.ToString(), dvgDichVu1.Rows[hangdichvu].Cells[1].Value.ToString(), dvgDichVu1.Rows[hangdichvu].Cells[2].Value.ToString(), dvgDichVu1.Rows[hangdichvu].Cells[3].Value.ToString(), dvgDichVu1.Rows[hangdichvu].Cells[4].Value.ToString());
                suaMenu.ShowDialog();
            }
            catch {
                MessageBox.Show("Vui lòng chọn dịch vụ để sửa");
            }
            

        }
        int hangdichvuct = 99;
        private void dvgDichVuCT_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            hangdichvuct  = dvgDichVuCT.CurrentRow.Index;
        }
        private void btnxuatM_Click(object sender, EventArgs e)
        {
            if (hangdichvuct < dvgDichVuCT.Rows.Count - 1)
            {
                FrmInhoadon xuatmenu = new FrmInhoadon(dvgDichVuCT.Rows[hangdichvuct].Cells[2].Value.ToString());
                xuatmenu.ShowDialog();
                loaddivuvuct();
            }
               
        }

        private void dvgDichVu1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hangdichvu = dvgDichVu1.CurrentRow.Index;
        }

        private void btnxoaM_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from menu where TENHANG = '" + dvgDichVu1.Rows[hangdichvu].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công ");
                loadthucan();
                loadnuocuong();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn danh mục để xóa ");
            }
            
           
        }
        private string previousValue;

        private void cbbcacmay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dvgDichVuCho.RowCount > 1)
            {
                MessageBox.Show("cái bảng tạm bạn chưa chọn xong kìa bạn ơi");
            }
            /*else
            {
                MessageBox.Show("cc");
                previousValue = cbbcacmay.SelectedItem.ToString();
            }    */
        }
        bool landau;
        private void btnchon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbcacmay.Text) && !string.IsNullOrEmpty(txtsoluongmaydat.Text))
            {
                DateTime currentDate = DateTime.Now;
                string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd hh:mm:ss");
                landau = Properties.Settings.Default.Landau;
                Sohoadon = Properties.Settings.Default.MaHD; // số hóa đơn 6 7 
                string mahoadon = "HD"; // Gán HD
                if (Sohoadon < 10)
                {
                    mahoadon = mahoadon + "0" + Sohoadon.ToString(); //HD + 0 + 9
                }
                else
                {
                    mahoadon = mahoadon + Sohoadon.ToString(); // HD + 10
                }
                if (landau==true)
                {
                    cmd = con.CreateCommand();
                    cmd.CommandText = "insert into HOADON values ('" + mahoadon + "','" + cbbcacmay.Text + "','NV01','Chua phuc vu','" + sqlFormattedDate + "')";
                    cmd.ExecuteNonQuery();
                }
                landau = false;
                Properties.Settings.Default.Landau = landau; 
                Properties.Settings.Default.Save();
             /*   MessageBox.Show(tempmay1);
                MessageBox.Show(tempmay2);
                MessageBox.Show(mahoadon);*/

                if (hangdichvu < dvgDichVu1.Rows.Count - 1)
                {

                    string mamh = "";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "select mahang from menu WHERE tenhang=N'" + dvgDichVu1.Rows[hangdichvu].Cells[0].Value.ToString() + "'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mamh = reader["mahang"].ToString();

                        }
                    }
                    bool trungten=false;
                    string mahd = "";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "select hd.MAHD as mahd from HOADON hd join CTHOADON ct on hd.MAHD = ct.MAHD where hd.TRANGTHAITT = 'Chua phuc vu' and CT.MAHANG = '"+ mamh + "' and CT.MAHD = '"+mahoadon+"'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mahd = reader["mahd"].ToString();
                            trungten = true;
                        }
                    }
                    if (trungten == true)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "update CTHOADON set SOLUONG = SOLUONG +" + int.Parse(txtsoluongmaydat.Text) + " where MAHD = '" + mahoadon + "' and MAHANG = '" + mamh + "'";
                        cmd.ExecuteNonQuery();

                    }
                    if (trungten == false)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "insert into CTHOADON values('" + mahoadon + "','" + mamh + "'," + txtsoluongmaydat.Text + ",0)";
                        cmd.ExecuteNonQuery();
                    }
                    loadmathangchopv();
                    loaddivuvuct();
                    string tenloaihang="";
                    cmd = con.CreateCommand();
                    cmd.CommandText = "select TENLOAIHANG from LOAIHANG lh join MENU m on m.MALOAIHANG=lh.MALOAIHANG where m.MAHANG='" + mamh + "'";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tenloaihang = reader["TENLOAIHANG"].ToString();
                        }
                    }
                    if(tenloaihang=="Đồ ăn")
                    {
                        loadthucan();
                    }
                    else
                    {
                        loadnuocuong();
                    }    
                  
                   
                }
               
                /*  if (dvgDichVuCho.Rows[dvgDichVuCho.Rows.Count].Cells[0].Value.ToString() == mahoadon && dvgDichVuCho.Rows[dvgDichVuCho.Rows.Count].Cells[0].Value.ToString() != null)
                   {
                       for (int i = 1; i < dvgDichVuCho.Rows.Count; i++)
                       {
                           if (dvgDichVuCho.Rows[i].Cells[2].Value != null)
                           {
                               MessageBox.Show(dvgDichVuCho.Rows[i].Cells[0].Value.ToString());
                               MessageBox.Show(dvgDichVuCho.Rows[i - 1].Cells[0].Value.ToString());
                           }
                           if (dvgDichVuCho.Rows[i].Cells[2].Value != null && dvgDichVu1.Rows[hangdichvu].Cells[0].Value != null && dvgDichVuCho.Rows[i].Cells[2].Value.ToString() == dvgDichVu1.Rows[hangdichvu].Cells[0].Value.ToString())
                           {

                           }

                       }
                   }*/
            }
        }
        private void btndat_Click(object sender, EventArgs e)
        {
            if (hangchophucvu < dvgDichVuCho.Rows.Count - 1)
            {
                Sohoadon = Properties.Settings.Default.MaHD;
                Properties.Settings.Default.MaHD = ++Sohoadon; // Thay đổi giá trị thành "8"
                Properties.Settings.Default.Save();
                cmd = con.CreateCommand();
                cmd.CommandText = "update HOADON SET NGAY = GETDATE() , TRANGTHAITT='Chua thanh toan'  where MAHD = '" + dvgDichVuCho.Rows[hangchophucvu].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                loadmathangchopv();
                loaddivuvuct();
                landau = true;
                Properties.Settings.Default.Landau = landau; 
                Properties.Settings.Default.Save();
            }
        }
        int hangchophucvu;
        private void dvgDichVuCho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hangchophucvu = dvgDichVuCho.CurrentRow.Index;
        }
        int hangmaytram;
    

        private void nạpTiềnToolStripMenuItem_Click(object sender, EventArgs e) // phần này đang rối không nên thử
        {
            //!String.IsNullOrEmpty(dgvmaytram.Rows[i].Cells[2].Value?.ToString()) để kiểm tra xem có null hay không chatgpt nó cho đấy
            if (hangmaytram < dgvmaytram.Rows.Count - 1 && !String.IsNullOrEmpty(dgvmaytram.Rows[hangmaytram].Cells[2].Value?.ToString()))
            {
                Frmcapnhap frmcapnhap = new Frmcapnhap(dgvmaytram.Rows[hangmaytram].Cells[2].Value.ToString(),temptong,dgvmaytram.Rows[hangmaytram].Cells[4].Value.ToString(), dgvmaytram.Rows[hangmaytram].Cells[5].Value.ToString());
                frmcapnhap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản có đâu mà nạp?");
            }    
        }

        private void trảTiềnTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hangmaytram < dgvmaytram.Rows.Count - 1 && dgvmaytram.Rows[hangmaytram].Cells[1].Value.ToString()=="DANG SU DUNG")
            {
                Frmcapnhap frmcapnhap = new Frmcapnhap("User", temptong, dgvmaytram.Rows[hangmaytram].Cells[4].Value.ToString(), dgvmaytram.Rows[hangmaytram].Cells[5].Value.ToString());
                frmcapnhap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Máy chưa mở mà?");
            }
        }
        int i;
        private void dgvthanhivien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = dgvthanhivien.CurrentRow.Index;

            if (e.Button == MouseButtons.Right)
            {
                dgvthanhivien.ContextMenuStrip = ctmshoivien;
            }
        }

        private void nạpTiềnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (i < dgvthanhivien.Rows.Count - 1)
            {
                cmd = new SqlCommand("select ROUND(CAST(SOTIENHIENCO AS float) / 8000 * 60, 0) as [Tổng giờ] from THANHVIEN tv where tv.TENTAIKHOAN ='" + dgvthanhivien.Rows[i].Cells[0].Value.ToString() + "'", con);
                int tong=0;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tong = Convert.ToInt32(reader["Tổng giờ"].ToString());  // lấy giờ còn lại từ hội viên 
                        // khi nạp vào tài khoản thì mặc định là 8000
                    }
                }
                Frmcapnhap frmcapnhap = new Frmcapnhap(dgvthanhivien.Rows[i].Cells[0].Value.ToString(), tong,"0", dgvthanhivien.Rows[i].Cells[2].Value.ToString(), dgvthanhivien.Rows[i].Cells[3].Value.ToString());
                frmcapnhap.ShowDialog();
                loadthanhvien();
                loadaddmoney();
            }
            else
            {
                MessageBox.Show("Tài khoản có đâu mà nạp?");
            }
        }
        public void themgio(double themgio)
        {
            temptong += Convert.ToInt32(themgio);
            conlai += Convert.ToInt32(themgio);
            dgvmaytram.Rows[i].Cells[5].Value = conlai;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtngay_Click(object sender, EventArgs e)
        {

        }

        private void txtthang_Click(object sender, EventArgs e)
        {

        }

        private void txtnam_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            loadthongkenaptien();
            loadthongkemathang();
            loadthongkedoanhso();
            loadthongkephongmay();
            int tong;
            if (string.IsNullOrEmpty(txtdoanhthu.Text))
                txtdoanhthu.Text = "0";
            if (string.IsNullOrEmpty(txttongtien.Text)) { txttongtien.Text = "0";}
            tong = int.Parse(txtdoanhthu.Text) + int.Parse(txttongtien.Text);
            txttongtiendoanhthu.Text = tong.ToString();
        }
        private void dgvmaytram_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            hangmaytram = dgvmaytram.CurrentRow.Index;

            if (e.Button == MouseButtons.Right)
            {
                dgvmaytram.ContextMenuStrip = ctms;
            }
            }
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "update HOADON\r\nset TRANGTHAITT='Da thanh toan'\r\nFROM HOADON hd join MAYKHACH mk on mk.MAMT = hd.MAMT \r\nwhere TENMAYTINH = '"+ dgvmaytram.Rows[hangmaytram].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            loaddivuvuct();
        }

        private void btnthemtv_Click(object sender, EventArgs e)
        {
            FrmThemTaiKhoan frmThemTaiKhoan = new FrmThemTaiKhoan();
            frmThemTaiKhoan.ShowDialog();
            loadthanhvien();
            loadaddmoney();
        }

        private void btnsuatv_Click(object sender, EventArgs e)
        {
            if (i < dgvthanhivien.Rows.Count - 1)
            {
                cmd = new SqlCommand("select ROUND(CAST(SOTIENHIENCO AS float) / 8000 * 60, 0) as [Tổng giờ] from THANHVIEN tv where tv.TENTAIKHOAN ='" + dgvthanhivien.Rows[i].Cells[0].Value.ToString() + "'", con);
                int tong = 0;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tong = Convert.ToInt32(reader["Tổng giờ"].ToString());  // lấy giờ còn lại từ hội viên 
                        // khi nạp vào tài khoản thì mặc định là 8000
                    }
                }
                Frmcapnhap frmcapnhap = new Frmcapnhap(dgvthanhivien.Rows[i].Cells[0].Value.ToString(), tong, "0", dgvthanhivien.Rows[i].Cells[2].Value.ToString(), dgvthanhivien.Rows[i].Cells[3].Value.ToString());
                frmcapnhap.ShowDialog();
                loadthanhvien();
                loadaddmoney();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!");
            }
        }

        private void btnxoatv_Click(object sender, EventArgs e)
        {
            if (i < dgvthanhivien.Rows.Count - 1)
            {
                string mataikhoan="";
                cmd = con.CreateCommand();
                cmd.CommandText = "select mataikhoan from THANHVIEN where TENTAIKHOAN='"+ dgvthanhivien.Rows[i].Cells[0].Value.ToString() + "'";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mataikhoan = reader["mataikhoan"].ToString();

                        // lấy số tiền trong tài khoản
                    }
                }
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from NAPTIEN where MATAIKHOAN='"+mataikhoan+"'";
                cmd.ExecuteNonQuery();
                cmd = con.CreateCommand();
                cmd.CommandText = "delete from THANHVIEN where TENTAIKHOAN='"+ dgvthanhivien.Rows[i].Cells[0].Value.ToString() + "'";
                cmd.ExecuteNonQuery();
                loadthanhvien();
            }
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            while (listmahd.Count > 0)
            {
                // Lấy phần tử đầu tiên từ danh sách
                string mahoadon = listmahd[0];
                string mamh = listmamh[0];
                string soluong = listsoluong[0];

                // Xóa phần tử đầu tiên khỏi danh sách
                listmahd.Remove(mahoadon);
                listmamh.Remove(mamh);
                listsoluong.Remove(soluong);

                // In ra phần tử vừa lấy
                cmd = con.CreateCommand();
                cmd.CommandText = "insert into CTHOADON values('" + mahoadon + "','" + mamh + "','" + soluong + "',0)";
                cmd.ExecuteNonQuery();
            }
            loadmathangchopv();
        }
        private void Menu_MouseClick(object sender, MouseEventArgs e)
        {
            loadmathangchopv();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dgvnaptien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvmathang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                label20.Visible = false;
                txttimkiem.Visible = false;
                txttimkiem.Clear();
            }
            else
            {
                label20.Visible = true;
                txttimkiem.Visible = true;
            }    
        }

        private void txtctnaptien_TextChanged(object sender, EventArgs e)
        {
            loadthongkenaptien();     
        }

        private void txtmathang_TextChanged(object sender, EventArgs e)
        {
            loadthongkemathang();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            loadthongkedoanhso();
            loadthongkephongmay();
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*essageBox.Show("")*/
        }














        //test
        /* private void dvgDichVuCT_CellLeave(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex >= 0)
             {
                 dvgDichVuCT.Rows[e.RowIndex].Selected = false;
             }

         }

         private void dvgDichVuCT_CellEnter(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex >= 0)
             {
                 dvgDichVuCT.Rows[e.RowIndex].Selected = true;
             }
         }*/
    }
}
