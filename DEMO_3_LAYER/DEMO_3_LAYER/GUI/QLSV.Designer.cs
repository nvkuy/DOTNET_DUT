namespace DEMO_3_LAYER
{
    partial class QLSV
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
            this.cobLopSinhHoat = new System.Windows.Forms.ComboBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // cobLopSinhHoat
            // 
            this.cobLopSinhHoat.FormattingEnabled = true;
            this.cobLopSinhHoat.Location = new System.Drawing.Point(68, 40);
            this.cobLopSinhHoat.Name = "cobLopSinhHoat";
            this.cobLopSinhHoat.Size = new System.Drawing.Size(256, 24);
            this.cobLopSinhHoat.TabIndex = 0;
            this.cobLopSinhHoat.SelectedIndexChanged += new System.EventHandler(this.cobLopSinhHoat_SelectedIndexChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(68, 92);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(664, 301);
            this.dgvSinhVien.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(385, 40);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.cobLopSinhHoat);
            this.Name = "QLSV";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cobLopSinhHoat;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button delBtn;
    }
}

