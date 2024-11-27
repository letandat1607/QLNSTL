using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong.Form_Con_BangLuongTheoThang;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ChiTraLuong;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_DuLieuTienLuong
{
    public partial class BangLuongTheoThang : Form
    {
        private IMongoCollection<ThongTin> BangLuongTheoThangCollection;

        public BangLuongTheoThang()
        {
            InitializeComponent();
            ConnectToDatabase();
            LoadDataIntoDataGridView();
        }

        private void ConnectToDatabase()
        {
            try
            {
                var connectionString = "mongodb://192.168.100.124:27017"; // ip ở nhà
                //var connectionString = "mongodb://192.168.0.125:27017/";//Nhà phúc 
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase("database");
                BangLuongTheoThangCollection = database.GetCollection<ThongTin>("BangLuongTheoThang");

                var sampleData = BangLuongTheoThangCollection;
                MessageBox.Show(sampleData != null
                    ? "Kết nối thành công! Đã tìm thấy collection."
                    : "Không tìm thấy thông tin trong cơ sở dữ liệu.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến cơ sở dữ liệu: {ex.Message}");
            }
        }
        // Trong hàm LoadDataIntoDataGridView
        private void LoadDataIntoDataGridView()
        {
            try
            {
                var results = BangLuongTheoThangCollection.Find(FilterDefinition<ThongTin>.Empty).Limit(100).ToList();

                if (results.Count > 0)
                {
                    // Xóa dữ liệu cũ trong DataGridView
                    dataGridView1.Rows.Clear();

                    // Đảm bảo cột đã có tên (gán tên cho các cột của DataGridView)
                    dataGridView1.Columns[0].Name = "TG";
                    dataGridView1.Columns[1].Name = "tenBangLuong";
                    dataGridView1.Columns[2].Name = "donViApDung";
                    dataGridView1.Columns[3].Name = "viTriApDung";

                    // Thêm dữ liệu mới vào DataGridView
                    foreach (var data in results)
                    {
                        dataGridView1.Rows.Add(data.TG, data.tenBangLuong, data.donViApDung, data.viTriApDung);
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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                string tg = dataGridView1.Rows[e.RowIndex].Cells["TG"].Value.ToString();
                string tenBangLuong = dataGridView1.Rows[e.RowIndex].Cells["tenBangLuong"].Value.ToString();
                string donViApDung = dataGridView1.Rows[e.RowIndex].Cells["donViApDung"].Value.ToString();
                string viTriApDung = dataGridView1.Rows[e.RowIndex].Cells["viTriApDung"].Value.ToString();

                // Tạo form chi tiết và truyền dữ liệu vào đó
                BangLuongTheoThangChiTiet formChiTiet = new BangLuongTheoThangChiTiet(tg, tenBangLuong, donViApDung, viTriApDung);
                this.Hide();
                formChiTiet.Show();
            }
        }

        private void tổngQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienLuong tienLuong = new TienLuong();
            this.Hide();
            tienLuong.Show();
        }

        private void thànhPhầnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPhanLuong thanhPhanLuong = new ThanhPhanLuong();
            this.Hide();
            thanhPhanLuong.Show();
        }

        private void mấuBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauBangLuong mauBangLuong = new MauBangLuong();
            this.Hide();
            mauBangLuong.Show();
        }

        private void BangLuongNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoNam bangLuongTheoNam = new BangLuongTheoNam();
            this.Hide();
            bangLuongTheoNam.Show();
        }

        private void bảngChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangChiTra bangChiTra = new BangChiTra();
            this.Hide();
            bangChiTra.Show();
        }

        private void tổngHợpChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopChiTra tongHopChiTra = new TongHopChiTra();
            this.Hide();
            tongHopChiTra.Show();
        }
    }

    // Lớp mô hình dữ liệu cho MongoDB
    public class ThongTin
    {
        [BsonId] public ObjectId Id { get; set; }
        [BsonElement("ThoiGian")] public string TG { get; set; }
        [BsonElement("TenBangLuong")] public string tenBangLuong { get; set; }
        [BsonElement("DonViApDung")] public string donViApDung { get; set; }
        [BsonElement("ViTriApDung")] public string viTriApDung { get; set; }
    }
}
