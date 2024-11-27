using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ChiTraLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_DuLieuTienLuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    public partial class TienLuong : Form
    {
        public TienLuong()
        {
            InitializeComponent();
        }

        private void btnThanhPhanLuong_Click(object sender, EventArgs e)
        {
            ThanhPhanLuong thanhPhanLuong = new ThanhPhanLuong();
            //this.Hide();
            thanhPhanLuong.Show();
        }
        private void btnMauBangLuong_Click(object sender, EventArgs e)
        {
            MauBangLuong mauBangLuong = new MauBangLuong();
            //this.Hide();
            mauBangLuong.Show();
        }
        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            //BangLuong BangLuong = new BangLuong();
            //this.Hide();
            //BangLuong.Show();
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            TinhLuong tinhLuong = new TinhLuong();
            this.Hide();
            tinhLuong.Show();
        }


        private void tìnhHìnhThToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập thông tin tìm kiếm...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Nhập thông tin tìm kiếm...";
                textBox1.ForeColor = Color.Gray;
            }
        }

        

        private void BangLuongThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoThang bangLuongTheoThang = new BangLuongTheoThang();
            //this.Hide();
            bangLuongTheoThang.Show();
        }

        private void bảngLươngTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoNam bangLuongTheoNam = new BangLuongTheoNam();
            //this.Hide();
            bangLuongTheoNam.Show();
        }

        private void bảngChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangChiTra bangChiTra = new BangChiTra();
            //this.Hide();
            bangChiTra.Show();
        }

        private void tổngHợpChiTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TongHopChiTra tongHopChiTra = new TongHopChiTra();
            //this.Hide();
            tongHopChiTra.Show();
        }
    }
}
