using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    public class ClassChamCong : NhanVien
    {
        private DateTime ngayChamCong;
        private TimeSpan checkIn;
        private TimeSpan checkOut;
        public ClassChamCong() { }
        public ClassChamCong(string maNhanVien, string hoTen, DateTime ngayChamCong, TimeSpan checkIn, TimeSpan checkOut)
            : base(maNhanVien, hoTen)
        {
            this.ngayChamCong = ngayChamCong;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public DateTime NgayChamCong
        {
            get { return ngayChamCong; }
            set { ngayChamCong = value; }
        }

        public TimeSpan CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public TimeSpan CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
    }

}
