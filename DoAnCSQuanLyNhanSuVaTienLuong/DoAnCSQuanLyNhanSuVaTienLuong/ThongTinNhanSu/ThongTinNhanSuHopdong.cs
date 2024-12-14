using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using MongoDB.Bson;
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
    public partial class ThongTinNhanSuHopdong : Form
    {
        MongoDataAccess mongo;
        string chonHD;
        public ThongTinNhanSuHopdong()
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            Load();
        }
        public void Load()
        {
            var dsHD = mongo.GetTatCaHopDong();
            dtgvHD.Columns.Clear();

            dtgvHD.Columns.Add("mahopdong", "Mã hợp đồng");
            dtgvHD.Columns.Add("tenhopdong", "Tên hợp đồng");
            dtgvHD.Columns.Add("manhanvien", "Mã nhân viên");
            dtgvHD.Columns.Add("hoten", "Họ và tên");
            dtgvHD.Columns.Add("ngaybatdau", "Thời gian bắt đầu hiệu lực");
            dtgvHD.Columns.Add("ngayketthuc", "Thời gian kết thúc hiệu lực");
            dtgvHD.Columns.Add("tinhtrang", "Tình trạng");

            dtgvHD.Columns["tenhopdong"].Width = 180;
            dtgvHD.Columns["hoten"].Width = 150;
            //dtgtuyendung.Columns["vitrituyendung"].Width = 150;
            //dtgtuyendung.Columns["nganhnghe"].Width = 110;
            //dtgtuyendung.Columns["thoigianbatdau"].Width = 150;
            //dtgtuyendung.Columns["thoigianketthuc"].Width = 150;
            //dtgtuyendung.Columns["lienhe"].Width = 150;

            foreach (var hd in dsHD)
            {
                var dsnv = mongo.GetTatCaNhanVien();

                foreach (var nv in dsnv)
                {
                    if (hd.MaHopDong == nv.MaHopDong)
                    {
                        dtgvHD.Rows.Add(
                        hd.MaHopDong,
                        hd.TenHopDong,
                        nv.MaNhanVien,
                        hd.HoTen,
                        hd.NgayBatDauHieuLuc.ToString("yyy//MM/dd"),
                        hd.NgayHetHieuLuc.ToString("yyy//MM/dd"),
                        hd.TinhTrang
                        );
                    }
                }

            }

            var dsHetHan = mongo.FindHetHanHopDong();
            dtgvHethan.Columns.Clear();

            dtgvHethan.Columns.Add("ngayketthuc", "Thời gian kết thúc hiệu lực");
            dtgvHethan.Columns.Add("mahopdong", "Mã hợp đồng");
            dtgvHethan.Columns.Add("tenhopdong", "Tên hợp đồng");
            dtgvHethan.Columns.Add("manhanvien", "Mã nhân viên");
            dtgvHethan.Columns.Add("hoten", "Họ và tên");
            dtgvHethan.Columns.Add("chucvu", "Chức vụ");
            dtgvHethan.Columns.Add("tinhtrang", "Tình trạng");

            foreach (var hd in dsHetHan)
            {
                var ma = mongo.GetTatCaNhanVien();

                foreach (var nv in ma)
                {
                    if (nv.MaHopDong == hd.MaHopDong)
                    {
                        dtgvHethan.Rows.Add(

                        hd.NgayHetHieuLuc.ToString("yyy//MM/dd"),
                        hd.MaHopDong,
                        hd.TenHopDong,
                        nv.MaNhanVien,
                        hd.HoTen,
                        hd.ChucVu,
                        hd.TinhTrang
                    );
                    }
                }

            }


            long hethan = mongo.DemtinhtrangHethan();
            long danglam = mongo.DemtinhtrangDanglam();
            //charttinhtrang.Series["Tình trạng"].Points.Clear();
            //charttinhtrang.Series["Tình trạng"].Points.AddXY("Còn hạn", danglam);
            //charttinhtrang.Series["Tình trạng"].Points.AddXY("Hết hạn", hethan);
            //charttinhtrang.Series["Tình trạng"].Points[0].Color = Color.FromArgb(128, 128, 255);
            //charttinhtrang.Series["Tình trạng"].Points[1].Color = Color.FromArgb(255, 255, 128);
            //charttinhtrang.Series["Tình trạng"].Points[0].Label = "Còn hạn";
            //charttinhtrang.Series["Tình trạng"].Points[1].Label = "Hết hạn";

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
            ThongTinNhanSuPhucloi formPhucloi = new ThongTinNhanSuPhucloi();
            this.Hide();
            formPhucloi.ShowDialog();
            this.Close();
        }

        private void btnThemmoithongtintuyendung_Click(object sender, EventArgs e)
        {
            Themhopdong formthemhopdong = new Themhopdong();
            this.Hide();
            formthemhopdong.ShowDialog();
            this.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (chonHD != null)
            {
                Suahopdong f = new Suahopdong(chonHD);
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui long chon hop dong");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            mongo.Delete(chonHD);
            //mongo.FindOneNhanVien(chonHD);
            //var nhanVien = mongo.FindOneNhanVien(chonHD);
            //mongo.Delete(nhanVien.MaNhanVien);

            ThongTinNhanSuHopdong f = new ThongTinNhanSuHopdong();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void dtgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chonHD = dtgvHD.Rows[e.RowIndex].Cells["mahopdong"].Value.ToString();
            }
        }

        private void btnChamdut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn chấm dứt hợp đồng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    string ketThuc = "Kết thúc";
                    var updateData = new BsonDocument
                    {
                        { "tinh_trang", ketThuc }
                    };
                    mongo.UpdateOne(chonHD, updateData);
                    MessageBox.Show
                    (
                        "Hợp đồng đã được chấm dứt thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    ThongTinNhanSuHopdong thongTinForm = new ThongTinNhanSuHopdong();
                    this.Hide();
                    thongTinForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Hợp đồng chưa được chấm dứt.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Có lỗi xảy ra khi chấm dứt hợp đồng: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
