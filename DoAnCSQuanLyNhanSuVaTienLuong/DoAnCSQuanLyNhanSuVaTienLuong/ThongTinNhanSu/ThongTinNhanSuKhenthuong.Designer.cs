using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class ThongTinNhanSuKhenthuong
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
            this.All = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.dgvChiTietNhanVien = new System.Windows.Forms.DataGridView();
            this.pnlKhenthuong = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSoluongnhanvienkhenthuong = new System.Windows.Forms.Label();
            this.lblNhanvienkhenthuong = new System.Windows.Forms.Label();
            this.lblKhenthuong = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvKhenThuong = new System.Windows.Forms.DataGridView();
            this.colManhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitricongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaykhenthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiduyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.All.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhanVien)).BeginInit();
            this.pnlKhenthuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).BeginInit();
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
            this.btnKhenthuong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKhenthuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhenthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKhenthuong.ForeColor = System.Drawing.Color.White;
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
            this.btnNghiviec.BackColor = System.Drawing.Color.White;
            this.btnNghiviec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNghiviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNghiviec.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // Main
            // 
            this.Main.Controls.Add(this.dgvChiTietNhanVien);
            this.Main.Controls.Add(this.pnlKhenthuong);
            this.Main.Controls.Add(this.lblKhenthuong);
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.dgvKhenThuong);
            this.Main.Controls.Add(this.btnThemmoi);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 634);
            this.Main.TabIndex = 3;
            // 
            // dgvChiTietNhanVien
            // 
            this.dgvChiTietNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhanVien.Location = new System.Drawing.Point(62, 165);
            this.dgvChiTietNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiTietNhanVien.Name = "dgvChiTietNhanVien";
            this.dgvChiTietNhanVien.RowHeadersWidth = 62;
            this.dgvChiTietNhanVien.RowTemplate.Height = 28;
            this.dgvChiTietNhanVien.Size = new System.Drawing.Size(887, 313);
            this.dgvChiTietNhanVien.TabIndex = 20;
            this.dgvChiTietNhanVien.Visible = false;
            // 
            // pnlKhenthuong
            // 
            this.pnlKhenthuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlKhenthuong.Controls.Add(this.pictureBox1);
            this.pnlKhenthuong.Controls.Add(this.lblSoluongnhanvienkhenthuong);
            this.pnlKhenthuong.Controls.Add(this.lblNhanvienkhenthuong);
            this.pnlKhenthuong.Location = new System.Drawing.Point(291, 17);
            this.pnlKhenthuong.Name = "pnlKhenthuong";
            this.pnlKhenthuong.Size = new System.Drawing.Size(373, 131);
            this.pnlKhenthuong.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.LikeChingchong_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(23, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblSoluongnhanvienkhenthuong
            // 
            this.lblSoluongnhanvienkhenthuong.AutoSize = true;
            this.lblSoluongnhanvienkhenthuong.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold);
            this.lblSoluongnhanvienkhenthuong.ForeColor = System.Drawing.Color.Green;
            this.lblSoluongnhanvienkhenthuong.Location = new System.Drawing.Point(294, 38);
            this.lblSoluongnhanvienkhenthuong.Name = "lblSoluongnhanvienkhenthuong";
            this.lblSoluongnhanvienkhenthuong.Size = new System.Drawing.Size(79, 88);
            this.lblSoluongnhanvienkhenthuong.TabIndex = 3;
            this.lblSoluongnhanvienkhenthuong.Text = "0";
            // 
            // lblNhanvienkhenthuong
            // 
            this.lblNhanvienkhenthuong.AutoSize = true;
            this.lblNhanvienkhenthuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNhanvienkhenthuong.ForeColor = System.Drawing.Color.Green;
            this.lblNhanvienkhenthuong.Location = new System.Drawing.Point(81, 8);
            this.lblNhanvienkhenthuong.Name = "lblNhanvienkhenthuong";
            this.lblNhanvienkhenthuong.Size = new System.Drawing.Size(233, 24);
            this.lblNhanvienkhenthuong.TabIndex = 0;
            this.lblNhanvienkhenthuong.Text = "Nhân viên khen thưởng";
            // 
            // lblKhenthuong
            // 
            this.lblKhenthuong.AutoSize = true;
            this.lblKhenthuong.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblKhenthuong.Location = new System.Drawing.Point(24, 17);
            this.lblKhenthuong.Name = "lblKhenthuong";
            this.lblKhenthuong.Size = new System.Drawing.Size(134, 22);
            this.lblKhenthuong.TabIndex = 18;
            this.lblKhenthuong.Text = "Khen thưởng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSua.Location = new System.Drawing.Point(830, 116);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 34);
            this.btnSua.TabIndex = 14;
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
            this.btnXoa.Location = new System.Drawing.Point(1008, 116);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dgvKhenThuong
            // 
            this.dgvKhenThuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhenThuong.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManhanvien,
            this.colTen,
            this.colVitricongviec,
            this.colNgaykhenthuong,
            this.colNoidung,
            this.colHinhthuc,
            this.colNguoiduyet});
            this.dgvKhenThuong.Location = new System.Drawing.Point(28, 165);
            this.dgvKhenThuong.Name = "dgvKhenThuong";
            this.dgvKhenThuong.RowHeadersWidth = 51;
            this.dgvKhenThuong.RowTemplate.Height = 24;
            this.dgvKhenThuong.Size = new System.Drawing.Size(1085, 458);
            this.dgvKhenThuong.TabIndex = 6;
            // 
            // colManhanvien
            // 
            this.colManhanvien.HeaderText = "Mã nhân viên";
            this.colManhanvien.MinimumWidth = 6;
            this.colManhanvien.Name = "colManhanvien";
            this.colManhanvien.ReadOnly = true;
            this.colManhanvien.Width = 99;
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
            this.colVitricongviec.Width = 99;
            // 
            // colNgaykhenthuong
            // 
            this.colNgaykhenthuong.HeaderText = "Ngày khen thưởng";
            this.colNgaykhenthuong.MinimumWidth = 6;
            this.colNgaykhenthuong.Name = "colNgaykhenthuong";
            this.colNgaykhenthuong.ReadOnly = true;
            this.colNgaykhenthuong.Width = 120;
            // 
            // colNoidung
            // 
            this.colNoidung.HeaderText = "Nội dung";
            this.colNoidung.MinimumWidth = 6;
            this.colNoidung.Name = "colNoidung";
            this.colNoidung.ReadOnly = true;
            this.colNoidung.Width = 125;
            // 
            // colHinhthuc
            // 
            this.colHinhthuc.HeaderText = "Hình thức";
            this.colHinhthuc.MinimumWidth = 6;
            this.colHinhthuc.Name = "colHinhthuc";
            this.colHinhthuc.ReadOnly = true;
            this.colHinhthuc.Width = 99;
            // 
            // colNguoiduyet
            // 
            this.colNguoiduyet.HeaderText = "Người duyệt";
            this.colNguoiduyet.MinimumWidth = 6;
            this.colNguoiduyet.Name = "colNguoiduyet";
            this.colNguoiduyet.ReadOnly = true;
            this.colNguoiduyet.Width = 125;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(688, 116);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(137, 34);
            this.btnThemmoi.TabIndex = 2;
            this.btnThemmoi.Text = "+ Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // ThongTinNhanSuKhenthuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinNhanSuKhenthuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNhanSuKhenthuong";
            this.Load += new System.EventHandler(this.ThongTinNhanSuKhenthuong_Load);
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.All.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhanVien)).EndInit();
            this.pnlKhenthuong.ResumeLayout(false);
            this.pnlKhenthuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhenThuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Button btnHoso;
        private Button btnHopdong;
        private Panel All;
        private Button btnPhucloi;
        private Button btnSuco;
        private Button btnKhenthuong;
        private Button btnNghiviec;
        private PictureBox pictureBox2;
        private Label lblThongtinnhansu;
        private Panel Main;
        private Panel pnlKhenthuong;
        private PictureBox pictureBox1;
        private Label lblSoluongnhanvienkhenthuong;
        private Label lblNhanvienkhenthuong;
        private Label lblKhenthuong;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThemmoi;
        private DataGridView dgvKhenThuong;
        private DataGridViewTextBoxColumn colManhanvien;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colVitricongviec;
        private DataGridViewTextBoxColumn colNgaykhenthuong;
        private DataGridViewTextBoxColumn colNoidung;
        private DataGridViewTextBoxColumn colHinhthuc;
        private DataGridViewTextBoxColumn colNguoiduyet;
        private DataGridView dgvChiTietNhanVien;
    }
}