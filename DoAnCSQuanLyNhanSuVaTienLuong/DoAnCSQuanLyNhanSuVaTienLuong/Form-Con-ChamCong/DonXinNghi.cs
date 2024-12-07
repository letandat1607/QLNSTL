using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
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

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class DonXinNghi : Form
    {
        private MongoDataAccess _dataAccess;
        private List<ClassDonXinNghi> danhSachDonXinNghi;
        public DonXinNghi()
        {
            InitializeComponent();
            _dataAccess = new MongoDataAccess();
            LoadBangDonXinNghi();
        }

        private void LoadBangDonXinNghi()
        {
            danhSachDonXinNghi = _dataAccess.GetTatCaDonXinNghi();
            string trangThai;
            dtgvBangDonXinNghi.Columns.Clear();
            dtgvBangDonXinNghi.Columns.Add("MaDonXinNghi", "Mã đơn xin nghỉ");
            dtgvBangDonXinNghi.Columns.Add("MaNhanVien", "Mã nhân viên");
            dtgvBangDonXinNghi.Columns.Add("HoTen", "Tên nhân viên xin nghỉ");
            dtgvBangDonXinNghi.Columns.Add("ViTriCongViec", "Vị trí công việc");
            dtgvBangDonXinNghi.Columns.Add("NgayNopDon", "Ngày nộp đơn");
            dtgvBangDonXinNghi.Columns.Add("TuNgay", "Từ ngày");
            dtgvBangDonXinNghi.Columns.Add("DenNgay", "Đến ngày");
            dtgvBangDonXinNghi.Columns.Add("LoaiNghi", "Loại nghỉ");
            dtgvBangDonXinNghi.Columns.Add("TrangThai", "Trạng thái");


            dtgvBangDonXinNghi.Columns["MaDonXinNghi"].Width = 127;
            dtgvBangDonXinNghi.Columns["MaNhanVien"].Width = 127;
            dtgvBangDonXinNghi.Columns["HoTen"].Width = 191;
            dtgvBangDonXinNghi.Columns["NgayNopDon"].Width = 127;
            dtgvBangDonXinNghi.Columns["TuNgay"].Width = 127;
            dtgvBangDonXinNghi.Columns["ViTriCongViec"].Width = 191;
            dtgvBangDonXinNghi.Columns["DenNgay"].Width = 127;
            dtgvBangDonXinNghi.Columns["LoaiNghi"].Width = 127;
            dtgvBangDonXinNghi.Columns["TrangThai"].Width = 110;

            foreach (var donNghi in danhSachDonXinNghi)
            {
                if(donNghi.TrangThai == 1)
                {
                    trangThai = "Đã phê duyệt";
                }
                else
                {
                    trangThai = "Chưa phê duyệt";
                }
                dtgvBangDonXinNghi.Rows.Add(
                        donNghi.MaDonXinNghi,
                        donNghi.MaNhanVien,
                        donNghi.HoTen,
                        donNghi.ViTriCongViec,
                        donNghi.NgayNopDon.ToString("yyyy-MM-dd"),
                        donNghi.TuNgay.ToString("yyyy-MM-dd"),
                        donNghi.DenNgay.ToString("yyyy-MM-dd"),
                        donNghi.LoaiNghi,
                        trangThai
                    );
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemDonXinNghi themDonXinNghi = new ThemDonXinNghi();
            if (themDonXinNghi.ShowDialog() == DialogResult.OK) 
            {
                LoadBangDonXinNghi();            
            }
        }

        private void dtgvBangDonXinNghi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var donXinNghi = danhSachDonXinNghi[e.RowIndex];
                PheDuyetDonXinNghi pheDuyetDonXinNghi = new PheDuyetDonXinNghi(donXinNghi);
                pheDuyetDonXinNghi.ShowDialog();
            }
        }
    }
}
