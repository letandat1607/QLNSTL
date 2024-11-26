using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong.Form_Con_BangLuongTheoThang
{
    public partial class BangLuongTheoThangChiTiet : Form
    {
        private string thoiGian;
        private string tenBangLuong;
        private string donViApDung;
        private string viTriApDung;
        private IMongoCollection<ChiTietBangLuong> BangLuongTheoThangChiTietCollection;

        // Constructor nhận các tham số
        public BangLuongTheoThangChiTiet(string tg, string tenBangLuong, string donViApDung, string viTriApDung)
        {
            InitializeComponent();

            // Gán các tham số vào các biến
            this.thoiGian = tg;
            this.tenBangLuong = tenBangLuong;
            this.donViApDung = donViApDung;
            this.viTriApDung = viTriApDung;

            // Kết nối đến cơ sở dữ liệu MongoDB và lấy dữ liệu chi tiết
            ConnectToDatabase();

            // Hiển thị dữ liệu chi tiết trong DataGridView
            LoadDataIntoDataGridView();
        }

        // Kết nối đến MongoDB và lấy dữ liệu chi tiết
        private void ConnectToDatabase()
        {
            try
            {
                var connectionString = "mongodb://192.168.100.124:27017"; // ip ở nhà
                //var connectionString = "mongodb://192.168.0.125:27017/";//Nhà phúc 
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("database");
                BangLuongTheoThangChiTietCollection = database.GetCollection<ChiTietBangLuong>("BangLuongTheoThangChiTiet");

                var sampleData = BangLuongTheoThangChiTietCollection;
                MessageBox.Show(sampleData != null
                    ? "Kết nối thành công! Đã tìm thấy collection."
                    : "Không tìm thấy thông tin trong cơ sở dữ liệu.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }

        // Hàm tải dữ liệu chi tiết vào DataGridView
        private void LoadDataIntoDataGridView()
        {
            try
            {
                var filter = Builders<ChiTietBangLuong>.Filter.Eq("ThoiGian", thoiGian);
                var results = BangLuongTheoThangChiTietCollection.Find(filter).ToList();
                if (results.Count > 0)
                {
                    // Thêm dữ liệu vào DataGridView
                    foreach (var item in results)
                    {
                        dataGridView1.Rows.Add(item.ChucDanh, item.HeSoLuong, item.LuongCoBan);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chi tiết.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu vào DataGridView: {ex.Message}");
            }
        }
    }
    public class ChiTietBangLuong
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tt")]
        public int ThoiGian { get; set; }  // Thứ tự (1, 2, 3,...)

        [BsonElement("HoTen")]
        public string HoTen { get; set; }

        [BsonElement("ChucDanh")]
        public string ChucDanh { get; set; }

        [BsonElement("HeSoLuong")]
        public double HeSoLuong { get; set; }

        [BsonElement("LuongCoBan")]
        public double LuongCoBan { get; set; }

        [BsonElement("PhuCapKhac")]
        public double PhuCapKhac { get; set; }

        [BsonElement("TienAnGiuaCa")]
        public double TienAnGiuaCa { get; set; }

        [BsonElement("ThemGio")]
        public double ThemGio { get; set; }

        [BsonElement("DongPhuc")]
        public double DongPhuc { get; set; }

        [BsonElement("Cong")]
        public double Cong { get; set; }

        [BsonElement("TamUngKy1")]
        public double TamUngKy1 { get; set; }

        [BsonElement("BHXH")]
        public double BHXH { get; set; }

        [BsonElement("BHYT")]
        public double BHYT { get; set; }

        [BsonElement("BHTN")]
        public double BHTN { get; set; }

        [BsonElement("SoNguoiPhuThuoc")]
        public int SoNguoiPhuThuoc { get; set; }

        [BsonElement("TongThuNhap")]
        public double TongThuNhap { get; set; }

        [BsonElement("ThuNhapChiuThue")]
        public double ThuNhapChiuThue { get; set; }

        [BsonElement("BHBB")]
        public double BHBB { get; set; }

        [BsonElement("ThuNhapTinhThue")]
        public double ThuNhapTinhThue { get; set; }

        [BsonElement("ThueTNCNKhauTru")]
        public double ThueTNCNKhauTru { get; set; }

        [BsonElement("SoTienLuongConPhaiTra")]
        public double SoTienLuongConPhaiTra { get; set; }
    }

}
