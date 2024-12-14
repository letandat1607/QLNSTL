using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using MongoDB.Bson;
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
    public partial class Suahoso : Form
    {
        MongoDataAccess mongo;
        string manv;
        public Suahoso(string a)
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            manv = a;
            Load();
        }
        public void Load()
        {
            var nv = mongo.FindOneNhanVien(manv);
            if (nv != null)
            {
                txtManhanvien.Text = nv.MaNhanVien;
                txtTen.Text = nv.HoTen;
                txtSdt.Text = nv.SoDienThoai;
                txtEmail.Text = nv.Email;
                txtChucvu.Text = nv.ChucVu;
                txtNoilamviec.Text = nv.NoiLamViec;
                ngaysinh.Value = nv.NgaySinh;
                ngayungtuyen.Value = nv.NgayUngTuyen;
                if (nv.GioiTinh == "Nam")
                {
                    chkNam.Checked = true;
                }
                if (nv.GioiTinh == "Nữ")
                {
                    chkNu.Checked = true;
                }
                txtDiachi.Text = nv.DiaChi;
                txtTongiao.Text = nv.TonGiao;
                txtDantoc.Text = nv.DanToc;
                ngaycap.Value = nv.NgayCap;
                txtNoiCap.Text = nv.NoiCap;
                txtCCCD.Text = nv.SoCccd;
                txtSohokhau.Text = nv.SoHoKhau;
                txtNoisinh.Text = nv.NoiSinh;
                txtQuequan.Text = nv.QueQuan;
                txtTamtrutamvang.Text = nv.TamTruTamVang;
                txtTrinhdo.Text = nv.TrinhDo;
                txtChuyennganh.Text = nv.ChuyenNganh;
                txtVitricongviec.Text = nv.ViTriCongViec;
                txtMota.Text = nv.MoTa;
            }
            else
            {
                ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
                this.Hide();
                formHoso.ShowDialog();
                this.Close();
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
            this.Hide();
            formHoso.ShowDialog();
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {

            bool kiemtra = true;

            if (string.IsNullOrEmpty(txtManhanvien.Text) ||
            string.IsNullOrEmpty(txtTen.Text) ||
            string.IsNullOrEmpty(txtSdt.Text) ||
            string.IsNullOrEmpty(txtEmail.Text) ||
            string.IsNullOrEmpty(txtChucvu.Text) ||
            string.IsNullOrEmpty(txtNoilamviec.Text) ||
            ngaysinh.Value == null ||
            string.IsNullOrEmpty(txtDiachi.Text) ||
            string.IsNullOrEmpty(txtTongiao.Text) ||
            string.IsNullOrEmpty(txtDantoc.Text) ||
            ngaycap.Value == null ||
            string.IsNullOrEmpty(txtNoiCap.Text) ||
            string.IsNullOrEmpty(txtCCCD.Text) ||
            string.IsNullOrEmpty(txtSohokhau.Text) ||
            string.IsNullOrEmpty(txtNoisinh.Text) ||
            string.IsNullOrEmpty(txtQuequan.Text) ||
            string.IsNullOrEmpty(txtTamtrutamvang.Text) ||
            string.IsNullOrEmpty(txtTrinhdo.Text) ||
            string.IsNullOrEmpty(txtChuyennganh.Text) ||
            string.IsNullOrEmpty(txtVitricongviec.Text) ||
            string.IsNullOrEmpty(txtMota.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                kiemtra = false;
            }

            if (!chkNam.Checked && !chkNu.Checked || chkNam.Checked && chkNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                kiemtra = false;
            }
            if (!int.TryParse(txtSdt.Text, out _))
            {
                MessageBox.Show("Số điện thoại phải là một số hợp lệ.");
                kiemtra = false;

            }

            if (kiemtra)
            {

                try
                {
                    var nv = mongo.FindOneNhanVien(manv);
                    NhanVien nnv = new NhanVien
                    {
                        MaNhanVien = nv.MaNhanVien,
                        HoTen = txtTen.Text,
                        SoDienThoai = txtSdt.Text,
                        Email = txtEmail.Text,
                        ChucVu = txtChucvu.Text,
                        NoiLamViec = txtNoilamviec.Text,
                        NgaySinh = ngaysinh.Value,
                        GioiTinh = chkNam.Checked ? "Nam" : chkNu.Checked ? "Nữ" : string.Empty,
                        DiaChi = txtDiachi.Text,
                        TonGiao = txtTongiao.Text,
                        DanToc = txtDantoc.Text,
                        NgayCap = ngaycap.Value,
                        NoiCap = txtNoiCap.Text,
                        SoCccd = txtCCCD.Text,
                        SoHoKhau = txtSohokhau.Text,
                        NoiSinh = txtNoisinh.Text,
                        QueQuan = txtQuequan.Text,
                        TamTruTamVang = txtTamtrutamvang.Text,
                        TrinhDo = txtTrinhdo.Text,
                        ChuyenNganh = txtChuyennganh.Text,
                        ViTriCongViec = txtVitricongviec.Text,
                        MoTa = txtMota.Text,
                        MaHopDong = nv.MaHopDong,
                    };
                    var nvdoc = new BsonDocument
                    {
                        { "ma_nhan_vien", nnv.MaNhanVien },
                        { "ngay_sinh", nnv.NgaySinh },
                        { "gioi_tinh", nnv.GioiTinh },
                        { "so_dien_thoai", nnv.SoDienThoai },
                        { "email", nnv.Email },
                        { "so_ho_khau", nnv.SoHoKhau },
                        { "tam_tru_tam_vang", nnv.TamTruTamVang },
                        { "dia_chi", nnv.DiaChi },
                        { "noi_sinh", nnv.NoiSinh },
                        { "que_quan", nnv.QueQuan },
                        { "ton_giao", nnv.TonGiao },
                        { "dan_toc", nnv.DanToc },
                        { "so_cccd", nnv.SoCccd },
                        { "ngay_cap", nnv.NgayCap },
                        { "noi_cap", nnv.NoiCap },
                        { "ngay_ung_tuyen", nnv.NgayUngTuyen },
                        { "ngay_chinh_thuc", nnv.NgayChinhThuc },
                        { "trinh_do", nnv.TrinhDo },
                        { "chuyen_nganh", nnv.ChuyenNganh },
                        { "vi_tri_cong_viec", nnv.ViTriCongViec },
                        { "noi_lam_viec", nnv.NoiLamViec },
                        { "so_ngay_phep", nnv.SoNgayPhep },
                        { "mo_ta", nnv.MoTa },
                        { "hop_dong", new BsonDocument
                            {
                                { "ma_hop_dong", nnv.MaHopDong },
                                { "ho_ten", nnv.HoTen },
                                { "ngay_ky", nnv.NgayKy },
                                { "chuc_vu", nnv.ChucVu }
                            }
                        },
                    };


                    mongo.UpdateOne(manv, nvdoc);
                    MessageBox.Show("Cập nhật thành công");

                    ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
                    this.Hide();
                    formHoso.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
}
