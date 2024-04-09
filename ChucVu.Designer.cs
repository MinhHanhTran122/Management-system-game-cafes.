namespace QUANLYQUANNET
{
    partial class ChucVu
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btncapnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenp = new System.Windows.Forms.TextBox();
            this.txtmap = new System.Windows.Forms.TextBox();
            this.dgvchucvu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(453, 19);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 34;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tìm kiếm";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(400, 346);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 39);
            this.btnxoa.TabIndex = 32;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(400, 282);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 39);
            this.btnthem.TabIndex = 31;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(506, 346);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 39);
            this.btnthoat.TabIndex = 30;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btncapnhap
            // 
            this.btncapnhap.Location = new System.Drawing.Point(506, 282);
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
            this.label2.Location = new System.Drawing.Point(242, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã chức vụ";
            // 
            // txttenp
            // 
            this.txttenp.Location = new System.Drawing.Point(225, 309);
            this.txttenp.Name = "txttenp";
            this.txttenp.Size = new System.Drawing.Size(118, 22);
            this.txttenp.TabIndex = 26;
            // 
            // txtmap
            // 
            this.txtmap.Location = new System.Drawing.Point(68, 309);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(114, 22);
            this.txtmap.TabIndex = 25;
            // 
            // dgvchucvu
            // 
            this.dgvchucvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvchucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchucvu.Location = new System.Drawing.Point(39, 58);
            this.dgvchucvu.Name = "dgvchucvu";
            this.dgvchucvu.ReadOnly = true;
            this.dgvchucvu.RowHeadersVisible = false;
            this.dgvchucvu.RowHeadersWidth = 51;
            this.dgvchucvu.RowTemplate.Height = 24;
            this.dgvchucvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvchucvu.Size = new System.Drawing.Size(555, 197);
            this.dgvchucvu.TabIndex = 24;
            this.dgvchucvu.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvchucvu_CellMouseClick);
            // 
            // ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 401);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenp);
            this.Controls.Add(this.txtmap);
            this.Controls.Add(this.dgvchucvu);
            this.Name = "ChucVu";
            this.Text = "ChucVu";
            this.Load += new System.EventHandler(this.ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchucvu)).EndInit();
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
        private System.Windows.Forms.TextBox txttenp;
        private System.Windows.Forms.TextBox txtmap;
        private System.Windows.Forms.DataGridView dgvchucvu;
    }
}