namespace QUANLYQUANNET
{
    partial class CTHOADON
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvcthoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmhd = new System.Windows.Forms.ComboBox();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet9 = new QUANLYQUANNET.QLQNDataSet9();
            this.cbbmh = new System.Windows.Forms.ComboBox();
            this.mENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet10 = new QUANLYQUANNET.QLQNDataSet10();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmgg = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hOADONTableAdapter = new QUANLYQUANNET.QLQNDataSet9TableAdapters.HOADONTableAdapter();
            this.mENUTableAdapter = new QUANLYQUANNET.QLQNDataSet10TableAdapters.MENUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(610, 9);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 53;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(540, 443);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 39);
            this.btnxoa.TabIndex = 51;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(540, 352);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 39);
            this.btnthem.TabIndex = 50;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(663, 443);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 39);
            this.btnthoat.TabIndex = 49;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(663, 352);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(88, 39);
            this.btncapnhap.TabIndex = 48;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã hàng";
            // 
            // dgvcthoadon
            // 
            this.dgvcthoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcthoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthoadon.Location = new System.Drawing.Point(50, 50);
            this.dgvcthoadon.Name = "dgvcthoadon";
            this.dgvcthoadon.ReadOnly = true;
            this.dgvcthoadon.RowHeadersVisible = false;
            this.dgvcthoadon.RowHeadersWidth = 51;
            this.dgvcthoadon.RowTemplate.Height = 24;
            this.dgvcthoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcthoadon.Size = new System.Drawing.Size(701, 197);
            this.dgvcthoadon.TabIndex = 45;
            this.dgvcthoadon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcthoadon_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã hóa đơn";
            // 
            // cbbmhd
            // 
            this.cbbmhd.DataSource = this.hOADONBindingSource;
            this.cbbmhd.DisplayMember = "MAHD";
            this.cbbmhd.FormattingEnabled = true;
            this.cbbmhd.Location = new System.Drawing.Point(85, 298);
            this.cbbmhd.Name = "cbbmhd";
            this.cbbmhd.Size = new System.Drawing.Size(139, 24);
            this.cbbmhd.TabIndex = 62;
            this.cbbmhd.ValueMember = "MAHD";
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLQNDataSet9;
            // 
            // qLQNDataSet9
            // 
            this.qLQNDataSet9.DataSetName = "QLQNDataSet9";
            this.qLQNDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbmh
            // 
            this.cbbmh.DataSource = this.mENUBindingSource;
            this.cbbmh.DisplayMember = "MAHANG";
            this.cbbmh.FormattingEnabled = true;
            this.cbbmh.Location = new System.Drawing.Point(83, 377);
            this.cbbmh.Name = "cbbmh";
            this.cbbmh.Size = new System.Drawing.Size(141, 24);
            this.cbbmh.TabIndex = 63;
            this.cbbmh.ValueMember = "MAHANG";
            this.cbbmh.SelectedIndexChanged += new System.EventHandler(this.cbbmh_SelectedIndexChanged);
            // 
            // mENUBindingSource
            // 
            this.mENUBindingSource.DataMember = "MENU";
            this.mENUBindingSource.DataSource = this.qLQNDataSet10;
            // 
            // qLQNDataSet10
            // 
            this.qLQNDataSet10.DataSetName = "QLQNDataSet10";
            this.qLQNDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(312, 380);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(140, 22);
            this.txtsoluong.TabIndex = 65;
            // 
            // txtmgg
            // 
            this.txtmgg.Location = new System.Drawing.Point(312, 459);
            this.txtmgg.Name = "txtmgg";
            this.txtmgg.Size = new System.Drawing.Size(140, 22);
            this.txtmgg.TabIndex = 66;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(85, 460);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(140, 22);
            this.txttenhang.TabIndex = 67;
            this.txttenhang.TextChanged += new System.EventHandler(this.txttenhang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mức giảm giá";
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // mENUTableAdapter
            // 
            this.mENUTableAdapter.ClearBeforeFill = true;
            // 
            // CTHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.txtmgg);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.cbbmh);
            this.Controls.Add(this.cbbmhd);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcthoadon);
            this.Name = "CTHOADON";
            this.Text = "CTHOADON";
            this.Load += new System.EventHandler(this.CTHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btncapnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvcthoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmhd;
        private System.Windows.Forms.ComboBox cbbmh;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmgg;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private QLQNDataSet9 qLQNDataSet9;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLQNDataSet9TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QLQNDataSet10 qLQNDataSet10;
        private System.Windows.Forms.BindingSource mENUBindingSource;
        private QLQNDataSet10TableAdapters.MENUTableAdapter mENUTableAdapter;
    }
}