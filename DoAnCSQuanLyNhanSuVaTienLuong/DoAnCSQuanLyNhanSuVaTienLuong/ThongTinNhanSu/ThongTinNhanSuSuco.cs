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

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class ThongTinNhanSuSuco : Form
    {
        private MongoDataAccess _mongoDataAccess;
        public ThongTinNhanSuSuco()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
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
            QuanLyTaiKhoan formPhucloi = new QuanLyTaiKhoan();
            this.Hide();
            formPhucloi.ShowDialog();
            this.Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Themsuco themsuco = new Themsuco();
            themsuco.ShowDialog();
        }

        private void ThongTinNhanSuSuco_Load(object sender, EventArgs e)
        {
            dgvSuCo.Columns.Clear();
            dgvSuCo.Rows.Clear();

            dgvSuCo.Columns.Add("MaSuCo", "Mã Sự Cố");
            dgvSuCo.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvSuCo.Columns.Add("HoTen", "Họ Tên");
            dgvSuCo.Columns.Add("ChucVu", "Chức Vụ");
            dgvSuCo.Columns.Add("NgayXayRa", "Ngày Xảy Ra");
            dgvSuCo.Columns.Add("LoaiSuCo", "Loại Sự Cố");
            dgvSuCo.Columns.Add("GhiChu", "Ghi Chú");
            dgvSuCo.Columns.Add("HinhThucXuLy", "Hình Thức Xử Lý");
            dgvSuCo.Columns.Add("SoTienPhat", "Số Tiền Phạt");

            var danhSachSuCo = _mongoDataAccess.GetTatCaSuCo();

            foreach (var suCo in danhSachSuCo)
            {
                dgvSuCo.Rows.Add(
                    suCo.maSuCo,
                    suCo.MaNhanVien,
                    suCo.HoTen,
                    suCo.ChucVu,
                    suCo.ngayXayRa,
                    suCo.loaiSuCo,
                    suCo.ghiChu,
                    suCo.hinhThucXuLy,
                    suCo.soTienPhat
                );
            }
        }

        private void picBMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
            heThongQuanLy.ShowDialog();
            this.Close();
        }
    }
}
