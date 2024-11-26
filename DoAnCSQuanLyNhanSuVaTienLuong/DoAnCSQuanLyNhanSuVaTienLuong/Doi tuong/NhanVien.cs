using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong
{
    internal class NhanVien
    {
        private string ma_nhan_vien;
        private string ho_ten;
        private DateTime ngay_sinh;
        private string gioi_tinh;
        private string so_dien_thoai;
        private string email;
        private string so_ho_khau;
        private string tam_tru_tam_vang;
        private string dia_chi;
        private string noi_sinh;
        private string que_quan;
        private string ton_giao;
        private string dan_toc;
        private string so_cccd;
        private DateTime ngay_cap;
        private string noi_cap;
        private DateTime ngay_ung_tuyen;
        private DateTime ngay_chinh_thuc;
        private string chuc_vu;
        private string trinh_do;
        private string chuyen_nganh;
        private string vi_tri_cong_viec;
        private string noi_lam_viec;
        private string mo_ta;
        public NhanVien(string ma_nhan_vien, string ho_ten, DateTime ngay_sinh, string gioi_tinh, string so_dien_thoai, string email, string so_ho_khau, string tam_tru_tam_vang, string dia_chi, string noi_sinh, string que_quan, string ton_giao, string dan_toc, string so_cccd, DateTime ngay_cap, string noi_cap, DateTime ngay_ung_tuyen, DateTime ngay_chinh_thuc, string chuc_vu, string trinh_do, string chuyen_nganh, string vi_tri_cong_viec, string noi_lam_viec, string mo_ta)
        {
            this.ma_nhan_vien = ma_nhan_vien;
            this.ho_ten = ho_ten;
            this.ngay_sinh = ngay_sinh;
            this.gioi_tinh = gioi_tinh;
            this.so_dien_thoai = so_dien_thoai;
            this.email = email;
            this.so_ho_khau = so_ho_khau;
            this.tam_tru_tam_vang = tam_tru_tam_vang;
            this.dia_chi = dia_chi;
            this.noi_sinh = noi_sinh;
            this.que_quan = que_quan;
            this.ton_giao = ton_giao;
            this.dan_toc = dan_toc;
            this.so_cccd = so_cccd;
            this.ngay_cap = ngay_cap;
            this.noi_cap = noi_cap;
            this.ngay_ung_tuyen = ngay_ung_tuyen;
            this.ngay_chinh_thuc = ngay_chinh_thuc;
            this.chuc_vu = chuc_vu;
            this.trinh_do = trinh_do;
            this.chuyen_nganh = chuyen_nganh;
            this.vi_tri_cong_viec = vi_tri_cong_viec;
            this.noi_lam_viec = noi_lam_viec;
            this.mo_ta = mo_ta;
        }
        public NhanVien(string ma_nhan_vien, string ho_ten)
        {
            ma_nhan_vien = ma_nhan_vien;
            ho_ten = ho_ten;
        }
        public NhanVien() { }
        public string Ho_ten { get { return ho_ten; } set { ho_ten = value; } }
        public DateTime Ngay_sinh { get { return ngay_sinh; } set { ngay_sinh = value; } }
        public string Gioi_tinh { get { return gioi_tinh; } set { gioi_tinh = value; } }
        public string So_cccd { get { return so_cccd; } set { so_cccd = value; } } 
        public string So_dien_thoai { get { return so_dien_thoai; } set { so_dien_thoai = value; } }
        public string Email {  get { return email; } set { email = value; } }
        public string So_ho_khau
        {
            get { return so_ho_khau; }
            set { so_ho_khau = value; }
        }
        public string Tam_tru_tam_vang { get { return tam_tru_tam_vang;  } set { tam_tru_tam_vang = value; } }
        public string Dia_chi { get { return dia_chi; } set { dia_chi = value; } }
        public string Noi_sinh { get { return noi_sinh; } set { noi_sinh = value; } }
        public string Que_quan { get { return que_quan; } set { que_quan = value; } }
        public string Ton_giao { get { return ton_giao; } set { ton_giao = value; } }
        public string Dan_toc { get { return dan_toc; } set { dan_toc = value; } }
        public DateTime Ngay_cap { get { return ngay_cap; } set { ngay_cap = value; } }
        public string Noi_cap { get { return noi_cap; } set { noi_cap = value; } }
        public DateTime Ngay_ung_tuyen
        {
            get { return ngay_ung_tuyen; }
            set { ngay_ung_tuyen = value; }
        }
        public DateTime Ngay_chinh_thuc
        {
            get { return ngay_chinh_thuc; }
            set { ngay_chinh_thuc = value; }
        }
        public string Chuc_vu { get { return chuc_vu; } set { chuc_vu = value; } }
        public string Trinh_do {  get { return trinh_do; } set { trinh_do = value; } }
        public string Chuyen_nganh { get { return chuyen_nganh; } set { chuyen_nganh = value; } }
        public string Vi_tri_cong_viec { get { return vi_tri_cong_viec; } set { vi_tri_cong_viec = value; } }
        public string Noi_lam_viec { get{ return noi_lam_viec; } set { noi_lam_viec = value; } }
        public string Mo_ta {  get { return mo_ta; } set { mo_ta = value; } }
    }
}
