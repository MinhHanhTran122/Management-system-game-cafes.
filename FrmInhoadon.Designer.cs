namespace QUANLYQUANNET
{
    partial class FrmInhoadon
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
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XuatHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(37, 132);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.RowHeadersVisible = false;
            this.dgvHoadon.RowHeadersWidth = 51;
            this.dgvHoadon.RowTemplate.Height = 24;
            this.dgvHoadon.Size = new System.Drawing.Size(416, 270);
            this.dgvHoadon.TabIndex = 0;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(116, 425);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(100, 22);
            this.txttong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng cộng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máy tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Khách hàng :";
            // 
            // XuatHD
            // 
            this.XuatHD.Location = new System.Drawing.Point(378, 468);
            this.XuatHD.Name = "XuatHD";
            this.XuatHD.Size = new System.Drawing.Size(75, 23);
            this.XuatHD.TabIndex = 6;
            this.XuatHD.Text = "In";
            this.XuatHD.UseVisualStyleBackColor = true;
            this.XuatHD.Click += new System.EventHandler(this.XuatHD_Click);
            // 
            // FrmInhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 503);
            this.Controls.Add(this.XuatHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.dgvHoadon);
            this.Name = "FrmInhoadon";
            this.Text = "FrmInhoadon";
            this.Load += new System.EventHandler(this.FrmInhoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button XuatHD;
    }
}