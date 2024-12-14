using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class DanhSachNhanVienDuocKhenThuong
    {
        private List<NhanVienKhenThuong> nhanViens;

        public DanhSachNhanVienDuocKhenThuong()
        {
            nhanViens = new List<NhanVienKhenThuong>();
        }
        public DanhSachNhanVienDuocKhenThuong(List<NhanVienKhenThuong> nhanViens)
        {
            this.nhanViens = nhanViens;
        }

        public void ThemNhanVien(NhanVienKhenThuong nhanVien)
        {
            if (!nhanViens.Any(x => x.MaNhanVien == nhanVien.MaNhanVien))
            {
                nhanViens.Add(nhanVien);
                Console.WriteLine("Nhân viên đã được thêm vào danh sách khen thưởng.");
            }
            else
            {
                Console.WriteLine("Nhân viên đã tồn tại trong danh sách.");
            }
        }

        public void XoaNhanVien()
        {
            nhanViens.Clear();
        }

        public void XoaMotNhanVien(NhanVienKhenThuong a)
        {
            nhanViens.Remove(a);
        }

        public bool CoDuLieu()
        {
            return nhanViens.Count > 0;
        }
        public List<NhanVienKhenThuong> LayDanhSachNhanVien()
        {
            return nhanViens;
        }

    }
}
