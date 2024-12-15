using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class TaiKhoan : NhanVien
    {
        private string tenTaiKhoan;
        private string matKhau;
        private string loaiTaiKhoan;
        private bool trangThai;

        public string TenTaiKhoan {  get { return tenTaiKhoan; } set { tenTaiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
        public string LoaiTaiKhoan { get {return loaiTaiKhoan; } set { loaiTaiKhoan= value; } }
        public bool TrangThai { get { return trangThai; } set { trangThai = value; } }
        public TaiKhoan()
        {
            TrangThai = false;
        }
    }
}
