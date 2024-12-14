using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Doituong
{
    public class KhenThuong : NhanVien
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("ma_khen_thuong")]
        public string MaKhenThuong { get; set; }

        [BsonElement("loai_khen_thuong")]
        public string LoaiKhenThuong { get; set; }

        [BsonElement("ngay_khen_thuong")]
        public DateTime NgayKhenThuong { get; set; }

        [BsonElement("hinh_thuc_khen_thuong")]
        public string HinhThucKhenThuong { get; set; }

        [BsonElement("danh_sach_nhan_vien")]
        public List<NhanVienKhenThuong> DanhSachNhanVien { get; set; }

        [BsonElement("noi_dung_khen_thuong")]
        public string NoiDungKhenThuong { get; set; }

        public KhenThuong()
        {
            DanhSachNhanVien = new List<NhanVienKhenThuong>();
        }

        public KhenThuong(string maKhenThuong, string loaiKhenThuong, DateTime ngayKhenThuong, string hinhThucKhenThuong, List<NhanVienKhenThuong> danhSachNhanVien, string noiDungKhenThuong)
        {
            this.MaKhenThuong = maKhenThuong;
            this.LoaiKhenThuong = loaiKhenThuong;
            this.NgayKhenThuong = ngayKhenThuong;
            this.HinhThucKhenThuong = hinhThucKhenThuong;
            this.DanhSachNhanVien = danhSachNhanVien;
            this.NoiDungKhenThuong = noiDungKhenThuong;
        }
    }
}
