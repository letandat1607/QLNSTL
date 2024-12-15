using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
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
    partial class BangChamCongCT : Form
    {
        private readonly MongoDataAccess _dataAccess;
        private List<DanhSachChamCong> _danhSachBangChamCong;
        public BangChamCongCT()
        {
            InitializeComponent();
            _dataAccess = new MongoDataAccess();
            LoadBangChamCong();
        }
        private void LoadBangChamCong()
        {
            _danhSachBangChamCong = _dataAccess.GetTatCaBangChamCong();
            dtgvBangChamCongCT.Columns.Clear();
            dtgvBangChamCongCT.Columns.Add("ThoiGianBatDau", "Thời gian bắt đầu");
            dtgvBangChamCongCT.Columns.Add("ThoiGianKetThuc", "Thời gian kết thúc");
            dtgvBangChamCongCT.Columns.Add("TenBangChamCong", "Tên bảng chấm công");
            dtgvBangChamCongCT.Columns.Add("ChamCong", "Chấm công");
            dtgvBangChamCongCT.Columns.Add("ViTriCongViec", "Vị trí công việc");
            dtgvBangChamCongCT.Columns.Add("TrangThai", "Trạng thái");

            dtgvBangChamCongCT.Columns["ThoiGianBatDau"].Width = 130;
            dtgvBangChamCongCT.Columns["ThoiGianKetThuc"].Width = 130;
            dtgvBangChamCongCT.Columns["TenBangChamCong"].Width = 300;
            dtgvBangChamCongCT.Columns["ChamCong"].Width = 100;
            dtgvBangChamCongCT.Columns["ViTriCongViec"].Width = 140;
            dtgvBangChamCongCT.Columns["TrangThai"].Width = 110;

            foreach (var bangChamCong in _danhSachBangChamCong)
            {
                dtgvBangChamCongCT.Rows.Add(
                    bangChamCong.ThoiGianBatDau.ToString("yyyy-MM-dd"),
                    bangChamCong.ThoiGianKetThuc.ToString("yyyy-MM-dd"),
                    bangChamCong.TenBangChamCong,
                    bangChamCong.ChamCong,
                    bangChamCong.ViTriCongViec,
                    "Hoàn thành"
                );
            }
        }



        private void btnTintuyendung_Click(object sender, EventArgs e)
        {
            BangChamCongCT formTuyendung = new BangChamCongCT();
            this.Hide();
            formTuyendung.ShowDialog();
            this.Close();

        }

        private void btnUngvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThucHienChamCong thucHienChamCong = new ThucHienChamCong();
            thucHienChamCong.ShowDialog();
            this.Close();
        }
        private void btnThemmoithongtintuyendung_Click(object sender, EventArgs e)
        {
        }

        private void dtgtuyendung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBangChamCongCT = _danhSachBangChamCong[e.RowIndex];
                var formDuLieu = new BangDuLieuChamCong(selectedBangChamCongCT);
                formDuLieu.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
        }

        private void picBMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
            heThongQuanLy.ShowDialog();
            this.Close();
        }

        private void btnDonXinNghi_Click(object sender, EventArgs e)
        {
            this.Hide();    
            DonXinNghi donXinNghi = new DonXinNghi();
            donXinNghi.ShowDialog();
            this.Close();
        }
    }
}
