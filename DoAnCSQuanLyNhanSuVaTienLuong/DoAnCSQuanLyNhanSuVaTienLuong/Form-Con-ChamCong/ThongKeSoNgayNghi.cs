using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class ThongKeSoNgayNghi : Form
    {
        private MongoDataAccess _mongoDataAccess;
        private List<NgayNghi> _ngayNghiList;
        public ThongKeSoNgayNghi()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            LoadData();
        }

        private void LoadData()
        {
            _ngayNghiList = _mongoDataAccess.GetTatCaNgayNghi();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaNhanVien", "MaNV");
            dataGridView1.Columns.Add("HoTen", "Họ Tên");
            dataGridView1.Columns.Add("SoNgayNghi" ,"Số ngày nghỉ");
            dataGridView1.Columns.Add("SoNgayPhep", "Số ngày có phép");
            dataGridView1.Columns.Add("SoNgayKhongPhep", "số ngày không phép");
            dataGridView1.Columns.Add("Thang", "Tháng");

            foreach (var ngayNghi in _ngayNghiList)
            {
                dataGridView1.Rows.Add(
                    ngayNghi.MaNhanVien,
                    ngayNghi.HoTen,
                    ngayNghi.SoNgayNghi,
                    ngayNghi.SoNgayNghiPhep,
                    ngayNghi.SoNgayKhongPhep,
                    ngayNghi.Thang
                    
                );
            }
        }
    }
}
