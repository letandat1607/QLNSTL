using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class ThongTinNhanSuNghiviec
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
            this.btnPhucloi = new System.Windows.Forms.Button();
            this.btnSuco = new System.Windows.Forms.Button();
            this.btnKhenthuong = new System.Windows.Forms.Button();
            this.btnNghiviec = new System.Windows.Forms.Button();
            this.btnHopdong = new System.Windows.Forms.Button();
            this.btnHoso = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblThongtinnhansu = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnThemmoithongtintuyendung = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.pnlDangnghi = new System.Windows.Forms.Panel();
            this.lblSoluongdanghi = new System.Windows.Forms.Label();
            this.lblDanghi = new System.Windows.Forms.Label();
            this.pnlDanglamviec = new System.Windows.Forms.Panel();
            this.lblSoluongdanglamviec = new System.Windows.Forms.Label();
            this.lblDanglamviec = new System.Windows.Forms.Label();
            this.lblNghiviec = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colManhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitricongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManhanviennghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLidonghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiduyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.All = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Main.SuspendLayout();
            this.pnlDangnghi.SuspendLayout();
            this.pnlDanglamviec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.All.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SideBar.Controls.Add(this.btnPhucloi);
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
            // btnPhucloi
            // 
            this.btnPhucloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPhucloi.Location = new System.Drawing.Point(12, 362);
            this.btnPhucloi.Name = "btnPhucloi";
            this.btnPhucloi.Size = new System.Drawing.Size(223, 42);
            this.btnPhucloi.TabIndex = 8;
            this.btnPhucloi.Text = "Phúc lợi";
            this.btnPhucloi.UseVisualStyleBackColor = true;
            this.btnPhucloi.Click += new System.EventHandler(this.btnPhucloi_Click);
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
            this.btnNghiviec.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNghiviec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNghiviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNghiviec.ForeColor = System.Drawing.Color.White;
            this.btnNghiviec.Location = new System.Drawing.Point(12, 151);
            this.btnNghiviec.Name = "btnNghiviec";
            this.btnNghiviec.Size = new System.Drawing.Size(223, 42);
            this.btnNghiviec.TabIndex = 5;
            this.btnNghiviec.Text = "Nghỉ việc";
            this.btnNghiviec.UseVisualStyleBackColor = false;
            this.btnNghiviec.Click += new System.EventHandler(this.btnNghiviec_Click);
            // 
            // btnHopdong
            // 
            this.btnHopdong.BackColor = System.Drawing.Color.White;
            this.btnHopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHopdong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.lblThongtinnhansu);
            this.Header.Controls.Add(this.txtTimkiem);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1375, 60);
            this.Header.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.nhansu;
            this.pictureBox2.Location = new System.Drawing.Point(71, 6);
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
            this.lblThongtinnhansu.Location = new System.Drawing.Point(128, 19);
            this.lblThongtinnhansu.Name = "lblThongtinnhansu";
            this.lblThongtinnhansu.Size = new System.Drawing.Size(186, 25);
            this.lblThongtinnhansu.TabIndex = 22;
            this.lblThongtinnhansu.Text = "Thông tin nhân sự";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimkiem.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTimkiem.Location = new System.Drawing.Point(331, 19);
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
            this.btnThemmoithongtintuyendung.Location = new System.Drawing.Point(782, 117);
            this.btnThemmoithongtintuyendung.Name = "btnThemmoithongtintuyendung";
            this.btnThemmoithongtintuyendung.Size = new System.Drawing.Size(137, 34);
            this.btnThemmoithongtintuyendung.TabIndex = 2;
            this.btnThemmoithongtintuyendung.Text = "+ Thêm mới";
            this.btnThemmoithongtintuyendung.UseVisualStyleBackColor = false;
            this.btnThemmoithongtintuyendung.Click += new System.EventHandler(this.btnThemmoithongtintuyendung_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.pnlDangnghi);
            this.Main.Controls.Add(this.pnlDanglamviec);
            this.Main.Controls.Add(this.lblNghiviec);
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.dataGridView1);
            this.Main.Controls.Add(this.comboBox1);
            this.Main.Controls.Add(this.btnThemmoithongtintuyendung);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 634);
            this.Main.TabIndex = 3;
            // 
            // pnlDangnghi
            // 
            this.pnlDangnghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlDangnghi.Controls.Add(this.lblSoluongdanghi);
            this.pnlDangnghi.Controls.Add(this.lblDanghi);
            this.pnlDangnghi.Location = new System.Drawing.Point(526, 14);
            this.pnlDangnghi.Name = "pnlDangnghi";
            this.pnlDangnghi.Size = new System.Drawing.Size(178, 131);
            this.pnlDangnghi.TabIndex = 20;
            // 
            // lblSoluongdanghi
            // 
            this.lblSoluongdanghi.AutoSize = true;
            this.lblSoluongdanghi.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold);
            this.lblSoluongdanghi.ForeColor = System.Drawing.Color.White;
            this.lblSoluongdanghi.Location = new System.Drawing.Point(86, 41);
            this.lblSoluongdanghi.Name = "lblSoluongdanghi";
            this.lblSoluongdanghi.Size = new System.Drawing.Size(79, 88);
            this.lblSoluongdanghi.TabIndex = 2;
            this.lblSoluongdanghi.Text = "0";
            // 
            // lblDanghi
            // 
            this.lblDanghi.AutoSize = true;
            this.lblDanghi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanghi.ForeColor = System.Drawing.Color.White;
            this.lblDanghi.Location = new System.Drawing.Point(35, 13);
            this.lblDanghi.Name = "lblDanghi";
            this.lblDanghi.Size = new System.Drawing.Size(81, 22);
            this.lblDanghi.TabIndex = 1;
            this.lblDanghi.Text = "Đã nghỉ";
            // 
            // pnlDanglamviec
            // 
            this.pnlDanglamviec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlDanglamviec.Controls.Add(this.lblSoluongdanglamviec);
            this.pnlDanglamviec.Controls.Add(this.lblDanglamviec);
            this.pnlDanglamviec.Location = new System.Drawing.Point(291, 17);
            this.pnlDanglamviec.Name = "pnlDanglamviec";
            this.pnlDanglamviec.Size = new System.Drawing.Size(179, 131);
            this.pnlDanglamviec.TabIndex = 19;
            // 
            // lblSoluongdanglamviec
            // 
            this.lblSoluongdanglamviec.AutoSize = true;
            this.lblSoluongdanglamviec.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold);
            this.lblSoluongdanglamviec.ForeColor = System.Drawing.Color.White;
            this.lblSoluongdanglamviec.Location = new System.Drawing.Point(97, 38);
            this.lblSoluongdanglamviec.Name = "lblSoluongdanglamviec";
            this.lblSoluongdanglamviec.Size = new System.Drawing.Size(79, 88);
            this.lblSoluongdanglamviec.TabIndex = 3;
            this.lblSoluongdanglamviec.Text = "0";
            // 
            // lblDanglamviec
            // 
            this.lblDanglamviec.AutoSize = true;
            this.lblDanglamviec.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblDanglamviec.ForeColor = System.Drawing.Color.White;
            this.lblDanglamviec.Location = new System.Drawing.Point(19, 10);
            this.lblDanglamviec.Name = "lblDanglamviec";
            this.lblDanglamviec.Size = new System.Drawing.Size(140, 22);
            this.lblDanglamviec.TabIndex = 0;
            this.lblDanglamviec.Text = "Đang làm việc";
            // 
            // lblNghiviec
            // 
            this.lblNghiviec.AutoSize = true;
            this.lblNghiviec.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblNghiviec.Location = new System.Drawing.Point(24, 17);
            this.lblNghiviec.Name = "lblNghiviec";
            this.lblNghiviec.Size = new System.Drawing.Size(95, 22);
            this.lblNghiviec.TabIndex = 18;
            this.lblNghiviec.Text = "Nghỉ việc";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(925, 117);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 34);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "+Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(1008, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManhanvien,
            this.colTen,
            this.colVitricongviec,
            this.colManhanviennghi,
            this.colNgayketthuc,
            this.colLidonghi,
            this.colNguoiduyet});
            this.dataGridView1.Location = new System.Drawing.Point(28, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 457);
            this.dataGridView1.TabIndex = 6;
            // 
            // colManhanvien
            // 
            this.colManhanvien.HeaderText = "Mã nhân viên";
            this.colManhanvien.MinimumWidth = 6;
            this.colManhanvien.Name = "colManhanvien";
            this.colManhanvien.ReadOnly = true;
            this.colManhanvien.Width = 125;
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
            // colManhanviennghi
            // 
            this.colManhanviennghi.HeaderText = "Ngày bắt đầu nghỉ";
            this.colManhanviennghi.MinimumWidth = 6;
            this.colManhanviennghi.Name = "colManhanviennghi";
            this.colManhanviennghi.ReadOnly = true;
            this.colManhanviennghi.Width = 125;
            // 
            // colNgayketthuc
            // 
            this.colNgayketthuc.HeaderText = "Ngày kết thúc";
            this.colNgayketthuc.MinimumWidth = 6;
            this.colNgayketthuc.Name = "colNgayketthuc";
            this.colNgayketthuc.ReadOnly = true;
            this.colNgayketthuc.Width = 99;
            // 
            // colLidonghi
            // 
            this.colLidonghi.HeaderText = "Lí do nghỉ";
            this.colLidonghi.MinimumWidth = 6;
            this.colLidonghi.Name = "colLidonghi";
            this.colLidonghi.ReadOnly = true;
            this.colLidonghi.Width = 125;
            // 
            // colNguoiduyet
            // 
            this.colNguoiduyet.HeaderText = "Người duyệt";
            this.colNguoiduyet.MinimumWidth = 6;
            this.colNguoiduyet.Name = "colNguoiduyet";
            this.colNguoiduyet.ReadOnly = true;
            this.colNguoiduyet.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Họ và tên",
            "Vị trí"});
            this.comboBox1.Location = new System.Drawing.Point(29, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Tất cả";
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
            // ThongTinNhanSuNghiviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinNhanSuNghiviec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNhanSuHopdong";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.pnlDangnghi.ResumeLayout(false);
            this.pnlDangnghi.PerformLayout();
            this.pnlDanglamviec.ResumeLayout(false);
            this.pnlDanglamviec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Panel All;
        private Button btnSua;
        private Button btnXoa;
        private Button btnPhucloi;
        private Button btnSuco;
        private Button btnKhenthuong;
        private Button btnNghiviec;
        private Label lblNghiviec;
        private Panel pnlDangnghi;
        private Label lblDanghi;
        private Panel pnlDanglamviec;
        private Label lblDanglamviec;
        private Label lblSoluongdanghi;
        private DataGridViewTextBoxColumn colManhanvien;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colVitricongviec;
        private DataGridViewTextBoxColumn colManhanviennghi;
        private DataGridViewTextBoxColumn colNgayketthuc;
        private DataGridViewTextBoxColumn colLidonghi;
        private DataGridViewTextBoxColumn colNguoiduyet;
        private Label lblSoluongdanglamviec;
        private PictureBox pictureBox2;
        private Label lblThongtinnhansu;
        private TextBox txtTimkiem;
    }
}