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
    public partial class Dichvu : Form
    {
        int mi = 0;
        int com = 0;
        int up = 0;
        int coca = 0;
        int caphe = 0;
        int gai = 0;
        SqlConnection con;
        SqlCommand cmd;
        string str = "Data Source=HOANGSON\\SQLEXPRESS;Initial Catalog=QLQN;Integrated Security=True;MultipleActiveResultSets=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        public Dichvu()
        {
            InitializeComponent();
            con = new SqlConnection(str);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if(mi > 0)
            {
                mi++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "Mì trứng")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = mi.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                mi++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "Mì trứng";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, mi.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "10000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (com > 0)
            {
                com++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "Cơm chiên")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = com.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                com++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "Cơm chiên";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, com.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "20000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (coca > 0)
            {coca++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "Coca")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = coca.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                coca++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "Coca";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, coca.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "7000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (up > 0)
            {
                up++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "7up")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = up.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                up++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "7up";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, up.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "7000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (caphe > 0)
            {caphe++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "Cà phê")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = caphe.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                caphe++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "Cà phê";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, caphe.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "12000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gai > 0)
            {
                gai++;
                foreach (ListViewItem item in listView1.Items)
                {
                    // Sử dụng phương thức SubItems để truy xuất đến giá trị của cột trong ListViewItem
                    string name = item.Text;

                    // Kiểm tra tên có khớp với tên bạn muốn sửa không
                    if (name == "Lẩu thái")
                    {
                        // Sử dụng phương thức SubItems để sửa giá trị của cột trong ListViewItem
                        item.SubItems[1].Text = gai.ToString();
                    }
                }
            }
            else
            {
                ListViewItem item = new ListViewItem();
                gai++;
                // Thiết lập giá trị cho cột đầu tiên
                item.Text = "Lẩu thái";
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, gai.ToString());
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, "500000");

                // Thêm các đối tượng ListViewItem.ListViewSubItem vào ListViewItem
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                // Thêm ListViewItem vào ListView
                listView1.Items.Add(item);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (listView1.Items.Count != 0)
            {
                
                May1 Hoadon = (May1)Application.OpenForms["May1"];
                Hoadon.GuiHoaDon();
                foreach (ListViewItem item in listView1.Items)
                {
                    string mamh;
                    if (item.Text == "Mì trứng")
                        mamh = "MH01";
                    else if (item.Text == "Cơm chiên")
                        mamh = "MH02";
                    else if (item.Text == "Coca")
                        mamh = "MH04";
                    else if (item.Text == "7up")
                        mamh = "MH03";
                    else if (item.Text == "Cà phê")
                        mamh = "MH05";
                    else 
                        mamh = "MH06";
                    System.Threading.Thread.Sleep(100); // đợi 1 giây (1000 milliseconds)
                    May1 cthoadon = (May1)Application.OpenForms["May1"];
                    cthoadon.GuiCTHoaDon(mamh, item.SubItems[1].Text);
                   

                }
                this.Close();
            }
               
        }
    }
}
