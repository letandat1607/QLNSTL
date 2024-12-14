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

namespace DoAnCSQuanLyNhanSuVaTienLuong.TuyenDung
{
    public partial class Thongtincanhan : Form
    {
        private string _maUngVien;
        private MongoDataAccess mongoDataAccess;
        public Thongtincanhan(string maUngVien)
        {
            InitializeComponent();
            mongoDataAccess = new MongoDataAccess();
            _maUngVien = maUngVien;
            ThongTin_Load();

        }


        private void ThongTin_Load()
        {
            var ungVien = mongoDataAccess.FindOneUngVien(_maUngVien);


            if (ungVien != null)
            {

                txtTen.Text = ungVien.Ten;
                txtMaungvien.Text = _maUngVien;
                txtNgaysinh.Text = ungVien.NgaySinh.ToString("dd/MM/yyyy");
                txtGioitinh.Text = ungVien.GioiTinh;
                txtSdt.Text = ungVien.SDT;
                txtemail.Text = ungVien.Email;
                txtNgayungtuyen.Text = ungVien.NgayUngTuyen.ToString("dd/MM/yyyy");
                txtChucvu.Text = ungVien.ChucVu;
                txtTrinhdo.Text = ungVien.TrinhDo;
                txtChuyennganh.Text = ungVien.ChuyenNganh;
                txtVitricongviec.Text = ungVien.ViTriCongViec;
                txtNoilamviec.Text = ungVien.NoiLamViec;
                txtMota.Text = ungVien.MoTa;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin ứng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu không tìm thấy
            }

        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
