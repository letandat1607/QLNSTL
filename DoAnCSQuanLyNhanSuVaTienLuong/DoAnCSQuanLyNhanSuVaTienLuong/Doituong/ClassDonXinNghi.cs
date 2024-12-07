using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class ClassDonXinNghi : NhanVien
    {
        private string maDonXinNghi;
        private DateTime ngayNopDon;
        private DateTime tuNgay;
        private DateTime denNgay;
        private string loaiNghi;
        private string liDoNghi;
        private int trangThai;

        public ClassDonXinNghi(string maDonXinNghi, DateTime ngayNopDon, DateTime tuNgay, DateTime denNgay, string loaiNghi, string liDoNghi, int trangThai)
        {
            this.maDonXinNghi = maDonXinNghi;
            this.ngayNopDon = ngayNopDon;
            this.tuNgay = tuNgay;
            this.denNgay = denNgay;
            this.loaiNghi = loaiNghi;
            this.liDoNghi = liDoNghi;
            this.trangThai = trangThai;
        }

        public ClassDonXinNghi() 
        {
            trangThai = 0;
        }

        public string MaDonXinNghi
        {
            get { return maDonXinNghi; }
            set { maDonXinNghi = value; }
        }

        public DateTime NgayNopDon { get { return ngayNopDon; } set { ngayNopDon = value; } }
        public DateTime TuNgay { get {return tuNgay; } set { tuNgay = value; } }
        public DateTime DenNgay { get { return denNgay; } set { denNgay = value; } }
        public string LoaiNghi { get { return loaiNghi; } set { loaiNghi = value; } }
        public string LiDoNghi { get { return liDoNghi; } set { liDoNghi = value; } }
        public int TrangThai { get { return trangThai; } set { trangThai = value; } }
    }
}
