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
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong;


namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    public partial class HeThongQuanLy : Form
    {
        public HeThongQuanLy()
        {
            InitializeComponent();
            //btnChamCong.Enabled = false;
            btnTienLuong.Enabled = false;
            btnTuyenDung.Enabled = false;
            //btnBHXH.Enabled = false;
            //btnDanhGia.Enabled = false;
            //btnMucTieu.Enabled = false;
            //btnThongTinNhanSu.Enabled = false;
            //btnThueTNCN.Enabled = false;
            loadFormHeThongQuanLy();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThucHienChamCong thucHienChamCong = new ThucHienChamCong();
            thucHienChamCong.ShowDialog();
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
            if(Const.taiKhoanActive.LoaiTaiKhoan == "quanlyns" || Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                this.Hide();
                ThongTinNhanSuHoso thongTinNhanSuHoSo = new ThongTinNhanSuHoso();
                thongTinNhanSuHoSo.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Hosocanhan hosocanhan = new Hosocanhan(Const.taiKhoanActive.MaNhanVien);
                hosocanhan.ShowDialog();
                this.Close();
            }
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
                    //btnChamCong.Enabled = true;
                    btnTienLuong.Enabled = true;
                    //btnBHXH.Enabled = true;
                    //btnDanhGia.Enabled = true;
                    //btnMucTieu.Enabled = true;
                    btnThongTinNhanSu.Enabled = true;
                    //btnThueTNCN.Enabled = true;
            }
            else if (Const.taiKhoanActive.LoaiTaiKhoan == "hr")
            {
                //btnChamCong.Enabled = true;
                btnTienLuong.Enabled = true;
                //btnBHXH.Enabled = true;
                //btnThueTNCN.Enabled = true;
                btnTuyenDung.Enabled = true;
            }
            else
            {
                //btnChamCong.Enabled = true;
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
