using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class ThongTinNhanSuHopdong
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
            this.btnQuanLyTK = new System.Windows.Forms.Button();
            this.btnSuco = new System.Windows.Forms.Button();
            this.btnKhenthuong = new System.Windows.Forms.Button();
            this.btnNghiviec = new System.Windows.Forms.Button();
            this.btnHopdong = new System.Windows.Forms.Button();
            this.btnHoso = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.picBMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblThongtinnhansu = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnThemmoithongtintuyendung = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTatcahopdong = new System.Windows.Forms.Label();
            this.dtgvHethan = new System.Windows.Forms.DataGridView();
            this.colNgayketthuc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMahopdong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitri1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaihoapdong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChamdut = new System.Windows.Forms.Button();
            this.dtgvHD = new System.Windows.Forms.DataGridView();
            this.colMahopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitricongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaihopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHopdonghethan = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHethan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).BeginInit();
            this.All.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideBar.Controls.Add(this.btnQuanLyTK);
            this.SideBar.Controls.Add(this.btnSuco);
            this.SideBar.Controls.Add(this.btnKhenthuong);
            this.SideBar.Controls.Add(this.btnNghiviec);
            this.SideBar.Controls.Add(this.btnHopdong);
            this.SideBar.Controls.Add(this.btnHoso);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 60);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(250, 634);
            this.SideBar.TabIndex = 0;
            // 
            // btnQuanLyTK
            // 
            this.btnQuanLyTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuanLyTK.Location = new System.Drawing.Point(12, 362);
            this.btnQuanLyTK.Name = "btnQuanLyTK";
            this.btnQuanLyTK.Size = new System.Drawing.Size(223, 42);
            this.btnQuanLyTK.TabIndex = 8;
            this.btnQuanLyTK.Text = "Quản lý tài khoản";
            this.btnQuanLyTK.UseVisualStyleBackColor = true;
            this.btnQuanLyTK.Click += new System.EventHandler(this.btnPhucloi_Click);
            // 
            // btnSuco
            // 
            this.btnSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSuco.Location = new System.Drawing.Point(12, 293);
            this.btnSuco.Name = "btnSuco";
            this.btnSuco.Size = new System.Drawing.Size(223, 42);
            this.btnSuco.TabIndex = 7;
            this.btnSuco.Text = "Sự cố";
            this.btnSuco.UseVisualStyleBackColor = true;
            this.btnSuco.Click += new System.EventHandler(this.btnSuco_Click);
            // 
            // btnKhenthuong
            // 
            this.btnKhenthuong.BackColor = System.Drawing.Color.White;
            this.btnKhenthuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhenthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKhenthuong.ForeColor = System.Drawing.Color.Black;
            this.btnKhenthuong.Location = new System.Drawing.Point(12, 222);
            this.btnKhenthuong.Name = "btnKhenthuong";
            this.btnKhenthuong.Size = new System.Drawing.Size(223, 42);
            this.btnKhenthuong.TabIndex = 6;
            this.btnKhenthuong.Text = "Khen thưởng";
            this.btnKhenthuong.UseVisualStyleBackColor = false;
            this.btnKhenthuong.Click += new System.EventHandler(this.btnKhenthuong_Click);
            // 
            // btnNghiviec
            // 
            this.btnNghiviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNghiviec.Location = new System.Drawing.Point(12, 151);
            this.btnNghiviec.Name = "btnNghiviec";
            this.btnNghiviec.Size = new System.Drawing.Size(223, 42);
            this.btnNghiviec.TabIndex = 5;
            this.btnNghiviec.Text = "Nghỉ việc";
            this.btnNghiviec.UseVisualStyleBackColor = true;
            this.btnNghiviec.Click += new System.EventHandler(this.btnNghiviec_Click);
            // 
            // btnHopdong
            // 
            this.btnHopdong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHopdong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHopdong.ForeColor = System.Drawing.Color.White;
            this.btnHopdong.Location = new System.Drawing.Point(12, 82);
            this.btnHopdong.Name = "btnHopdong";
            this.btnHopdong.Size = new System.Drawing.Size(223, 42);
            this.btnHopdong.TabIndex = 3;
            this.btnHopdong.Text = "Hợp đồng";
            this.btnHopdong.UseVisualStyleBackColor = false;
            this.btnHopdong.Click += new System.EventHandler(this.btnHopdong_Click);
            // 
            // btnHoso
            // 
            this.btnHoso.BackColor = System.Drawing.Color.White;
            this.btnHoso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHoso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHoso.Location = new System.Drawing.Point(12, 17);
            this.btnHoso.Name = "btnHoso";
            this.btnHoso.Size = new System.Drawing.Size(223, 42);
            this.btnHoso.TabIndex = 0;
            this.btnHoso.Text = "Hồ sơ";
            this.btnHoso.UseVisualStyleBackColor = false;
            this.btnHoso.Click += new System.EventHandler(this.btnHoso_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.picBMenu);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.lblThongtinnhansu);
            this.Header.Controls.Add(this.txtTimkiem);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1375, 60);
            this.Header.TabIndex = 1;
            // 
            // picBMenu
            // 
            this.picBMenu.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.menu;
            this.picBMenu.Location = new System.Drawing.Point(15, 6);
            this.picBMenu.Name = "picBMenu";
            this.picBMenu.Size = new System.Drawing.Size(51, 48);
            this.picBMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBMenu.TabIndex = 24;
            this.picBMenu.TabStop = false;
            this.picBMenu.Click += new System.EventHandler(this.picBMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.nhansu;
            this.pictureBox2.Location = new System.Drawing.Point(72, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // lblThongtinnhansu
            // 
            this.lblThongtinnhansu.AutoSize = true;
            this.lblThongtinnhansu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongtinnhansu.Location = new System.Drawing.Point(129, 19);
            this.lblThongtinnhansu.Name = "lblThongtinnhansu";
            this.lblThongtinnhansu.Size = new System.Drawing.Size(186, 25);
            this.lblThongtinnhansu.TabIndex = 22;
            this.lblThongtinnhansu.Text = "Thông tin nhân sự";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimkiem.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTimkiem.Location = new System.Drawing.Point(332, 19);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(280, 32);
            this.txtTimkiem.TabIndex = 21;
            // 
            // btnThemmoithongtintuyendung
            // 
            this.btnThemmoithongtintuyendung.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmoithongtintuyendung.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemmoithongtintuyendung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoithongtintuyendung.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemmoithongtintuyendung.ForeColor = System.Drawing.Color.White;
            this.btnThemmoithongtintuyendung.Location = new System.Drawing.Point(629, 322);
            this.btnThemmoithongtintuyendung.Name = "btnThemmoithongtintuyendung";
            this.btnThemmoithongtintuyendung.Size = new System.Drawing.Size(137, 34);
            this.btnThemmoithongtintuyendung.TabIndex = 2;
            this.btnThemmoithongtintuyendung.Text = "+ Thêm mới";
            this.btnThemmoithongtintuyendung.UseVisualStyleBackColor = false;
            this.btnThemmoithongtintuyendung.Click += new System.EventHandler(this.btnThemmoithongtintuyendung_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.lblTatcahopdong);
            this.Main.Controls.Add(this.dtgvHethan);
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnChamdut);
            this.Main.Controls.Add(this.dtgvHD);
            this.Main.Controls.Add(this.lblHopdonghethan);
            this.Main.Controls.Add(this.btnThemmoithongtintuyendung);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 634);
            this.Main.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(855, 322);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 34);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTatcahopdong
            // 
            this.lblTatcahopdong.AutoSize = true;
            this.lblTatcahopdong.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblTatcahopdong.Location = new System.Drawing.Point(24, 322);
            this.lblTatcahopdong.Name = "lblTatcahopdong";
            this.lblTatcahopdong.Size = new System.Drawing.Size(163, 22);
            this.lblTatcahopdong.TabIndex = 18;
            this.lblTatcahopdong.Text = "Tất cả hợp đồng";
            // 
            // dtgvHethan
            // 
            this.dtgvHethan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvHethan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHethan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgayketthuc1,
            this.colMahopdong1,
            this.colTen1,
            this.colVitri1,
            this.colLoaihoapdong1});
            this.dtgvHethan.Location = new System.Drawing.Point(18, 63);
            this.dtgvHethan.Name = "dtgvHethan";
            this.dtgvHethan.RowHeadersWidth = 51;
            this.dtgvHethan.RowTemplate.Height = 24;
            this.dtgvHethan.Size = new System.Drawing.Size(656, 200);
            this.dtgvHethan.TabIndex = 17;
            // 
            // colNgayketthuc1
            // 
            this.colNgayketthuc1.HeaderText = "Ngày kết thúc";
            this.colNgayketthuc1.MinimumWidth = 6;
            this.colNgayketthuc1.Name = "colNgayketthuc1";
            this.colNgayketthuc1.ReadOnly = true;
            this.colNgayketthuc1.Width = 99;
            // 
            // colMahopdong1
            // 
            this.colMahopdong1.HeaderText = "Mã hợp đồng";
            this.colMahopdong1.MinimumWidth = 6;
            this.colMahopdong1.Name = "colMahopdong1";
            this.colMahopdong1.ReadOnly = true;
            this.colMahopdong1.Width = 99;
            // 
            // colTen1
            // 
            this.colTen1.HeaderText = "Họ và tên";
            this.colTen1.MinimumWidth = 6;
            this.colTen1.Name = "colTen1";
            this.colTen1.ReadOnly = true;
            this.colTen1.Width = 125;
            // 
            // colVitri1
            // 
            this.colVitri1.HeaderText = "Vị trí";
            this.colVitri1.MinimumWidth = 6;
            this.colVitri1.Name = "colVitri1";
            this.colVitri1.ReadOnly = true;
            this.colVitri1.Width = 90;
            // 
            // colLoaihoapdong1
            // 
            this.colLoaihoapdong1.HeaderText = "Loại hợp đồng";
            this.colLoaihoapdong1.MinimumWidth = 6;
            this.colLoaihoapdong1.Name = "colLoaihoapdong1";
            this.colLoaihoapdong1.ReadOnly = true;
            this.colLoaihoapdong1.Width = 90;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(772, 322);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 34);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "+Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChamdut
            // 
            this.btnChamdut.BackColor = System.Drawing.Color.White;
            this.btnChamdut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChamdut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamdut.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnChamdut.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnChamdut.Location = new System.Drawing.Point(930, 322);
            this.btnChamdut.Name = "btnChamdut";
            this.btnChamdut.Size = new System.Drawing.Size(138, 34);
            this.btnChamdut.TabIndex = 13;
            this.btnChamdut.Text = "- Chấm dứt";
            this.btnChamdut.UseVisualStyleBackColor = false;
            this.btnChamdut.Click += new System.EventHandler(this.btnChamdut_Click);
            // 
            // dtgvHD
            // 
            this.dtgvHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMahopdong,
            this.colTen,
            this.colVitricongviec,
            this.colNgaybatdau,
            this.colNgayketthuc,
            this.colLoaihopdong});
            this.dtgvHD.Location = new System.Drawing.Point(17, 367);
            this.dtgvHD.Name = "dtgvHD";
            this.dtgvHD.RowHeadersWidth = 51;
            this.dtgvHD.RowTemplate.Height = 24;
            this.dtgvHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHD.Size = new System.Drawing.Size(1085, 255);
            this.dtgvHD.TabIndex = 6;
            this.dtgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHD_CellContentClick);
            // 
            // colMahopdong
            // 
            this.colMahopdong.HeaderText = "Mã hợp đồng";
            this.colMahopdong.MinimumWidth = 6;
            this.colMahopdong.Name = "colMahopdong";
            this.colMahopdong.ReadOnly = true;
            this.colMahopdong.Width = 125;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Họ và tên";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 135;
            // 
            // colVitricongviec
            // 
            this.colVitricongviec.HeaderText = "Vị trí";
            this.colVitricongviec.MinimumWidth = 6;
            this.colVitricongviec.Name = "colVitricongviec";
            this.colVitricongviec.ReadOnly = true;
            this.colVitricongviec.Width = 125;
            // 
            // colNgaybatdau
            // 
            this.colNgaybatdau.HeaderText = "Ngày bắt đầu";
            this.colNgaybatdau.MinimumWidth = 6;
            this.colNgaybatdau.Name = "colNgaybatdau";
            this.colNgaybatdau.ReadOnly = true;
            this.colNgaybatdau.Width = 125;
            // 
            // colNgayketthuc
            // 
            this.colNgayketthuc.HeaderText = "Ngày kết thúc";
            this.colNgayketthuc.MinimumWidth = 6;
            this.colNgayketthuc.Name = "colNgayketthuc";
            this.colNgayketthuc.ReadOnly = true;
            this.colNgayketthuc.Width = 125;
            // 
            // colLoaihopdong
            // 
            this.colLoaihopdong.HeaderText = "Loại hợp đồng";
            this.colLoaihopdong.MinimumWidth = 6;
            this.colLoaihopdong.Name = "colLoaihopdong";
            this.colLoaihopdong.ReadOnly = true;
            this.colLoaihopdong.Width = 125;
            // 
            // lblHopdonghethan
            // 
            this.lblHopdonghethan.AutoSize = true;
            this.lblHopdonghethan.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblHopdonghethan.Location = new System.Drawing.Point(24, 17);
            this.lblHopdonghethan.Name = "lblHopdonghethan";
            this.lblHopdonghethan.Size = new System.Drawing.Size(176, 22);
            this.lblHopdonghethan.TabIndex = 4;
            this.lblHopdonghethan.Text = "Hợp đồng hết hạn";
            // 
            // All
            // 
            this.All.Controls.Add(this.Main);
            this.All.Controls.Add(this.SideBar);
            this.All.Controls.Add(this.Header);
            this.All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(1375, 694);
            this.All.TabIndex = 2;
            // 
            // ThongTinNhanSuHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinNhanSuHopdong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNhanSuHopdong";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHethan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHD)).EndInit();
            this.All.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Button btnHoso;
        private Button btnHopdong;
        private Button btnThemmoithongtintuyendung;
        private Panel Main;
        private DataGridView dtgvHD;
        private Panel All;
        private Button btnChamdut;
        private Button btnQuanLyTK;
        private Button btnSuco;
        private Button btnKhenthuong;
        private Button btnNghiviec;
        //private System.Windows.Forms.DataVisualization.Charting.Chart charttinhtrang;
        private DataGridView dtgvHethan;
        private Label lblHopdonghethan;
        private Label lblTatcahopdong;
        private DataGridViewTextBoxColumn colNgayketthuc1;
        private DataGridViewTextBoxColumn colMahopdong1;
        private DataGridViewTextBoxColumn colTen1;
        private DataGridViewTextBoxColumn colVitri1;
        private DataGridViewTextBoxColumn colLoaihoapdong1;
        private DataGridViewTextBoxColumn colMahopdong;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colVitricongviec;
        private DataGridViewTextBoxColumn colNgaybatdau;
        private DataGridViewTextBoxColumn colNgayketthuc;
        private DataGridViewTextBoxColumn colLoaihopdong;
        private PictureBox pictureBox2;
        private Label lblThongtinnhansu;
        private TextBox txtTimkiem;
        private Button btnXoa;
        private Button btnSua;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox picBMenu;
    }
}