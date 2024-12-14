using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public interface IKhenThuong
    {
        double TienKhenThuong { get; set; }
    }

    public class BangLuong : NgayNghi, IKhenThuong
    {
        //public string MaNhanVien { get; set; }
        //public string TenNhanVien { get; set; }
        //public string ChucVu { get; set; }
        //public double LuongCoBan { get; set; }
        public double TienKhenThuong { get; set; }
        //public int NgayNghiBiTruLuong { get; set; } 
        //public int NgayNghiKhongBiTruLuong { get; set; }
        //public int Thang { get; set; }
        public double KhauTru { get; set; }
        public double LuongChamCong { get; set; } = 0;
        public double LuongTruocThue { get; set; } = 0;
        public double LuongSauThue { get; set; } = 0;
        public double LuongThucTe { get; set; } = 0;

        public BangLuong(string ma, double tienKhenThuong, int thang, double khauTru)
        {
            MaNhanVien = ma;
            //TenNhanVien = ten;
            //ChucVu = chucvu;
            //LuongCoBan = luong;
            TienKhenThuong = tienKhenThuong;
            //NgayNghiBiTruLuong = ngayNghiBiTruLuong;
            //NgayNghiKhongBiTruLuong = ngayNghiKhongBiTruLuong;
            //Thang = thang;
            KhauTru = khauTru;
            LuongChamCong = 0; // Mặc định là 0
            LuongTruocThue = 0; // Mặc định là 0
            LuongSauThue = 0; // Mặc định là 0
            LuongThucTe = 0; // Mặc định là 0
        }

        public BangLuong()
        { }
    }
}
