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

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class ThucHienChamCong : Form
    {
        private MongoDataAccess _mongoDataAccess;
        public ThucHienChamCong()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            dtpNgayChamCong.Value = DateTime.Now;
<<<<<<< HEAD
            Const.chamCong.NgayChamCong = DateTime.UtcNow;
<<<<<<< HEAD
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
=======
            btnCheckOut.Enabled = false;
>>>>>>> parent of e3d248a (up20)
=======
            bool check = false;
            foreach (var chamCong in Const.danhSachChamCong)
            {
                if (chamCong.MaNhanVien == Const.taiKhoanActive.MaNhanVien)
                {
                    check = true;
                }
            }
            if (!check) 
            {
                Const.chamCong.NgayChamCong = DateTime.UtcNow;
                Const.danhSachChamCong.Add(Const.chamCong);
            }
            btnCheckOut.Enabled = false;
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

>>>>>>> parent of 2a3fcce (up21)
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
<<<<<<< HEAD
<<<<<<< HEAD
            Const.chamCong.CheckIn = DateTime.UtcNow.TimeOfDay; 
=======
            Const.chamCong.CheckIn = DateTime.UtcNow.TimeOfDay;
>>>>>>> parent of 2a3fcce (up21)
            txtCheckIn.Text = vietnamTime.ToString("HH:mm:ss");
            checkin = vietnamTime.ToString("HH:mm:ss");
=======
            Const.chamCong.CheckIn = DateTime.UtcNow.TimeOfDay;
            //rtbCheckIn.Text = DateTime.UtcNow.TimeOfDay.ToString();
            rtbCheckIn.Text = vietnamTime.ToString("HH:mm:ss");
>>>>>>> parent of e3d248a (up20)
            btnCheckOut.Enabled = true;
            btnCheckIn.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
<<<<<<< HEAD
            Const.chamCong.CheckOut = DateTime.UtcNow.TimeOfDay;
            txtCheckOut.Text = vietnamTime.ToString("HH:mm:ss");
<<<<<<< HEAD
=======
            Const.chamCong.CheckOut = DateTime.UtcNow.TimeOfDay;    
            rtbCheckOut.Text = vietnamTime.ToString("HH:mm:ss");
>>>>>>> parent of e3d248a (up20)
=======
            checkout = vietnamTime.ToString("HH:mm:ss");
>>>>>>> parent of 2a3fcce (up21)
            _mongoDataAccess.InsertChamCong();
        }
        private DateTime ConvertToVietnamTime(DateTime utcDateTime)
        {
            var vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, vietnamTimeZone);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
