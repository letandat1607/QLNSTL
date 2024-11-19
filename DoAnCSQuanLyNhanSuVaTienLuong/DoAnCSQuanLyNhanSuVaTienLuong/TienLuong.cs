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
            ThanhPhanLuong thanhphanluong = new ThanhPhanLuong();
            this.Hide();
            thanhphanluong.Show();
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
    }
}
