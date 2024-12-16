using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class ThongTinNhanSuPhucloi
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
            this.lblThongtinnhansu = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.pnlKhenthuong = new System.Windows.Forms.Panel();
            this.lblPhucloicnhanvien = new System.Windows.Forms.Label();
            this.lblPhucloi = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colManhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitricongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaylamviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhucloi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiduyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.All = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            this.Main.SuspendLayout();
            this.pnlKhenthuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.btnPhucloi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPhucloi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhucloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPhucloi.ForeColor = System.Drawing.Color.White;
            this.btnPhucloi.Location = new System.Drawing.Point(12, 362);
            this.btnPhucloi.Name = "btnPhucloi";
            this.btnPhucloi.Size = new System.Drawing.Size(223, 42);
            this.btnPhucloi.TabIndex = 8;
            this.btnPhucloi.Text = "Phúc lợi";
            this.btnPhucloi.UseVisualStyleBackColor = false;
            this.btnPhucloi.Click += new System.EventHandler(this.btnPhucloi_Click);
            // 
            // btnSuco
            // 
            this.btnSuco.BackColor = System.Drawing.Color.White;
            this.btnSuco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSuco.ForeColor = System.Drawing.Color.Black;
            this.btnSuco.Location = new System.Drawing.Point(12, 293);
            this.btnSuco.Name = "btnSuco";
            this.btnSuco.Size = new System.Drawing.Size(223, 42);
            this.btnSuco.TabIndex = 7;
            this.btnSuco.Text = "Sự cố";
            this.btnSuco.UseVisualStyleBackColor = false;
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
            this.Header.Controls.Add(this.txtTimkiem);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1375, 60);
            this.Header.TabIndex = 1;
            // 
            // lblThongtinnhansu
            // 
            this.lblThongtinnhansu.AutoSize = true;
            this.lblThongtinnhansu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongtinnhansu.Location = new System.Drawing.Point(127, 19);
            this.lblThongtinnhansu.Name = "lblThongtinnhansu";
            this.lblThongtinnhansu.Size = new System.Drawing.Size(186, 25);
            this.lblThongtinnhansu.TabIndex = 1;
            this.lblThongtinnhansu.Text = "Thông tin nhân sự";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimkiem.Font = new System.Drawing.Font("Arial", 11F);
            this.txtTimkiem.Location = new System.Drawing.Point(330, 19);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(280, 32);
            this.txtTimkiem.TabIndex = 0;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemmoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemmoi.ForeColor = System.Drawing.Color.White;
            this.btnThemmoi.Location = new System.Drawing.Point(782, 117);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(137, 34);
            this.btnThemmoi.TabIndex = 2;
            this.btnThemmoi.Text = "+ Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.pnlKhenthuong);
            this.Main.Controls.Add(this.lblPhucloi);
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.dataGridView1);
            this.Main.Controls.Add(this.comboBox1);
            this.Main.Controls.Add(this.btnThemmoi);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(250, 60);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1125, 634);
            this.Main.TabIndex = 3;
            // 
            // pnlKhenthuong
            // 
            this.pnlKhenthuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlKhenthuong.Controls.Add(this.pictureBox3);
            this.pnlKhenthuong.Controls.Add(this.pictureBox1);
            this.pnlKhenthuong.Controls.Add(this.lblPhucloicnhanvien);
            this.pnlKhenthuong.Location = new System.Drawing.Point(291, 17);
            this.pnlKhenthuong.Name = "pnlKhenthuong";
            this.pnlKhenthuong.Size = new System.Drawing.Size(373, 131);
            this.pnlKhenthuong.TabIndex = 19;
            // 
            // lblPhucloicnhanvien
            // 
            this.lblPhucloicnhanvien.AutoSize = true;
            this.lblPhucloicnhanvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhucloicnhanvien.ForeColor = System.Drawing.Color.Olive;
            this.lblPhucloicnhanvien.Location = new System.Drawing.Point(81, 8);
            this.lblPhucloicnhanvien.Name = "lblPhucloicnhanvien";
            this.lblPhucloicnhanvien.Size = new System.Drawing.Size(186, 24);
            this.lblPhucloicnhanvien.TabIndex = 0;
            this.lblPhucloicnhanvien.Text = "Phúc lợi nhân viên";
            // 
            // lblPhucloi
            // 
            this.lblPhucloi.AutoSize = true;
            this.lblPhucloi.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhucloi.Location = new System.Drawing.Point(24, 17);
            this.lblPhucloi.Name = "lblPhucloi";
            this.lblPhucloi.Size = new System.Drawing.Size(87, 22);
            this.lblPhucloi.TabIndex = 18;
            this.lblPhucloi.Text = "Phúc lợi";
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
            this.colNgaylamviec,
            this.colPhucloi,
            this.colHinhthuc,
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
            // colNgaylamviec
            // 
            this.colNgaylamviec.HeaderText = "Ngày làm việc";
            this.colNgaylamviec.MinimumWidth = 6;
            this.colNgaylamviec.Name = "colNgaylamviec";
            this.colNgaylamviec.ReadOnly = true;
            this.colNgaylamviec.Width = 120;
            // 
            // colPhucloi
            // 
            this.colPhucloi.HeaderText = "Phúc lợi";
            this.colPhucloi.MinimumWidth = 6;
            this.colPhucloi.Name = "colPhucloi";
            this.colPhucloi.ReadOnly = true;
            this.colPhucloi.Width = 125;
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.Phucloi_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(198, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.phucloithantai_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(23, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnCSQuanLyNhanSuVaTienLuong.Properties.Resources.nhansu;
            this.pictureBox2.Location = new System.Drawing.Point(70, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // ThongTinNhanSuPhucloi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinNhanSuPhucloi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNhanSuPhucloi";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.pnlKhenthuong.ResumeLayout(false);
            this.pnlKhenthuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox txtTimkiem;
        private Button btnHoso;
        private Button btnHopdong;
        private Label lblThongtinnhansu;
        private Button btnThemmoi;
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
        private Label lblPhucloi;
        private Panel pnlKhenthuong;
        private Label lblPhucloicnhanvien;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn colManhanvien;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colVitricongviec;
        private DataGridViewTextBoxColumn colNgaylamviec;
        private DataGridViewTextBoxColumn colPhucloi;
        private DataGridViewTextBoxColumn colHinhthuc;
        private DataGridViewTextBoxColumn colNguoiduyet;
    }
}