using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong;
using System.Runtime.InteropServices;

namespace DoAnCSQuanLyNhanSuVaTienLuong.DataAccess
{
    public class MongoDataAccess
    {
        private readonly IMongoCollection<BsonDocument> _nhanViencollection;
        private readonly IMongoCollection<BsonDocument> _chamCongcollection;
        private readonly IMongoCollection<BsonDocument> _taiKhoancollection;
        private readonly IMongoCollection<BsonDocument> _donXinNghicollection;
        private readonly IMongoCollection<BsonDocument> _ngayNghicollection;
        private readonly IMongoCollection<BsonDocument> _hopDongcollection;
        private readonly IMongoCollection<BsonDocument> _khenThuongcollection;
        private readonly IMongoCollection<BsonDocument> _suCocollection;
        private readonly IMongoCollection<BsonDocument> Ungvienlist;
        private readonly IMongoCollection<BsonDocument> Tuyendunglist;
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
            _hopDongcollection = database.GetCollection<BsonDocument>("hop_dong");
            _khenThuongcollection = database.GetCollection<BsonDocument>("khen_thuong");
            _suCocollection = database.GetCollection<BsonDocument>("su_co");
            Ungvienlist = database.GetCollection<BsonDocument>("ung_vien");
            Tuyendunglist = database.GetCollection<BsonDocument>("tuyen_dung");
            //_thanhPhanLuongcollection = database.GetCollection<BsonDocument>("thanh_phan_tien_luong");
            //_bangLuongTheoThangcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang");
            //_bangLuongTheoThangChiTietcollection = database.GetCollection<BsonDocument>("bang_luong_theo_thang_chi_tiet");
            //_tongQuanTienLuongcollection = database.GetCollection<BsonDocument>("tong_quan_tien_luong");

        }
        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////

        public List<SuCo> GetTatCaSuCo()
        {
            var suCos = _suCocollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachSuCo = suCos.Select(x =>
            {
                return new SuCo
                {
                    maSuCo = x.Contains("ma_su_co") ? x["ma_su_co"].ToString() : string.Empty,
                    MaNhanVien = x["nhan_vien"]["ma_nhan_vien"].ToString(),
                    HoTen = x["nhan_vien"]["ho_ten"].ToString(),
                    ChucVu = x["nhan_vien"]["chuc_vu"].ToString(),
                    ngayXayRa = x.Contains("ngay_xay_ra") ? x["ngay_xay_ra"].ToUniversalTime() : DateTime.MinValue,
                    loaiSuCo = x.Contains("loai_su_co") ? x["loai_su_co"].ToString() : string.Empty,
                    ghiChu = x.Contains("ghi_chu") ? x["ghi_chu"].ToString() : string.Empty,
                    hinhThucXuLy = x.Contains("hinh_thuc_xu_ly") ? x["hinh_thuc_xu_ly"].ToString() : string.Empty,
                    soTienPhat = x.Contains("so_tien_phat") ? x["so_tien_phat"].ToDouble() : 0,
                };
            }).ToList();

            return danhSachSuCo;
        }

        public List<KhenThuong> GetTatCaKhenThuong()
        {
            var khenThuongDocs = _khenThuongcollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachKhenThuong = khenThuongDocs.Select(x =>
            {
                return new KhenThuong
                {
                    MaKhenThuong = x["ma_khen_thuong"].ToString(),
                    LoaiKhenThuong = x["loai_khen_thuong"].ToString(),
                    NgayKhenThuong = x["ngay_khen_thuong"].ToUniversalTime(),
                    HinhThucKhenThuong = x["hinh_thuc_khen_thuong"].ToString(),
                    NoiDungKhenThuong = x["noi_dung_khen_thuong"].ToString(),
                    DanhSachNhanVien = x["danh_sach_nhan_vien"].AsBsonArray.Select(nv =>
                    {
                        return new NhanVienKhenThuong
                        {
                            MaNhanVien = nv["ma_nhan_vien"].ToString(),
                            HoTen = nv["ho_ten"].ToString(),
                            ChucVu = nv["chuc_vu"].ToString(),
                            TienThuong = nv["so_tien_thuong"].ToDouble()
                        };
                    }).ToList()
                };
            }).ToList();

            return danhSachKhenThuong;
        }

        public void UpdateTienKhenThuong(string maNhanVien, double soTienThuong)
        {
            try
            {
                var collection = _khenThuongcollection;

                var filter = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", maNhanVien);

                var update = Builders<BsonDocument>.Update.Set("so_tien_thuong", soTienThuong);

                var result = collection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    Console.WriteLine("Cập nhật tiền thưởng thành công!");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy mã nhân viên hoặc dữ liệu không được cập nhật!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
            }
        }

        public double TinhTienThuong(string thang, string nam, string mnv)
        {
            var danhSachKhenThuong = GetTatCaKhenThuong();
            List<KhenThuong> khenThuongs = new List<KhenThuong>();
            foreach (var a in danhSachKhenThuong)
            {
                if (a.NgayKhenThuong.Year.ToString() == nam && a.NgayKhenThuong.Month.ToString() == thang)
                {
                    khenThuongs.Add(a);
                }
            }
            double thuong = 0;
            foreach (var a in khenThuongs)
            {
                foreach (var b in a.DanhSachNhanVien)
                {
                    if (b.MaNhanVien == mnv)
                    {
                        thuong += b.tienThuong;
                    }
                }
            }
            return thuong;
        }
        public double TinhTienPhat(string thang, string nam, string mnv)
        {
            var danhSachSuCo = GetTatCaSuCo();
            double phat = 0;
            foreach (var a in danhSachSuCo)
            {
                if (a.ngayXayRa.Year.ToString() == nam && a.ngayXayRa.Month.ToString() == thang && a.MaNhanVien == mnv)
                {
                    phat = phat + a.soTienPhat;
                }
            }
            return phat;
        }


        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        public IMongoCollection<BsonDocument> GetUngVienCollection()
        {
            return Ungvienlist;
        }
        public List<Ungvien> GetAllUngVien()
        {
            var data = Ungvienlist.Find(new BsonDocument()).ToList();
            var UngvienList = data.Select(doc => new Ungvien
            {
                MaUngVien = doc["ma_ung_vien"].ToString(),
                Ten = doc["ten"].ToString(),
                NgaySinh = doc["ngay_sinh"].ToUniversalTime(),
                GioiTinh = doc["gioi_tinh"].ToString(),
                SDT = doc["sdt"].ToString(),
                Email = doc["email"].ToString(),
                NgayUngTuyen = doc["ngay_ung_tuyen"].ToUniversalTime(),
                ChucVu = doc["chuc_vu"].ToString(),
                TrinhDo = doc["trinh_do"].ToString(),
                ChuyenNganh = doc["chuyen_nganh"].ToString(),
                ViTriCongViec = doc["vi_tri_cong_viec"].ToString(),
                NoiLamViec = doc["noi_lam_viec"].ToString(),
                MoTa = doc["mo_ta"].ToString()
            }).ToList();

            return UngvienList;
        }
        public Ungvien FindOneUngVien(string maUngVien)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ma_ung_vien", maUngVien);
            var data = Ungvienlist.Find(filter).FirstOrDefault();


            if (data != null)
            {
                var ungvien = new Ungvien
                {
                    MaUngVien = data["ma_ung_vien"].ToString(),
                    Ten = data["ten"].ToString(),
                    NgaySinh = data["ngay_sinh"].ToUniversalTime(),
                    GioiTinh = data["gioi_tinh"].ToString(),
                    SDT = data["sdt"].ToString(),
                    Email = data["email"].ToString(),
                    NgayUngTuyen = data["ngay_ung_tuyen"].ToUniversalTime(),
                    ChucVu = data["chuc_vu"].ToString(),
                    TrinhDo = data["trinh_do"].ToString(),
                    ChuyenNganh = data["chuyen_nganh"].ToString(),
                    ViTriCongViec = data["vi_tri_cong_viec"].ToString(),
                    NoiLamViec = data["noi_lam_viec"].ToString(),
                    MoTa = data["mo_ta"].ToString()
                };
                return ungvien;
            }
            return null;
        }
        public void InsertUngVien(BsonDocument ungVien)
        {
            var collection = GetUngVienCollection();
            collection.InsertOne(ungVien);
        }

        public void UpdateUngVien(string maUngVien, BsonDocument ungVienCapNhat)
        {
            var collection = GetUngVienCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("ma_ung_vien", maUngVien);
            var update = new BsonDocument("$set", ungVienCapNhat);
            collection.UpdateOne(filter, update);
        }
        public string TaoMaUngVienMoi()
        {
            var ungviencuoi = Ungvienlist
                .Find(FilterDefinition<BsonDocument>.Empty)
                .SortByDescending(x => x["ma_ung_vien"])
                .Limit(1)
                .FirstOrDefault();

            string maungvienmoi;

            if (ungviencuoi != null)
            {
                var maungviencuoi = ungviencuoi["ma_ung_vien"].ToString();
                int soHienTai = int.Parse(maungviencuoi.Substring(2));
                int soMoi = soHienTai + 1;
                maungvienmoi = $"HD{soMoi.ToString("D3")}";
            }
            else
            {
                maungvienmoi = "UV001";
            }

            return maungvienmoi;
        }
        public IMongoCollection<BsonDocument> GetTuyendungCollection()
        {
            return Tuyendunglist;
        }
        public List<Tuyendung> GetallTuyendung()
        {
            var data = Tuyendunglist.Find(new BsonDocument()).ToList();
            var TuyendungList = data.Select(doc => new Tuyendung
            {
                Tieude = doc["tieu_de"].ToString(),
                Vitriungtuyen = doc["vi_tri_ung_tuyen"].ToString(),
                Nganhnghe = doc["nganh_nghe"].ToString(),
                Thoigianbatdau = doc["thoi_gian_bat_dau"].ToUniversalTime(),
                Thoigianketthuc = doc["thoi_gian_ket_thuc"].ToUniversalTime(),
                Lienhe = doc["lien_he"].ToString()
            }).ToList();
            return TuyendungList;
        }
        public void Inserttuyendung(BsonDocument tin)
        {
            var collection = GetTuyendungCollection();
            collection.InsertOne(tin);
        }
        public Tuyendung FindOneTuyenDung(string tieude)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("tieu_de", tieude);
            var data = Tuyendunglist.Find(filter).FirstOrDefault();

            if (data != null)
            {
                var tintuyendung = new Tuyendung
                {
                    Tieude = data["tieu_de"].ToString(),
                    Vitriungtuyen = data["vi_tri_ung_tuyen"].ToString(),
                    Nganhnghe = data["nganh_nghe"].ToString(),
                    Thoigianbatdau = data["thoi_gian_bat_dau"].ToUniversalTime(),
                    Thoigianketthuc = data["thoi_gian_ket_thuc"].ToUniversalTime(),
                    Lienhe = data["lien_he"].ToString()
                };
                return tintuyendung;
            }
            return null;
        }

        public void UpdateOne(string tieude, BsonDocument tintuyendung)
        {
            var collection = GetTuyendungCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("tieu_de", tieude);
            var update = new BsonDocument("$set", tintuyendung);
            collection.UpdateOne(filter, update);
        }
        public void Xoa(string tieude)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("tieu_de", tieude);
            Tuyendunglist.DeleteOne(filter);

            var mauv = Builders<BsonDocument>.Filter.Eq("ma_ung_vien", tieude);
            Ungvienlist.DeleteOne(mauv);

        }
        public string TaoMaNhanVienMoi()
        {
            var nhanviencuoi = _nhanViencollection
                .Find(FilterDefinition<BsonDocument>.Empty)
                .SortByDescending(x => x["ma_nhan_vien"])
                .Limit(1)
                .FirstOrDefault();
            string mamoi;

            if (nhanviencuoi != null)
            {
                var manhanviencuoi = nhanviencuoi["ma_nhan_vien"].ToString();
                int soHienTai = int.Parse(manhanviencuoi.Substring(2));
                int soMoi = soHienTai + 1;
                mamoi = $"NV{soMoi.ToString("D3")}";
            }
            else
            {
                mamoi = "NV001";
            }
            return mamoi;
        }
        public string TaoMaHopDongMoi()
        {
            var hopdongcuoi = _hopDongcollection
                .Find(FilterDefinition<BsonDocument>.Empty)
                .SortByDescending(x => x["ma_hop_dong"])
                .Limit(1)
                .FirstOrDefault();
            string mamoi;

            if (hopdongcuoi != null)
            {
                var mahopdongcuoi = hopdongcuoi["ma_hop_dong"].ToString();
                int soHienTai = int.Parse(mahopdongcuoi.Substring(2));
                int soMoi = soHienTai + 1;
                mamoi = $"HD{soMoi.ToString("D3")}";
            }
            else
            {
                mamoi = "HD001";
            }
            return mamoi;
        }
        public void InsertHopDong(BsonDocument hopdong)
        {
            _hopDongcollection.InsertOne(hopdong);
        }
        public void InsertNhanvien(BsonDocument nhanvien)
        {
            _nhanViencollection.InsertOne(nhanvien);
        }
        public void UpdateOnes(string ma, BsonDocument doituong)
        {
            var mahopdong = Builders<BsonDocument>.Filter.Eq("ma_hop_dong", ma);
            var manhanvien = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", ma);


            var updatehopdong = new BsonDocument("$set", doituong);
            _hopDongcollection.UpdateOne(mahopdong, updatehopdong);

            var updatenhanvien = new BsonDocument("$set", doituong);
            _nhanViencollection.UpdateOne(manhanvien, updatenhanvien);
        }
        public void Delete(string ma)
        {
            var timHD = Builders<BsonDocument>.Filter.Eq("ma_hop_dong", ma);
            var timNV = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", ma);

            _hopDongcollection.DeleteOne(timHD);
            _nhanViencollection.DeleteOne(timNV);
        }
        public HopDong FindOneHopDong(string ma)
        {
            var timHD = Builders<BsonDocument>.Filter.Eq("ma_hop_dong", ma);
            var HD = _hopDongcollection.Find(timHD).FirstOrDefault();



            if (HD != null)
            {
                var hd = new HopDong
                {
                    MaHopDong = HD["ma_hop_dong"].ToString(),
                    TenHopDong = HD["ten_hop_dong"].ToString(),
                    LoaiHopDong = HD["loai_hop_dong"].ToString(),
                    //MaNhanVien = HD["nhan_vien"]["ma_nhan_vien"].ToString(),
                    HoTen = HD["ho_ten"].ToString(),
                    NgayKy = HD["ngay_ky"].ToUniversalTime(),
                    ChucVu = HD["chuc_vu"].ToString(),
                    ThoiHan = HD["thoi_han"].ToString(),
                    NgayBatDauHieuLuc = HD["ngay_bat_dau_hieu_luc"].ToUniversalTime(),
                    NgayHetHieuLuc = HD["ngay_het_hieu_luc"].ToUniversalTime(),
                    LuongCoBan = Convert.ToDouble(HD["luong_co_ban"]),
                    GhiChu = HD["ghi_chu"].ToString(),
                    TinhTrang = HD["tinh_trang"].ToString()

                };
                return hd;
            }

            return null;
        }
        public List<HopDong> FindHetHanHopDong()
        {
            string ketthuc = "Kết thúc";
            var filter = Builders<BsonDocument>.Filter.Eq("tinh_trang", ketthuc);
            var timHD = _hopDongcollection.Find(filter).ToList();

            var dsHDhethan = timHD.Select(HD => new HopDong
            {
                MaHopDong = HD["ma_hop_dong"].ToString(),
                TenHopDong = HD["ten_hop_dong"].ToString(),
                LoaiHopDong = HD["loai_hop_dong"].ToString(),
                //MaNhanVien = HD["nhan_vien"]["ma_nhan_vien"].ToString(),
                HoTen = HD["ho_ten"].ToString(),
                NgayKy = HD["ngay_ky"].ToUniversalTime(),
                ChucVu = HD["chuc_vu"].ToString(),
                ThoiHan = HD["thoi_han"].ToString(),
                NgayBatDauHieuLuc = HD["ngay_bat_dau_hieu_luc"].ToUniversalTime(),
                NgayHetHieuLuc = HD["ngay_het_hieu_luc"].ToUniversalTime(),
                LuongCoBan = Convert.ToDouble(HD["luong_co_ban"]),
                TinhTrang = HD["tinh_trang"].ToString(),
                GhiChu = HD["ghi_chu"].ToString()
            }).ToList();
            return dsHDhethan;
        }
        public NhanVien FindOneNhanVien(string ma)
        {
            var timNV = Builders<BsonDocument>.Filter.Eq("ma_nhan_vien", ma);
            var NV = _nhanViencollection.Find(timNV).FirstOrDefault();


            var timNVhd = Builders<BsonDocument>.Filter.Eq("hop_dong.ma_hop_dong", ma);
            var nvhd = _nhanViencollection.Find(timNVhd).FirstOrDefault();

            if (NV != null)

            {
                var nv = new NhanVien
                {
                    MaNhanVien = NV["ma_nhan_vien"].ToString(),
                    HoTen = NV["hop_dong"]["ho_ten"].ToString(),
                    NgayKy = NV["hop_dong"]["ngay_ky"].ToUniversalTime(),
                    ChucVu = NV["hop_dong"]["chuc_vu"].ToString(),
                    LuongCoBan = NV["hop_dong"]["luong_co_ban"].ToDouble(),
                    NgaySinh = NV["ngay_sinh"].ToUniversalTime(),
                    GioiTinh = NV["gioi_tinh"].ToString(),
                    SoDienThoai = NV["so_dien_thoai"].ToString(),
                    Email = NV["email"].ToString(),
                    SoHoKhau = NV["so_ho_khau"].ToString(),
                    TamTruTamVang = NV["tam_tru_tam_vang"].ToString(),
                    DiaChi = NV["dia_chi"].ToString(),
                    NoiSinh = NV["noi_sinh"].ToString(),
                    QueQuan = NV["que_quan"].ToString(),
                    TonGiao = NV["ton_giao"].ToString(),
                    DanToc = NV["dan_toc"].ToString(),
                    SoCccd = NV["so_cccd"].ToString(),
                    NgayCap = NV["ngay_cap"].ToUniversalTime(),
                    NoiCap = NV["noi_cap"].ToString(),
                    NgayUngTuyen = NV["ngay_ung_tuyen"].ToUniversalTime(),
                    NgayChinhThuc = NV["ngay_chinh_thuc"].ToUniversalTime(),
                    TrinhDo = NV["trinh_do"].ToString(),
                    ChuyenNganh = NV["chuyen_nganh"].ToString(),
                    ViTriCongViec = NV["vi_tri_cong_viec"].ToString(),
                    NoiLamViec = NV["noi_lam_viec"].ToString(),
                    SoNgayPhep = NV["so_ngay_phep"].ToInt32(),
                    MoTa = NV["mo_ta"].ToString(),
                    MaHopDong = NV["hop_dong"]["ma_hop_dong"].ToString()
                };
                return nv;
            }
            if (nvhd != null)
            {
                var nv = new NhanVien
                {
                    MaNhanVien = nvhd["ma_nhan_vien"].ToString(),
                    HoTen = nvhd["hop_dong"]["ho_ten"].ToString(),
                    NgayKy = nvhd["hop_dong"]["ngay_ky"].ToUniversalTime(),
                    ChucVu = nvhd["hop_dong"]["chuc_vu"].ToString(),
                    NgaySinh = nvhd["ngay_sinh"].ToUniversalTime(),
                    LuongCoBan = NV["hop_dong"]["luong_co_ban"].ToDouble(),
                    GioiTinh = nvhd["gioi_tinh"].ToString(),
                    SoDienThoai = nvhd["so_dien_thoai"].ToString(),
                    Email = nvhd["email"].ToString(),
                    SoHoKhau = nvhd["so_ho_khau"].ToString(),
                    TamTruTamVang = nvhd["tam_tru_tam_vang"].ToString(),
                    DiaChi = nvhd["dia_chi"].ToString(),
                    NoiSinh = nvhd["noi_sinh"].ToString(),
                    QueQuan = nvhd["que_quan"].ToString(),
                    TonGiao = nvhd["ton_giao"].ToString(),
                    DanToc = nvhd["dan_toc"].ToString(),
                    SoCccd = nvhd["so_cccd"].ToString(),
                    NgayCap = nvhd["ngay_cap"].ToUniversalTime(),
                    NoiCap = nvhd["noi_cap"].ToString(),
                    NgayUngTuyen = nvhd["ngay_ung_tuyen"].ToUniversalTime(),
                    NgayChinhThuc = nvhd["ngay_chinh_thuc"].ToUniversalTime(),
                    TrinhDo = nvhd["trinh_do"].ToString(),
                    ChuyenNganh = nvhd["chuyen_nganh"].ToString(),
                    ViTriCongViec = nvhd["vi_tri_cong_viec"].ToString(),
                    NoiLamViec = nvhd["noi_lam_viec"].ToString(),
                    SoNgayPhep = nvhd["so_ngay_phep"].ToInt32(),
                    MoTa = nvhd["mo_ta"].ToString(),
                    MaHopDong = nvhd["hop_dong"]["ma_hop_dong"].ToString()

                };
                return nv;
            }
            return null;
        }
        public long DemNhanVienNam()
        {
            return _nhanViencollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("gioi_tinh", "Nam"));
        }
        public long DemNhanVienNu()
        {
            return _nhanViencollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("gioi_tinh", "Nữ"));
        }
        public long DemNhanVien()
        {
            return _nhanViencollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("hop_dong.chuc_vu", "Nhân viên"));
        }
        public long DemQuanLi()
        {
            return _nhanViencollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("hop_dong.chuc_vu", "Quản lí"));
        }
        public long DemHR()
        {
            return _nhanViencollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("hop_dong.chuc_vu", "HR"));
        }
        public long DemtinhtrangHethan()
        {
            return _hopDongcollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("tinh_trang", "Kết thúc"));
        }
        public long DemtinhtrangDanglam()
        {
            return _hopDongcollection.CountDocuments(Builders<BsonDocument>.Filter.Eq("tinh_trang", "Đang làm"));
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
                    NgayKy = x["hop_dong"]["ngay_ky"].ToUniversalTime(),
                    LuongCoBan = x["hop_dong"]["luong_co_ban"].ToDouble(),
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


        public List<HopDong> GetTatCaHopDong()
        {
            var hopDongDocs = _hopDongcollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();
            var danhSachHopDong = hopDongDocs.Select(HD => new HopDong
            {
                MaHopDong = HD["ma_hop_dong"].ToString(),
                TenHopDong = HD["ten_hop_dong"].ToString(),
                LoaiHopDong = HD["loai_hop_dong"].ToString(),
                HoTen = HD["ho_ten"].ToString(),
                NgayKy = HD["ngay_ky"].ToUniversalTime(),
                ChucVu = HD["chuc_vu"].ToString(),
                ThoiHan = HD["thoi_han"].ToString(),
                NgayBatDauHieuLuc = HD["ngay_bat_dau_hieu_luc"].ToUniversalTime(),
                NgayHetHieuLuc = HD["ngay_het_hieu_luc"].ToUniversalTime(),
                LuongCoBan = HD["luong_co_ban"].ToDouble(),
                GhiChu = HD["ghi_chu"].ToString(),
                TinhTrang = HD["tinh_trang"].ToString()
            }).ToList();
            return danhSachHopDong;
        }


        //public List<KhenThuong> GetTatCaKhenThuong()
        //{
        //    var KhenThuongDocs = _khenThuongcollection.Find(FilterDefinition<BsonDocument>.Empty).ToList();

        //    var DanhSachKhenThuong = KhenThuongDocs.SelectMany(x =>
        //    {
        //        // Kiểm tra xem "danh_sach_nhan_vien" có phải là một BsonArray
        //        if (x.Contains("danh_sach_nhan_vien") && x["danh_sach_nhan_vien"] is BsonArray danhSachNhanVienArray)
        //        {
        //            // Duyệt qua từng nhân viên trong danh_sach_nhan_vien
        //            return danhSachNhanVienArray.Select(nv =>
        //            {
        //                return new KhenThuong
        //                {
        //                    MaNhanVien = nv["MaNhanVien"].AsString,
        //                    TienThuong = nv["TienThuong"].ToDouble()
        //                };
        //            }).ToList();
        //        }
        //        else
        //        {
        //            // Nếu "danh_sach_nhan_vien" không phải là BsonArray, bỏ qua
        //            return new List<KhenThuong>();
        //        }
        //    }).ToList();

        //    return DanhSachKhenThuong;
        //}
        public List<BangLuong> GetBangLuong()
        {

            // Lấy danh sách hợp đồng, ngày nghỉ và khen thưởng
            var nhanVienList = GetTatCaNhanVien(); // Danh sách hợp đồng nhân viên
            var ngayNghiList = GetTatCaNgayNghi(); // Danh sách ngày nghỉ
            var khenThuongList = GetTatCaKhenThuong(); // Danh sách khen thưởng
            // Danh sách lương
            List<BangLuong> bangLuongList = new List<BangLuong>();

            // Lặp qua từng hợp đồng để tạo bảng lương
            //foreach (var nn in ngayNghiList)
            //{
            //    // Lấy thông tin khen thưởng của nhân viên
            //    //var khenThuong = khenThuongList.FirstOrDefault(kt => kt.MaNhanVien == nhanVien.MaNhanVien);
            //    //Lấy thông tin ngày nghỉ của nhân viên
            //    //var ngayNghi = ngayNghiList.Find(nn => nn.MaNhanVien == nhanVien.MaNhanVien);
            //    var nhanVien = nhanVienList.FirstOrDefault(nv => nv.MaNhanVien == nn.MaNhanVien);
            //    // Tạo đối tượng BangLuong

            //        if (nhanVien == null)
            //        {
            //            var bangLuong = new BangLuong
            //            {
            //                MaNhanVien = nhanVien.MaNhanVien,
            //                HoTen = nhanVien.HoTen,
            //                ChucVu = nhanVien.ChucVu,
            //                LuongCoBan = nhanVien.LuongCoBan,
            //                SoNgayKhongPhep = 0,
            //                SoNgayNghiPhep = 0,
            //                Thang = "9",
            //                TienKhenThuong = 200000, // Giá trị mặc định là 0 nếu không có khen thưởng
            //                                         //TienKhenThuong = khenThuong?.TienThuong ?? 0, // Giá trị mặc định là 0 nếu không có khen thưởng
            //                KhauTru = 100000 // Giá trị khấu trừ cố định
            //            };

            //            // Thêm đối tượng BangLuong vào danh sách
            //            bangLuongList.Add(bangLuong);
            //        }
            //        else
            //        {
            //            var bangLuong = new BangLuong
            //            {
            //                MaNhanVien = nhanVien.MaNhanVien,
            //                HoTen = nhanVien.HoTen,
            //                ChucVu = nhanVien.ChucVu,
            //                LuongCoBan = nhanVien.LuongCoBan,
            //                SoNgayKhongPhep = 0,
            //                SoNgayNghiPhep = 0,
            //                Thang = "0",
            //                TienKhenThuong = 200000, // Giá trị mặc định là 0 nếu không có khen thưởng
            //                                         //TienKhenThuong = khenThuong?.TienThuong ?? 0, // Giá trị mặc định là 0 nếu không có khen thưởng
            //                KhauTru = 100000 // Giá trị khấu trừ cố định
            //            };

            //            // Thêm đối tượng BangLuong vào danh sách
            //            bangLuongList.Add(bangLuong);
            //        }
            //}
            // Trả về danh sách bảng lương
            return bangLuongList;
        }

    }
}
