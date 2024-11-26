using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong.Form_Con_BangLuongTheoNam;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong.Form_Con_BangLuongTheoThang;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ChiTraLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_DuLieuTienLuong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong
{
    public partial class BangLuongTheoNam : Form
    {
        public BangLuongTheoNam()
        {
            InitializeComponent();
        }

        private void tổngQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienLuong tienLuong = new TienLuong();
            this.Hide();
            tienLuong.Show();
        }

        private void thànhPhầnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPhanLuong thanhPhanLuong = new ThanhPhanLuong();
            this.Hide();
            thanhPhanLuong.Show();
        }

        private void mấuBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauBangLuong mauBangLuong = new MauBangLuong();
            this.Hide();
            mauBangLuong.Show();
        }

        private void BangLuongThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoThang bangLuongTheoThang = new BangLuongTheoThang();
            this.Hide();
            bangLuongTheoThang.Show();
        }

        private void bảngChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangChiTra bangChiTra = new BangChiTra();
            this.Hide();
            bangChiTra.Show();
        }

        private void tổngHợpChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopChiTra tongHopChiTra = new TongHopChiTra();
            this.Hide();
            tongHopChiTra.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu không phải tiêu đề cột hoặc tiêu đề hàng
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Kiểm tra ô được nhấn có dữ liệu hay không
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                {
                    MessageBox.Show("Không có dữ liệu, không thể mở chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form nếu ô có dữ liệu
                BangLuongTheoNamChiTiet bangLuongTheoNamChiTiet = new BangLuongTheoNamChiTiet();
                this.Hide();
                bangLuongTheoNamChiTiet.Show();
            }
        }
    }
}

