using System.Windows.Forms;

namespace QUANLYQUANNET
{
    partial class Frmcapnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsotien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconlai = new System.Windows.Forms.TextBox();
            this.txtsudung = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.datetimehh = new System.Windows.Forms.DateTimePicker();
            this.datetimenc = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(112, 21);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(100, 22);
            this.txtsotien.TabIndex = 0;
            this.txtsotien.TextChanged += new System.EventHandler(this.txtsotien_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtconlai);
            this.groupBox1.Controls.Add(this.txtsudung);
            this.groupBox1.Controls.Add(this.txttong);
            this.groupBox1.Controls.Add(this.txtsotien);
            this.groupBox1.Location = new System.Drawing.Point(371, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nạp tiền tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Còn lại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đã sử dụng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tổng số phút:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số tiền:";
            // 
            // txtconlai
            // 
            this.txtconlai.Location = new System.Drawing.Point(112, 156);
            this.txtconlai.Name = "txtconlai";
            this.txtconlai.ReadOnly = true;
            this.txtconlai.Size = new System.Drawing.Size(100, 22);
            this.txtconlai.TabIndex = 3;
            // 
            // txtsudung
            // 
            this.txtsudung.Location = new System.Drawing.Point(112, 108);
            this.txtsudung.Name = "txtsudung";
            this.txtsudung.ReadOnly = true;
            this.txtsudung.Size = new System.Drawing.Size(100, 22);
            this.txtsudung.TabIndex = 2;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(112, 60);
            this.txttong.Name = "txttong";
            this.txttong.ReadOnly = true;
            this.txttong.Size = new System.Drawing.Size(100, 22);
            this.txttong.TabIndex = 1;
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(380, 259);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(83, 35);
            this.btncapnhap.TabIndex = 2;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(500, 259);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(83, 35);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(135, 22);
            this.txttk.Name = "txttk";
            this.txttk.ReadOnly = true;
            this.txttk.Size = new System.Drawing.Size(166, 22);
            this.txttk.TabIndex = 4;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(135, 69);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(166, 22);
            this.txtmk.TabIndex = 5;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(135, 177);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(166, 22);
            this.hoten.TabIndex = 7;
            // 
            // cmnd
            // 
            this.cmnd.Location = new System.Drawing.Point(135, 224);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(166, 22);
            this.cmnd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(132, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nhập mật khẩu mới nếu thay đổi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ngày hết hạn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Họ tên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "CMND:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ngày cấp:";
            // 
            // datetimehh
            // 
            this.datetimehh.CustomFormat = "dd/MM/yyyy";
            this.datetimehh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimehh.Location = new System.Drawing.Point(135, 133);
            this.datetimehh.Name = "datetimehh";
            this.datetimehh.Size = new System.Drawing.Size(166, 22);
            this.datetimehh.TabIndex = 16;
            this.datetimehh.Value = new System.DateTime(2099, 3, 20, 11, 6, 0, 0);
            // 
            // datetimenc
            // 
            this.datetimenc.CustomFormat = "dd/MM/yyyy";
            this.datetimenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimenc.Location = new System.Drawing.Point(135, 272);
            this.datetimenc.Name = "datetimenc";
            this.datetimenc.Size = new System.Drawing.Size(166, 22);
            this.datetimenc.TabIndex = 17;
            this.datetimenc.Value = new System.DateTime(2023, 3, 12, 11, 6, 0, 0);
            // 
            // Frmcapnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 306);
            this.Controls.Add(this.datetimenc);
            this.Controls.Add(this.datetimehh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmcapnhap";
            this.Text = "Cập nhập thông tin thành viên";
            this.Load += new System.EventHandler(this.Frmcapnhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsotien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtconlai;
        private System.Windows.Forms.TextBox txtsudung;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datetimehh;
        private DateTimePicker datetimenc;
    }
}