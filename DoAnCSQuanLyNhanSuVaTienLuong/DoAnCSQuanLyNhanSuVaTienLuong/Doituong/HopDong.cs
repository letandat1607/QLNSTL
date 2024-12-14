using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class HopDong
    {
        private string maHopDong;
        private string tenHopDong;
        private string loaiHopDong;
        private string hoTen;
        private DateTime ngayKy;
        private string thoiHan;
        private string chucVu;
        private DateTime ngayBatDauHieuLuc;
        private DateTime ngayHetHieuLuc;
        private double luongCoBan;
        private string ghiChu;
        public string TinhTrang {  get; set; }

        public HopDong(string maHopDong, string tenHopDong, string loaiHopDong, string hoTen, DateTime ngayKy, string thoiHan, string chucVu, DateTime ngayBatDauHieuLuc, DateTime ngayHetHieuLuc, double luongCoBan, string ghiChu, string tinhTrang)
        {
            this.maHopDong = maHopDong;
            this.tenHopDong = tenHopDong;
            this.loaiHopDong = loaiHopDong;
            this.hoTen = hoTen;
            this.ngayKy = ngayKy;
            this.thoiHan = thoiHan;
            this.chucVu = chucVu;
            this.ngayBatDauHieuLuc = ngayBatDauHieuLuc;
            this.ngayHetHieuLuc = ngayHetHieuLuc;
            this.luongCoBan = luongCoBan;
            this.ghiChu = ghiChu;
            TinhTrang = tinhTrang;
        }
        public HopDong() { }
        public string MaHopDong
        {
            get { return this.maHopDong; }
            set { maHopDong = value; }
        }
        public string TenHopDong
        {
            get { return this.tenHopDong; }
            set { tenHopDong = value; }
        }
        public string LoaiHopDong
        {
            get { return loaiHopDong; }
            set { loaiHopDong = value; }
        }

        public DateTime NgayKy
        {
            get { return ngayKy; }
            set { ngayKy = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        } 
        public string ChucVu 
        { 
            get { return chucVu; } 
            set { chucVu = value; } 
        }
        public string ThoiHan
        {
            get { return thoiHan; }
            set { thoiHan = value; }
        }
        public DateTime NgayBatDauHieuLuc
        {
            get { return ngayBatDauHieuLuc; }
            set { ngayBatDauHieuLuc = value; }
        }
        public DateTime NgayHetHieuLuc
        {
            get { return ngayHetHieuLuc; }
            set { ngayHetHieuLuc = value; }
        }
        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }
        public string GhiChu 
        { 
            get { return ghiChu; } 
            set { ghiChu = value; } 
        }
    }
}
