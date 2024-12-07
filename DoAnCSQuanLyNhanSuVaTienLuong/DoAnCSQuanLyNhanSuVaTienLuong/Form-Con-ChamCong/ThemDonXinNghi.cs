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
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class ThemDonXinNghi : Form
    {
        private MongoDataAccess _mongoDataAccess;
        private List<NhanVien> danhSachNhanVien;
        private string maNhanVien, tenNhanVien, viTriCongViec;
        private ClassDonXinNghi donXinNghi = new ClassDonXinNghi();
        public ThemDonXinNghi()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            LoadComboBoxNhanVien();
        }

        private void LoadComboBoxNhanVien()
        {
            danhSachNhanVien = _mongoDataAccess.GetTatCaNhanVien();
            var danhSachHienThi = danhSachNhanVien.Select(x => $"{x.HoTen} ({x.MaNhanVien})").ToList();
            cbNhanVien.DataSource = danhSachHienThi;
            cbNhanVien.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                donXinNghi.MaDonXinNghi = _mongoDataAccess.TaoMaDonXinNghiMoi();

                donXinNghi.NgayNopDon = dtpNgayNopDon.Value;
                donXinNghi.TuNgay = dtpTuNgay.Value;
                donXinNghi.DenNgay = dtpDenNgay.Value;
                if (string.IsNullOrWhiteSpace(rtbLyDoNghi.Text) || string.IsNullOrWhiteSpace(cbLoaiNghi.SelectedItem.ToString()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(dtpNgayNopDon.Value > dtpTuNgay.Value)
                {
                    MessageBox.Show("Ngày nộp đơn không được bé hơn ngày bắt đầu nghỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtpTuNgay.Value > dtpDenNgay.Value)
                {
                    MessageBox.Show("Ngày kết thúc nghỉ không thể trước ngày bắt đầu nghỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                donXinNghi.MaNhanVien = maNhanVien;
                donXinNghi.HoTen = tenNhanVien;
                donXinNghi.ViTriCongViec = viTriCongViec;
                donXinNghi.LoaiNghi = cbLoaiNghi.SelectedItem.ToString();
                donXinNghi.LiDoNghi = rtbLyDoNghi.Text;
                _mongoDataAccess.InsertDonXinNghi(donXinNghi);

                MessageBox.Show("Thêm đơn xin nghỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNhanVien.SelectedIndex == -1)
            {
                txtNPDuocSuDung.Text = "0";
            }
            else
            {
                var selectedText = cbNhanVien.SelectedItem.ToString();
                var nhanVien = danhSachNhanVien.FirstOrDefault(
                    nv => $"{nv.HoTen} ({nv.MaNhanVien})" == selectedText);
                if (nhanVien != null)
                {
                    txtNPDuocSuDung.Text = nhanVien.SoNgayPhep.ToString();
                    tenNhanVien = nhanVien.HoTen;
                    maNhanVien = nhanVien.MaNhanVien;
                    viTriCongViec = nhanVien.ViTriCongViec;
                }
            }
        }
    }
}
