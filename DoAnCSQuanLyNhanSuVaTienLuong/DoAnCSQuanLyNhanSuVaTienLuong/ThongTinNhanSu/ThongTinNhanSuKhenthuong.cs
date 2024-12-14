using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class ThongTinNhanSuKhenthuong : Form
    {
        private MongoDataAccess _mongoDataAccess;
        public ThongTinNhanSuKhenthuong()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            dgvKhenThuong.CellContentClick += dgvKhenThuong_CellContentClick;
        }

        private void btnHoso_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
            this.Hide();
            formHoso.ShowDialog();
            this.Close();
        }
        private void btnHopdong_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHopdong formHopdong = new ThongTinNhanSuHopdong();
            this.Hide();
            formHopdong.ShowDialog();
            this.Close();
        }

        private void btnNghiviec_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuNghiviec formNghiviec = new ThongTinNhanSuNghiviec();
            this.Hide();
            formNghiviec.ShowDialog();
            this.Close();
        }

        private void btnKhenthuong_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuKhenthuong formKhenthuong = new ThongTinNhanSuKhenthuong();
            this.Hide();
            formKhenthuong.ShowDialog();
            this.Close();
        }

        private void btnSuco_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuSuco formSuco = new ThongTinNhanSuSuco();
            this.Hide();
            formSuco.ShowDialog();
            this.Close();
        }

        private void btnPhucloi_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuPhucloi formPhucloi = new ThongTinNhanSuPhucloi();
            this.Hide();
            formPhucloi.ShowDialog();
            this.Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Themkhenthuong themkhenthuong = new Themkhenthuong();
            themkhenthuong.ShowDialog();
        }

        private void ThongTinNhanSuKhenthuong_Load(object sender, EventArgs e)
        {

            dgvKhenThuong.MultiSelect = false;
            dgvKhenThuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvChiTietNhanVien.Visible = false;
            dgvKhenThuong.Rows.Clear();
            dgvKhenThuong.Columns.Clear();

            dgvKhenThuong.ReadOnly = true;

            dgvKhenThuong.Columns.Add("MaKhenThuong", "Mã Khen Thưởng");
            dgvKhenThuong.Columns.Add("LoaiKhenThuong", "Loại Khen Thưởng");
            dgvKhenThuong.Columns.Add("NgayKhenThuong", "Ngày Khen Thưởng");
            dgvKhenThuong.Columns.Add("HinhThucKhenThuong", "Hình Thức Khen Thưởng");
            dgvKhenThuong.Columns.Add("NoiDungKhenThuong", "Nội Dung Khen Thưởng");

            dgvKhenThuong.Columns.Add("DanhSachNhanVien", "Danh Sách Nhân Viên");
            dgvKhenThuong.Columns["DanhSachNhanVien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var danhSachKhenThuong = _mongoDataAccess.GetTatCaKhenThuong();

            foreach (var khenThuong in danhSachKhenThuong)
            {
                int rowIndex = dgvKhenThuong.Rows.Add();
                dgvKhenThuong.Rows[rowIndex].Cells["MaKhenThuong"].Value = khenThuong.MaKhenThuong;
                dgvKhenThuong.Rows[rowIndex].Cells["LoaiKhenThuong"].Value = khenThuong.LoaiKhenThuong;
                dgvKhenThuong.Rows[rowIndex].Cells["NgayKhenThuong"].Value = khenThuong.NgayKhenThuong != DateTime.MinValue
                ? khenThuong.NgayKhenThuong.ToString("yyyy-MM-dd")
                : string.Empty;
                dgvKhenThuong.Rows[rowIndex].Cells["HinhThucKhenThuong"].Value = khenThuong.HinhThucKhenThuong;
                dgvKhenThuong.Rows[rowIndex].Cells["NoiDungKhenThuong"].Value = khenThuong.NoiDungKhenThuong;

                dgvKhenThuong.Rows[rowIndex].Cells["DanhSachNhanVien"].Value = string.Join(", ", khenThuong.DanhSachNhanVien.Select(nv => nv.HoTen));
            }
        }

        private void dgvKhenThuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKhenThuong.Columns["DanhSachNhanVien"].Index)
            {
                var khenThuong = _mongoDataAccess.GetTatCaKhenThuong()[e.RowIndex];


                List<NhanVienKhenThuong> danhSach = khenThuong.DanhSachNhanVien.ToList();

                DanhSachNhanVienDuocKhenThuong a = new DanhSachNhanVienDuocKhenThuong(danhSach);


                DanhSachNhanVienKhenThuong dsnvkt = new DanhSachNhanVienKhenThuong(a, x: 2, y: 1, z: 0);
                dsnvkt.ShowDialog();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvKhenThuong.SelectedRows[0];
            if (selectedRow.Cells["MaKhenThuong"].Value != null && selectedRow.Cells["LoaiKhenThuong"].Value.ToString() != "Thưởng tết " && selectedRow.Cells["HinhThucKhenThuong"].Value.ToString() == "Thưởng tiền")
            {
                DanhSachNhanVienKhenThuong dsnvkt = new DanhSachNhanVienKhenThuong(selectedRow.Cells["MaKhenThuong"].Value.ToString());
                dsnvkt.ShowDialog();
            }
            else
            {
                if (selectedRow.Cells["LoaiKhenThuong"].Value.ToString() == "Thưởng tết ")
                {
                    MessageBox.Show("Thưởng tết không được sửa!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedRow.Cells["HinhThucKhenThuong"].Value.ToString() == "Biểu dương")
                {
                    MessageBox.Show("Đây là khen thưởng biểu dương!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để sửa!!!", "Sửa tiền tưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
