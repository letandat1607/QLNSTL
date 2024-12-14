using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;


namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class DanhSachNhanVien : Form
    {
        private MongoDataAccess _mongoDataAccess;
        private DanhSachNhanVienDuocKhenThuong dsnvdkt;
        private SuCo sc;
        public DanhSachNhanVien(DanhSachNhanVienDuocKhenThuong danhSach)
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            this.dsnvdkt = danhSach;
            btnHuyDSNV.Click += btnHuyDSNV_Click;
            btnChonDSNV.Click += btnChonDSNV_Click;
            this.Load += DanhSachNhanVienKhenThuong_Load;
        }
        public DanhSachNhanVien(SuCo suCo)
        {
            InitializeComponent();
            this.sc = suCo;
            _mongoDataAccess = new MongoDataAccess();
            btnHuyDSNV.Click += btnHuyDSNV_Click1;
            btnChonDSNV.Click += btnChonDSNV_Click1;
            this.Load += DanhSachNhanVienSuCo_Load;
        }

        private void DanhSachNhanVienKhenThuong_Load(object sender, EventArgs e)
        {
            dgvDSNV.MultiSelect = true;
            dgvDSNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSNV.ReadOnly = true;

            var danhSachNhanVien = _mongoDataAccess.GetTatCaNhanVien();


            dgvDSNV.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvDSNV.Columns.Add("TenNhanVien", "Tên Nhân Viên");
            dgvDSNV.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvDSNV.Columns.Add("GioiTinh", "Giới Tính");
            dgvDSNV.Columns.Add("SDT", "Sđt");
            dgvDSNV.Columns.Add("Email", "Email");
            dgvDSNV.Columns.Add("ChucVu", "Chức vụ");


            foreach (DataGridViewColumn column in dgvDSNV.Columns)
            {
                column.Width = 150;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                dgvDSNV.Rows.Add(
                    nhanVien.MaNhanVien,
                    nhanVien.HoTen,
                    nhanVien.NgaySinh.ToString("yyyy-MM-dd"),
                    nhanVien.GioiTinh,
                    nhanVien.SoDienThoai,
                    nhanVien.Email,
                    nhanVien.ChucVu
                );
            }
        }
        private void DanhSachNhanVienSuCo_Load(object sender, EventArgs e)
        {
            dgvDSNV.MultiSelect = false;
            dgvDSNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSNV.ReadOnly = true;

            var danhSachNhanVien = _mongoDataAccess.GetTatCaNhanVien();


            dgvDSNV.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvDSNV.Columns.Add("TenNhanVien", "Tên Nhân Viên");
            dgvDSNV.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvDSNV.Columns.Add("GioiTinh", "Giới Tính");
            dgvDSNV.Columns.Add("SDT", "Sđt");
            dgvDSNV.Columns.Add("Email", "Email");
            dgvDSNV.Columns.Add("ChucVu", "Chức vụ");

            foreach (DataGridViewColumn column in dgvDSNV.Columns)
            {
                column.Width = 150;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                dgvDSNV.Rows.Add(
                    nhanVien.MaNhanVien,
                    nhanVien.HoTen,
                    nhanVien.NgaySinh.ToString("yyyy-MM-dd"),
                    nhanVien.GioiTinh,
                    nhanVien.SoDienThoai,
                    nhanVien.Email,
                    nhanVien.ChucVu
                );
            }
        }
        private void btnHuyDSNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ThongTinNhanSuKhenthuong khenThuong = new ThongTinNhanSuKhenthuong();
                khenThuong.Show();
                this.Close();
            }
        }
        private void btnHuyDSNV_Click1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                ThongTinNhanSuSuco suCo = new ThongTinNhanSuSuco();
                suCo.Show();
                this.Close();
            }
        }
        private void btnChonDSNV_Click(object sender, EventArgs e)
        {
            if (dgvDSNV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDSNV.SelectedRows)
                {
                    if (row.Cells["MaNhanVien"].Value != null ||
                        row.Cells["TenNhanVien"].Value != null ||
                        row.Cells["NgaySinh"].Value != null ||
                        row.Cells["GioiTinh"].Value != null ||
                        row.Cells["ChucVu"].Value != null ||
                        row.Cells["SDT"].Value != null ||
                        row.Cells["Email"].Value != null)
                    {
                        string maNhanVien = row.Cells["MaNhanVien"].Value.ToString();
                        string hoTen = row.Cells["TenNhanVien"].Value.ToString();
                        DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                        string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                        string soDienThoai = row.Cells["SDT"].Value.ToString();
                        string email = row.Cells["Email"].Value.ToString();
                        string chucVu = row.Cells["ChucVu"].Value.ToString();
                        int tienThuong = 0;

                        NhanVienKhenThuong nhanVien = new NhanVienKhenThuong();
                        nhanVien.MaNhanVien = maNhanVien;
                        nhanVien.HoTen = hoTen;
                        nhanVien.NgaySinh = ngaySinh;
                        nhanVien.GioiTinh = gioiTinh;
                        nhanVien.SoDienThoai = soDienThoai;
                        nhanVien.Email = email;
                        nhanVien.ChucVu = chucVu;
                        nhanVien.tienThuong = tienThuong;
                        dsnvdkt.ThemNhanVien(nhanVien);
                    }
                }
                if (dsnvdkt.CoDuLieu())
                {
                    MessageBox.Show("Đã lưu danh sách nhân viên được khen thưởng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xin vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để khen thưởng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnChonDSNV_Click1(object sender, EventArgs e)
        {
            var selectedRow = dgvDSNV.SelectedRows[0];

            if (selectedRow.Cells["MaNhanVien"].Value != null && selectedRow.Cells["MaNhanVien"].Value.ToString() != string.Empty)
            {
                sc.MaNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();
                sc.HoTen = selectedRow.Cells["TenNhanVien"].Value.ToString();
                sc.ChucVu = selectedRow.Cells["ChucVu"].Value.ToString();

                MessageBox.Show("Đã thêm thông tin nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
