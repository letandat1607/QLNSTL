namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    partial class ChamCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tấtCảỨngDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTongQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mitBangChamCongCT = new System.Windows.Forms.ToolStripMenuItem();
            this.mitChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDonNghi = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 64);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(147, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 6);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tấtCảỨngDụngToolStripMenuItem,
            this.tsmiTongQuan,
            this.tsmiChamCong,
            this.tsmiQLDon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tấtCảỨngDụngToolStripMenuItem
            // 
            this.tấtCảỨngDụngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tấtCảỨngDụngToolStripMenuItem.Name = "tấtCảỨngDụngToolStripMenuItem";
            this.tấtCảỨngDụngToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.tấtCảỨngDụngToolStripMenuItem.Text = "Tất cả ứng dụng";
            // 
            // tsmiTongQuan
            // 
            this.tsmiTongQuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiTongQuan.Name = "tsmiTongQuan";
            this.tsmiTongQuan.Size = new System.Drawing.Size(112, 27);
            this.tsmiTongQuan.Text = "Tổng quan ";
            // 
            // tsmiChamCong
            // 
            this.tsmiChamCong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitBangChamCongCT,
            this.mitChamCong});
            this.tsmiChamCong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiChamCong.Name = "tsmiChamCong";
            this.tsmiChamCong.Size = new System.Drawing.Size(129, 27);
            this.tsmiChamCong.Text = "Chấm công ^";
            // 
            // mitBangChamCongCT
            // 
            this.mitBangChamCongCT.Name = "mitBangChamCongCT";
            this.mitBangChamCongCT.Size = new System.Drawing.Size(280, 28);
            this.mitBangChamCongCT.Text = "Bảng chấm công chi tiết";
            this.mitBangChamCongCT.Click += new System.EventHandler(this.mitBangChamCongCT_Click);
            // 
            // mitChamCong
            // 
            this.mitChamCong.Name = "mitChamCong";
            this.mitChamCong.Size = new System.Drawing.Size(280, 28);
            this.mitChamCong.Text = "Chấm công";
            this.mitChamCong.Click += new System.EventHandler(this.mitChamCong_Click);
            // 
            // tsmiQLDon
            // 
            this.tsmiQLDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitDonNghi});
            this.tsmiQLDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiQLDon.Name = "tsmiQLDon";
            this.tsmiQLDon.Size = new System.Drawing.Size(135, 27);
            this.tsmiQLDon.Text = "Quản lý đơn ^";
            // 
            // mitDonNghi
            // 
            this.mitDonNghi.Name = "mitDonNghi";
            this.mitDonNghi.Size = new System.Drawing.Size(284, 28);
            this.mitDonNghi.Text = "Đơn xin nghỉ";
            this.mitDonNghi.Click += new System.EventHandler(this.mitDonNghi_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 630);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChamCong";
            this.Text = "Chấm công";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tấtCảỨngDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTongQuan;
        private System.Windows.Forms.ToolStripMenuItem tsmiChamCong;
        private System.Windows.Forms.ToolStripMenuItem mitBangChamCongCT;
        private System.Windows.Forms.ToolStripMenuItem mitChamCong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLDon;
        private System.Windows.Forms.ToolStripMenuItem mitDonNghi;
        private System.Windows.Forms.Panel panel2;
        #endregion
    }
}