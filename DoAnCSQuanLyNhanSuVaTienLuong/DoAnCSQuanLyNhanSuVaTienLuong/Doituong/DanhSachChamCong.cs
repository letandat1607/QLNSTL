using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    public class DanhSachChamCong
    {
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;
        private string tenBangChamCong;
        private string chamCong;
        private string viTriCongViec;
        public List<ClassChamCong> DSChamCong {  get; set; }

        public DanhSachChamCong() { }

        public string TenBangChamCong { get { return tenBangChamCong; } set { tenBangChamCong = value; } }
        public DateTime ThoiGianBatDau
        {
            get { return thoiGianBatDau; }
            set { thoiGianBatDau = value; }
        }

        public DateTime ThoiGianKetThuc
        {
            get { return thoiGianKetThuc; }
            set { thoiGianKetThuc = value; }
        }

        public string ChamCong
        {
            get { return chamCong; }
            set { chamCong = value; }
        }

        public string ViTriCongViec
        {
            get { return viTriCongViec; }
            set { viTriCongViec = value; }
        }

        public void Them(ClassChamCong chamCong)
        {
            DSChamCong.Add(chamCong);
        }
    }
}
