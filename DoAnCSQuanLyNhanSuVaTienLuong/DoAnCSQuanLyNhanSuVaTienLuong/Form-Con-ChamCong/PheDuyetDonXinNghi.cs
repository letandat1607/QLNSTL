using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class PheDuyetDonXinNghi : Form
    {
        private MongoDataAccess _mongoDataAccess;
        private ClassDonXinNghi duLieuDonXinNghi;
        private List<NhanVien> duLieuNhanVien;
        int soNPConLai, soNgayNghi, soNgayPhep;

        public PheDuyetDonXinNghi(ClassDonXinNghi donXinNghi)
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            duLieuDonXinNghi = donXinNghi;
            LoadDonXinNghi();
            btnPheDuyet.Enabled = false;
            if(Const.taiKhoanActive.LoaiTaiKhoan == "quanlyns" || Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                btnPheDuyet.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDonXinNghi()
        {
            duLieuNhanVien = _mongoDataAccess.GetTatCaNhanVien();
            var nhanVien = duLieuNhanVien.FirstOrDefault( x => x.MaNhanVien == duLieuDonXinNghi.MaNhanVien);
            txtNhanVien.Text = duLieuDonXinNghi.HoTen +" ("+ duLieuDonXinNghi.MaNhanVien+ ")";
            dtpNgayNopDon.Value = duLieuDonXinNghi.NgayNopDon;
            dtpTuNgay.Value = duLieuDonXinNghi.TuNgay;
            dtpDenNgay.Value = duLieuDonXinNghi.DenNgay;
            txtLoaiNghi.Text = duLieuDonXinNghi.LoaiNghi;
            rtbLyDoNghi.Text = duLieuDonXinNghi.LiDoNghi;
            if (nhanVien != null)
            {
                if(duLieuDonXinNghi.TuNgay == duLieuDonXinNghi.DenNgay)
                {
                    soNgayNghi = 1;
                }
                else
                {
                    soNgayNghi = (duLieuDonXinNghi.DenNgay.Date - duLieuDonXinNghi.TuNgay.Date).Days +1;
                }
                txtSoNgayNghi.Text = soNgayNghi.ToString();
                soNgayPhep = nhanVien.SoNgayPhep;
                soNPConLai = soNgayPhep - soNgayNghi;
                if(soNPConLai < 0)
                {
                    txtSoNPConLai.Text = "0";
                }
                else
                {
                    txtSoNPConLai.Text = soNPConLai.ToString();
                }
                txtNPDuocSuDung.Text = nhanVien.SoNgayPhep.ToString();
                if (duLieuDonXinNghi.TrangThai == 1)
                {
                    txtNPDuocSuDung.Visible = false;
                    lblSoNPDuocSuDung.Visible = false;
                    btnPheDuyet.Enabled = false;
                    btnPheDuyet.Text = "Đã duyệt";
                }
            }
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                if (soNPConLai >= 0) 
            {
                _mongoDataAccess.CapNhatVaThemMoiNgayNghi(soNPConLai, duLieuDonXinNghi, "CoPhep");
            }
            else
            {
                if (soNgayPhep > 0)
                {
                    var donCoPhep = new ClassDonXinNghi
                    {
                        MaDonXinNghi = duLieuDonXinNghi.MaDonXinNghi,
                        NgayNopDon = duLieuDonXinNghi.NgayNopDon,
                        TuNgay = duLieuDonXinNghi.TuNgay,
                        DenNgay = duLieuDonXinNghi.TuNgay.AddDays(soNgayPhep - 1),
                        LoaiNghi = duLieuDonXinNghi.LoaiNghi + " (Có phép)",
                        LiDoNghi = duLieuDonXinNghi.LiDoNghi,
                        TrangThai = duLieuDonXinNghi.TrangThai,
                        MaNhanVien = duLieuDonXinNghi.MaNhanVien,
                        HoTen = duLieuDonXinNghi.HoTen,
                        ViTriCongViec = duLieuDonXinNghi.ViTriCongViec
                    };
                    _mongoDataAccess.CapNhatVaThemMoiNgayNghi(0, donCoPhep, "CoPhep");
                    var donKhongPhep = new ClassDonXinNghi
                    {
                        MaDonXinNghi = duLieuDonXinNghi.MaDonXinNghi,
                        NgayNopDon = duLieuDonXinNghi.NgayNopDon,
                        TuNgay = duLieuDonXinNghi.TuNgay.AddDays(soNgayPhep),
                        DenNgay = duLieuDonXinNghi.DenNgay,
                        LoaiNghi = duLieuDonXinNghi.LoaiNghi + " (Không phép)",
                        LiDoNghi = duLieuDonXinNghi.LiDoNghi,
                        TrangThai = duLieuDonXinNghi.TrangThai,
                        MaNhanVien = duLieuDonXinNghi.MaNhanVien,
                        HoTen = duLieuDonXinNghi.HoTen,
                        ViTriCongViec = duLieuDonXinNghi.ViTriCongViec
                    };
                    _mongoDataAccess.CapNhatVaThemMoiNgayNghi(0, donKhongPhep, "KhongPhep");
                }
                else 
                {
                    _mongoDataAccess.CapNhatVaThemMoiNgayNghi(0, duLieuDonXinNghi, "KhongPhep");
                }
            }
            MessageBox.Show("Phê duyệt đơn xin nghỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
