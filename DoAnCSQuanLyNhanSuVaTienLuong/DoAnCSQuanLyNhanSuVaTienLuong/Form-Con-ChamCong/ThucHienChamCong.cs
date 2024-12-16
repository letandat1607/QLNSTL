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
using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using ZstdSharp.Unsafe;


namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    partial class ThucHienChamCong : Form
    {
        private MongoDataAccess _mongoDataAccess;
        public static string checkin;
        public static string checkout;
        public ThucHienChamCong()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            btnBangChamCongCT.Visible = false;
            if (Const.taiKhoanActive.LoaiTaiKhoan == "quanlyns" || Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                btnBangChamCongCT.Visible = true;
            }
            dtpNgayChamCong.Value = DateTime.Now;
            Const.chamCong.NgayChamCong = DateTime.UtcNow;
            bool check = false;
            //foreach (var chamCong in Const.danhSachChamCong)
            //{
            //    if (chamCong.MaNhanVien == Const.taiKhoanActive.MaNhanVien)
            //    {
            //        check = true;
            //    }
            //}
            //if (!check) 
            //{
            //    Const.chamCong.NgayChamCong = DateTime.UtcNow;
            //    Const.danhSachChamCong.Add(Const.chamCong);
            //}
            //btnCheckOut.Enabled = false;
        }

        private void btnTintuyendung_Click(object sender, EventArgs e)
        {
        }
        private void btnUngvien_Click(object sender, EventArgs e)
        {
        }
        private void btnThemmoithongtintuyendung_Click(object sender, EventArgs e)
        {
        }
        private void dtgtuyendung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void btnBangChamCongCT_Click(object sender, EventArgs e)
        {
            this.Hide();
            BangChamCongCT bangChamCongCT = new BangChamCongCT();
            bangChamCongCT.ShowDialog();
            this.Close();
        }

        private void btnQuanLyDonXinNghi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonXinNghi donXinNghi = new DonXinNghi();
            donXinNghi.ShowDialog();
            this.Close();
        }

        private void txtCheckIn_TextChanged(object sender, EventArgs e)
        {
        }
        private DateTime ConvertToVietnamTime(DateTime utcDateTime)
        {
            var vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, vietnamTimeZone);
        }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
            Const.chamCong.CheckIn = DateTime.UtcNow.TimeOfDay; 
            txtCheckIn.Text = vietnamTime.ToString("HH:mm:ss");
            checkin = vietnamTime.ToString("HH:mm:ss");
            btnCheckOut.Enabled = true;
            btnCheckIn.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
            Const.chamCong.CheckOut = DateTime.UtcNow.TimeOfDay;
            checkout = vietnamTime.ToString("HH:mm:ss");
            txtCheckOut.Text = vietnamTime.ToString("HH:mm:ss");
            _mongoDataAccess.InsertChamCong();

        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThucHienChamCong thucHien = new ThucHienChamCong();
            thucHien.ShowDialog();
            this.Close();
        }
    }
}
