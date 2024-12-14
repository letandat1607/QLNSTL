using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class HopDong
    {
        public string MaHopDong { get; set; } = "Chưa có";
        public string TenHopDong { get; set; } = "Chưa có";
        public string LoaiHopDong { get; set; } = "Chưa có";

        /// 

        //public string MaNhanVien { get; set; }
        public string HoTen { get; set; } = "Chưa có";
        public DateTime NgayKy { get; set; } = DateTime.Now;
        public string ChucVu { get; set; } = "Chưa có";

        /// 

        public string ThoiHan { get; set; } = "Chưa có";
        public DateTime NgayBatDauHieuLuc { get; set; } = DateTime.Now;
        public DateTime NgayHetHieuLuc { get; set; } = DateTime.Now;
        public double LuongCoBan { get; set; } = 0.0;
        public string GhiChu { get; set; } = "Chưa có";
        public string TinhTrang { get; set; } = "Chưa có";

        public HopDong(string maHopDong, string tenHopDong, string loaiHopDong, string hoTen, DateTime ngayKy, string thoiHan, string chucVu, DateTime ngayBatDauHieuLuc, DateTime ngayHetHieuLuc, double luongCoBan, string ghiChu, string tinhTrang)
        {
            MaHopDong = maHopDong;
            TenHopDong = tenHopDong;
            LoaiHopDong = loaiHopDong;
            //MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgayKy = ngayKy;
            ChucVu = chucVu;
            ThoiHan = thoiHan;
            NgayBatDauHieuLuc = ngayBatDauHieuLuc;
            NgayHetHieuLuc = ngayHetHieuLuc;
            LuongCoBan = luongCoBan;
            GhiChu = ghiChu;
            TinhTrang = tinhTrang;
        }
        public HopDong() { }
    }
}
