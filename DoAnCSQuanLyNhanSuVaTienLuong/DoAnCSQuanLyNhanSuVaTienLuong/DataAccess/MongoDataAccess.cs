using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.DataAccess
{
    public class MongoDataAccess
    {
        private readonly IMongoCollection<BsonDocument> _nhanViencollection;
        private readonly IMongoCollection<BsonDocument> _chamCongcollection;
        private readonly IMongoCollection<BsonDocument> _taiKhoancollection;
        private readonly IMongoCollection<BsonDocument> _donXinNghicollection;
        private readonly IMongoCollection<BsonDocument> _ngayNghicollection;
        public MongoDataAccess()
        {
            var client = new MongoClient("mongodb://localhost:27017/"); //của ae
            //var client = new MongoClient("mongodb://192.168.100.124:27017"); // ip ở nhà
            //var client = new MongoClient("mongodb://192.168.0.125:27017/");  //Nhà phúc 
            //var client = new MongoClient("mongodb://172.16.1.195:27017/");   //Tân bình ticos
            //var client = new MongoClient("mongodb://192.168.28.115:27017");  //ip ở csc
            //var client = new MongoClient("mongodb://192.168.31.195:27017");  //ip trên trường cs1
            var database = client.GetDatabase("cong_ty_dbpt");
            _nhanViencollection = database.GetCollection<BsonDocument>("nhan_vien");
            _chamCongcollection = database.GetCollection<BsonDocument>("cham_cong");
            _taiKhoancollection = database.GetCollection<BsonDocument>("tai_khoan");
            _donXinNghicollection = database.GetCollection<BsonDocument>("don_xin_nghi");
            _ngayNghicollection = database.GetCollection<BsonDocument>("ngay_nghi");
            //_thanhPhanLuongcollection = database.GetCollection<BsonDocument>("thanh_phan_tien_luong");
            //_bangLuongTheoThangcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang");
            //_bangLuongTheoThangChiTietcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang_chi_tiet");
            //_tongQuanTienLuongcollection = database.GetCollection<BsonDocument>("tong_quan_tien_luong");

        }
        public List<NgayNghi> GetTatCaNgayNghi()
        {
            var ngayNghiDocs = _ngayNghicollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachNgayNghi = ngayNghiDocs.Select(x =>
            {
                return new NgayNghi
                {
                    MaNhanVien = x["nhan_vien"]["ma_nhan_vien"].ToString(),
                    HoTen = x["nhan_vien"]["ho_ten"].ToString(),
                    MaDonXinNghi = x["don_xin_nghi"]["ma_don_xin_nghi"].ToString(),
                    TuNgay = x["don_xin_nghi"]["tu_ngay"].ToUniversalTime(),
                    DenNgay = x["don_xin_nghi"]["den_ngay"].ToUniversalTime(),
                    LoaiNghi = x["loai_nghi"].ToString(),
                };

            })
                .SelectMany(chiaNgay =>
                {
                    // Chia khoảng ngày theo từng tháng
                    var chiaNgayTheoThang = new List<(DateTime Month, string LoaiNghi, int Days)>();
                    DateTime ngayBatDau = chiaNgay.TuNgay;
                    while (ngayBatDau <= chiaNgay.DenNgay)
                    {
                        var batDauThang = new DateTime(ngayBatDau.Year, ngayBatDau.Month, 1);
                        var ketThucThang = batDauThang.AddMonths(1).AddDays(-1);
                        DateTime ngayKetThuc = (chiaNgay.DenNgay < ketThucThang) ? chiaNgay.DenNgay : ketThucThang;
                        chiaNgayTheoThang.Add((new DateTime(ngayBatDau.Year, ngayBatDau.Month, 1), chiaNgay.LoaiNghi, (ngayKetThuc - ngayBatDau).Days + 1));
                        ngayBatDau = ngayKetThuc.AddDays(1);
                    }
                    return chiaNgayTheoThang.Select(r => new
                    {
                        chiaNgay.MaNhanVien,
                        chiaNgay.HoTen,
                        Thang = r.Month,
                        LoaiNghi = r.LoaiNghi,
                        Days = r.Days
                    });
                })
                .GroupBy(x => new { x.MaNhanVien, x.HoTen, Thang = x.Thang.ToString("yyyy-MM") })
                .Select(group => new NgayNghi
                {
                    MaNhanVien = group.Key.MaNhanVien,
                    HoTen = group.Key.HoTen,
                    Thang = group.Key.Thang,
                    SoNgayNghi = group.Sum(g => g.Days),
                    SoNgayNghiPhep = group.Where(g => g.LoaiNghi == "CoPhep").Sum(g => g.Days),
                    SoNgayKhongPhep = group.Where(g => g.LoaiNghi == "KhongPhep").Sum(g => g.Days)
                }).ToList();

            return danhSachNgayNghi;
        }
        public void InsertDonXinNghi(ClassDonXinNghi donXinNghi)
        {
            var nhanVienDocument = new BsonDocument
            {
                { "ma_nhan_vien", donXinNghi.MaNhanVien },
                { "ho_ten", donXinNghi.HoTen },
                { "vi_tri_cong_viec", donXinNghi.ViTriCongViec }
            };
            var donXinNghiDocument = new BsonDocument
            {
                {"ma_don_xin_nghi", donXinNghi.MaDonXinNghi},
                {"nhan_vien", nhanVienDocument},
                {"ngay_nop_don", donXinNghi.NgayNopDon},
                {"tu_ngay", donXinNghi.TuNgay},
                {"den_ngay", donXinNghi.DenNgay},
                {"loai_nghi", donXinNghi.LoaiNghi},
                {"li_do_nghi", donXinNghi.LiDoNghi},
                {"trang_thai", donXinNghi.TrangThai}
            };
            _donXinNghicollection.InsertOne(donXinNghiDocument);
        }
        public List<ClassDonXinNghi> GetTatCaDonXinNghi()
        {
            var donXinNghiDocs = _donXinNghicollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachDonXinNghi = donXinNghiDocs.Select(x =>
            {
                return new ClassDonXinNghi
                {
                    MaDonXinNghi = x["ma_don_xin_nghi"].ToString(),
                    MaNhanVien = x["nhan_vien"]["ma_nhan_vien"].ToString(),
                    HoTen = x["nhan_vien"]["ho_ten"].ToString(),
                    ViTriCongViec = x["nhan_vien"]["vi_tri_cong_viec"].ToString(),
                    NgayNopDon = x["ngay_nop_don"].ToUniversalTime(),
                    TuNgay = x["tu_ngay"].ToUniversalTime(),
                    DenNgay = x["den_ngay"].ToUniversalTime(),
                    LoaiNghi = x["loai_nghi"].ToString(),
                    LiDoNghi = x["li_do_nghi"].ToString(),
                    TrangThai = x["trang_thai"].ToInt32()
                };
            }).ToList();
            return danhSachDonXinNghi;
        }
        public void CapNhatVaThemMoiNgayNghi(int soNPConLai, ClassDonXinNghi donXinNghi, string loaiNghi)
        {
            var filterDonXinNghi = Builders<BsonDocument>.Filter.Eq("ma_don_xin_nghi", donXinNghi.MaDonXinNghi);
            var updateDonXinNghi = Builders<BsonDocument>.Update.Set("trang_thai", 1);
            _donXinNghicollection.UpdateOne(filterDonXinNghi, updateDonXinNghi);

            var filterNhanVien = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", donXinNghi.MaNhanVien);
            var updateNhanVien = Builders<BsonDocument>.Update.Set("so_ngay_phep", soNPConLai);
            _nhanViencollection.UpdateOne(filterNhanVien, updateNhanVien);

            var nhanVienDocument = new BsonDocument
            {
                { "ma_nhan_vien", donXinNghi.MaNhanVien },
                { "ho_ten", donXinNghi.HoTen },
            };
            var donXinNghiDocument = new BsonDocument
            {
                {"ma_don_xin_nghi", donXinNghi.MaDonXinNghi},
                {"tu_ngay", donXinNghi.TuNgay},
                {"den_ngay", donXinNghi.DenNgay},
            };
            var ngayNghi = new BsonDocument
            {
                {"nhan_vien", nhanVienDocument},
                {"don_xin_nghi", donXinNghiDocument},
                {"loai_nghi", loaiNghi}
            };
            _ngayNghicollection.InsertOne(ngayNghi);
        }
        public string TaoMaDonXinNghiMoi()
        {
            var donXinCuoi = _donXinNghicollection
                .Find(FilterDefinition<BsonDocument>.Empty)
                .SortByDescending(x => x["ma_don_xin_nghi"])
                .Limit(1)
                .FirstOrDefault();

            string maDonXinNghiMoi;

            if (donXinCuoi != null)
            {
                var maDonXinNghiCuoi = donXinCuoi["ma_don_xin_nghi"].ToString();
                int soHienTai = int.Parse(maDonXinNghiCuoi.Substring(3));
                int soMoi = soHienTai + 1;
                maDonXinNghiMoi = $"DXN{soMoi.ToString("D3")}";
            }
            else
            {
                maDonXinNghiMoi = "DXN001";
            }
            return maDonXinNghiMoi;
        }
        public List<NhanVien> GetTatCaNhanVien()
        {
            var nhanVienDocs = _nhanViencollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachNhanVien = nhanVienDocs.Select(x => 
            {
                return new NhanVien
                {
                    MaNhanVien = x["ma_nhan_vien"].ToString(),
                    HoTen = x["hop_dong"]["ho_ten"].ToString(),
                    NgaySinh = x["ngay_sinh"].ToUniversalTime(),
                    GioiTinh = x["gioi_tinh"].ToString(),
                    SoDienThoai = x["so_dien_thoai"].ToString(),
                    Email = x["email"].ToString(),
                    SoHoKhau = x["so_ho_khau"].ToString(),
                    TamTruTamVang = x["tam_tru_tam_vang"].ToString(),
                    DiaChi = x["dia_chi"].ToString(),
                    NoiSinh = x["noi_sinh"].ToString(),
                    QueQuan = x["que_quan"].ToString(),
                    TonGiao = x["ton_giao"].ToString(),
                    DanToc = x["dan_toc"].ToString(),
                    SoCccd = x["so_cccd"].ToString(),
                    NgayCap = x["ngay_cap"].ToUniversalTime(),
                    NoiCap = x["noi_cap"].ToString(),
                    NgayUngTuyen = x["ngay_ung_tuyen"].ToUniversalTime(),
                    NgayChinhThuc = x["ngay_chinh_thuc"].ToUniversalTime(),
                    TrinhDo = x["trinh_do"].ToString(),
                    ChuyenNganh = x["chuyen_nganh"].ToString(),
                    ViTriCongViec = x["vi_tri_cong_viec"].ToString(),
                    NoiLamViec = x["noi_lam_viec"].ToString(),
                    SoNgayPhep = x["so_ngay_phep"].ToInt32(),
                    MoTa = x["mo_ta"].ToString(), 
                    MaHopDong = x["hop_dong"]["ma_hop_dong"].ToString(),
                    ChucVu = x["hop_dong"]["chuc_vu"].ToString(),
                    NgayKy = x["hop_dong"]["ngay_ky"].ToUniversalTime()
                };
            }).ToList();
            return danhSachNhanVien;
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
        
        public void InsertChamCong()
        {
            var checkIn = DateTime.UtcNow.Date.Add(Const.chamCong.CheckIn); 
            var checkOut = DateTime.UtcNow.Date.Add(Const.chamCong.CheckOut);
            var danhSachNhanVien = GetTatCaNhanVien();
            NhanVien nhanVien;
            foreach(var nv in danhSachNhanVien)
            {
                if(nv.MaNhanVien == Const.taiKhoanActive.TenTaiKhoan)
                {
                    nhanVien = nv;
                    var nhanVienDocument = new BsonDocument
                    {
                        {"ma_nhan_vien", nhanVien.MaNhanVien },
                        {"ho_ten", nhanVien.HoTen }
                    };
                    var chamCongDocument = new BsonDocument
                    {
                        {"ngay_cham_cong", Const.chamCong.NgayChamCong},
                        {"check_in", checkIn },
                        {"check_out", checkOut },
                        {"nhan_vien", nhanVienDocument }
                    };
                    _chamCongcollection.InsertOne(chamCongDocument);
                }
            }
        }
    }
}
