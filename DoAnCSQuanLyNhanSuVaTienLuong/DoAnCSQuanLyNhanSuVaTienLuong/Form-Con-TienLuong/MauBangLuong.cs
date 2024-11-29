using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ChiTraLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_DuLieuTienLuong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong
{
    public partial class MauBangLuong : Form
    {
        public MauBangLuong()
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

        private void BangLuongThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoThang bangLuongTheoThang = new BangLuongTheoThang();
            this.Hide();
            bangLuongTheoThang.Show();
        }

        private void BangLuongNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BangLuongTheoNam bangLuongTheoNam = new BangLuongTheoNam();
            this.Hide();
            bangLuongTheoNam.Show();
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

        private void tấtCảỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
            this.Hide();
            heThongQuanLy.Show();
        }
    }
}
