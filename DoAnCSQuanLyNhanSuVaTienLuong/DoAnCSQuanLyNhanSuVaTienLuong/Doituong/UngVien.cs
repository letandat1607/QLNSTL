using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    public class UngVien
    {
        private string maUngVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDienThoai;
        private string email;
        private string soHoKhau;
        private string tamTruTamVang;
        private string diaChi;
        private string noiSinh;
        private string queQuan;
        private string tonGiao;
        private string danToc;
        private string soCccd;
        private DateTime ngayCap;
        private string noiCap;
        private DateTime ngayUngTuyen;
        private string chucVu;
        private string trinhDo;
        private string chuyenNganh;
        private string viTriCongViec;
        private string noiLamViec;
        private string moTa;

        public UngVien(string maUngVien, string hoTen, DateTime ngaySinh, string gioiTinh, string soDienThoai, string email, string soHoKhau, string tamTruTamVang, string diaChi, string noiSinh, string queQuan, string tonGiao, string danToc, string soCccd, DateTime ngayCap, string noiCap, DateTime ngayUngTuyen, string chucVu, string trinhDo, string chuyenNganh, string viTriCongViec, string noiLamViec, string moTa)
        {
            this.maUngVien = maUngVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.soHoKhau = soHoKhau;
            this.tamTruTamVang = tamTruTamVang;
            this.diaChi = diaChi;
            this.noiSinh = noiSinh;
            this.queQuan = queQuan;
            this.tonGiao = tonGiao;
            this.danToc = danToc;
            this.soCccd = soCccd;
            this.ngayCap = ngayCap;
            this.noiCap = noiCap;
            this.ngayUngTuyen = ngayUngTuyen;
            this.chucVu = chucVu;
            this.trinhDo = trinhDo;
            this.chuyenNganh = chuyenNganh;
            this.viTriCongViec = viTriCongViec;
            this.noiLamViec = noiLamViec;
            this.moTa = moTa;
        }

        public UngVien(string maNhanVien, string hoTen)
        {
            this.maUngVien = maNhanVien;
            this.hoTen = hoTen;
        }

        public UngVien() { }

        public string MaUngVien
        {
            get { return maUngVien; }
            set { maUngVien = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string SoCccd
        {
            get { return soCccd; }
            set { soCccd = value; }
        }

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string SoHoKhau
        {
            get { return soHoKhau; }
            set { soHoKhau = value; }
        }

        public string TamTruTamVang
        {
            get { return tamTruTamVang; }
            set { tamTruTamVang = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string NoiSinh
        {
            get { return noiSinh; }
            set { noiSinh = value; }
        }

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }

        public string TonGiao
        {
            get { return tonGiao; }
            set { tonGiao = value; }
        }

        public string DanToc
        {
            get { return danToc; }
            set { danToc = value; }
        }

        public DateTime NgayCap
        {
            get { return ngayCap; }
            set { ngayCap = value; }
        }

        public string NoiCap
        {
            get { return noiCap; }
            set { noiCap = value; }
        }

        public DateTime NgayUngTuyen
        {
            get { return ngayUngTuyen; }
            set { ngayUngTuyen = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string TrinhDo
        {
            get { return trinhDo; }
            set { trinhDo = value; }
        }

        public string ChuyenNganh
        {
            get { return chuyenNganh; }
            set { chuyenNganh = value; }
        }

        public string ViTriCongViec
        {
            get { return viTriCongViec; }
            set { viTriCongViec = value; }
        }

        public string NoiLamViec
        {
            get { return noiLamViec; }
            set { noiLamViec = value; }
        }

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
    }
}
