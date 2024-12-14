using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
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

namespace DoAnCSQuanLyNhanSuVaTienLuong.TuyenDung
{
    public partial class Suaungvien : Form
    {
        private MongoDataAccess mongo;
        private string mauv;
        public Suaungvien(string chonungvien)
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            mauv = chonungvien;
            LoadThongtin();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TuyenDungUngvien fr = new TuyenDungUngvien();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
        public void LoadThongtin()
        {
            var ungVien = mongo.FindOneUngVien(mauv);
            if (ungVien != null)
            {
                txtTen.Text = ungVien.Ten;
                txtTrinhdo.Text = ungVien.TrinhDo;
                txtChuyennganh.Text = ungVien.ChuyenNganh;
                txtVitricongviec.Text = ungVien.ViTriCongViec;
                txtNoilamviec.Text = ungVien.NoiLamViec;
                txtMota.Text = ungVien.MoTa;
                txtChucvu.Text = ungVien.ChucVu;
                if (ungVien.NgaySinh != null)
                {
                    ngaysinh.Value = ungVien.NgaySinh.ToLocalTime();  // dtpNgaySinh là tên của DateTimePicker
                }
                if (ungVien.GioiTinh == "Nam")
                {
                    chkNam.Checked = true;
                }
                else if (ungVien.GioiTinh == "Nữ")
                {
                    chkNu.Checked = true;
                }
                txtSdt.Text = ungVien.SDT;
                txtEmail.Text = ungVien.Email;
                if (ungVien.NgayUngTuyen != null)
                {
                    ngayungtuyen.Value = ungVien.NgayUngTuyen.ToLocalTime();
                }

            }
            else
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Ungvien suauv = new Ungvien();
                suauv.Ten = txtTen.Text;
                suauv.NgaySinh = ngaysinh.Value;
                if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSdt.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTrinhdo.Text) || string.IsNullOrWhiteSpace(txtChuyennganh.Text) || string.IsNullOrWhiteSpace(txtVitricongviec.Text) || string.IsNullOrWhiteSpace(txtNoilamviec.Text) || string.IsNullOrWhiteSpace(txtMota.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (chkNam.Checked || chkNu.Checked)
                {
                    suauv.GioiTinh = chkNam.Checked ? "Nam" : "Nữ";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                suauv.SDT = txtSdt.Text;
                suauv.Email = txtEmail.Text;
                suauv.NgayUngTuyen = ngayungtuyen.Value;
                suauv.ChucVu = txtChucvu.Text;
                suauv.TrinhDo = txtTrinhdo.Text;
                suauv.ChuyenNganh = txtChuyennganh.Text;
                suauv.ViTriCongViec = txtVitricongviec.Text;
                suauv.NoiLamViec = txtNoilamviec.Text;
                suauv.MoTa = txtMota.Text;

                var ungvien = mongo.FindOneUngVien(mauv);
                var ungviendoc = new BsonDocument()
                {
                    { "ma_ung_vien", mauv },
                    { "ten", suauv.Ten },
                    { "ngay_sinh", suauv.NgaySinh },
                    { "gioi_tinh", suauv.GioiTinh },
                    { "sdt", suauv.SDT },
                    { "email", suauv.Email },
                    { "ngay_ung_tuyen", suauv.NgayUngTuyen },
                    { "chuc_vu", suauv.ChucVu },
                    { "trinh_do", suauv.TrinhDo },
                    { "chuyen_nganh", suauv.ChuyenNganh },
                    { "vi_tri_cong_viec", suauv.ViTriCongViec },
                    { "noi_lam_viec", suauv.NoiLamViec },
                    { "mo_ta", suauv.MoTa }
                };
                mongo.UpdateUngVien(mauv, ungviendoc);
                MessageBox.Show("Sửa ứng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TuyenDungUngvien formUngvien = new TuyenDungUngvien();
                this.Hide();
                formUngvien.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
