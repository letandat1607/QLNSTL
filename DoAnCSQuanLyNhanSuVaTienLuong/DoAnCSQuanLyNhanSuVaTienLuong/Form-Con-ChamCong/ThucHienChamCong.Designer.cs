using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    partial class ThucHienChamCong
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
            this.btnBangChamCongCT = new System.Windows.Forms.Button();
            this.btnQuanLyDonXinNghi = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.picBMenu = new System.Windows.Forms.PictureBox();
            this.lblTuyendung = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.dtpNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            this.All.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideBar.Controls.Add(this.btnBangChamCongCT);
            this.SideBar.Controls.Add(this.btnQuanLyDonXinNghi);
            this.SideBar.Controls.Add(this.btnChamCong);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 60);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(250, 625);
            this.SideBar.TabIndex = 0;
            // 
            // btnBangChamCongCT
            // 
            this.btnBangChamCongCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBangChamCongCT.Location = new System.Drawing.Point(12, 125);
            this.btnBangChamCongCT.Name = "btnBangChamCongCT";
            this.btnBangChamCongCT.Size = new System.Drawing.Size(223, 42);
            this.btnBangChamCongCT.TabIndex = 6;
            this.btnBangChamCongCT.Text = "Bảng chấm công tổng hợp";
            this.btnBangChamCongCT.UseVisualStyleBackColor = true;
            this.btnBangChamCongCT.Click += new System.EventHandler(this.btnBangChamCongCT_Click);
            // 
            // btnQuanLyDonXinNghi
            // 
            this.btnQuanLyDonXinNghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuanLyDonXinNghi.Location = new System.Drawing.Point(12, 65);
            this.btnQuanLyDonXinNghi.Name = "btnQuanLyDonXinNghi";
            this.btnQuanLyDonXinNghi.Size = new System.Drawing.Size(223, 42);
            this.btnQuanLyDonXinNghi.TabIndex = 5;
            this.btnQuanLyDonXinNghi.Text = "Quản lý đơn xin nghỉ";
            this.btnQuanLyDonXinNghi.UseVisualStyleBackColor = true;
            this.btnQuanLyDonXinNghi.Click += new System.EventHandler(this.btnQuanLyDonXinNghi_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChamCong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChamCong.Location = new System.Drawing.Point(12, 6);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(223, 42);
            this.btnChamCong.TabIndex = 4;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.picBMenu);
            this.Header.Controls.Add(this.lblTuyendung);
            this.Header.Controls.Add(this.txtTimkiem);
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
            this.lblTuyendung.Size = new System.Drawing.Size(127, 25);
            this.lblTuyendung.TabIndex = 14;
            this.lblTuyendung.Text = "Tuyển dụng";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimkiem.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTimkiem.Location = new System.Drawing.Point(236, 16);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(280, 32);
            this.txtTimkiem.TabIndex = 13;
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
            this.Main.Controls.Add(this.dtpNgayChamCong);
            this.Main.Controls.Add(this.txtCheckOut);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.txtCheckIn);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.btnCheckOut);
            this.Main.Controls.Add(this.btnCheckIn);
            this.Main.Controls.Add(this.lblTittle);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 625);
            this.Main.TabIndex = 3;
            // 
            // dtpNgayChamCong
            // 
            this.dtpNgayChamCong.Enabled = false;
            this.dtpNgayChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayChamCong.Location = new System.Drawing.Point(330, 133);
            this.dtpNgayChamCong.Name = "dtpNgayChamCong";
            this.dtpNgayChamCong.Size = new System.Drawing.Size(436, 38);
            this.dtpNgayChamCong.TabIndex = 12;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Enabled = false;
            this.txtCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCheckOut.Location = new System.Drawing.Point(748, 265);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(220, 38);
            this.txtCheckOut.TabIndex = 11;
            this.txtCheckOut.TextChanged += new System.EventHandler(this.txtCheckOut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(583, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Check out:";
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Enabled = false;
            this.txtCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCheckIn.Location = new System.Drawing.Point(304, 262);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(227, 38);
            this.txtCheckIn.TabIndex = 9;
            this.txtCheckIn.TextChanged += new System.EventHandler(this.txtCheckIn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(157, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Check in:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.Location = new System.Drawing.Point(631, 395);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(126, 69);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.Location = new System.Drawing.Point(372, 395);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(126, 69);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTittle.Location = new System.Drawing.Point(379, 70);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(357, 38);
            this.lblTittle.TabIndex = 4;
            this.lblTittle.Text = "Thực hiện chấm công";
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
            // ThucHienChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 685);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThucHienChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuyenDung";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.All.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Panel Main;
        private Label lblTittle;
        private Panel All;
        private Label lblTuyendung;
        private TextBox txtTimkiem;
        private PictureBox pictureBox1;
        private PictureBox picBMenu;
        private Button btnChamCong;
        private Button btnBangChamCongCT;
        private Button btnQuanLyDonXinNghi;
        private TextBox txtCheckOut;
        private Label label2;
        private TextBox txtCheckIn;
        private Label label1;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private DateTimePicker dtpNgayChamCong;
    }
}
