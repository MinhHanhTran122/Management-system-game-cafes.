namespace QUANLYQUANNET
{
    partial class BangGia
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
            this.dgvbanggia = new System.Windows.Forms.DataGridView();
            this.txtmap = new System.Windows.Forms.TextBox();
            this.txttenp = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanggia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbanggia
            // 
            this.dgvbanggia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbanggia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbanggia.Location = new System.Drawing.Point(31, 61);
            this.dgvbanggia.Name = "dgvbanggia";
            this.dgvbanggia.ReadOnly = true;
            this.dgvbanggia.RowHeadersWidth = 51;
            this.dgvbanggia.RowTemplate.Height = 24;
            this.dgvbanggia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbanggia.Size = new System.Drawing.Size(555, 197);
            this.dgvbanggia.TabIndex = 0;
            this.dgvbanggia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvbanggia_CellMouseClick);
            // 
            // txtmap
            // 
            this.txtmap.Location = new System.Drawing.Point(62, 312);
            this.txtmap.Name = "txtmap";
            this.txtmap.Size = new System.Drawing.Size(103, 22);
            this.txtmap.TabIndex = 1;
            // 
            // txttenp
            // 
            this.txttenp.Location = new System.Drawing.Point(256, 312);
            this.txttenp.Name = "txttenp";
            this.txttenp.Size = new System.Drawing.Size(118, 22);
            this.txttenp.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(453, 312);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(103, 22);
            this.txtgia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá/giờ (VND)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cập nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(128, 349);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 39);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(372, 349);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(88, 39);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tìm kiếm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(445, 22);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(141, 22);
            this.txttimkiem.TabIndex = 12;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // BangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 402);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txttenp);
            this.Controls.Add(this.txtmap);
            this.Controls.Add(this.dgvbanggia);
            this.Name = "BangGia";
            this.Text = "BangGia";
            this.Load += new System.EventHandler(this.BangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbanggia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbanggia;
        private System.Windows.Forms.TextBox txtmap;
        private System.Windows.Forms.TextBox txttenp;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}