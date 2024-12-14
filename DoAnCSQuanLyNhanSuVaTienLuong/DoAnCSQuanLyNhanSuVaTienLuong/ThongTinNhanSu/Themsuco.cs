using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class Themsuco : Form
    {
        SuCo sc;
        private MongoDataAccess _mongoDataAccess;
        public Themsuco()
        {
            InitializeComponent();
            sc = new SuCo();
            _mongoDataAccess = new MongoDataAccess();
            btnDSNV.Click += btnDSNV_Click;
            cbbHinhThucXuLy.SelectedIndexChanged += cbbHinhThucXuLy_SelectedIndexChanged;
            cbbLoaiSuCo.SelectedIndexChanged += cbbLoaiSuCo_SelectedIndexChanged;
            btnTao.Click += btnTao_Click;
            button1.Click += button1_Click;
        }

        private void Themsuco_Load(object sender, EventArgs e)
        {
            cbbLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHinhThucXuLy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChonSoTienPhat.DropDownStyle = ComboBoxStyle.DropDownList;

            lblChonSoTienPhat.Visible = false;
            cbbChonSoTienPhat.Visible = false;

            sc.ngayXayRa = dtpNgayXayRa.Value.Date;
            sc.loaiSuCo = cbbLoaiSuCo.SelectedItem?.ToString();

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDSNV_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien(sc);
            dsnv.ShowDialog();

            if (!string.IsNullOrWhiteSpace(sc.MaNhanVien) &&
                !string.IsNullOrWhiteSpace(sc.HoTen) &&
                !string.IsNullOrWhiteSpace(sc.ChucVu))
            {
                string hienThiNhanVien = sc.MaNhanVien + " || " + sc.HoTen + " || " + sc.ChucVu;
                txbThongTinNhanVien.Text = hienThiNhanVien;
            }
        }
        private void cbbLoaiSuCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbChonSoTienPhat.Items.Clear();
            sc.loaiSuCo = cbbLoaiSuCo.SelectedItem.ToString();
            if (cbbLoaiSuCo.SelectedIndex == 0)
            {
                cbbChonSoTienPhat.Items.Add("50000 VND");
                cbbChonSoTienPhat.Items.Add("100000 VND");
                cbbChonSoTienPhat.Items.Add("150000 VND");
                cbbChonSoTienPhat.Items.Add("200000 VND");
            }
            else if (cbbLoaiSuCo.SelectedIndex == 1 || cbbLoaiSuCo.SelectedIndex == 2 || cbbLoaiSuCo.SelectedIndex == 3)
            {

                cbbChonSoTienPhat.Items.Add("1/8 tháng lương");
                cbbChonSoTienPhat.Items.Add("1/4 tháng lương");
                cbbChonSoTienPhat.Items.Add("nửa tháng lương");
                cbbChonSoTienPhat.Items.Add("1 tháng lương");
            }
        }
        private void cbbHinhThucXuLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHinhThucXuLy.SelectedIndex == 0)
            {
                lblChonSoTienPhat.Visible = true;
                cbbChonSoTienPhat.Visible = true;

            }
            else
            {
                lblChonSoTienPhat.Visible = false;
                cbbChonSoTienPhat.Visible = false;
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sc.MaNhanVien) ||
                string.IsNullOrWhiteSpace(sc.HoTen) ||
                string.IsNullOrWhiteSpace(sc.ChucVu))
            {
                MessageBox.Show("Xin vui lòng chọn nhân viên !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var danhSachSuCo = _mongoDataAccess.GetTatCaSuCo();

            bool check = true;
            foreach (var suCo in danhSachSuCo)
            {
                // Kiểm tra null trước khi so sánh
                if (suCo != null &&
                    !string.IsNullOrWhiteSpace(suCo.MaNhanVien) &&
                    suCo.ngayXayRa != null &&
                    !string.IsNullOrWhiteSpace(suCo.loaiSuCo))
                {
                    if (suCo.MaNhanVien.ToString() == sc.MaNhanVien.ToString() &&
                         suCo.ngayXayRa.ToUniversalTime().Date == sc.ngayXayRa.ToUniversalTime().Date &&
                         suCo.loaiSuCo.ToString() == sc.loaiSuCo.ToString())
                    {
                        check = false;
                        break;
                    }
                }
            }

            if (check)
            {
                ThemDuLieu();
            }
            else
            {
                MessageBox.Show("Đã có sự cố được lưu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ThemDuLieu()
        {
            double luong = 0;
            var danhSachHopDong = _mongoDataAccess.GetTatCaHopDong();

            foreach (var a in danhSachHopDong)
            {
                if (sc.MaHopDong == a.MaHopDong)
                {
                    luong = a.LuongCoBan;
                    break;
                }
            }
            string maSC = LayMaSuCo();
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("cong_ty_dbpt");
                var collection = database.GetCollection<BsonDocument>("su_co");

                sc.maSuCo = maSC;
                sc.ngayXayRa = dtpNgayXayRa.Value.Date;
                sc.loaiSuCo = cbbLoaiSuCo.SelectedItem?.ToString();
                sc.ghiChu = txbGhiChu.Text;
                sc.hinhThucXuLy = cbbHinhThucXuLy.SelectedItem?.ToString();

                if (cbbChonSoTienPhat.SelectedItem != null)
                {
                    string selectedItem = cbbChonSoTienPhat.SelectedItem.ToString();

                    if (selectedItem.Contains("VND"))
                    {
                        string amountString = selectedItem.Replace(" VND", "").Trim();
                        double soTienPhat = 0;

                        if (double.TryParse(amountString, out soTienPhat))
                        {
                            sc.soTienPhat = soTienPhat;
                        }
                    }
                    else if (selectedItem == "nửa tháng lương" || selectedItem == "1 tháng lương" || selectedItem == "1/8 tháng lương" || selectedItem == "1/4 tháng lương")
                    {
                        double soTienPhat = 0;
                        if (selectedItem == "nửa tháng lương")
                        {
                            soTienPhat = 0.5 * luong;
                        }
                        else if (selectedItem == "1 tháng lương")
                        {
                            soTienPhat = 1 * luong;
                        }
                        else if (selectedItem == "1/8 tháng lương")
                        {
                            soTienPhat = 0.125 * luong;
                        }
                        else if (selectedItem == "1/4 tháng lương")
                        {
                            soTienPhat = 0.25 * luong;
                        }

                        sc.soTienPhat = soTienPhat;
                    }
                }
                var nhanVienDocument = new BsonDocument
                {
                    {"ma_nhan_vien", sc.MaNhanVien },
                    {"ho_ten", sc.HoTen },
                    {"chuc_vu", sc.ChucVu }
                };
                var suCoDocument = new BsonDocument
                {
                    {"ma_su_co", sc.maSuCo },
                    {"nhan_vien", nhanVienDocument },
                    {"ngay_xay_ra", sc.ngayXayRa },
                    {"loai_su_co", sc.loaiSuCo },
                    {"ghi_chu", sc.ghiChu },
                    {"hinh_thuc_xu_ly", sc.hinhThucXuLy },
                    {"so_tien_phat", sc.soTienPhat }
                };

                collection.InsertOne(suCoDocument);
                MessageBox.Show("Dữ liệu đã được thêm vào MongoDB!");

                ThongTinNhanSuSuco ttnssc = new ThongTinNhanSuSuco();
                this.Hide();
                ttnssc.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string LayMaSuCo()
        {
            var danhSachSuCo = _mongoDataAccess.GetTatCaSuCo();

            if (danhSachSuCo == null || danhSachSuCo.Count == 0)
            {
                return "SC001";
            }
            else
            {
                int max = 0;
                foreach (var b in danhSachSuCo)
                {
                    string soString = b.maSuCo.Substring(2);
                    int so = int.Parse(soString);
                    if (max < so)
                    {
                        max = so;
                    }
                }
                return "SC00" + (max + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sc.MaNhanVien) &&
               string.IsNullOrWhiteSpace(sc.HoTen) &&
               string.IsNullOrWhiteSpace(sc.ChucVu))
            {
                MessageBox.Show("Xin vui lòng chọn nhân viên !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double Thuong = _mongoDataAccess.TinhTienThuong(dtpNgayXayRa.Value.Month.ToString(), dtpNgayXayRa.Value.Year.ToString(), sc.MaNhanVien.ToString());

                MessageBox.Show("Lương tháng " + dtpNgayXayRa.Value.Month.ToString() + " năm " + dtpNgayXayRa.Value.Year.ToString() + " là: " + Thuong, "Tiền Thưởng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTao_Click_1(object sender, EventArgs e)
        {

        }

        private void dtpNgayXayRa_ValueChanged(object sender, EventArgs e)
        {
            sc.ngayXayRa = dtpNgayXayRa.Value.Date;
        }

        private void cbbLoaiSuCo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sc.loaiSuCo = cbbLoaiSuCo.SelectedItem?.ToString();
        }

        private void cbbLoaiSuCo_SelectedValueChanged(object sender, EventArgs e)
        {
            sc.loaiSuCo = cbbLoaiSuCo.SelectedItem?.ToString();
        }

        private void lbDSNV_Click(object sender, EventArgs e)
        {

        }
    }
}
