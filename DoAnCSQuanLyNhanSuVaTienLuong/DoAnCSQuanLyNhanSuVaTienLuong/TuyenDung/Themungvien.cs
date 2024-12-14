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
    public partial class Themungvien : Form
    {
        public Themungvien()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TuyenDungUngvien formUngvien = new TuyenDungUngvien();
            this.Hide();
            formUngvien.ShowDialog();
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Ungvien themuv = new Ungvien();
                MongoDataAccess taomauv = new MongoDataAccess();

                themuv.MaUngVien = taomauv.TaoMaUngVienMoi();
                themuv.Ten = txtTen.Text;
                themuv.NgaySinh = ngaysinhuv.Value;
                if (chkNam.Checked || chkNu.Checked)
                {
                    themuv.GioiTinh = chkNam.Checked ? "Nam" : "Nữ";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                themuv.SDT = txtSdt.Text;
                themuv.Email = txtEmail.Text;
                themuv.NgayUngTuyen = ngaytrungtuyen.Value;
                themuv.ChucVu = cmbchucvu.SelectedItem?.ToString();
                themuv.TrinhDo = txtTrinhdo.Text;
                themuv.ChuyenNganh = txtChuyennganh.Text;
                themuv.ViTriCongViec = txtVitricongviec.Text;
                themuv.NoiLamViec = txtNoilamviec.Text;
                themuv.MoTa = txtMota.Text;
                if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSdt.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtTrinhdo.Text) || string.IsNullOrWhiteSpace(txtChuyennganh.Text) || string.IsNullOrWhiteSpace(txtVitricongviec.Text) || string.IsNullOrWhiteSpace(txtNoilamviec.Text) || string.IsNullOrWhiteSpace(txtMota.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Lưu ứng viên vào cơ sở dữ liệu
                var ungVienDoc = new BsonDocument
                {
                    { "ma_ung_vien", themuv.MaUngVien },
                    { "ten", themuv.Ten },
                    { "ngay_sinh", themuv.NgaySinh },
                    { "gioi_tinh", themuv.GioiTinh },
                    { "sdt", themuv.SDT },
                    { "email", themuv.Email },
                    { "ngay_ung_tuyen", themuv.NgayUngTuyen },
                    { "chuc_vu", themuv.ChucVu },
                    { "trinh_do", themuv.TrinhDo },
                    { "chuyen_nganh", themuv.ChuyenNganh },
                    { "vi_tri_cong_viec", themuv.ViTriCongViec },
                    { "noi_lam_viec", themuv.NoiLamViec },
                    { "mo_ta", themuv.MoTa }
                };

                taomauv.InsertUngVien(ungVienDoc);
                MessageBox.Show("Thêm ứng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
