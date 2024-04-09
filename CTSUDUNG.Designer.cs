namespace QUANLYQUANNET
{
    partial class CTSUDUNG
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvctsudung = new System.Windows.Forms.DataGridView();
            this.txtgiobatdau = new System.Windows.Forms.TextBox();
            this.txtgioketthuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtttk = new System.Windows.Forms.TextBox();
            this.txttmt = new System.Windows.Forms.TextBox();
            this.cbbmmt = new System.Windows.Forms.ComboBox();
            this.mAYKHACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet4 = new QUANLYQUANNET.QLQNDataSet4();
            this.cbbmtk = new System.Windows.Forms.ComboBox();
            this.tHANHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet5 = new QUANLYQUANNET.QLQNDataSet5();
            this.mAYKHACHTableAdapter = new QUANLYQUANNET.QLQNDataSet4TableAdapters.MAYKHACHTableAdapter();
            this.tHANHVIENTableAdapter = new QUANLYQUANNET.QLQNDataSet5TableAdapters.THANHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctsudung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYKHACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(599, 12);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 34;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(529, 446);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 39);
            this.btnxoa.TabIndex = 32;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(529, 355);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 39);
            this.btnthem.TabIndex = 31;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(652, 446);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 39);
            this.btnthoat.TabIndex = 30;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(652, 355);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(88, 39);
            this.btncapnhap.TabIndex = 29;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã máy tính";
            // 
            // dgvctsudung
            // 
            this.dgvctsudung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvctsudung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctsudung.Location = new System.Drawing.Point(39, 53);
            this.dgvctsudung.Name = "dgvctsudung";
            this.dgvctsudung.ReadOnly = true;
            this.dgvctsudung.RowHeadersVisible = false;
            this.dgvctsudung.RowHeadersWidth = 51;
            this.dgvctsudung.RowTemplate.Height = 24;
            this.dgvctsudung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvctsudung.Size = new System.Drawing.Size(701, 197);
            this.dgvctsudung.TabIndex = 24;
            this.dgvctsudung.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvctsudung_CellMouseClick);
            // 
            // txtgiobatdau
            // 
            this.txtgiobatdau.Location = new System.Drawing.Point(59, 454);
            this.txtgiobatdau.Name = "txtgiobatdau";
            this.txtgiobatdau.Size = new System.Drawing.Size(171, 22);
            this.txtgiobatdau.TabIndex = 35;
            // 
            // txtgioketthuc
            // 
            this.txtgioketthuc.Location = new System.Drawing.Point(291, 454);
            this.txtgioketthuc.Name = "txtgioketthuc";
            this.txtgioketthuc.Size = new System.Drawing.Size(168, 22);
            this.txtgioketthuc.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Giờ bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Giờ kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tên tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Tên máy tính";
            // 
            // txtttk
            // 
            this.txtttk.Location = new System.Drawing.Point(305, 380);
            this.txtttk.Name = "txtttk";
            this.txtttk.ReadOnly = true;
            this.txtttk.Size = new System.Drawing.Size(141, 22);
            this.txtttk.TabIndex = 40;
            // 
            // txttmt
            // 
            this.txttmt.Location = new System.Drawing.Point(74, 380);
            this.txttmt.Name = "txttmt";
            this.txttmt.ReadOnly = true;
            this.txttmt.Size = new System.Drawing.Size(139, 22);
            this.txttmt.TabIndex = 39;
            // 
            // cbbmmt
            // 
            this.cbbmmt.DataSource = this.mAYKHACHBindingSource;
            this.cbbmmt.DisplayMember = "MAMT";
            this.cbbmmt.FormattingEnabled = true;
            this.cbbmmt.Location = new System.Drawing.Point(72, 306);
            this.cbbmmt.Name = "cbbmmt";
            this.cbbmmt.Size = new System.Drawing.Size(138, 24);
            this.cbbmmt.TabIndex = 43;
            this.cbbmmt.ValueMember = "MAMT";
            this.cbbmmt.SelectedIndexChanged += new System.EventHandler(this.cbbmmt_SelectedIndexChanged);
            // 
            // mAYKHACHBindingSource
            // 
            this.mAYKHACHBindingSource.DataMember = "MAYKHACH";
            this.mAYKHACHBindingSource.DataSource = this.qLQNDataSet4;
            // 
            // qLQNDataSet4
            // 
            this.qLQNDataSet4.DataSetName = "QLQNDataSet4";
            this.qLQNDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbmtk
            // 
            this.cbbmtk.DataSource = this.tHANHVIENBindingSource;
            this.cbbmtk.DisplayMember = "MATAIKHOAN";
            this.cbbmtk.FormattingEnabled = true;
            this.cbbmtk.Location = new System.Drawing.Point(304, 306);
            this.cbbmtk.Name = "cbbmtk";
            this.cbbmtk.Size = new System.Drawing.Size(138, 24);
            this.cbbmtk.TabIndex = 44;
            this.cbbmtk.ValueMember = "MATAIKHOAN";
            this.cbbmtk.SelectedIndexChanged += new System.EventHandler(this.cbbmtk_SelectedIndexChanged);
            // 
            // tHANHVIENBindingSource
            // 
            this.tHANHVIENBindingSource.DataMember = "THANHVIEN";
            this.tHANHVIENBindingSource.DataSource = this.qLQNDataSet5;
            // 
            // qLQNDataSet5
            // 
            this.qLQNDataSet5.DataSetName = "QLQNDataSet5";
            this.qLQNDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAYKHACHTableAdapter
            // 
            this.mAYKHACHTableAdapter.ClearBeforeFill = true;
            // 
            // tHANHVIENTableAdapter
            // 
            this.tHANHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // CTSUDUNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 509);
            this.Controls.Add(this.cbbmtk);
            this.Controls.Add(this.cbbmmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtttk);
            this.Controls.Add(this.txttmt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgioketthuc);
            this.Controls.Add(this.txtgiobatdau);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvctsudung);
            this.Name = "CTSUDUNG";
            this.Text = "CTSUDUNG";
            this.Load += new System.EventHandler(this.CTSUDUNG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvctsudung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYKHACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHANHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet5)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvctsudung;
        private System.Windows.Forms.TextBox txtgiobatdau;
        private System.Windows.Forms.TextBox txtgioketthuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtttk;
        private System.Windows.Forms.TextBox txttmt;
        private System.Windows.Forms.ComboBox cbbmmt;
        private System.Windows.Forms.ComboBox cbbmtk;
        private QLQNDataSet4 qLQNDataSet4;
        private System.Windows.Forms.BindingSource mAYKHACHBindingSource;
        private QLQNDataSet4TableAdapters.MAYKHACHTableAdapter mAYKHACHTableAdapter;
        private QLQNDataSet5 qLQNDataSet5;
        private System.Windows.Forms.BindingSource tHANHVIENBindingSource;
        private QLQNDataSet5TableAdapters.THANHVIENTableAdapter tHANHVIENTableAdapter;
    }
}