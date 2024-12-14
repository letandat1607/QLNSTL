using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    partial class ThongTinNhanSuHoso
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
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
            this.All = new System.Windows.Forms.Panel();
            this.chartNamnu = new System.Windows.Forms.Panel();
            this.dtgvNV = new System.Windows.Forms.DataGridView();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVitricongviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonvicongtac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaythuviec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaychinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHoso = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SideBar.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.All.SuspendLayout();
            this.chartNamnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.btnHopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHopdong.Location = new System.Drawing.Point(12, 82);
            this.btnHopdong.Name = "btnHopdong";
            this.btnHopdong.Size = new System.Drawing.Size(223, 42);
            this.btnHopdong.TabIndex = 3;
            this.btnHopdong.Text = "Hợp đồng";
            this.btnHopdong.UseVisualStyleBackColor = true;
            this.btnHopdong.Click += new System.EventHandler(this.btnHopdong_Click);
            // 
            // btnHoso
            // 
            this.btnHoso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHoso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHoso.ForeColor = System.Drawing.Color.White;
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
            // All
            // 
            this.All.Controls.Add(this.chartNamnu);
            this.All.Controls.Add(this.SideBar);
            this.All.Controls.Add(this.Header);
            this.All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(1375, 694);
            this.All.TabIndex = 2;
            // 
            // chartNamnu
            // 
            this.chartNamnu.Controls.Add(this.chart1);
            this.chartNamnu.Controls.Add(this.btnXoa);
            this.chartNamnu.Controls.Add(this.dtgvNV);
            this.chartNamnu.Controls.Add(this.lblHoso);
            this.chartNamnu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartNamnu.Location = new System.Drawing.Point(250, 60);
            this.chartNamnu.Name = "chartNamnu";
            this.chartNamnu.Size = new System.Drawing.Size(1125, 634);
            this.chartNamnu.TabIndex = 3;
            // 
            // dtgvNV
            // 
            this.dtgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvNV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManv,
            this.colTen,
            this.colVitricongviec,
            this.colDonvicongtac,
            this.colNgaythuviec,
            this.colNgaychinhthuc,
            this.colGioitinh,
            this.colEmail});
            this.dtgvNV.Location = new System.Drawing.Point(28, 333);
            this.dtgvNV.Name = "dtgvNV";
            this.dtgvNV.RowHeadersWidth = 51;
            this.dtgvNV.RowTemplate.Height = 24;
            this.dtgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNV.Size = new System.Drawing.Size(1085, 289);
            this.dtgvNV.TabIndex = 6;
            this.dtgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colManv
            // 
            this.colManv.HeaderText = "Mã nhân viên";
            this.colManv.MinimumWidth = 6;
            this.colManv.Name = "colManv";
            this.colManv.ReadOnly = true;
            this.colManv.Width = 180;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Họ và tên";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 125;
            // 
            // colVitricongviec
            // 
            this.colVitricongviec.HeaderText = "Vị trí công việc";
            this.colVitricongviec.MinimumWidth = 6;
            this.colVitricongviec.Name = "colVitricongviec";
            this.colVitricongviec.ReadOnly = true;
            this.colVitricongviec.Width = 125;
            // 
            // colDonvicongtac
            // 
            this.colDonvicongtac.HeaderText = "Đơn vị công tác";
            this.colDonvicongtac.MinimumWidth = 6;
            this.colDonvicongtac.Name = "colDonvicongtac";
            this.colDonvicongtac.ReadOnly = true;
            this.colDonvicongtac.Width = 125;
            // 
            // colNgaythuviec
            // 
            this.colNgaythuviec.HeaderText = "Ngày thử việc";
            this.colNgaythuviec.MinimumWidth = 6;
            this.colNgaythuviec.Name = "colNgaythuviec";
            this.colNgaythuviec.ReadOnly = true;
            this.colNgaythuviec.Width = 117;
            // 
            // colNgaychinhthuc
            // 
            this.colNgaychinhthuc.HeaderText = "Ngày chính thức";
            this.colNgaychinhthuc.MinimumWidth = 6;
            this.colNgaychinhthuc.Name = "colNgaychinhthuc";
            this.colNgaychinhthuc.ReadOnly = true;
            this.colNgaychinhthuc.Width = 117;
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới tính";
            this.colGioitinh.MinimumWidth = 6;
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.ReadOnly = true;
            this.colGioitinh.Width = 80;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 125;
            // 
            // lblHoso
            // 
            this.lblHoso.AutoSize = true;
            this.lblHoso.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblHoso.Location = new System.Drawing.Point(24, 17);
            this.lblHoso.Name = "lblHoso";
            this.lblHoso.Size = new System.Drawing.Size(65, 22);
            this.lblHoso.TabIndex = 4;
            this.lblHoso.Text = "Hồ sơ";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(178, 17);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series3.Legend = "Legend1";
            series3.Name = "Nhân viên";
            dataPoint7.Label = "Nam";
            dataPoint8.Label = "Nữ";
            series3.Points.Add(dataPoint7);
            series3.Points.Add(dataPoint8);
            series3.Points.Add(dataPoint9);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(1043, 291);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 34);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "- Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ThongTinNhanSuHoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 694);
            this.Controls.Add(this.All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThongTinNhanSuHoso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinNhanSuHoso";
            this.SideBar.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.All.ResumeLayout(false);
            this.chartNamnu.ResumeLayout(false);
            this.chartNamnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private Button btnHoso;
        private Button btnHopdong;
        private Panel chartNamnu;
        private Panel All;
        private Button btnPhucloi;
        private Button btnSuco;
        private Button btnKhenthuong;
        private Button btnNghiviec;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chartNamnu;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chartchucvu;
        private PictureBox pictureBox2;
        private Label lblThongtinnhansu;
        private TextBox txtTimkiem;
        private Label lblHoso;
        private DataGridView dtgvNV;
        private DataGridViewTextBoxColumn colManv;
        private DataGridViewTextBoxColumn colTen;
        private DataGridViewTextBoxColumn colVitricongviec;
        private DataGridViewTextBoxColumn colDonvicongtac;
        private DataGridViewTextBoxColumn colNgaythuviec;
        private DataGridViewTextBoxColumn colNgaychinhthuc;
        private DataGridViewTextBoxColumn colGioitinh;
        private DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnXoa;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
    }
}