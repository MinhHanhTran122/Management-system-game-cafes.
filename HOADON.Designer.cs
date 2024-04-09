namespace QUANLYQUANNET
{
    partial class HOADON
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
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttnv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttmt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttt = new System.Windows.Forms.TextBox();
            this.cbbmmt = new System.Windows.Forms.ComboBox();
            this.mAYKHACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet6 = new QUANLYQUANNET.QLQNDataSet6();
            this.cbbmnv = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet7 = new QUANLYQUANNET.QLQNDataSet7();
            this.datetimenl = new System.Windows.Forms.DateTimePicker();
            this.mAYKHACHTableAdapter = new QUANLYQUANNET.QLQNDataSet6TableAdapters.MAYKHACHTableAdapter();
            this.nHANVIENTableAdapter = new QUANLYQUANNET.QLQNDataSet7TableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYKHACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(682, 12);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 45;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(628, 418);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 39);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(628, 354);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 39);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(734, 418);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 39);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(734, 354);
            this.btncapnhap.Name = "btncapnhap";
            this.btncapnhap.Size = new System.Drawing.Size(88, 39);
            this.btncapnhap.TabIndex = 40;
            this.btncapnhap.Text = "Cập nhập";
            this.btncapnhap.UseVisualStyleBackColor = true;
            this.btncapnhap.Click += new System.EventHandler(this.btncapnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã máy tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtmahd
            // 
            this.txtmahd.Location = new System.Drawing.Point(76, 328);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(131, 22);
            this.txtmahd.TabIndex = 36;
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Location = new System.Drawing.Point(57, 54);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.ReadOnly = true;
            this.dgvhoadon.RowHeadersVisible = false;
            this.dgvhoadon.RowHeadersWidth = 51;
            this.dgvhoadon.RowTemplate.Height = 24;
            this.dgvhoadon.Size = new System.Drawing.Size(766, 218);
            this.dgvhoadon.TabIndex = 35;
            this.dgvhoadon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvhoadon_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Ngày";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Tên nhân viên";
            // 
            // txttnv
            // 
            this.txttnv.Location = new System.Drawing.Point(283, 469);
            this.txttnv.Name = "txttnv";
            this.txttnv.ReadOnly = true;
            this.txttnv.Size = new System.Drawing.Size(135, 22);
            this.txttnv.TabIndex = 52;
            this.txttnv.TextChanged += new System.EventHandler(this.txttnv_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tên máy tính";
            // 
            // txttmt
            // 
            this.txttmt.Location = new System.Drawing.Point(76, 469);
            this.txttmt.Name = "txttmt";
            this.txttmt.ReadOnly = true;
            this.txttmt.Size = new System.Drawing.Size(131, 22);
            this.txttmt.TabIndex = 50;
            this.txttmt.TextChanged += new System.EventHandler(this.txttmt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Trạng thái thanh toán";
            // 
            // txttt
            // 
            this.txttt.Location = new System.Drawing.Point(469, 469);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(128, 22);
            this.txttt.TabIndex = 54;
            // 
            // cbbmmt
            // 
            this.cbbmmt.DataSource = this.mAYKHACHBindingSource;
            this.cbbmmt.DisplayMember = "MAMT";
            this.cbbmmt.FormattingEnabled = true;
            this.cbbmmt.Location = new System.Drawing.Point(76, 400);
            this.cbbmmt.Name = "cbbmmt";
            this.cbbmmt.Size = new System.Drawing.Size(131, 24);
            this.cbbmmt.TabIndex = 56;
            this.cbbmmt.ValueMember = "MAMT";
            this.cbbmmt.SelectedIndexChanged += new System.EventHandler(this.cbbmmt_SelectedIndexChanged);
            // 
            // mAYKHACHBindingSource
            // 
            this.mAYKHACHBindingSource.DataMember = "MAYKHACH";
            this.mAYKHACHBindingSource.DataSource = this.qLQNDataSet6;
            // 
            // qLQNDataSet6
            // 
            this.qLQNDataSet6.DataSetName = "QLQNDataSet6";
            this.qLQNDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbmnv
            // 
            this.cbbmnv.DataSource = this.nHANVIENBindingSource;
            this.cbbmnv.DisplayMember = "MANV";
            this.cbbmnv.FormattingEnabled = true;
            this.cbbmnv.Location = new System.Drawing.Point(283, 400);
            this.cbbmnv.Name = "cbbmnv";
            this.cbbmnv.Size = new System.Drawing.Size(135, 24);
            this.cbbmnv.TabIndex = 57;
            this.cbbmnv.ValueMember = "MANV";
            this.cbbmnv.SelectedIndexChanged += new System.EventHandler(this.cbbmnv_SelectedIndexChanged);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLQNDataSet7;
            // 
            // qLQNDataSet7
            // 
            this.qLQNDataSet7.DataSetName = "QLQNDataSet7";
            this.qLQNDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datetimenl
            // 
            this.datetimenl.CustomFormat = "dd/MM/yyyy";
            this.datetimenl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimenl.Location = new System.Drawing.Point(283, 326);
            this.datetimenl.Name = "datetimenl";
            this.datetimenl.Size = new System.Drawing.Size(135, 22);
            this.datetimenl.TabIndex = 58;
            this.datetimenl.Value = new System.DateTime(2099, 3, 20, 11, 6, 0, 0);
            // 
            // mAYKHACHTableAdapter
            // 
            this.mAYKHACHTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 521);
            this.Controls.Add(this.datetimenl);
            this.Controls.Add(this.cbbmnv);
            this.Controls.Add(this.cbbmmt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttnv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttmt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.dgvhoadon);
            this.Name = "HOADON";
            this.Text = "HOADON";
            this.Load += new System.EventHandler(this.HOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAYKHACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet7)).EndInit();
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
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.ComboBox cbbmmt;
        private System.Windows.Forms.ComboBox cbbmnv;
        private System.Windows.Forms.DateTimePicker datetimenl;
        private QLQNDataSet6 qLQNDataSet6;
        private System.Windows.Forms.BindingSource mAYKHACHBindingSource;
        private QLQNDataSet6TableAdapters.MAYKHACHTableAdapter mAYKHACHTableAdapter;
        private QLQNDataSet7 qLQNDataSet7;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLQNDataSet7TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}