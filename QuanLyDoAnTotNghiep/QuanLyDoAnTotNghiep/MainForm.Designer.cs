namespace QuanLyDoAnTotNghiep
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
            this.dgvDATN = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTimTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobHuongNC = new System.Windows.Forms.ComboBox();
            this.cobGVHD = new System.Windows.Forms.ComboBox();
            this.cobTinhTrang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDATN
            // 
            this.dgvDATN.AllowUserToAddRows = false;
            this.dgvDATN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDATN.Location = new System.Drawing.Point(3, 3);
            this.dgvDATN.MultiSelect = false;
            this.dgvDATN.Name = "dgvDATN";
            this.dgvDATN.ReadOnly = true;
            this.dgvDATN.RowHeadersWidth = 51;
            this.dgvDATN.RowTemplate.Height = 24;
            this.dgvDATN.Size = new System.Drawing.Size(794, 327);
            this.dgvDATN.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(191, 357);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(305, 357);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(72, 407);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTimTen
            // 
            this.tbTimTen.Location = new System.Drawing.Point(191, 407);
            this.tbTimTen.Name = "tbTimTen";
            this.tbTimTen.Size = new System.Drawing.Size(189, 22);
            this.tbTimTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hướng NC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "GVHD";
            // 
            // cobHuongNC
            // 
            this.cobHuongNC.FormattingEnabled = true;
            this.cobHuongNC.Location = new System.Drawing.Point(549, 354);
            this.cobHuongNC.Name = "cobHuongNC";
            this.cobHuongNC.Size = new System.Drawing.Size(173, 24);
            this.cobHuongNC.TabIndex = 9;
            this.cobHuongNC.SelectedIndexChanged += new System.EventHandler(this.cobHuongNC_SelectedIndexChanged);
            // 
            // cobGVHD
            // 
            this.cobGVHD.FormattingEnabled = true;
            this.cobGVHD.Location = new System.Drawing.Point(549, 412);
            this.cobGVHD.Name = "cobGVHD";
            this.cobGVHD.Size = new System.Drawing.Size(173, 24);
            this.cobGVHD.TabIndex = 11;
            // 
            // cobTinhTrang
            // 
            this.cobTinhTrang.FormattingEnabled = true;
            this.cobTinhTrang.Location = new System.Drawing.Point(549, 382);
            this.cobTinhTrang.Name = "cobTinhTrang";
            this.cobTinhTrang.Size = new System.Drawing.Size(173, 24);
            this.cobTinhTrang.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cobTinhTrang);
            this.Controls.Add(this.cobGVHD);
            this.Controls.Add(this.cobHuongNC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimTen);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDATN);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDATN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDATN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbTimTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobHuongNC;
        private System.Windows.Forms.ComboBox cobGVHD;
        private System.Windows.Forms.ComboBox cobTinhTrang;
    }
}

