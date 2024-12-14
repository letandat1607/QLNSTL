using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.TuyenDung
{
    partial class TuyenDungTintuyendung
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
            this.btnThemmoithongtintuyendung = new System.Windows.Forms.Button();
            this.Main = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgtuyendung = new System.Windows.Forms.DataGridView();
            this.colTieude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitrituyendung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNganhnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLienhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTittle = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtuyendung)).BeginInit();
            this.All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnUngvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUngvien.Location = new System.Drawing.Point(12, 66);
            this.btnUngvien.Name = "btnUngvien";
            this.btnUngvien.Size = new System.Drawing.Size(223, 42);
            this.btnUngvien.TabIndex = 3;
            this.btnUngvien.Text = "Ứng viên";
            this.btnUngvien.UseVisualStyleBackColor = true;
            this.btnUngvien.Click += new System.EventHandler(this.btnUngvien_Click);
            // 
            // btnTintuyendung
            // 
            this.btnTintuyendung.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTintuyendung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTintuyendung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTintuyendung.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTintuyendung.Location = new System.Drawing.Point(13, 7);
            this.btnTintuyendung.Name = "btnTintuyendung";
            this.btnTintuyendung.Size = new System.Drawing.Size(223, 42);
            this.btnTintuyendung.TabIndex = 0;
            this.btnTintuyendung.Text = "Tin tuyển dụng";
            this.btnTintuyendung.UseVisualStyleBackColor = false;
            this.btnTintuyendung.Click += new System.EventHandler(this.btnTintuyendung_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
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
            // btnThemmoithongtintuyendung
            // 
            this.btnThemmoithongtintuyendung.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemmoithongtintuyendung.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemmoithongtintuyendung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemmoithongtintuyendung.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemmoithongtintuyendung.ForeColor = System.Drawing.Color.White;
            this.btnThemmoithongtintuyendung.Location = new System.Drawing.Point(809, 44);
            this.btnThemmoithongtintuyendung.Name = "btnThemmoithongtintuyendung";
            this.btnThemmoithongtintuyendung.Size = new System.Drawing.Size(137, 34);
            this.btnThemmoithongtintuyendung.TabIndex = 2;
            this.btnThemmoithongtintuyendung.Text = "+ Thêm mới";
            this.btnThemmoithongtintuyendung.UseVisualStyleBackColor = false;
            this.btnThemmoithongtintuyendung.Click += new System.EventHandler(this.btnThemmoithongtintuyendung_Click);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Main.Controls.Add(this.btnSua);
            this.Main.Controls.Add(this.btnXoa);
            this.Main.Controls.Add(this.dtgtuyendung);
            this.Main.Controls.Add(this.lblTittle);
            this.Main.Controls.Add(this.btnThemmoithongtintuyendung);
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
            this.btnSua.Location = new System.Drawing.Point(952, 44);
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
            this.btnXoa.Location = new System.Drawing.Point(1035, 43);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgtuyendung
            // 
            this.dtgtuyendung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgtuyendung.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgtuyendung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtuyendung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTieude,
            this.colVitrituyendung,
            this.colNganhnghe,
            this.c,
            this.colThoigianketthuc,
            this.colLienhe});
            this.dtgtuyendung.Location = new System.Drawing.Point(19, 83);
            this.dtgtuyendung.Name = "dtgtuyendung";
            this.dtgtuyendung.ReadOnly = true;
            this.dtgtuyendung.RowHeadersWidth = 51;
            this.dtgtuyendung.RowTemplate.Height = 24;
            this.dtgtuyendung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgtuyendung.Size = new System.Drawing.Size(1085, 542);
            this.dtgtuyendung.TabIndex = 6;
            this.dtgtuyendung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtuyendung_CellContentClick);
            // 
            // colTieude
            // 
            this.colTieude.HeaderText = "Tiêu đề";
            this.colTieude.MinimumWidth = 6;
            this.colTieude.Name = "colTieude";
            this.colTieude.ReadOnly = true;
            this.colTieude.Width = 180;
            // 
            // colVitrituyendung
            // 
            this.colVitrituyendung.HeaderText = "Vị trí ứng tuyển ";
            this.colVitrituyendung.MinimumWidth = 6;
            this.colVitrituyendung.Name = "colVitrituyendung";
            this.colVitrituyendung.ReadOnly = true;
            this.colVitrituyendung.Width = 125;
            // 
            // colNganhnghe
            // 
            this.colNganhnghe.HeaderText = "Ngành nghề";
            this.colNganhnghe.MinimumWidth = 6;
            this.colNganhnghe.Name = "colNganhnghe";
            this.colNganhnghe.ReadOnly = true;
            this.colNganhnghe.Width = 125;
            // 
            // c
            // 
            this.c.HeaderText = "Thời gian bắt đầu";
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Width = 117;
            // 
            // colThoigianketthuc
            // 
            this.colThoigianketthuc.HeaderText = "Thời gian kết thúc";
            this.colThoigianketthuc.MinimumWidth = 6;
            this.colThoigianketthuc.Name = "colThoigianketthuc";
            this.colThoigianketthuc.ReadOnly = true;
            this.colThoigianketthuc.Width = 117;
            // 
            // colLienhe
            // 
            this.colLienhe.HeaderText = "Liên hệ";
            this.colLienhe.MinimumWidth = 6;
            this.colLienhe.Name = "colLienhe";
            this.colLienhe.ReadOnly = true;
            this.colLienhe.Width = 125;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblTittle.Location = new System.Drawing.Point(24, 17);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(189, 30);
            this.lblTittle.TabIndex = 4;
            this.lblTittle.Text = "Tin tuyển dụng";
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
            // TuyenDungTintuyendung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 685);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TuyenDungTintuyendung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TuyenDung";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtuyendung)).EndInit();
            this.All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Button btnTintuyendung;
        private Button btnUngvien;
        private Button btnThemmoithongtintuyendung;
        private Panel Main;
        private Label lblTittle;
        private DataGridView dtgtuyendung;
        private Panel All;
        private Button btnSua;
        private Button btnXoa;
        private Label lblTuyendung;
        private TextBox txtTimkiem;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colTieude;
        private DataGridViewTextBoxColumn colVitrituyendung;
        private DataGridViewTextBoxColumn colNganhnghe;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn colThoigianketthuc;
        private DataGridViewTextBoxColumn colLienhe;
    }
}