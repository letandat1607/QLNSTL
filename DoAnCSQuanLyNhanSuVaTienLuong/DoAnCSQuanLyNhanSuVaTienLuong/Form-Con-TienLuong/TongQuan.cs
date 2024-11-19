using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong
{
    public partial class TongQuan : Form
    {
        public TongQuan()
        {
            InitializeComponent();
        }
        private void Quayve_Click (object sender, EventArgs e)
        {
            TienLuong tienLuong = new TienLuong();
            this.Hide();
            tienLuong.Show();
        }
        private void tìnhHìnhThToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
