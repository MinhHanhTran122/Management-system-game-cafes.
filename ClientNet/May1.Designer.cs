namespace ClientNet
{
    partial class May1
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
            this.btndichvu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtconlai = new System.Windows.Forms.TextBox();
            this.txtsudung = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndichvu
            // 
            this.btndichvu.Location = new System.Drawing.Point(13, 140);
            this.btndichvu.Name = "btndichvu";
            this.btndichvu.Size = new System.Drawing.Size(73, 34);
            this.btndichvu.TabIndex = 0;
            this.btndichvu.Text = "Dịch vụ";
            this.btndichvu.UseVisualStyleBackColor = true;
            this.btndichvu.Click += new System.EventHandler(this.btndichvu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtconlai);
            this.panel1.Controls.Add(this.txtsudung);
            this.panel1.Controls.Add(this.txttong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btndichvu);
            this.panel1.Location = new System.Drawing.Point(572, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 384);
            this.panel1.TabIndex = 1;
            // 
            // txtconlai
            // 
            this.txtconlai.Location = new System.Drawing.Point(128, 93);
            this.txtconlai.Name = "txtconlai";
            this.txtconlai.Size = new System.Drawing.Size(100, 22);
            this.txtconlai.TabIndex = 6;
            // 
            // txtsudung
            // 
            this.txtsudung.Location = new System.Drawing.Point(127, 56);
            this.txtsudung.Name = "txtsudung";
            this.txtsudung.Size = new System.Drawing.Size(100, 22);
            this.txtsudung.TabIndex = 5;
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(127, 16);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(100, 22);
            this.txttong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian còn lại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian sử dụng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng thời gian:";
            // 
            // May1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClientNet.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(813, 510);
            this.Controls.Add(this.panel1);
            this.Name = "May1";
            this.Text = "May1";
            this.Load += new System.EventHandler(this.May1_Load);
            this.Click += new System.EventHandler(this.May1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndichvu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconlai;
        private System.Windows.Forms.TextBox txtsudung;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

