using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
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
    public partial class Themtuyendung : Form
    {
        MongoDataAccess mongo;

        public Themtuyendung()
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TuyenDungTintuyendung formTuyendung = new TuyenDungTintuyendung();
            this.Hide();
            formTuyendung.ShowDialog();
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Tuyendung td = new Tuyendung();
                td.Tieude = txtTieude.Text;
                td.Vitriungtuyen = txtVitrituyendung.Text;
                td.Nganhnghe = txtNganhnghe.Text;
                td.Thoigianbatdau = Thoigianbatdau.Value;
                td.Thoigianketthuc = Thoigianketthuc.Value;
                td.Lienhe = txtLienhe.Text;
                if (string.IsNullOrWhiteSpace(txtTieude.Text) || string.IsNullOrWhiteSpace(txtVitrituyendung.Text) || string.IsNullOrWhiteSpace(txtNganhnghe.Text) || string.IsNullOrWhiteSpace(txtLienhe.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Thoigianbatdau.Value == DateTime.MinValue || Thoigianketthuc.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thời gian bắt đầu và kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (Thoigianbatdau.Value > Thoigianketthuc.Value)
                {
                    MessageBox.Show("Ngày kết thúc không thể trước ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var tintddoc = new BsonDocument
                {
                { "tieu_de",td.Tieude},
                { "vi_tri_ung_tuyen",td.Vitriungtuyen},
                { "nganh_nghe",td.Nganhnghe},
                { "thoi_gian_bat_dau",td.Thoigianbatdau},
                { "thoi_gian_ket_thuc",td.Thoigianketthuc},
                { "lien_he",td.Lienhe}
                };
                mongo.Inserttuyendung(tintddoc);

                TuyenDungTintuyendung formTuyendung = new TuyenDungTintuyendung();
                this.Hide();
                formTuyendung.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
