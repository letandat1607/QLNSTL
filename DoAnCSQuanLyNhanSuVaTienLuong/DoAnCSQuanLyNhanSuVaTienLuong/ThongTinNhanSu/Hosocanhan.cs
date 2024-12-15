using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class Hosocanhan : Form
    {
        MongoDataAccess mongo;
        string manv;

        public Hosocanhan(string nv)
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            manv = nv;
            Load();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(Const.taiKhoanActive.LoaiTaiKhoan == "quanlyns" || Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
                this.Hide();
                formHoso.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
                heThongQuanLy.ShowDialog();
                this.Close();
            }
        }
        public void Load()
        {
            var hosonv = mongo.FindOneNhanVien(manv);
            var hosohd = mongo.FindOneHopDong(hosonv.MaHopDong);
            if (hosonv != null)
            {
                lblManhanvien.Text = hosonv.MaNhanVien;
                lblTen.Text = hosonv.HoTen; ;
                lblNgayky.Text = hosonv.NgayKy.ToString();
                lblChucvu.Text = hosonv.ChucVu;
                lblNgaysinh.Text = hosonv.NgaySinh.ToString("yyyy-MM-dd");
                lblGioitinh.Text = hosonv.GioiTinh;
                lblSdt.Text = hosonv.SoDienThoai;
                lblEmail.Text = hosonv.Email;
                lblSohokhau.Text = hosonv.SoHoKhau;
                lblTamtrutamvang.Text = hosonv.TamTruTamVang;
                lblDiachi.Text = hosonv.DiaChi;
                lblNoisinh.Text = hosonv.NoiSinh;
                lblQuequan.Text = hosonv.QueQuan;
                lblTongiao.Text = hosonv.TonGiao;
                lblDantoc.Text = hosonv.DanToc;
                lblCCCD.Text = hosonv.SoCccd;
                lblNgaycap.Text = hosonv.NgayCap.ToString("yyyy-MM-dd");
                lblNoicap.Text = hosonv.NoiCap;
                lblNgayungtuyen.Text = hosonv.NgayUngTuyen.ToString("yyyy-MM-dd");
                lblNgaychinhthuc.Text = hosonv.NgayChinhThuc.ToString("yyyy-MM-dd");
                lblTrinhdo.Text = hosonv.TrinhDo;
                lblChuyennganh.Text = hosonv.ChuyenNganh;
                lblVitricongviec.Text = hosonv.ViTriCongViec;
                lblNoilamviec.Text = hosonv.NoiLamViec;
                //lblSoNgayPhep.Text = hosonv.SoNgayPhep.ToString();
                lblMota.Text = hosonv.MoTa;
                //
                lblNgaybatdauhieuluc.Text = hosonv.NgayBatDauHieuLuc.ToString("yyyy-MM-dd");
                lblNgayketthuchieuluc.Text = hosonv.NgayHetHieuLuc.ToString("yyyy-MM-dd");
                lblGhichu.Text = hosonv.GhiChu;


                dtgvhosocanhan.Columns.Clear();
                dtgvhosocanhan.Columns.Add("mahopdong", "Mã HD");
                dtgvhosocanhan.Columns.Add("tenhopdong", "Tên hợp đồng");
                dtgvhosocanhan.Columns.Add("manhanvien", "Mã NV");
                dtgvhosocanhan.Columns.Add("tennhanvien", "Họ và tên");
                dtgvhosocanhan.Columns.Add("loaihopdong", "Loại hợp đồng");
                dtgvhosocanhan.Columns.Add("thoihan", "Thời hạn");
                dtgvhosocanhan.Columns.Add("tinhtrang", "Tình trạng");

                dtgvhosocanhan.Columns["mahopdong"].Width = 76;
                dtgvhosocanhan.Columns["manhanvien"].Width = 76;
                dtgvhosocanhan.Columns["tennhanvien"].Width = 150;

                dtgvhosocanhan.Columns["tenhopdong"].Width = 220;
                dtgvhosocanhan.Columns["loaihopdong"].Width = 180;
                dtgvhosocanhan.Columns["thoihan"].Width = 150;


                var allhd = mongo.GetTatCaHopDong();
                var timhs = mongo.FindOneHopDong(hosonv.MaHopDong);
                if(timhs != null)
                {
                    dtgvhosocanhan.Rows.Add(
                hosonv.MaHopDong,
                timhs.TenHopDong,
                hosonv.MaNhanVien,
                timhs.HoTen,
                timhs.LoaiHopDong,
                timhs.ThoiHan,
                timhs.TinhTrang
                    );
                }

            }
            else
            {
                MessageBox.Show("cc");
            }





        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (manv != null)
            {
                Suahoso f = new Suahoso(manv);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            mongo.Delete(manv);
            ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
            this.Hide();
            formHoso.ShowDialog();
            this.Close();
        }
    }
}
