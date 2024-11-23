using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    public partial class DangNhap : Form
    {
        private IMongoCollection<User> nguoidungCollection;

        public DangNhap()
        {
            InitializeComponent();
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            try
            {
                //var connectionString = "mongodb://localhost:27017/";//mongo của Đạt nhaaa
                var connectionString = "mongodb://192.168.100.124:27017"; // ip ở nhà
                //var connectionString = "mongodb://192.168.28.115:27017";//ip ở csc
                // var connectionString = "mongodb://         :27017";//ip của dữ liệu di động của mình
                // var connectionString = "mongodb://         :27017";//ip của dữ liệu di động của đạt
                //var connectionString = "mongodb://192.168.31.195:27017"; //ip trên trường cs1
                Console.WriteLine("Đang kết nối đến MongoDB...");
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("database"); // Tên cơ sở dữ liệu
                nguoidungCollection = database.GetCollection<User>("nguoidung"); // Tên bộ sưu tập (collection)

                // Kiểm tra và in ra thông tin người dùng đầu tiên từ cơ sở dữ liệu
                var user = nguoidungCollection.Find(u => true).FirstOrDefault();
                if (user != null)
                {
                    Console.WriteLine($"User từ CSDL: ID: {user.Id}, Username: {user.Username}, Password: {user.Password}, Role: {user.Role}");
                    MessageBox.Show($"Kết nối thành công! User từ CSDL: {user.Username}");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng nào trong cơ sở dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }

        // Phương thức xử lý sự kiện đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var UsernameInput = textBox1.Text.Trim().ToLower();
            var PasswordInput = textBox2.Text.Trim();

            var user = nguoidungCollection.Find(u => u.Username == UsernameInput && u.Password == PasswordInput).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                HeThongQuanLy hethongquanly = new HeThongQuanLy();
                hethongquanly.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class User
        {
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            [BsonElement("username")]
            public string Username { get; set; }

            [BsonElement("password")]
            public string Password { get; set; }

            [BsonElement("role")]
            public string Role { get; set; }
        }
    }
}
