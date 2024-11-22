using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class ThemBangChamCongCT : Form
    {
        public ThemBangChamCongCT()
        {
            InitializeComponent();
            clbViTriCongViec.Visible = false;
            lbViTriCongViec.MouseClick += LbViTriCongViec_MouseClick;
            clbViTriCongViec.MouseLeave += ClbViTriCongViec_MouseLeave;
        }

        private void ClbViTriCongViec_MouseLeave(object sender, EventArgs e)
        {
            clbViTriCongViec.Visible=false;
        }

        private void LbViTriCongViec_MouseClick(object sender, MouseEventArgs e)
        {
            clbViTriCongViec.Visible = true;
        }

        private void clbViTriCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbViTriCongViec.SelectedItem != null)
            {
                var selectedItem = clbViTriCongViec.SelectedItem;
                if (!lbViTriCongViec.Items.Contains(selectedItem) )
                {
                    lbViTriCongViec.Items.Add(selectedItem.ToString());
                }
            }
        }

    }
}
