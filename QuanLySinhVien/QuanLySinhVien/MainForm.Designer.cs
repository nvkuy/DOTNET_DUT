namespace QuanLySinhVien
{
    partial class MainForm
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
            this.cobThuocTinh = new System.Windows.Forms.ComboBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgSinhVien = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.cobLopSinhHoat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cobThuocTinh
            // 
            this.cobThuocTinh.FormattingEnabled = true;
            this.cobThuocTinh.Items.AddRange(new object[] {
            "Tên",
            "Điểm trung bình",
            "Ngày sinh"});
            this.cobThuocTinh.Location = new System.Drawing.Point(377, 404);
            this.cobThuocTinh.Name = "cobThuocTinh";
            this.cobThuocTinh.Size = new System.Drawing.Size(243, 24);
            this.cobThuocTinh.TabIndex = 19;
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(289, 404);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 18;
            this.btnSapXep.Text = "Sort";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(196, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Del";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(105, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Edit";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnAddOrEdit_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 404);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Add";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnAddOrEdit_Click);
            // 
            // dgSinhVien
            // 
            this.dgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSinhVien.Location = new System.Drawing.Point(16, 69);
            this.dgSinhVien.Name = "dgSinhVien";
            this.dgSinhVien.RowHeadersWidth = 51;
            this.dgSinhVien.RowTemplate.Height = 24;
            this.dgSinhVien.Size = new System.Drawing.Size(604, 301);
            this.dgSinhVien.TabIndex = 14;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(545, 22);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(292, 23);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(247, 22);
            this.tbTimKiem.TabIndex = 12;
            // 
            // cobLopSinhHoat
            // 
            this.cobLopSinhHoat.FormattingEnabled = true;
            this.cobLopSinhHoat.Items.AddRange(new object[] {
            "21T_DT1",
            "21T_DT2",
            "21TCLC_DT1",
            "21TCLC_DT2",
            "21TCLC_DT3",
            "21TCLC_DT4"});
            this.cobLopSinhHoat.Location = new System.Drawing.Point(105, 23);
            this.cobLopSinhHoat.Name = "cobLopSinhHoat";
            this.cobLopSinhHoat.Size = new System.Drawing.Size(166, 24);
            this.cobLopSinhHoat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lớp sinh hoạt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.cobThuocTinh);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgSinhVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.cobLopSinhHoat);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobThuocTinh;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgSinhVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.ComboBox cobLopSinhHoat;
        private System.Windows.Forms.Label label1;
    }
}

