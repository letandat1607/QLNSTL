namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class DanhSachNhanVien
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
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyDSNV = new System.Windows.Forms.Button();
            this.btnChonDSNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(-17, 23);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 62;
            this.dgvDSNV.RowTemplate.Height = 28;
            this.dgvDSNV.Size = new System.Drawing.Size(1395, 522);
            this.dgvDSNV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyDSNV);
            this.panel1.Controls.Add(this.btnChonDSNV);
            this.panel1.Location = new System.Drawing.Point(12, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnHuyDSNV
            // 
            this.btnHuyDSNV.Location = new System.Drawing.Point(1222, 11);
            this.btnHuyDSNV.Name = "btnHuyDSNV";
            this.btnHuyDSNV.Size = new System.Drawing.Size(144, 49);
            this.btnHuyDSNV.TabIndex = 1;
            this.btnHuyDSNV.Text = "Hủy";
            this.btnHuyDSNV.UseVisualStyleBackColor = true;
            // 
            // btnChonDSNV
            // 
            this.btnChonDSNV.Location = new System.Drawing.Point(1072, 11);
            this.btnChonDSNV.Name = "btnChonDSNV";
            this.btnChonDSNV.Size = new System.Drawing.Size(144, 49);
            this.btnChonDSNV.TabIndex = 0;
            this.btnChonDSNV.Text = "Chọn";
            this.btnChonDSNV.UseVisualStyleBackColor = true;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSNV);
            this.Name = "DanhSachNhanVien";
            this.Text = "DanhSachNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonDSNV;
        private System.Windows.Forms.Button btnHuyDSNV;
    }
}