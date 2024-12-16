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
    public partial class TuyenDungUngvien : Form
    {
        public string chonmaungvien { get; set; }
        private MongoDataAccess mongoDataAccess;
        public TuyenDungUngvien()
        {
            InitializeComponent();
            mongoDataAccess = new MongoDataAccess();
            BindDataToDataGridView();

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

        private void btnThemungvien_Click(object sender, EventArgs e)
        {
            Themungvien formThemungvien = new Themungvien();
            this.Hide();
            formThemungvien.ShowDialog();
            this.Close();
        }
        public void BindDataToDataGridView()
        {
            var UngvienList = mongoDataAccess.GetAllUngVien();
            dtgvUngvien.Columns.Clear();

            dtgvUngvien.Columns.Add("maungvien", "Mã ứng viên");
            dtgvUngvien.Columns.Add("ten", "Họ và tên");
            dtgvUngvien.Columns.Add("sdt", "Số điện thoại");
            dtgvUngvien.Columns.Add("email", "Email");
            dtgvUngvien.Columns.Add("chucvu", "Chức vụ");
            dtgvUngvien.Columns.Add("ngaytuyendung", "Ngày tuyển dụng");
            dtgvUngvien.Columns.Add("mota", "Mô tả");

            dtgvUngvien.Columns["email"].Width = 150;
            dtgvUngvien.Columns["ten"].Width = 150;
            foreach (var ungvien in UngvienList)
            {
                dtgvUngvien.Rows.Add(
                    ungvien.MaUngVien,
                    ungvien.Ten,
                    ungvien.SDT,
                    ungvien.Email,
                    ungvien.ChucVu,
                    ungvien.NgayUngTuyen.ToString("yyyy-MM-dd"),
                    ungvien.MoTa
                );
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(chonmaungvien))
            {
                MessageBox.Show("Vui lòng chọn một ứng viên để xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Thongtincanhan thongtin = new Thongtincanhan(chonmaungvien);
            thongtin.Show();
        }

        private void dtgvUngvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chonmaungvien = dtgvUngvien.Rows[e.RowIndex].Cells["maungvien"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chonmaungvien))
            {
                MessageBox.Show("Vui lòng chọn một ứng viên để xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Suaungvien thongtin = new Suaungvien(chonmaungvien);
            this.Hide();
            thongtin.ShowDialog();
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
                mongoDataAccess.Xoa(chonmaungvien);
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TuyenDungUngvien formUngvien = new TuyenDungUngvien();
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
