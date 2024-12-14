using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class NgayNghi : ClassDonXinNghi
    {
        private string LoaiNghi { get; set; }
        public string Thang {  get; set; }    
        public int SoNgayNghi { get; set; }
        public int SoNgayNghiPhep { get; set; }
        public int SoNgayKhongPhep { get; set; }

        public NgayNghi()
        {
            SoNgayNghi = 0;
            SoNgayNghiPhep = 0;
            SoNgayKhongPhep = 0;
        }
    }
}
