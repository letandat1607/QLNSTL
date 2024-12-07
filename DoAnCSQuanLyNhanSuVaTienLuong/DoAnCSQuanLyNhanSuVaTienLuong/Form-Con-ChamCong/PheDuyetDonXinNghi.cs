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

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class PheDuyetDonXinNghi : Form
    {
        private MongoDataAccess _mongoDataAccess;
        private ClassDonXinNghi duLieuDonXinNghi;
        public PheDuyetDonXinNghi(ClassDonXinNghi donXinNghi)
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            duLieuDonXinNghi = donXinNghi;
            LoadDonXinNghi();
        }
        private void LoadDonXinNghi()
        {
            txtNhanVien.Text = duLieuDonXinNghi.HoTen +" ("+ duLieuDonXinNghi.MaNhanVien+ ")";
            dtpNgayNopDon.Value = duLieuDonXinNghi.NgayNopDon;
            dtpTuNgay.Value = duLieuDonXinNghi.TuNgay;
            dtpDenNgay.Value = duLieuDonXinNghi.DenNgay;
            txtLoaiNghi.Text = duLieuDonXinNghi.LoaiNghi;
            rtbLyDoNghi.Text = duLieuDonXinNghi.LiDoNghi;
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {

        }
    }
}
