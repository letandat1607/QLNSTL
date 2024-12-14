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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayVe = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(418, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dữ liệu chấm công";
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(991, 121);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(126, 63);
            this.btnQuayVe.TabIndex = 2;
            this.btnQuayVe.Text = "Quay dề";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // BangDuLieuChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 511);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvBangDuLieuChamCong);
            this.Name = "BangDuLieuChamCong";
            this.Text = "BangDuLieuChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDuLieuChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBangDuLieuChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuayVe;
    }
}