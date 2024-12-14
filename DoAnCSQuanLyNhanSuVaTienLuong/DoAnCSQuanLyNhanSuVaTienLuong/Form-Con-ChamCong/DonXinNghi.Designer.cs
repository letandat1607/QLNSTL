namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    partial class DonXinNghi
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
            this.tsmiAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTongQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mitBangChamCongCT = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDuLieuChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQLDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDonNghi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitDiMuonVeSom = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBangChamCongCT = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBangDonXinNghi = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDonXinNghi)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1310, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(268, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 6);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAll,
            this.tsmiTongQuan,
            this.tsmiChamCong,
            this.tsmiQLDon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAll
            // 
            this.tsmiAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmiAll.Name = "tsmiAll";
            this.tsmiAll.Size = new System.Drawing.Size(150, 27);
            this.tsmiAll.Text = "Tất cả ứng dụng";
            this.tsmiAll.Click += new System.EventHandler(this.tsmiAll_Click);
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
            this.mitDuLieuChamCong});
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
            // mitDuLieuChamCong
            // 
            this.mitDuLieuChamCong.Name = "mitDuLieuChamCong";
            this.mitDuLieuChamCong.Size = new System.Drawing.Size(280, 28);
            this.mitDuLieuChamCong.Text = "Chấm công";
            this.mitDuLieuChamCong.Click += new System.EventHandler(this.mitDuLieuChamCong_Click);
            // 
            // tsmiQLDon
            // 
            this.tsmiQLDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitDonNghi,
            this.mitDiMuonVeSom});
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
            // 
            // mitDiMuonVeSom
            // 
            this.mitDiMuonVeSom.Name = "mitDiMuonVeSom";
            this.mitDiMuonVeSom.Size = new System.Drawing.Size(284, 28);
            this.mitDiMuonVeSom.Text = "Đăng ký đi sớm về muộn";
            // 
            // lblBangChamCongCT
            // 
            this.lblBangChamCongCT.AutoSize = true;
            this.lblBangChamCongCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBangChamCongCT.Location = new System.Drawing.Point(12, 50);
            this.lblBangChamCongCT.Name = "lblBangChamCongCT";
            this.lblBangChamCongCT.Size = new System.Drawing.Size(221, 29);
            this.lblBangChamCongCT.TabIndex = 1;
            this.lblBangChamCongCT.Text = "Bảng đơn xin nghỉ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(1165, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBangDonXinNghi);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1286, 560);
            this.panel3.TabIndex = 3;
            // 
            // dtgvBangDonXinNghi
            // 
            this.dtgvBangDonXinNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangDonXinNghi.Location = new System.Drawing.Point(5, 53);
            this.dtgvBangDonXinNghi.Name = "dtgvBangDonXinNghi";
            this.dtgvBangDonXinNghi.RowHeadersWidth = 51;
            this.dtgvBangDonXinNghi.RowTemplate.Height = 24;
            this.dtgvBangDonXinNghi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBangDonXinNghi.Size = new System.Drawing.Size(1278, 346);
            this.dtgvBangDonXinNghi.TabIndex = 1;
            this.dtgvBangDonXinNghi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBangDonXinNghi_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(5, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1278, 44);
            this.panel4.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(18, 3);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 0;
            // 
            // DonXinNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBangChamCongCT);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DonXinNghi";
            this.Text = "7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangDonXinNghi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiTongQuan;
        private System.Windows.Forms.ToolStripMenuItem tsmiChamCong;
        private System.Windows.Forms.ToolStripMenuItem mitBangChamCongCT;
        private System.Windows.Forms.ToolStripMenuItem mitDuLieuChamCong;
        private System.Windows.Forms.ToolStripMenuItem tsmiQLDon;
        private System.Windows.Forms.ToolStripMenuItem mitDonNghi;
        private System.Windows.Forms.ToolStripMenuItem mitDiMuonVeSom;
        private System.Windows.Forms.Panel panel2;
        #endregion

        private System.Windows.Forms.Label lblBangChamCongCT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvBangDonXinNghi;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
    }
}