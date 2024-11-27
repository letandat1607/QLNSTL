namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    partial class BangDuLieuChamCong
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
            this.dtgvBangDuLieuChamCong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDuLieuChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBangDuLieuChamCong
            // 
            this.dtgvBangDuLieuChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangDuLieuChamCong.Location = new System.Drawing.Point(12, 220);
            this.dtgvBangDuLieuChamCong.Name = "dtgvBangDuLieuChamCong";
            this.dtgvBangDuLieuChamCong.RowHeadersWidth = 51;
            this.dtgvBangDuLieuChamCong.RowTemplate.Height = 24;
            this.dtgvBangDuLieuChamCong.Size = new System.Drawing.Size(1237, 279);
            this.dtgvBangDuLieuChamCong.TabIndex = 0;
            // 
            // BangDuLieuChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 511);
            this.Controls.Add(this.dtgvBangDuLieuChamCong);
            this.Name = "BangDuLieuChamCong";
            this.Text = "BangDuLieuChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDuLieuChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBangDuLieuChamCong;
    }
}