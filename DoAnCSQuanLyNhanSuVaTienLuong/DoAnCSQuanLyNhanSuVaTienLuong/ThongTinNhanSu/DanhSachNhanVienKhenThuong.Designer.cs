namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class DanhSachNhanVienKhenThuong
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
            this.dgvDSNVKT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemDSNVKT = new System.Windows.Forms.Button();
            this.btnXongDSNVKT = new System.Windows.Forms.Button();
            this.btnXoaDSNVKT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVKT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNVKT
            // 
            this.dgvDSNVKT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDSNVKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNVKT.Location = new System.Drawing.Point(2, 2);
            this.dgvDSNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSNVKT.Name = "dgvDSNVKT";
            this.dgvDSNVKT.RowHeadersWidth = 62;
            this.dgvDSNVKT.RowTemplate.Height = 28;
            this.dgvDSNVKT.Size = new System.Drawing.Size(1076, 418);
            this.dgvDSNVKT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemDSNVKT);
            this.panel1.Controls.Add(this.btnXongDSNVKT);
            this.panel1.Controls.Add(this.btnXoaDSNVKT);
            this.panel1.Location = new System.Drawing.Point(2, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnThemDSNVKT
            // 
            this.btnThemDSNVKT.Location = new System.Drawing.Point(660, 11);
            this.btnThemDSNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDSNVKT.Name = "btnThemDSNVKT";
            this.btnThemDSNVKT.Size = new System.Drawing.Size(128, 39);
            this.btnThemDSNVKT.TabIndex = 2;
            this.btnThemDSNVKT.Text = "Thêm";
            this.btnThemDSNVKT.UseVisualStyleBackColor = true;
            // 
            // btnXongDSNVKT
            // 
            this.btnXongDSNVKT.Location = new System.Drawing.Point(926, 9);
            this.btnXongDSNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXongDSNVKT.Name = "btnXongDSNVKT";
            this.btnXongDSNVKT.Size = new System.Drawing.Size(128, 39);
            this.btnXongDSNVKT.TabIndex = 1;
            this.btnXongDSNVKT.Text = "Xong";
            this.btnXongDSNVKT.UseVisualStyleBackColor = true;
            this.btnXongDSNVKT.Click += new System.EventHandler(this.btnXongDSNVKT_Click_1);
            // 
            // btnXoaDSNVKT
            // 
            this.btnXoaDSNVKT.Location = new System.Drawing.Point(793, 9);
            this.btnXoaDSNVKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDSNVKT.Name = "btnXoaDSNVKT";
            this.btnXoaDSNVKT.Size = new System.Drawing.Size(128, 39);
            this.btnXoaDSNVKT.TabIndex = 0;
            this.btnXoaDSNVKT.Text = "Xóa";
            this.btnXoaDSNVKT.UseVisualStyleBackColor = true;
            // 
            // DanhSachNhanVienKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSNVKT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachNhanVienKhenThuong";
            this.Text = "DanhSachNhanVienKhenThuong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNVKT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNVKT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXongDSNVKT;
        private System.Windows.Forms.Button btnXoaDSNVKT;
        private System.Windows.Forms.Button btnThemDSNVKT;
    }
}