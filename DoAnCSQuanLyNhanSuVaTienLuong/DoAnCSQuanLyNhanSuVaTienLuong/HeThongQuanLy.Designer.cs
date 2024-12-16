using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    partial class HeThongQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeThongQuanLy));
            this.button5 = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTienLuong = new System.Windows.Forms.Button();
            this.btnThongTinNhanSu = new System.Windows.Forms.Button();
            this.btnTuyenDung = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChaomung = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.All.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(958, 160);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(5, 5);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.All.Controls.Add(this.label2);
            this.All.Controls.Add(this.panel1);
            this.All.Controls.Add(this.Header);
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(1535, 814);
            this.All.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(380, 771);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(753, 27);
            this.label2.TabIndex = 100;
            this.label2.Text = "Dự kiến cập nhật các chức năng tiếp theo, Thuế, BHXH, Mục tiêu, Đánh giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnTienLuong);
            this.panel1.Controls.Add(this.btnThongTinNhanSu);
            this.panel1.Controls.Add(this.btnTuyenDung);
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Location = new System.Drawing.Point(1, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 526);
            this.panel1.TabIndex = 9;
            // 
            // btnTienLuong
            // 
            this.btnTienLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnTienLuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTienLuong.BackgroundImage")));
            this.btnTienLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTienLuong.FlatAppearance.BorderSize = 0;
            this.btnTienLuong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTienLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTienLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienLuong.Location = new System.Drawing.Point(1137, -91);
            this.btnTienLuong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTienLuong.Name = "btnTienLuong";
            this.btnTienLuong.Size = new System.Drawing.Size(371, 368);
            this.btnTienLuong.TabIndex = 3;
            this.btnTienLuong.UseVisualStyleBackColor = false;
            this.btnTienLuong.Click += new System.EventHandler(this.btnTienLuong_Click);
            // 
            // btnThongTinNhanSu
            // 
            this.btnThongTinNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinNhanSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongTinNhanSu.FlatAppearance.BorderSize = 0;
            this.btnThongTinNhanSu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnThongTinNhanSu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnThongTinNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinNhanSu.Location = new System.Drawing.Point(385, -91);
            this.btnThongTinNhanSu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTinNhanSu.Name = "btnThongTinNhanSu";
            this.btnThongTinNhanSu.Size = new System.Drawing.Size(371, 368);
            this.btnThongTinNhanSu.TabIndex = 1;
            this.btnThongTinNhanSu.UseVisualStyleBackColor = false;
            this.btnThongTinNhanSu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTuyenDung
            // 
            this.btnTuyenDung.BackColor = System.Drawing.Color.Transparent;
            this.btnTuyenDung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTuyenDung.BackgroundImage")));
            this.btnTuyenDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTuyenDung.FlatAppearance.BorderSize = 0;
            this.btnTuyenDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTuyenDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTuyenDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuyenDung.Location = new System.Drawing.Point(10, -91);
            this.btnTuyenDung.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuyenDung.Name = "btnTuyenDung";
            this.btnTuyenDung.Size = new System.Drawing.Size(371, 368);
            this.btnTuyenDung.TabIndex = 7;
            this.btnTuyenDung.UseVisualStyleBackColor = false;
            this.btnTuyenDung.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Location = new System.Drawing.Point(761, -91);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(371, 368);
            this.btnChamCong.TabIndex = 0;
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.lblChaomung);
            this.Header.Controls.Add(this.lblProfile);
            this.Header.Location = new System.Drawing.Point(1, 1);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1535, 125);
            this.Header.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 42);
            this.label1.TabIndex = 99;
            this.label1.Text = "DBPT";
            // 
            // lblChaomung
            // 
            this.lblChaomung.AutoSize = true;
            this.lblChaomung.BackColor = System.Drawing.Color.Transparent;
            this.lblChaomung.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.lblChaomung.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblChaomung.Location = new System.Drawing.Point(447, 94);
            this.lblChaomung.Name = "lblChaomung";
            this.lblChaomung.Size = new System.Drawing.Size(619, 27);
            this.lblChaomung.TabIndex = 98;
            this.lblChaomung.Text = "Chào mừng người dùng, hãy chọn chức năng làm việc của bạn";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblProfile.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold);
            this.lblProfile.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblProfile.Location = new System.Drawing.Point(581, 8);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(328, 76);
            this.lblProfile.TabIndex = 97;
            this.lblProfile.Text = "Trang chủ";
            // 
            // HeThongQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 807);
            this.Controls.Add(this.All);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HeThongQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeThongQuanLy";
            this.All.ResumeLayout(false);
            this.All.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnThongTinNhanSu;
        private System.Windows.Forms.Button btnTienLuong;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTuyenDung;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel All;
        private System.Windows.Forms.Panel panel1;
        private Label lblProfile;
        private Label lblChaomung;
        private Label label1;
        private Label label2;
    }
}