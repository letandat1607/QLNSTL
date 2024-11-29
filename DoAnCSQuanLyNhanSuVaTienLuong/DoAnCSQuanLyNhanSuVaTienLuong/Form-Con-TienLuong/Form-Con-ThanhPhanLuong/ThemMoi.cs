using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ThanhPhanLuong
{
    public partial class ThemMoi : Form
    {
        public ThemMoi()
        {
            InitializeComponent();
        }

        private void tấtCảỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeThongQuanLy heThongQuanLy = new HeThongQuanLy();
            this.Hide();
            heThongQuanLy.Show();
        }

        private void tổngQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TienLuong tienLuong = new TienLuong();
            this.Hide();
            tienLuong.Show();
        }

        private void mấuBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauBangLuong mauBangLuong = new MauBangLuong();
            this.Hide();
            mauBangLuong.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThanhPhanLuong thanhPhanLuong = new ThanhPhanLuong();
            this.Hide();
            thanhPhanLuong.Show();
        }
    }
}
