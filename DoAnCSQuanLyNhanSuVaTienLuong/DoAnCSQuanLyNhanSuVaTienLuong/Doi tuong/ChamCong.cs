using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    internal class ChamCong : NhanVien
    {
        private DateTime ngay_cham_cong;
        private DateTime check_in;
        private DateTime check_out;
        public ChamCong(string ma_nhan_vien, string ho_ten) { }
        public DateTime Ngay_cham_cong { get { return ngay_cham_cong;} set {  ngay_cham_cong = value; } }
        public DateTime Check_in { get { return check_in; } set { check_in = value; } }
        public DateTime Check_out { get { return check_out; } set { check_out = value; } }
    }
}
