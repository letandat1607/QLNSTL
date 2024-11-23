using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong;
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
       



        private void btnTongquan_Click(object sender, EventArgs e)
        {
            TongQuan Tongquan = new TongQuan();
            this.Hide();
            Tongquan.Show();
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
            this.Hide();
            mauBangLuong.Show();
        }
        private void btnDuLieuTinhLuong_Click(object sender, EventArgs e)
        {
            DuLieuTienLuong dulieutienluong = new DuLieuTienLuong();
            this.Hide();
            dulieutienluong.Show();
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
    }
}
