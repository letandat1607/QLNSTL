using System;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Linq;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ThanhPhanLuong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong
{
    public partial class ThanhPhanLuong : Form
    {
        private IMongoCollection<ThongTin> thongTinCollection;

        public ThanhPhanLuong()
        {
            InitializeComponent();
            SetPlaceholder(textBox1, "Nhập từ khóa tìm kiếm...");
            ConnectToDatabase();

            // Tải dữ liệu vào DataGridView ngay khi form khởi động mà không sử dụng AutoGenerateColumns
            LoadDataIntoDataGridView();
        }

        // Thiết lập placeholder cho TextBox
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        // Kết nối đến cơ sở dữ liệu MongoDB
        private void ConnectToDatabase()
        {
            try
            {
                var connectionString = "mongodb://192.168.100.124:27017"; // ip ở nhà
                //var connectionString = "mongodb://192.168.0.125:27017/";//Nhà phúc 
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("database");
                thongTinCollection = database.GetCollection<ThongTin>("thanhphantienluong");

                var sampleData = thongTinCollection.Find(t => t.MaTp == "KPCD_CONG_TY_DONG").Limit(1).FirstOrDefault();
                MessageBox.Show(sampleData != null
                    ? $"Kết nối thành công! Mẫu dữ liệu: {sampleData.TenTp}"
                    : "Không tìm thấy thông tin trong cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }

        // Hàm tải dữ liệu vào DataGridView có sẵn
        private void LoadDataIntoDataGridView()
        {
            try
            {
                var results = thongTinCollection.Find(FilterDefinition<ThongTin>.Empty).Limit(100).ToList();

                if (results.Count > 0)
                {
                    // Xóa dữ liệu cũ trong DataGridView
                    dataGridView1.Rows.Clear();

                    // Thêm dữ liệu mới vào DataGridView
                    foreach (var data in results)
                    {
                        dataGridView1.Rows.Add(data.MaTp, data.TenTp, data.DonViApDung, data.LoaiTp, data.TinhChat, data.KieuGt, data.GiaTri);
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu vào DataGridView: {ex.Message}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemMoi themMoi = new ThemMoi();
            this.Hide();
            themMoi.Show();
        }
    }

    // Lớp mô hình dữ liệu cho MongoDB
    public class ThongTin
    {
        [BsonId] public ObjectId Id { get; set; }
        [BsonElement("matp")] public string MaTp { get; set; }
        [BsonElement("tentp")] public string TenTp { get; set; }
        [BsonElement("donviapdung")] public string DonViApDung { get; set; }
        [BsonElement("loaitp")] public string LoaiTp { get; set; }
        [BsonElement("tinhchat")] public string TinhChat { get; set; }
        [BsonElement("kieugt")] public string KieuGt { get; set; }
        [BsonElement("giatri")] public string GiaTri { get; set; }
    }
}
