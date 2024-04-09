using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Reflection.Emit;

namespace ClientNet
{
    public partial class May1 : Form
    {
        string Tk;
        public May1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        Dangnhap dangnhap;

        private void May1_Load(object sender, EventArgs e)
        {
            dangnhap = new Dangnhap();
            dangnhap.ShowDialog();
            client.Send(Serialize("MÁY 1,DANG SU DUNG,"+Tk.ToString()));
/*            Properties.Settings.Default.MaHD = 200; // Thay đổi giá trị thành "8"
            Properties.Settings.Default.Save();*/
        }
        public void SetValue(string tk)
        {
            Tk = tk;
        }
        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối Server", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }
        void close()
        {
            client.Close();
        }
        string Doithoigian(int tong) // dạng 00:00
        {
            string text;
            int gio;
            gio = tong / 60; // lấy giờ
            tong = tong % 60; // lấy phút
            string temp = (tong < 10) ? "0" + tong.ToString() : tong.ToString(); // đổi phần :00
            text = (gio < 10) ? "0" + gio.ToString()+":"+ temp : gio.ToString()+ ":"+ temp; // đổi phần 00:
            return text;

        }
        int Doithoigiannhucu(string text) //dạng phút 03:00 thành 180 phút
        {
            string input = text;
            int hour = int.Parse(input.Split(':')[0]); // lấy giờ
            int minute = int.Parse(input.Split(':')[1]); // lấy phút
            int totalMinutes = hour * 60 + minute;
            return totalMinutes;

        }
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    string temp = message.Split(',')[0];
                    if (temp=="NapTien")
                    {
                        int tong = Convert.ToInt32(Doithoigiannhucu(txttong.Text));
                        int tong2= int.Parse(message.Split(',')[1]);
                        tong = tong + tong2;
                    }   
                    if(temp=="Thoigian")
                    {
                        int tong = int.Parse(message.Split(',')[1]);
                        txttong.Text = Doithoigian(tong);
                        int phut = int.Parse(message.Split(',')[2]);
                        txtsudung.Text = Doithoigian(phut);
                        int conlai = int.Parse(message.Split(',')[3]);
                        txtconlai.Text = conlai.ToString();
                    }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                close();
            }

        }
      /*  void addmess(string s)
        {
            lsvmess.Items.Add(new ListViewItem() { Text = s });
            txtmess.Clear();
        }*/
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

        private void May1_Click(object sender, EventArgs e)
        {
        }

        private void btndichvu_Click(object sender, EventArgs e)
        {
            Dichvu dichvu = new Dichvu();
            dichvu.ShowDialog();
        }

        public void GuiHoaDon()
        {
            client.Send(Serialize("HOADON"));
        }
        public void GuiCTHoaDon(string mamh,string soluong)
        {
            client.Send(Serialize("CTHoadon," + mamh +","+soluong));
        }
    }
  
}
