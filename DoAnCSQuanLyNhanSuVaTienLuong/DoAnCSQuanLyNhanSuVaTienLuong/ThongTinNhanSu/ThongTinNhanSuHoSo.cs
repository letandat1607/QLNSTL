using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class ThongTinNhanSuHoso : Form
    {
        MongoDataAccess mongo;
        string chonNV;


        public ThongTinNhanSuHoso()
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            btnQuanLyTK.Visible = false;
            if(Const.taiKhoanActive.LoaiTaiKhoan == "admin")
            {
                btnQuanLyTK.Visible = true;
            }
            Load();
        }
        public void Load()
        {
            var dsHD = mongo.GetTatCaHopDong();
            var dsNV = mongo.GetTatCaNhanVien();
            dtgvNV.Columns.Clear();

            dtgvNV.Columns.Add("manhanvien", "Mã nhân viên");
            dtgvNV.Columns.Add("hoten", "Họ và tên");
            dtgvNV.Columns.Add("ngaysinh", "Ngày sinh");
            dtgvNV.Columns.Add("chucvu", "Chức vụ");
            dtgvNV.Columns.Add("ngayungtuyen", "Ngày ứng tuyển");
            dtgvNV.Columns.Add("ngaychinhthuc", "Ngày chính thức");
            dtgvNV.Columns.Add("email", "Email");
            dtgvNV.Columns.Add("sdt", "Sdt");

            //dtgtuyendung.Columns["tieude"].Width = 150;
            //dtgtuyendung.Columns["vitrituyendung"].Width = 150;
            //dtgtuyendung.Columns["nganhnghe"].Width = 110;
            //dtgtuyendung.Columns["thoigianbatdau"].Width = 150;
            //dtgtuyendung.Columns["thoigianketthuc"].Width = 150;
            //dtgtuyendung.Columns["lienhe"].Width = 150;

            foreach (var nv in dsNV)
            {


                dtgvNV.Rows.Add(
                    nv.MaNhanVien,
                    nv.HoTen,
                    nv.NgaySinh.ToString("yyyy-MM-dd"),
                    nv.ChucVu,
                    nv.NgayUngTuyen.ToString("yyyy-MM-dd"),
                    nv.NgayChinhThuc.ToString("yyyy-MM-dd"),
                    nv.Email,
                    nv.SoDienThoai
                );
            }

            //
            //
            //
            long nam = mongo.DemNhanVienNam();
            long nu = mongo.DemNhanVienNu();
            //chartNamnu.Series["Nhân viên"].Points.Clear();

            //chartNamnu.Series["Nhân viên"].Points.AddXY("Nam", nam);
            //chartNamnu.Series["Nhân viên"].Points.AddXY("Nữ", nu);
            //chartNamnu.Series["Nhân viên"].Points[0].Color = Color.FromArgb(192, 255, 192);
            //chartNamnu.Series["Nhân viên"].Points[1].Color = Color.FromArgb(255, 192, 192);
            //chartNamnu.Series["Nhân viên"].Points[0].Label = "Nam";
            //chartNamnu.Series["Nhân viên"].Points[1].Label = "Nữ";

            long nhanvien = mongo.DemNhanVien();
            long hr = mongo.DemHR();
            long quanli = mongo.DemQuanLi();
            //chartchucvu.Series["Chức vụ"].Points.Clear();

            //chartchucvu.Series["Chức vụ"].Points.AddXY("Nhân viên", nhanvien);
            //chartchucvu.Series["Chức vụ"].Points.AddXY("HR", hr);
            //chartchucvu.Series["Chức vụ"].Points.AddXY("Quản lí", quanli);
            //chartchucvu.Series["Chức vụ"].Points[0].Color = Color.FromArgb(128, 128, 255);
            //chartchucvu.Series["Chức vụ"].Points[1].Color = Color.FromArgb(255, 192, 128);
            //chartchucvu.Series["Chức vụ"].Points[2].Color = Color.FromArgb(255, 255, 128);
            //chartchucvu.Series["Chức vụ"].Points[0].Label = "Nhân viên";
            //chartchucvu.Series["Chức vụ"].Points[1].Label = "HR";
            //chartchucvu.Series["Chức vụ"].Points[2].Label = "Quản lí";



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chonNV = dtgvNV.Rows[e.RowIndex].Cells["manhanvien"].Value.ToString();
                Hosocanhan f = new Hosocanhan(chonNV);
                this.Hide();
                f.ShowDialog();
                this.Close();

            }
            if (string.IsNullOrEmpty(chonNV))
            {
                MessageBox.Show("Vui lòng chọn một ứng viên để xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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
    }
}
