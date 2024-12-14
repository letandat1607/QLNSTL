using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class SuCo : NhanVien
    {
        public string maSuCo { get; set; }

        public DateTime ngayXayRa { get; set; }

        public string loaiSuCo { get; set; }

        public string ghiChu { get; set; }

        public string hinhThucXuLy { get; set; }

        public double soTienPhat { get; set; }

        public SuCo(string maSuCo, DateTime ngayXayRa, string loaiSuCo, string ghiChu, string hinhThucXuLy, double soTienPhat)
        {
            this.ngayXayRa = ngayXayRa;
            this.loaiSuCo = loaiSuCo;
            this.ghiChu = ghiChu;
            this.hinhThucXuLy = hinhThucXuLy;
            this.soTienPhat = soTienPhat;
        }
        public SuCo()
        {

        }
    }
}
