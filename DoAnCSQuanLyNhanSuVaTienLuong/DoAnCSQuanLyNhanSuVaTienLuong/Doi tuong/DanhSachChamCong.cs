using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    internal class DanhSachChamCong
    {
        private List<ChamCong> dsChamCong = new List<ChamCong>();

        public void Them(ChamCong chamCong)
        {
            dsChamCong.Add(chamCong);
        }
    }
}
