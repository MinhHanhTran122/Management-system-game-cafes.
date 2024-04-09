namespace QUANLYQUANNET
{
    partial class Computer
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
            this.dgvmaykhach = new System.Windows.Forms.DataGridView();
            this.txtmt = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenmay = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.cbbmp = new System.Windows.Forms.ComboBox();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQNDataSet11 = new QUANLYQUANNET.QLQNDataSet11();
            this.pHONGTableAdapter = new QUANLYQUANNET.QLQNDataSet11TableAdapters.PHONGTableAdapter();
            this.cbbtt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaykhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmaykhach
            // 
            this.dgvmaykhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmaykhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmaykhach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvmaykhach.Location = new System.Drawing.Point(33, 65);
            this.dgvmaykhach.Name = "dgvmaykhach";
            this.dgvmaykhach.ReadOnly = true;
            this.dgvmaykhach.RowHeadersVisible = false;
            this.dgvmaykhach.RowHeadersWidth = 51;
            this.dgvmaykhach.RowTemplate.Height = 24;
            this.dgvmaykhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmaykhach.Size = new System.Drawing.Size(621, 250);
            this.dgvmaykhach.TabIndex = 0;
            this.dgvmaykhach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmaykhach_CellMouseClick);
            // 
            // txtmt
            // 
            this.txtmt.Location = new System.Drawing.Point(91, 350);
            this.txtmt.Name = "txtmt";
            this.txtmt.Size = new System.Drawing.Size(144, 22);
            this.txtmt.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(552, 342);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 39);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(552, 400);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 39);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(552, 458);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 39);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "MãMT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên máy";
            // 
            // txttenmay
            // 
            this.txttenmay.Location = new System.Drawing.Point(332, 350);
            this.txttenmay.Name = "txttenmay";
            this.txttenmay.Size = new System.Drawing.Size(144, 22);
            this.txttenmay.TabIndex = 8;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(513, 26);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 55;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tìm kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tên phòng";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(91, 469);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(144, 22);
            this.txttenphong.TabIndex = 56;
            this.txttenphong.TextChanged += new System.EventHandler(this.txttenphong_TextChanged);
            // 
            // cbbmp
            // 
            this.cbbmp.DataSource = this.pHONGBindingSource;
            this.cbbmp.DisplayMember = "MAPHONG";
            this.cbbmp.FormattingEnabled = true;
            this.cbbmp.Location = new System.Drawing.Point(91, 408);
            this.cbbmp.Name = "cbbmp";
            this.cbbmp.Size = new System.Drawing.Size(144, 24);
            this.cbbmp.TabIndex = 58;
            this.cbbmp.ValueMember = "MAPHONG";
            this.cbbmp.SelectedIndexChanged += new System.EventHandler(this.cbbmp_SelectedIndexChanged);
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.qLQNDataSet11;
            // 
            // qLQNDataSet11
            // 
            this.qLQNDataSet11.DataSetName = "QLQNDataSet11";
            this.qLQNDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // cbbtt
            // 
            this.cbbtt.FormattingEnabled = true;
            this.cbbtt.Items.AddRange(new object[] {
            "DA KET NOI",
            "MAT KET NOI",
            "DANG SU DUNG"});
            this.cbbtt.Location = new System.Drawing.Point(335, 408);
            this.cbbtt.Name = "cbbtt";
            this.cbbtt.Size = new System.Drawing.Size(141, 24);
            this.cbbtt.TabIndex = 59;
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 512);
            this.Controls.Add(this.cbbtt);
            this.Controls.Add(this.cbbmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttenmay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmt);
            this.Controls.Add(this.dgvmaykhach);
            this.Name = "Computer";
            this.Text = "Computer";
            this.Load += new System.EventHandler(this.Computer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmaykhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQNDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmaykhach;
        private System.Windows.Forms.TextBox txtmt;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenmay;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.ComboBox cbbmp;
        private QLQNDataSet11 qLQNDataSet11;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QLQNDataSet11TableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private System.Windows.Forms.ComboBox cbbtt;
    }
}