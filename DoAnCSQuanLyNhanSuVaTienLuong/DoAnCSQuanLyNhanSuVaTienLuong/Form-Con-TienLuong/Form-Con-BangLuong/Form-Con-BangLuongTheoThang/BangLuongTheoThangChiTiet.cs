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
        public BangLuongTheoThangChiTiet(string tg, string tenBangLuong, string donViApDung, string viTriApDung)
        {
            InitializeComponent();

            // Gán các tham số vào các biến
            this.thoiGian = tg;
            this.tenBangLuong = tenBangLuong;
            this.donViApDung = donViApDung;
            this.viTriApDung = viTriApDung;

            ConnectToDatabase();
            LoadDataIntoDataGridView();
        }

        // Kết nối đến MongoDB và lấy dữ liệu chi tiết
        private void ConnectToDatabase()
        {
            try
            {
                var connectionString = "mongodb://172.16.1.195:27017/";   //Tân bình ticos
                //var connectionString = "mongodb://192.168.100.124:27017"; // ip ở nhà
                //var connectionString = "mongodb://192.168.0.125:27017/";//Nhà phúc 
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("cong_ty_dbpt");
                BangLuongTheoThangChiTietCollection = database.GetCollection<ChiTietBangLuong>("bang_luong_theo_thang_chi_tiet");

                //var sampleData = BangLuongTheoThangChiTietCollection;
                //MessageBox.Show(sampleData != null
                //    ? "Kết nối thành công! Đã tìm thấy collection."
                //    : "Không tìm thấy thông tin trong cơ sở dữ liệu.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Xóa dữ liệu cũ trong DataGridView
                dataGridView1.Rows.Clear();

                var filter = Builders<ChiTietBangLuong>.Filter.Eq("tt", thoiGian);  // Kiểu dữ liệu thoiGian phải khớp
                var results = BangLuongTheoThangChiTietCollection.Find(filter).ToList();

                if (results.Count > 0)
                {
                    // Thêm dữ liệu vào DataGridView
                    foreach (var item in results)
                    {
                        dataGridView1.Rows.Add(
                            item.ThuTu,
                            item.HoTen,
                            item.ChucDanh,
                            item.LuongCoBan,
                            item.ThemGio,
                            item.Cong,
                            item.BHXH,
                            item.BHYT,
                            item.BHTN,
                            item.TongThuNhap,
                            item.ThuNhapChiuThue,
                            item.ThuNhapTinhThue,
                            item.ThueTNCNKhauTru,
                            item.SoTienLuongConPhaiTra
                        );
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class ChiTietBangLuong
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("tt")]
        public int ThuTu { get; set; }  // Thứ tự (1, 2, 3,...)

        [BsonElement("HoTen")]
        public string HoTen { get; set; }

        [BsonElement("ChucDanh")]
        public string ChucDanh { get; set; }

        [BsonElement("LuongCoBan")]
        public double LuongCoBan { get; set; }

        [BsonElement("ThemGio")]
        public double ThemGio { get; set; }

        [BsonElement("Cong")]
        public double Cong { get; set; }

        [BsonElement("BHXH")]
        public double BHXH { get; set; }

        [BsonElement("BHYT")]
        public double BHYT { get; set; }

        [BsonElement("BHTN")]
        public double BHTN { get; set; }

        [BsonElement("TongThuNhap")]
        public double TongThuNhap { get; set; }

        [BsonElement("ThuNhapChiuThue")]
        public double ThuNhapChiuThue { get; set; }

        [BsonElement("ThuNhapTinhThue")]
        public double ThuNhapTinhThue { get; set; }

        [BsonElement("ThueTNCNKhauTru")]
        public double ThueTNCNKhauTru { get; set; }

        [BsonElement("SoTienLuongConPhaiTra")]
        public double SoTienLuongConPhaiTra { get; set; }
    }

}
