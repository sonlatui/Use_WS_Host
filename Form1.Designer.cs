namespace Use_WS_Host
{
    partial class Form1
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
            this.TbTp1 = new System.Windows.Forms.TextBox();
            this.BuTim1 = new System.Windows.Forms.Button();
            this.LbStt1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbAddress1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbAddress2 = new System.Windows.Forms.TextBox();
            this.TbTp2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuTim2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LbStt2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbTp1
            // 
            this.TbTp1.Location = new System.Drawing.Point(106, 47);
            this.TbTp1.Name = "TbTp1";
            this.TbTp1.Size = new System.Drawing.Size(100, 20);
            this.TbTp1.TabIndex = 0;
            this.TbTp1.Text = "So Do";
            // 
            // BuTim1
            // 
            this.BuTim1.Location = new System.Drawing.Point(212, 44);
            this.BuTim1.Name = "BuTim1";
            this.BuTim1.Size = new System.Drawing.Size(54, 23);
            this.BuTim1.TabIndex = 1;
            this.BuTim1.Text = "Tìm";
            this.BuTim1.UseVisualStyleBackColor = true;
            this.BuTim1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbStt1
            // 
            this.LbStt1.AutoSize = true;
            this.LbStt1.Location = new System.Drawing.Point(103, 78);
            this.LbStt1.Name = "LbStt1";
            this.LbStt1.Size = new System.Drawing.Size(35, 13);
            this.LbStt1.TabIndex = 2;
            this.LbStt1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điền tên tác phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // TbAddress1
            // 
            this.TbAddress1.Location = new System.Drawing.Point(57, 21);
            this.TbAddress1.Name = "TbAddress1";
            this.TbAddress1.Size = new System.Drawing.Size(207, 20);
            this.TbAddress1.TabIndex = 6;
            this.TbAddress1.Text = "http://localhost:8000/Lib";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbAddress1);
            this.groupBox1.Controls.Add(this.TbTp1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BuTim1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LbStt1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 110);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Http";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TbAddress2);
            this.groupBox2.Controls.Add(this.TbTp2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BuTim2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LbStt2);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Net.Tcp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điền tên tác phẩm";
            // 
            // TbAddress2
            // 
            this.TbAddress2.Location = new System.Drawing.Point(57, 21);
            this.TbAddress2.Name = "TbAddress2";
            this.TbAddress2.Size = new System.Drawing.Size(207, 20);
            this.TbAddress2.TabIndex = 6;
            this.TbAddress2.Text = "net.tcp://localhost:8080/Lib";
            // 
            // TbTp2
            // 
            this.TbTp2.Location = new System.Drawing.Point(106, 47);
            this.TbTp2.Name = "TbTp2";
            this.TbTp2.Size = new System.Drawing.Size(100, 20);
            this.TbTp2.TabIndex = 0;
            this.TbTp2.Text = "Tat Den";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // BuTim2
            // 
            this.BuTim2.Location = new System.Drawing.Point(212, 44);
            this.BuTim2.Name = "BuTim2";
            this.BuTim2.Size = new System.Drawing.Size(54, 23);
            this.BuTim2.TabIndex = 1;
            this.BuTim2.Text = "Tìm";
            this.BuTim2.UseVisualStyleBackColor = true;
            this.BuTim2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên tác giả";
            // 
            // LbStt2
            // 
            this.LbStt2.AutoSize = true;
            this.LbStt2.Location = new System.Drawing.Point(103, 78);
            this.LbStt2.Name = "LbStt2";
            this.LbStt2.Size = new System.Drawing.Size(35, 13);
            this.LbStt2.TabIndex = 2;
            this.LbStt2.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbTp1;
        private System.Windows.Forms.Button BuTim1;
        private System.Windows.Forms.Label LbStt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbAddress1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbAddress2;
        private System.Windows.Forms.TextBox TbTp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuTim2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbStt2;
    }
}

