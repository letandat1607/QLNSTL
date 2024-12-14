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
    public partial class Suatuyendung : Form
    {
        MongoDataAccess mongo;
        string tieude;
        public Suatuyendung(string chontuyendung)
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            tieude = chontuyendung;
            Loadthongtin();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TuyenDungTintuyendung formTuyendung = new TuyenDungTintuyendung();
            this.Hide();
            formTuyendung.ShowDialog();
            this.Close();
        }

        public void Loadthongtin()
        {
            var tuyendung = mongo.FindOneTuyenDung(tieude);
            if (tuyendung != null)
            {

                txtTieude.Text = tuyendung.Tieude;
                txtVitrituyendung.Text = tuyendung.Vitriungtuyen;
                txtNganhnghe.Text = tuyendung.Nganhnghe;
                if (tuyendung.Thoigianbatdau != null)
                {
                    Thoigianbatdau.Value = tuyendung.Thoigianbatdau.ToLocalTime();
                }
                if (tuyendung.Thoigianketthuc != null)
                {
                    Thoigianketthuc.Value = tuyendung.Thoigianketthuc.ToLocalTime();
                }
                txtLienhe.Text = tuyendung.Lienhe;
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
                Tuyendung suatin = new Tuyendung();
                suatin.Tieude = txtTieude.Text;
                suatin.Vitriungtuyen = txtVitrituyendung.Text;
                suatin.Nganhnghe = txtNganhnghe.Text;
                suatin.Thoigianbatdau = Thoigianbatdau.Value;
                suatin.Thoigianketthuc = Thoigianketthuc.Value;
                suatin.Lienhe = txtLienhe.Text;
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

                var tuyendungdoc = new BsonDocument
                    {
                        {"tieu_de",suatin.Tieude},
                        {"vi_tri_ung_tuyen",suatin.Vitriungtuyen},
                        {"nganh_nghe",suatin.Nganhnghe},
                        {"thoi_gian_bat_dau",suatin.Thoigianbatdau},
                        {"thoi_gian_ket_thuc",suatin.Thoigianketthuc},
                        {"lien_he",suatin.Lienhe}
                    };
                mongo.UpdateOne(tieude, tuyendungdoc);
                MessageBox.Show("Sua thanh cong");


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
