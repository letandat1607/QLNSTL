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
    public partial class Suahopdong : Form
    {
        MongoDataAccess mongo;
        string ma;
        public Suahopdong(string a)
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            ma = a;
            Load();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHopdong f = new ThongTinNhanSuHopdong();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        public void Load()
        {
            var timHD = mongo.FindOneHopDong(ma);
            var timnv = mongo.FindOneNhanVien(ma);
            if (timHD != null)
            {
                //txtTen.Text = timnv.MaNhanVien;

                txtTen.Text = timHD.HoTen;
                txtTenhopdong.Text = timHD.TenHopDong;
                Ngayky.Value = timHD.NgayKy;
                cmbLoaihopdong.Text = timHD.LoaiHopDong;
                txtChucvu.Text = timHD.ChucVu;
                cmbThoihan.Text = timHD.ThoiHan;
                ngaybatdau.Value = timHD.NgayBatDauHieuLuc;
                ngayketthuc.Value = timHD.NgayHetHieuLuc;
                txtLuongcoban.Text = timHD.LuongCoBan.ToString();
                txtGhichu.Text = timHD.GhiChu;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }


        }




        private void btnTao_Click(object sender, EventArgs e)
        {
            var timhd = mongo.FindOneHopDong(ma);
            var timnv = mongo.FindOneNhanVien(ma);

            try
            {
                HopDong HD = new HopDong();
                HD.MaHopDong = ma;
                HD.TenHopDong = txtTenhopdong.Text;
                HD.LoaiHopDong = cmbLoaihopdong.Text;

                NhanVien NV = new NhanVien();
                NV.MaNhanVien = timnv.MaNhanVien;
                NV.HoTen = txtTen.Text;
                NV.NgayKy = Ngayky.Value;
                NV.ChucVu = txtChucvu.Text;


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
                if (NV.NgayKy >= HD.NgayBatDauHieuLuc)
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
                    { "ho_ten", NV.HoTen },
                    { "ngay_ky", NV.NgayKy },
                    { "chuc_vu", NV.ChucVu },
                    { "ghi_chu", HD.GhiChu }
                };

                mongo.UpdateOne(timhd.MaHopDong, hopdong);



                var nhanvien = new BsonDocument
                {
                    { "ma_nhan_vien", NV.MaNhanVien },
                    { "chuc_vu", NV.ChucVu },
                    { "hop_dong",new BsonDocument
                        {
                            { "ma_hop_dong", HD.MaHopDong },
                            { "ho_ten", NV.HoTen },
                            { "ngay_ky", NV.NgayKy },
                            { "luong_co_ban", HD.LuongCoBan },
                            { "chuc_vu", NV.ChucVu }
                        }
                    }
                };

                mongo.UpdateOne(timnv.MaNhanVien, nhanvien);

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
        private void cmbThoihan_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ngaybatdau_ValueChanged_1(object sender, EventArgs e)
        {
            TinhNgayHetHieuLuc();
        }
    }
}
