using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong;
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
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void mitBangChamCongCT_Click(object sender, EventArgs e)
        {
            BangChamCongCT bangChamCongCT = new BangChamCongCT();
            bangChamCongCT.ShowDialog();
        }
    }
}
