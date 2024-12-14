using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class NhanVienKhenThuong : NhanVien
    {
        public double tienThuong { get; set; }
        public NhanVienKhenThuong(string maNhanVien, string hoTen, DateTime? ngaySinh, string gioiTinh, string soDienThoai, string email, string chucVu, double tienThuong)
        {

            this.tienThuong = tienThuong;
        }
        public NhanVienKhenThuong()
        {
            tienThuong = 0;
        }

        public double TienThuong
        {
            get { return tienThuong; }
            set { tienThuong = value; }
        }
    }
}
