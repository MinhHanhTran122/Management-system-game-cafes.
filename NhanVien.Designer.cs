namespace QUANLYQUANNET
{
    partial class NhanVien
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.cbbcv = new System.Windows.Forms.ComboBox();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.kHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.qLQNDataSet = new QUANLYQUANNET.QLQNDataSet();
            this.cHUCVUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter1 = new QUANLYQUANNET.QLQNDataSetTableAdapters.CHUCVUTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(42, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(19, 21);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.ReadOnly = true;
            this.dgvnhanvien.RowHeadersVisible = false;
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhanvien.Size = new System.Drawing.Size(913, 269);
            this.dgvnhanvien.TabIndex = 0;
            this.dgvnhanvien.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvnhanvien_CellMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtluong);
            this.groupBox2.Controls.Add(this.cbbcv);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtcmnd);
            this.groupBox2.Controls.Add(this.txtgioitinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtngaysinh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtmanv);
            this.groupBox2.Controls.Add(this.txttennv);
            this.groupBox2.Location = new System.Drawing.Point(42, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 244);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Lương";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(449, 197);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(111, 22);
            this.txtluong.TabIndex = 25;
            // 
            // cbbcv
            // 
            this.cbbcv.DataSource = this.cHUCVUBindingSource1;
            this.cbbcv.DisplayMember = "TENCV";
            this.cbbcv.FormattingEnabled = true;
            this.cbbcv.Location = new System.Drawing.Point(705, 33);
            this.cbbcv.Name = "cbbcv";
            this.cbbcv.Size = new System.Drawing.Size(121, 24);
            this.cbbcv.TabIndex = 22;
            this.cbbcv.ValueMember = "TENCV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "CMND";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.Location = new System.Drawing.Point(449, 138);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(111, 24);
            this.txtcmnd.TabIndex = 20;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.FormattingEnabled = true;
            this.txtgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.txtgioitinh.Location = new System.Drawing.Point(94, 139);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(121, 24);
            this.txtgioitinh.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã NV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ";
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Location = new System.Drawing.Point(449, 29);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(111, 24);
            this.txtngaysinh.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giới tính";
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(449, 85);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(147, 24);
            this.txtsdt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(637, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chức vụ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(94, 196);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(240, 24);
            this.txtdiachi.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điện thoại";
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(94, 29);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(111, 24);
            this.txtmanv.TabIndex = 1;
            // 
            // txttennv
            // 
            this.txttennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennv.Location = new System.Drawing.Point(94, 83);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(166, 24);
            this.txttennv.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(916, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(916, 449);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 40);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(916, 511);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 40);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(916, 573);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 40);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // qLQNDataSet
            // 
            this.qLQNDataSet.DataSetName = "QLQNDataSet";
            this.qLQNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHUCVUBindingSource1
            // 
            this.cHUCVUBindingSource1.DataMember = "CHUCVU";
            this.cHUCVUBindingSource1.DataSource = this.qLQNDataSet;
            // 
            // cHUCVUTableAdapter1
            // 
            this.cHUCVUTableAdapter1.ClearBeforeFill = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 634);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.ComboBox txtgioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.ComboBox cbbcv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private System.Windows.Forms.BindingSource kHUBindingSource;
        private QLQNDataSet qLQNDataSet;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource1;
        private QLQNDataSetTableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter1;
    }
}