using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.DataAccess
{
    public class MongoDataAccess
    {
        private readonly IMongoCollection<BsonDocument> _nhanViencollection;
        private readonly IMongoCollection<BsonDocument> _chamCongcollection;
        private readonly IMongoCollection<BsonDocument> _taiKhoancollection;

        public MongoDataAccess()
        {
            //var client = new MongoClient("mongodb://localhost:27017/"); //của ae
            //var client = new MongoClient("mongodb://192.168.100.124:27017"); // ip ở nhà
            //var client = new MongoClient("mongodb://192.168.0.125:27017/");  //Nhà phúc 
            var client = new MongoClient("mongodb://172.16.1.195:27017/");   //Tân bình ticos
            //var client = new MongoClient("mongodb://192.168.28.115:27017");  //ip ở csc
            //var client = new MongoClient("mongodb://192.168.31.195:27017");  //ip trên trường cs1
            var database = client.GetDatabase("cong_ty_dbpt");
            _nhanViencollection = database.GetCollection<BsonDocument>("nhan_vien");
            _chamCongcollection = database.GetCollection<BsonDocument>("cham_cong");
            _taiKhoancollection = database.GetCollection<BsonDocument>("tai_khoan");
            //_thanhPhanLuongcollection = database.GetCollection<BsonDocument>("thanh_phan_tien_luong");
            //_bangLuongTheoThangcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang");
            //_bangLuongTheoThangChiTietcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang_chi_tiet");
            //_tongQuanTienLuongcollection = database.GetCollection<BsonDocument>("tong_quan_tien_luong");

        }
        public List<TaiKhoan> GetTatCaTaiKhoan()
        {
            var taiKhoanDocs = _taiKhoancollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachTaiKhoan = taiKhoanDocs.Select(x =>
            {
                return new TaiKhoan
                {
                    TenTaiKhoan = x["ten_tai_khoan"].ToString(),
                    MatKhau = x["mat_khau"].ToString(),
                    LoaiTaiKhoan = x["loai_tai_khoan"].ToString(),
                    TrangThai = x["trang_thai"].ToBoolean()
                };
            }).ToList();
            return danhSachTaiKhoan;
        }
        public List<DanhSachChamCong> GetTatCaBangChamCong()
        {
            var chamCongDocs = _chamCongcollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var groupData = chamCongDocs.GroupBy(x => new
            {
                Thang = ConvertToVietnamTime(x["ngay_cham_cong"].ToUniversalTime()).Month,
                Nam = ConvertToVietnamTime(x["ngay_cham_cong"].ToUniversalTime()).Year
            }).ToList();

            var danhSachBangChamCong = groupData.Select(group =>
            {
                var danhSachChamCong = group.Select(x =>
                {
                    var ngayChamCongUtc = x["ngay_cham_cong"].ToUniversalTime();
                    var checkInUtc = x["check_in"].ToUniversalTime();
                    var checkOutUtc = x["check_out"].ToUniversalTime();

                    return new ClassChamCong
                    {
                        MaNhanVien = x["nhan_vien"]["ma_nhan_vien"].ToString(),
                        HoTen = x["nhan_vien"]["ho_ten"].ToString(),
                        NgayChamCong = ConvertToVietnamTime(ngayChamCongUtc),
                        CheckIn = TimeSpan.Parse(ConvertToVietnamTime(checkInUtc).ToString("HH:mm:ss")),
                        CheckOut = TimeSpan.Parse(ConvertToVietnamTime(checkOutUtc).ToString("HH:mm:ss"))
                    };
                }).ToList();

                return new DanhSachChamCong
                {
                    ThoiGianBatDau = danhSachChamCong.Min(x => x.NgayChamCong),
                    ThoiGianKetThuc = danhSachChamCong.Max(x => x.NgayChamCong),
                    TenBangChamCong = $"Bảng chấm công tháng {group.Key.Thang}/{group.Key.Nam}",
                    ChamCong = "Theo ngày",
                    ViTriCongViec = "Tất cả các vị trí",
                    DSChamCong = danhSachChamCong
                };
            }).ToList();

            return danhSachBangChamCong;
        }


        private DateTime ConvertToVietnamTime(DateTime utcDateTime)
        {
            var vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, vietnamTimeZone);
        }

    }
}
