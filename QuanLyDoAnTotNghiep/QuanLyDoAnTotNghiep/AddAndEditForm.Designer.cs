namespace QuanLyDoAnTotNghiep
{
    partial class AddAndEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaDATN = new System.Windows.Forms.TextBox();
            this.tbTenDATN = new System.Windows.Forms.TextBox();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.cobHuongNC = new System.Windows.Forms.ComboBox();
            this.cobGVHD = new System.Windows.Forms.ComboBox();
            this.tbNamBaoVe = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTinhTrang = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã DATN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên DATN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SV thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hướng NC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "GVHD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm bảo vệ";
            // 
            // tbMaDATN
            // 
            this.tbMaDATN.Location = new System.Drawing.Point(120, 19);
            this.tbMaDATN.Name = "tbMaDATN";
            this.tbMaDATN.Size = new System.Drawing.Size(245, 22);
            this.tbMaDATN.TabIndex = 7;
            // 
            // tbTenDATN
            // 
            this.tbTenDATN.Location = new System.Drawing.Point(120, 47);
            this.tbTenDATN.Name = "tbTenDATN";
            this.tbTenDATN.Size = new System.Drawing.Size(245, 22);
            this.tbTenDATN.TabIndex = 8;
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(120, 75);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(245, 22);
            this.tbTacGia.TabIndex = 9;
            // 
            // cobHuongNC
            // 
            this.cobHuongNC.FormattingEnabled = true;
            this.cobHuongNC.Location = new System.Drawing.Point(120, 101);
            this.cobHuongNC.Name = "cobHuongNC";
            this.cobHuongNC.Size = new System.Drawing.Size(245, 24);
            this.cobHuongNC.TabIndex = 10;
            this.cobHuongNC.SelectedIndexChanged += new System.EventHandler(this.cobHuongNC_SelectedIndexChanged);
            // 
            // cobGVHD
            // 
            this.cobGVHD.FormattingEnabled = true;
            this.cobGVHD.Location = new System.Drawing.Point(120, 131);
            this.cobGVHD.Name = "cobGVHD";
            this.cobGVHD.Size = new System.Drawing.Size(245, 24);
            this.cobGVHD.TabIndex = 11;
            // 
            // tbNamBaoVe
            // 
            this.tbNamBaoVe.Location = new System.Drawing.Point(120, 190);
            this.tbNamBaoVe.Name = "tbNamBaoVe";
            this.tbNamBaoVe.Size = new System.Drawing.Size(245, 22);
            this.tbNamBaoVe.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 241);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "CANCEL";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tình trạng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rbTinhTrang);
            this.panel1.Location = new System.Drawing.Point(120, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 16);
            this.panel1.TabIndex = 18;
            // 
            // rbTinhTrang
            // 
            this.rbTinhTrang.AutoSize = true;
            this.rbTinhTrang.Checked = true;
            this.rbTinhTrang.Location = new System.Drawing.Point(0, -2);
            this.rbTinhTrang.Name = "rbTinhTrang";
            this.rbTinhTrang.Size = new System.Drawing.Size(90, 20);
            this.rbTinhTrang.TabIndex = 19;
            this.rbTinhTrang.TabStop = true;
            this.rbTinhTrang.Text = "Đã bảo vệ";
            this.rbTinhTrang.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, -2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "Chưa bảo vệ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // AddAndEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbNamBaoVe);
            this.Controls.Add(this.cobGVHD);
            this.Controls.Add(this.cobHuongNC);
            this.Controls.Add(this.tbTacGia);
            this.Controls.Add(this.tbTenDATN);
            this.Controls.Add(this.tbMaDATN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAndEditForm";
            this.Text = "Detail Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaDATN;
        private System.Windows.Forms.TextBox tbTenDATN;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.ComboBox cobHuongNC;
        private System.Windows.Forms.ComboBox cobGVHD;
        private System.Windows.Forms.TextBox tbNamBaoVe;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbTinhTrang;
    }
}