using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using MongoDB.Bson;
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
    public partial class Themhopdong : Form
    {
        MongoDataAccess mongo;
        public Themhopdong()
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHopdong f = new ThongTinNhanSuHopdong();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        public void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                HopDong HD = new HopDong();
                HD.MaHopDong = mongo.TaoMaHopDongMoi();
                HD.TenHopDong = txtTenhopdong.Text;
                HD.LoaiHopDong = cmbLoaihopdong.Text;

                NhanVien NV = new NhanVien();
                NV.MaNhanVien = mongo.TaoMaNhanVienMoi();
                HD.HoTen = txtTen.Text;
                HD.NgayKy = Ngayky.Value;
                HD.ChucVu = txtChucvu.Text;


                HD.ThoiHan = cmbThoihan.Text;
                HD.NgayBatDauHieuLuc = ngaybatdau.Value;
                HD.NgayHetHieuLuc = ngayketthuc.Value;

                double luongCoBan;
                if (double.TryParse(txtLuongcoban.Text, out luongCoBan))
                {
                    HD.LuongCoBan = luongCoBan;
                }
                else
                {
                    MessageBox.Show("Giá trị lương cơ bản không hợp lệ. Vui lòng nhập số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HD.TinhTrang = KiemTraTinhTrangHopDong(HD.NgayHetHieuLuc);




                if (string.IsNullOrWhiteSpace(txtTenhopdong.Text) || string.IsNullOrWhiteSpace(cmbLoaihopdong.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtChucvu.Text) || string.IsNullOrWhiteSpace(txtGhichu.Text) || string.IsNullOrWhiteSpace(cmbThoihan.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (HD.NgayBatDauHieuLuc > HD.NgayHetHieuLuc)
                {
                    MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (HD.NgayKy > HD.NgayBatDauHieuLuc)
                {
                    MessageBox.Show("Ngày ký phải nhỏ hơn ngày bắt đầu hiệu lực.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                HD.GhiChu = txtGhichu.Text;




                var hopdong = new BsonDocument
                {
                    { "ma_hop_dong", HD.MaHopDong },
                    { "ten_hop_dong", HD.TenHopDong },
                    { "loai_hop_dong", HD.LoaiHopDong },
                    { "thoi_han", HD.ThoiHan },
                    { "ngay_bat_dau_hieu_luc", HD.NgayBatDauHieuLuc },
                    { "ngay_het_hieu_luc", HD.NgayHetHieuLuc },
                    { "luong_co_ban", HD.LuongCoBan },
                    { "tinh_trang", HD.TinhTrang },
                    { "ho_ten", HD.HoTen },
                    { "ngay_ky", HD.NgayKy },
                    { "chuc_vu", HD.ChucVu },
                    { "ghi_chu", HD.GhiChu }
                };

                mongo.InsertHopDong(hopdong);

                var nhanvien = new BsonDocument
                {
                    { "ma_nhan_vien", NV.MaNhanVien },
                    { "ngay_sinh", NV.NgaySinh },
                    { "gioi_tinh", NV.GioiTinh },
                    { "so_dien_thoai", NV.SoDienThoai },
                    { "email", NV.Email },
                    { "so_ho_khau", NV.SoHoKhau },
                    { "tam_tru_tam_vang", NV.TamTruTamVang },
                    { "dia_chi", NV.DiaChi },
                    { "noi_sinh", NV.NoiSinh },
                    { "que_quan", NV.QueQuan },
                    { "ton_giao", NV.TonGiao },
                    { "dan_toc", NV.DanToc },
                    { "so_cccd", NV.SoCccd },
                    { "ngay_cap", NV.NgayCap },
                    { "noi_cap", NV.NoiCap },
                    { "ngay_ung_tuyen", HD.NgayKy },
                    { "ngay_chinh_thuc", HD.NgayBatDauHieuLuc },
                    { "trinh_do", NV.TrinhDo },
                    { "chuyen_nganh", NV.ChuyenNganh },
                    { "vi_tri_cong_viec", NV.ViTriCongViec },
                    { "noi_lam_viec", NV.NoiLamViec },
                    { "so_ngay_phep", NV.SoNgayPhep },
                    { "mo_ta", NV.MoTa },
                    { "hop_dong",new BsonDocument
                        {
                            { "ma_hop_dong", HD.MaHopDong },
                            { "ho_ten", HD.HoTen },
                            { "ngay_ky", HD.NgayKy },
                            { "chuc_vu", HD.ChucVu },
                            {"luong_co_ban", HD.LuongCoBan }
                        }
                    }
                };

                mongo.InsertNhanvien(nhanvien);

                ThongTinNhanSuHopdong f = new ThongTinNhanSuHopdong();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void cmbThoihan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TinhNgayHetHieuLuc();
        }
        public string KiemTraTinhTrangHopDong(DateTime ngayHetHieuLuc)
        {
            return DateTime.Now > ngayHetHieuLuc ? "Kết thúc" : "Đang làm";
        }

        private void TinhNgayHetHieuLuc()
        {
            if (ngaybatdau.Value != null)
            {
                DateTime ngayBatDau = ngaybatdau.Value;
                DateTime ngayHetHieuLuc;

                switch (cmbThoihan.Text)
                {
                    case "1 tháng":
                        ngayHetHieuLuc = ngayBatDau.AddMonths(1);
                        break;
                    case "3 tháng":
                        ngayHetHieuLuc = ngayBatDau.AddMonths(3);
                        break;
                    case "6 tháng":
                        ngayHetHieuLuc = ngayBatDau.AddMonths(6);
                        break;
                    case "1 năm":
                        ngayHetHieuLuc = ngayBatDau.AddYears(1);
                        break;
                    case "2 năm":
                        ngayHetHieuLuc = ngayBatDau.AddYears(2);
                        break;
                    case "3 năm":
                        ngayHetHieuLuc = ngayBatDau.AddYears(3);
                        break;
                    case "Vĩnh viễn":
                        ngayHetHieuLuc = DateTime.MaxValue;
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn thời hạn hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
                ngayketthuc.Value = ngayHetHieuLuc;
                KiemTraTinhTrangHopDong(ngayHetHieuLuc);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày bắt đầu hiệu lực!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ngaybatdau_ValueChanged(object sender, EventArgs e)
        {
            TinhNgayHetHieuLuc();

        }
    }
}