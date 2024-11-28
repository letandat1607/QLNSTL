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
    public partial class HeThongQuanLy : Form
    {
        public HeThongQuanLy()
        {
            InitializeComponent();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ChamCong chamCong = new ChamCong();
            chamCong.ShowDialog();
        }
        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            this.Hide();
            TienLuong tienLuong = new TienLuong();
            tienLuong.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
