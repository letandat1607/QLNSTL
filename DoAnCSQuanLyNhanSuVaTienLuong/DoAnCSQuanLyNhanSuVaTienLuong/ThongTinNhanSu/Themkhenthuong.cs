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
    public partial class Themkhenthuong : Form
    {
        DanhSachNhanVienDuocKhenThuong danhSach = new DanhSachNhanVienDuocKhenThuong();
        private MongoDataAccess _mongoDataAccess;
        private int cbbLoaikhenThuongIndex;
        private int cbbHinhThucKhenThuongIndex;
        public Themkhenthuong()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            btnDSNV.Click += btnDSNV_Click;
            btnDSNVKT.Click += btnDSNVKT_Click;
            btnTao.Click += new EventHandler(btnTao_Click);
            cbbHinhThucKhenThuong.SelectedIndexChanged += cbbHinhThucKhenThuong_SelectedIndexChanged;

        }
        private void Themkhenthuong_Load(object sender, EventArgs e)
        {
            danhSach.XoaNhanVien();
            cbbLoaikhenThuong.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHinhThucKhenThuong.DropDownStyle = ComboBoxStyle.DropDownList;
            lbSoTienKhenThuong.Visible = false;
            btnThemTienThuong.Visible = false;
        }
        private void cbbLoaikhenThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTendotkhenthuong.ForeColor = System.Drawing.Color.Black;
            lblLoaiKhenThuongSao.Visible = false;
            if (cbbLoaikhenThuong.SelectedIndex == 2)
            {
                cbbLoaikhenThuongIndex = 2;

                cbbHinhThucKhenThuong.SelectedIndex = 1;
                cbbHinhThucKhenThuong.Enabled = false;

                btnDSNV.Visible = false;
                lbDSNV.Visible = false;

                lbDSNVKT.Location = new System.Drawing.Point(7, 200);
                btnDSNVKT.Location = new System.Drawing.Point(7, 220);

                lbSoTienKhenThuong.Visible = false;
                btnThemTienThuong.Visible = false;

                danhSach.XoaNhanVien();

                if (_mongoDataAccess == null)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var danhSachNhanVien = _mongoDataAccess.GetTatCaNhanVien();
                var danhSachHopDong = _mongoDataAccess.GetTatCaHopDong();

                if (danhSachNhanVien == null || !danhSachNhanVien.Any())
                {
                    MessageBox.Show("Không có nhân viên nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int tienThuong = 0;

                foreach (var nhanVien in danhSachNhanVien)
                {
                    NhanVienKhenThuong a = new NhanVienKhenThuong();

                    a.MaNhanVien = nhanVien.MaNhanVien;
                    a.HoTen = nhanVien.HoTen;
                    a.SoDienThoai = nhanVien.SoDienThoai;
                    a.Email = nhanVien.Email;
                    a.ChucVu = nhanVien.ChucVu;
                    a.TienThuong = tienThuong;
                    a.MaHopDong = nhanVien.MaHopDong;
                    danhSach.ThemNhanVien(a);
                }
                foreach (var a in danhSach.LayDanhSachNhanVien())
                {
                    foreach (var hopDongs in danhSachHopDong)
                    {
                        if (a.MaHopDong == hopDongs.MaHopDong)
                        {
                            a.TienThuong = hopDongs.LuongCoBan;
                        }
                    }
                }
            }
            if (cbbLoaikhenThuong.SelectedIndex == 1)
            {
                cbbLoaikhenThuongIndex = 1;

                danhSach.XoaNhanVien();
                cbbHinhThucKhenThuong.SelectedIndex = 1;
                cbbHinhThucKhenThuong.Enabled = false;

                btnDSNV.Visible = true;
                lbDSNV.Visible = true;

                lbDSNVKT.Location = new System.Drawing.Point(10, 252);
                btnDSNVKT.Location = new System.Drawing.Point(10, 275);

                lbSoTienKhenThuong.Visible = true;
                btnThemTienThuong.Visible = true;

            }
            if (cbbLoaikhenThuong.SelectedIndex == 0)
            {
                cbbLoaikhenThuongIndex = 0;

                danhSach.XoaNhanVien();
                cbbHinhThucKhenThuong.SelectedIndex = -1;
                cbbHinhThucKhenThuong.Enabled = true;

                btnDSNV.Visible = true;
                lbDSNV.Visible = true;

                lbDSNVKT.Location = new System.Drawing.Point(10, 252);
                btnDSNVKT.Location = new System.Drawing.Point(10, 275);

            }
        }
        private void cbbHinhThucKhenThuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHinhThucKhenThuongSao.Visible = false;
            lblHinhthuckhenthuong.ForeColor = System.Drawing.Color.Black;
            if (cbbHinhThucKhenThuong.SelectedIndex == 1)
            {
                cbbHinhThucKhenThuongIndex = 1;

                lbSoTienKhenThuong.Visible = true;
                btnThemTienThuong.Visible = true;
            }
            else
            {
                cbbHinhThucKhenThuongIndex = 0;

                lbSoTienKhenThuong.Visible = false;
                btnThemTienThuong.Visible = false;
            }
        }
        public void btnDSNV_Click(object sender, EventArgs e)
        {
            lbDSNV.ForeColor = System.Drawing.Color.Gray;
            lblChonNhanVienKhenThuongSao.Visible = false;
            DanhSachNhanVien dsnv = new DanhSachNhanVien(danhSach);
            dsnv.ShowDialog();
        }
        public void btnDSNVKT_Click(object sender, EventArgs e)
        {
            int z = 1;
            DanhSachNhanVienKhenThuong dsnvkt = new DanhSachNhanVienKhenThuong(danhSach, cbbLoaikhenThuongIndex, cbbHinhThucKhenThuongIndex, z);
            dsnvkt.ShowDialog();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void txtNoidungkhenthuong_Enter(object sender, EventArgs e)
        {
            lblNoidungkhenthuong.ForeColor = System.Drawing.Color.Black;
            lblNoiDungKhenThuongSao.Visible = false;
        }
        private void btnThemTienThuong_Click(object sender, EventArgs e)
        {
            int z = 0;
            lbSoTienKhenThuong.ForeColor = System.Drawing.Color.Black;
            lblThemTienThuongSao.Visible = false;
            DanhSachNhanVienKhenThuong dsnvkt = new DanhSachNhanVienKhenThuong(danhSach, cbbLoaikhenThuongIndex, cbbHinhThucKhenThuongIndex, z);
            dsnvkt.ShowDialog();
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cbbLoaikhenThuong.SelectedItem == null || cbbHinhThucKhenThuong.SelectedItem == null || string.IsNullOrEmpty(txtNoidungkhenthuong.Text))
            {
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin !!!", "Bực", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                if (cbbLoaikhenThuong.SelectedItem == null)
                {
                    lblTendotkhenthuong.ForeColor = System.Drawing.Color.Red;
                    lblLoaiKhenThuongSao.Visible = true;
                }
                if (cbbHinhThucKhenThuong.SelectedItem == null)
                {
                    lblHinhthuckhenthuong.ForeColor = System.Drawing.Color.Red;
                    lblHinhThucKhenThuongSao.Visible = true;
                }
                if (string.IsNullOrEmpty(txtNoidungkhenthuong.Text))
                {
                    lblNoidungkhenthuong.ForeColor = System.Drawing.Color.Red;
                    lblNoiDungKhenThuongSao.Visible = true;
                }
            }
            else
            {
                var khenThuong = _mongoDataAccess.GetTatCaKhenThuong();
                if (cbbLoaikhenThuong.SelectedIndex == 2)
                {
                    bool check = true;

                    foreach (var a in khenThuong)
                    {
                        if (a.NgayKhenThuong.Year == dateTimePicker2Ngaytrungtuyn.Value.Year && a.LoaiKhenThuong == cbbLoaikhenThuong.SelectedItem?.ToString())
                        {
                            check = false;
                            break;
                        }
                    }

                    if (!check)
                    {
                        MessageBox.Show("Bạn đã thêm khen thưởng Tết cho năm " + (dateTimePicker2Ngaytrungtuyn.Value.Year + 1) + " rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        LuuDuLieu();
                    }
                }
                if (cbbLoaikhenThuong.SelectedIndex == 0)
                {
                    if (danhSach.CoDuLieu())
                    {
                        if (cbbHinhThucKhenThuong.SelectedIndex == 1)
                        {
                            bool check = true;
                            foreach (var a in danhSach.LayDanhSachNhanVien())
                            {
                                if (a.TienThuong == 0)
                                {
                                    check = false;
                                    break;
                                }
                            }
                            if (check)
                            {
                                LuuDuLieu();
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập đầy đủ tiền thưởng cho nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                lbSoTienKhenThuong.ForeColor = System.Drawing.Color.Red;
                                lblThemTienThuongSao.Visible = true;
                            }
                        }
                        else
                        {
                            LuuDuLieu();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin chọn ít nhất một nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        lbDSNV.ForeColor = System.Drawing.Color.Red;
                        lblChonNhanVienKhenThuongSao.Visible = true;
                    }
                }
                if (cbbLoaikhenThuong.SelectedIndex == 1)
                {
                    if (danhSach.CoDuLieu())
                    {
                        bool kiemTraTienThuong = danhSach.LayDanhSachNhanVien().All(nv => nv.TienThuong > 0);

                        if (kiemTraTienThuong)
                        {
                            foreach (var khenThuongItem in khenThuong)
                            {
                                if (khenThuongItem.NgayKhenThuong.Year == dateTimePicker2Ngaytrungtuyn.Value.Year &&
                                    khenThuongItem.LoaiKhenThuong == cbbLoaikhenThuong.SelectedItem?.ToString())
                                {
                                    foreach (var nhanVienKhenThuong in khenThuongItem.DanhSachNhanVien)
                                    {
                                        var nhanVienCanXoa = danhSach.LayDanhSachNhanVien()
                                            .FirstOrDefault(nv => nv.MaNhanVien == nhanVienKhenThuong.MaNhanVien);

                                        if (nhanVienCanXoa != null)
                                        {
                                            danhSach.XoaMotNhanVien(nhanVienCanXoa);
                                        }
                                    }
                                }
                            }
                            if (danhSach.CoDuLieu())
                            {
                                LuuDuLieu();
                            }
                            else
                            {
                                MessageBox.Show("Bạn Đã Thưởng Tháng 13 năm " + dateTimePicker2Ngaytrungtuyn.Value.Year.ToString() + " cho những nhân viên này rồi !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ tiền thưởng cho nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            lbSoTienKhenThuong.ForeColor = System.Drawing.Color.Red;
                            lblThemTienThuongSao.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xin chọn ít nhất một nhân viên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        lbDSNV.ForeColor = System.Drawing.Color.Red;
                        lblChonNhanVienKhenThuongSao.Visible = true;
                    }
                }
            }
        }

        private void LuuDuLieu()
        {
            string maKhenThuong = LayMaKhenThuong();
            try
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("cong_ty_dbpt");
                var collection = database.GetCollection<BsonDocument>("khen_thuong");

                var danhSachNhanVien = new BsonArray();

                foreach (NhanVienKhenThuong a in danhSach.LayDanhSachNhanVien())
                {
                    var nhanVienDoc = new BsonDocument
                    {
                        { "ma_nhan_vien", a.MaNhanVien },
                        { "ho_ten", a.HoTen },
                        { "chuc_vu", a.ChucVu },
                        { "so_tien_thuong", a.tienThuong }
                    };

                    danhSachNhanVien.Add(nhanVienDoc);
                }

                var khenThuong = new BsonDocument
                {
                    { "ma_khen_thuong", maKhenThuong },
                    { "loai_khen_thuong", cbbLoaikhenThuong.SelectedItem?.ToString() },
                    { "ngay_khen_thuong", dateTimePicker2Ngaytrungtuyn.Value },
                    { "hinh_thuc_khen_thuong", cbbHinhThucKhenThuong.SelectedItem?.ToString() },
                    { "noi_dung_khen_thuong", txtNoidungkhenthuong.Text },
                    { "danh_sach_nhan_vien", danhSachNhanVien }
                };

                collection.InsertOne(khenThuong);
                MessageBox.Show("Dữ liệu đã được thêm vào MongoDB!");

                ThongTinNhanSuKhenthuong ttnskt = new ThongTinNhanSuKhenthuong();
                this.Hide();
                ttnskt.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string LayMaKhenThuong()
        {
            var danhSachKhenThuong = _mongoDataAccess.GetTatCaKhenThuong();

            if (danhSachKhenThuong == null || danhSachKhenThuong.Count == 0)
            {
                return "KT001";
            }
            else
            {
                int max = 0;
                foreach (var b in danhSachKhenThuong)
                {
                    string soString = b.MaKhenThuong.Substring(2);
                    int so = int.Parse(soString);
                    if (max < so)
                    {
                        max = so;
                    }
                }
                return "KT00" + (max + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDSNVKT_Click_1(object sender, EventArgs e)
        {

        }
    }
}
