using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    partial class BangChamCongCT
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
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnDonXinNghi = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnBangChamCong = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.picBMenu = new System.Windows.Forms.PictureBox();
            this.lblTuyendung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.dtgvBangChamCongCT = new System.Windows.Forms.DataGridView();
            this.lblTittle = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangChamCongCT)).BeginInit();
            this.All.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideBar.Controls.Add(this.btnDonXinNghi);
            this.SideBar.Controls.Add(this.btnChamCong);
            this.SideBar.Controls.Add(this.btnBangChamCong);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 60);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(250, 625);
            this.SideBar.TabIndex = 0;
            // 
            // btnDonXinNghi
            // 
            this.btnDonXinNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDonXinNghi.Location = new System.Drawing.Point(12, 76);
            this.btnDonXinNghi.Name = "btnDonXinNghi";
            this.btnDonXinNghi.Size = new System.Drawing.Size(223, 42);
            this.btnDonXinNghi.TabIndex = 4;
            this.btnDonXinNghi.Text = "Quản lý đơn xin nghỉ";
            this.btnDonXinNghi.UseVisualStyleBackColor = true;
            this.btnDonXinNghi.Click += new System.EventHandler(this.btnDonXinNghi_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChamCong.Location = new System.Drawing.Point(12, 17);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(223, 42);
            this.btnChamCong.TabIndex = 3;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = true;
            this.btnChamCong.Click += new System.EventHandler(this.btnUngvien_Click);
            // 
            // btnBangChamCong
            // 
            this.btnBangChamCong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBangChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBangChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBangChamCong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBangChamCong.Location = new System.Drawing.Point(12, 136);
            this.btnBangChamCong.Name = "btnBangChamCong";
            this.btnBangChamCong.Size = new System.Drawing.Size(223, 42);
            this.btnBangChamCong.TabIndex = 0;
            this.btnBangChamCong.Text = "Bảng chấm công tổng hợp";
            this.btnBangChamCong.UseVisualStyleBackColor = false;
            this.btnBangChamCong.Click += new System.EventHandler(this.btnTintuyendung_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.picBMenu);
            this.Header.Controls.Add(this.lblTuyendung);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1375, 60);
            this.Header.TabIndex = 1;
            // 
            // picBMenu
            // 
            this.picBMenu.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.menu;
            this.picBMenu.Location = new System.Drawing.Point(3, 3);
            this.picBMenu.Name = "picBMenu";
            this.picBMenu.Size = new System.Drawing.Size(51, 48);
            this.picBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMenu.TabIndex = 23;
            this.picBMenu.TabStop = false;
            this.picBMenu.Click += new System.EventHandler(this.picBMenu_Click);
            // 
            // lblTuyendung
            // 
            this.lblTuyendung.AutoSize = true;
            this.lblTuyendung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTuyendung.Location = new System.Drawing.Point(103, 16);
            this.lblTuyendung.Name = "lblTuyendung";
            this.lblTuyendung.Size = new System.Drawing.Size(122, 25);
            this.lblTuyendung.TabIndex = 14;
            this.lblTuyendung.Text = "Chấm công";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources._1200x630wa_removebg_preview;
            this.pictureBox1.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources._1200x630wa_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(22, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Main.Controls.Add(this.dtgvBangChamCongCT);
            this.Main.Controls.Add(this.lblTittle);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 625);
            this.Main.TabIndex = 3;
            // 
            // dtgvBangChamCongCT
            // 
            this.dtgvBangChamCongCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBangChamCongCT.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvBangChamCongCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBangChamCongCT.Location = new System.Drawing.Point(19, 83);
            this.dtgvBangChamCongCT.Name = "dtgvBangChamCongCT";
            this.dtgvBangChamCongCT.ReadOnly = true;
            this.dtgvBangChamCongCT.RowHeadersWidth = 51;
            this.dtgvBangChamCongCT.RowTemplate.Height = 24;
            this.dtgvBangChamCongCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvBangChamCongCT.Size = new System.Drawing.Size(1085, 542);
            this.dtgvBangChamCongCT.TabIndex = 6;
            this.dtgvBangChamCongCT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtuyendung_CellContentClick);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTittle.Location = new System.Drawing.Point(24, 17);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(212, 30);
            this.lblTittle.TabIndex = 4;
            this.lblTittle.Text = "Bảng chấm công";
            // 
            // All
            // 
            this.All.Controls.Add(this.Main);
            this.All.Controls.Add(this.SideBar);
            this.All.Controls.Add(this.Header);
            this.All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(1375, 685);
            this.All.TabIndex = 2;
            // 
            // BangChamCongCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 685);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BangChamCongCT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuyenDung";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBangChamCongCT)).EndInit();
            this.All.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Button btnBangChamCong;
        private Button btnChamCong;
        private Panel Main;
        private Label lblTittle;
        private DataGridView dtgvBangChamCongCT;
        private Panel All;
        private Label lblTuyendung;
        private PictureBox pictureBox1;
        private PictureBox picBMenu;
        private Button btnDonXinNghi;
    }
}