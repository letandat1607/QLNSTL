using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.TuyenDung
{
    partial class TuyenDungUngvien
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
            this.btnUngvien = new System.Windows.Forms.Button();
            this.btnTintuyendung = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.lblTuyendung = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtgvUngvien = new System.Windows.Forms.DataGridView();
            this.Manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitrituyendung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytuyendung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trinhdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUngvien = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.All = new System.Windows.Forms.Panel();
            this.picBMenu = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUngvien)).BeginInit();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideBar.Controls.Add(this.btnUngvien);
            this.SideBar.Controls.Add(this.btnTintuyendung);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 60);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(250, 625);
            this.SideBar.TabIndex = 0;
            // 
            // btnUngvien
            // 
            this.btnUngvien.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUngvien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUngvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUngvien.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUngvien.Location = new System.Drawing.Point(12, 66);
            this.btnUngvien.Name = "btnUngvien";
            this.btnUngvien.Size = new System.Drawing.Size(223, 42);
            this.btnUngvien.TabIndex = 3;
            this.btnUngvien.Text = "Ứng viên";
            this.btnUngvien.UseVisualStyleBackColor = false;
            this.btnUngvien.Click += new System.EventHandler(this.btnUngvien_Click);
            // 
            // btnTintuyendung
            // 
            this.btnTintuyendung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTintuyendung.Location = new System.Drawing.Point(13, 7);
            this.btnTintuyendung.Name = "btnTintuyendung";
            this.btnTintuyendung.Size = new System.Drawing.Size(223, 42);
            this.btnTintuyendung.TabIndex = 0;
            this.btnTintuyendung.Text = "Tin tuyển dụng";
            this.btnTintuyendung.UseVisualStyleBackColor = true;
            this.btnTintuyendung.Click += new System.EventHandler(this.btnTintuyendung_Click);
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
            // lblTuyendung
            // 
            this.lblTuyendung.AutoSize = true;
            this.lblTuyendung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTuyendung.Location = new System.Drawing.Point(102, 19);
            this.lblTuyendung.Name = "lblTuyendung";
            this.lblTuyendung.Size = new System.Drawing.Size(127, 25);
            this.lblTuyendung.TabIndex = 1;
            this.lblTuyendung.Text = "Tuyển dụng";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimkiem.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTimkiem.Location = new System.Drawing.Point(235, 19);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(280, 32);
            this.txtTimkiem.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources._1200x630wa_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.btnTim);
            this.Main.Controls.Add(this.dtgvUngvien);
            this.Main.Controls.Add(this.lblUngvien);
            this.Main.Controls.Add(this.btnThemmoi);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 625);
            this.Main.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(788, 39);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 34);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "+Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(871, 39);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 34);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnTim.Location = new System.Drawing.Point(555, 40);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 33);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtgvUngvien
            // 
            this.dtgvUngvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvUngvien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvUngvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUngvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhanvien,
            this.Ten,
            this.Sdt,
            this.Email,
            this.Vitrituyendung,
            this.Ngaytuyendung,
            this.Trinhdo,
            this.Chuyennganh,
            this.Tinhtrang});
            this.dtgvUngvien.Location = new System.Drawing.Point(21, 79);
            this.dtgvUngvien.Name = "dtgvUngvien";
            this.dtgvUngvien.ReadOnly = true;
            this.dtgvUngvien.RowHeadersWidth = 51;
            this.dtgvUngvien.RowTemplate.Height = 24;
            this.dtgvUngvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUngvien.Size = new System.Drawing.Size(1077, 534);
            this.dtgvUngvien.TabIndex = 6;
            this.dtgvUngvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUngvien_CellContentClick);
            // 
            // Manhanvien
            // 
            this.Manhanvien.HeaderText = "Mã nhân viên";
            this.Manhanvien.MinimumWidth = 6;
            this.Manhanvien.Name = "Manhanvien";
            this.Manhanvien.ReadOnly = true;
            this.Manhanvien.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Họ và Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 110;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Vitrituyendung
            // 
            this.Vitrituyendung.HeaderText = "Vị trí tuyển dụng";
            this.Vitrituyendung.MinimumWidth = 6;
            this.Vitrituyendung.Name = "Vitrituyendung";
            this.Vitrituyendung.ReadOnly = true;
            this.Vitrituyendung.Width = 120;
            // 
            // Ngaytuyendung
            // 
            this.Ngaytuyendung.HeaderText = "Ngày tuyển dụng";
            this.Ngaytuyendung.MinimumWidth = 6;
            this.Ngaytuyendung.Name = "Ngaytuyendung";
            this.Ngaytuyendung.ReadOnly = true;
            this.Ngaytuyendung.Width = 117;
            // 
            // Trinhdo
            // 
            this.Trinhdo.HeaderText = "Trình độ";
            this.Trinhdo.MinimumWidth = 6;
            this.Trinhdo.Name = "Trinhdo";
            this.Trinhdo.ReadOnly = true;
            this.Trinhdo.Width = 125;
            // 
            // Chuyennganh
            // 
            this.Chuyennganh.HeaderText = "Chuyên ngành";
            this.Chuyennganh.MinimumWidth = 6;
            this.Chuyennganh.Name = "Chuyennganh";
            this.Chuyennganh.ReadOnly = true;
            this.Chuyennganh.Width = 125;
            // 
            // Tinhtrang
            // 
            this.Tinhtrang.HeaderText = "Tình trạng";
            this.Tinhtrang.MinimumWidth = 6;
            this.Tinhtrang.Name = "Tinhtrang";
            this.Tinhtrang.ReadOnly = true;
            this.Tinhtrang.Width = 125;
            // 
            // lblUngvien
            // 
            this.lblUngvien.AutoSize = true;
            this.lblUngvien.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblUngvien.Location = new System.Drawing.Point(24, 17);
            this.lblUngvien.Name = "lblUngvien";
            this.lblUngvien.Size = new System.Drawing.Size(122, 30);
            this.lblUngvien.TabIndex = 4;
            this.lblUngvien.Text = "Ứng viên";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(648, 40);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(135, 34);
            this.btnThemmoi.TabIndex = 2;
            this.btnThemmoi.Text = "+ Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemungvien_Click);
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
            // picBMenu
            // 
            this.picBMenu.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.menu;
            this.picBMenu.Location = new System.Drawing.Point(3, 6);
            this.picBMenu.Name = "picBMenu";
            this.picBMenu.Size = new System.Drawing.Size(51, 48);
            this.picBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMenu.TabIndex = 23;
            this.picBMenu.TabStop = false;
            this.picBMenu.Click += new System.EventHandler(this.picBMenu_Click);
            // 
            // TuyenDungUngvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 685);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TuyenDungUngvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuyenDung";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUngvien)).EndInit();
            this.All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox txtTimkiem;
        private Button btnTintuyendung;
        private Button btnUngvien;
        private Label lblTuyendung;
        private Panel Main;
        private Label lblUngvien;
        private DataGridView dtgvUngvien;
        private Panel All;
        private Button btnTim;
        private Button btnXoa;
        private Button btnThemmoi;
        private Button btnSua;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Manhanvien;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Vitrituyendung;
        private DataGridViewTextBoxColumn Ngaytuyendung;
        private DataGridViewTextBoxColumn Trinhdo;
        private DataGridViewTextBoxColumn Chuyennganh;
        private DataGridViewTextBoxColumn Tinhtrang;
        private PictureBox picBMenu;
    }
}