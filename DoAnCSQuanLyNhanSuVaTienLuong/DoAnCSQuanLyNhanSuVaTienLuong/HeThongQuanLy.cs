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
using DoAnCSQuanLyNhanSuVaTienLuong.TuyenDung;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu;


namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    public partial class HeThongQuanLy : Form
    {
        public HeThongQuanLy()
        {
            InitializeComponent();
            btnChamCong.Enabled = false;
            btnTienLuong.Enabled = false;
            btnTuyenDung.Enabled = false;
<<<<<<< HEAD
            //btnBHXH.Enabled = false;
            //btnDanhGia.Enabled = false;
            //btnMucTieu.Enabled = false;
            //btnThongTinNhanSu.Enabled = false;
            //btnThueTNCN.Enabled = false;
=======
            btnBHXH.Enabled = false;
            btnDanhGia.Enabled = false;
            btnMucTieu.Enabled = false;
            btnThongTinNhanSu.Enabled = false;
            btnThueTNCN.Enabled = false;
>>>>>>> parent of e3d248a (up20)
            loadFormHeThongQuanLy();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChamCong chamCong = new ChamCong();
            chamCong.ShowDialog();
            this.Close();
        }
        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            TienLuong tienLuong = new TienLuong();
            tienLuong.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinNhanSuHoso thongTinNhanSuHoSo = new ThongTinNhanSuHoso();
            thongTinNhanSuHoSo.ShowDialog();
            this.Close();
        }
        public void loadFormHeThongQuanLy()
        {
            if (Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                btnChamCong.Enabled = true;
                btnTienLuong.Enabled = true;
                btnTuyenDung.Enabled = true;
                //btnBHXH.Enabled = true;
                //btnDanhGia.Enabled = true;
                //btnMucTieu.Enabled = true;
                btnThongTinNhanSu.Enabled = true;
                //btnThueTNCN.Enabled = true;
            }
            else if (Const.taiKhoanActive.LoaiTaiKhoan == "quanlyns")
            {
                    btnChamCong.Enabled = true;
                    btnTienLuong.Enabled = true;
                    //btnBHXH.Enabled = true;
                    //btnDanhGia.Enabled = true;
                    //btnMucTieu.Enabled = true;
                    btnThongTinNhanSu.Enabled = true;
                    //btnThueTNCN.Enabled = true;
            }
            else if (Const.taiKhoanActive.LoaiTaiKhoan == "hr")
            {
                btnChamCong.Enabled = true;
                btnTienLuong.Enabled = true;
                //btnBHXH.Enabled = true;
                //btnThueTNCN.Enabled = true;
                btnTuyenDung.Enabled = true;
            }
            else
            {
                btnChamCong.Enabled = true;
                btnTienLuong.Enabled = true;
                //btnBHXH.Enabled = true;
                //btnThueTNCN.Enabled = true;
            }
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            TuyenDungTintuyendung tuyenDungTintuyendung = new TuyenDungTintuyendung();
            tuyenDungTintuyendung.ShowDialog();

        }
    }
}
