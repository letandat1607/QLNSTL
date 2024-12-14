using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
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
    partial class TuyenDungTintuyendung : Form
    {
        MongoDataAccess mongo;
        string chontuyendung { get; set; }
        public TuyenDungTintuyendung()
        {
            InitializeComponent();
            mongo = new MongoDataAccess();
            Loadform();
        }



        private void btnTintuyendung_Click(object sender, EventArgs e)
        {
            TuyenDungTintuyendung formTuyendung = new TuyenDungTintuyendung();
            this.Hide();
            formTuyendung.ShowDialog();
            this.Close();

        }

        private void btnUngvien_Click(object sender, EventArgs e)
        {
            TuyenDungUngvien formUngvien = new TuyenDungUngvien();
            this.Hide();
            formUngvien.ShowDialog();
            this.Close();
        }
        public void Loadform()
        {
            var Tuyendunglist = mongo.GetallTuyendung();
            dtgtuyendung.Columns.Clear();

            dtgtuyendung.Columns.Add("tieude", "Tiêu đề");
            dtgtuyendung.Columns.Add("vitrituyendung", "Vị trí ứng tuyển");
            dtgtuyendung.Columns.Add("nganhnghe", "Ngành nghề");
            dtgtuyendung.Columns.Add("thoigianbatdau", "Thời gian bắt đầu");
            dtgtuyendung.Columns.Add("thoigianketthuc", "Thời gian kết thúc");
            dtgtuyendung.Columns.Add("lienhe", "Liên hệ");

            dtgtuyendung.Columns["tieude"].Width = 150;
            dtgtuyendung.Columns["vitrituyendung"].Width = 150;
            dtgtuyendung.Columns["nganhnghe"].Width = 110;
            dtgtuyendung.Columns["thoigianbatdau"].Width = 150;
            dtgtuyendung.Columns["thoigianketthuc"].Width = 150;
            dtgtuyendung.Columns["lienhe"].Width = 150;

            foreach (var tuyendung in Tuyendunglist)
            {
                dtgtuyendung.Rows.Add(
                    tuyendung.Tieude,
                    tuyendung.Vitriungtuyen,
                    tuyendung.Nganhnghe,
                    tuyendung.Thoigianbatdau,
                    tuyendung.Thoigianketthuc.ToString("yyy//MM/dd"),
                    tuyendung.Lienhe
                    );
            }


        }

        private void btnThemmoithongtintuyendung_Click(object sender, EventArgs e)
        {
            Themtuyendung themtuyendung = new Themtuyendung();
            this.Hide();
            themtuyendung.ShowDialog();
            this.Close();
        }

        private void dtgtuyendung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chontuyendung = dtgtuyendung.Rows[e.RowIndex].Cells["tieude"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Suatuyendung suatuyendung = new Suatuyendung(chontuyendung);
            this.Hide();
            suatuyendung.ShowDialog();
            this.Close();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc muốn xóa?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                mongo.Xoa(chontuyendung);
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TuyenDungTintuyendung formUngvien = new TuyenDungTintuyendung();
                this.Hide();
                formUngvien.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Hủy bỏ thao tác xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
