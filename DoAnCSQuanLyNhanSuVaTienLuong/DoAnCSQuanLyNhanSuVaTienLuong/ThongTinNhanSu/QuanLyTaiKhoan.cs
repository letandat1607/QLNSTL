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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnHoso_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHoso formHoso = new ThongTinNhanSuHoso();
            this.Hide();
            formHoso.ShowDialog();
            this.Close();
        }
        private void btnHopdong_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuHopdong formHopdong = new ThongTinNhanSuHopdong();
            this.Hide();
            formHopdong.ShowDialog();
            this.Close();
        }

        private void btnNghiviec_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuNghiviec formNghiviec = new ThongTinNhanSuNghiviec();
            this.Hide();
            formNghiviec.ShowDialog();
            this.Close();
        }

        private void btnKhenthuong_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuKhenthuong formKhenthuong = new ThongTinNhanSuKhenthuong();
            this.Hide();
            formKhenthuong.ShowDialog();
            this.Close();
        }

        private void btnSuco_Click(object sender, EventArgs e)
        {
            ThongTinNhanSuSuco formSuco = new ThongTinNhanSuSuco();
            this.Hide();
            formSuco.ShowDialog();
            this.Close();
        }

        private void btnPhucloi_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan formPhucloi = new QuanLyTaiKhoan();
            this.Hide();
            formPhucloi.ShowDialog();
            this.Close();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Themphucloi themphucloi = new Themphucloi();
            themphucloi.ShowDialog();
        }

        private void picBMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
            heThongQuanLy.ShowDialog();
            this.Close();
        }
    }
}
