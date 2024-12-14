using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    public class NhanVien : HopDong
    {
        //

        public string MaNhanVien { get; set; }
        //public string HoTen { get; set; }
        //public DateTime NgayKy { get; set; }
        //public string ChucVu { get; set; }

        // 

        public DateTime NgaySinh { get; set; } = new DateTime(2000, 1, 1);
        public string GioiTinh { get; set; } = "Chưa xác định";
        public string SoDienThoai { get; set; } = "Chưa có";
        public string Email { get; set; } = "Chưa có";
        public string SoHoKhau { get; set; } = "Chưa có";
        public string TamTruTamVang { get; set; } = "Chưa có";
        public string DiaChi { get; set; } = "Chưa có";
        public string NoiSinh { get; set; } = "Chưa có";
        public string QueQuan { get; set; } = "Chưa có";
        public string TonGiao { get; set; } = "Chưa có";
        public string DanToc { get; set; } = "Chưa có";
        public string SoCccd { get; set; } = "Chưa có";
        public DateTime NgayCap { get; set; } = DateTime.Now;
        public string NoiCap { get; set; } = "Chưa có";
        public DateTime NgayUngTuyen { get; set; } = DateTime.Now;//Ngayky
        public DateTime NgayChinhThuc { get; set; } = DateTime.Now;//Ngaybatdauhieuluc
        public string TrinhDo { get; set; } = "Chưa có";
        public string ChuyenNganh { get; set; } = "Chưa có";
        public string ViTriCongViec { get; set; } = "Chưa có";
        public string NoiLamViec { get; set; } = "Chưa có";
        public int SoNgayPhep { get; set; } = 12;
        public string MoTa { get; set; } = "Chưa có";
        //public string MaHopDong { get; set; }


        public NhanVien(string maNhanVien, string hoTen, DateTime ngayKy, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, string soHoKhau, string tamTruTamVang, string diaChi, string noiSinh, string queQuan, string tonGiao, string danToc, string soCccd, DateTime ngayCap, string noiCap, DateTime ngayUngTuyen, DateTime ngayChinhThuc, string chucvu, string trinhDo, string chuyenNganh, string viTriCongViec, string noiLamViec, int soNgayPhep, string moTa)
        {
            //MaHopDong = MaHopDong;
            MaNhanVien = maNhanVien;
            //HoTen = HoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDienThoai = soDienThoai;
            Email = email;
            SoHoKhau = soHoKhau;
            TamTruTamVang = tamTruTamVang;
            DiaChi = diaChi;
            NoiSinh = noiSinh;
            QueQuan = queQuan;
            TonGiao = tonGiao;
            DanToc = danToc;
            SoCccd = soCccd;
            NgayCap = ngayCap;
            NoiCap = noiCap;
            NgayUngTuyen = ngayUngTuyen;
            NgayChinhThuc = ngayChinhThuc;
            //ChucVu = ChucVu;
            TrinhDo = trinhDo;
            ChuyenNganh = chuyenNganh;
            ViTriCongViec = viTriCongViec;
            NoiLamViec = noiLamViec;
            SoNgayPhep = soNgayPhep;
            MoTa = moTa;
            //NgayKy = NgayKy;
        }


        public NhanVien() { }
    }
}
