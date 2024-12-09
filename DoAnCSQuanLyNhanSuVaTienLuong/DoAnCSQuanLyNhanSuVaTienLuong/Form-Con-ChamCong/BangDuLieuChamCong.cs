using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
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
    public partial class BangDuLieuChamCong : Form
    {
        private readonly DanhSachChamCong _duLieuChamCong;
        public BangDuLieuChamCong(DanhSachChamCong selectedBangChamCongCT)
        {
            InitializeComponent();
            _duLieuChamCong = selectedBangChamCongCT;
            LoadBangDuLieuChamCong();
        }
        private void LoadBangDuLieuChamCong()
        {
            dtgvBangDuLieuChamCong.Columns.Clear();
            dtgvBangDuLieuChamCong.Columns.Add("MaNhanVien", "Mã nhân viên");
            dtgvBangDuLieuChamCong.Columns.Add("TenNhanVien", "Tên nhân viên");

            var startDate = new DateTime(_duLieuChamCong.ThoiGianBatDau.Year, _duLieuChamCong.ThoiGianBatDau.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var columnName = date.ToString("dd/MM");
                dtgvBangDuLieuChamCong.Columns.Add(columnName, columnName);
            }

            dtgvBangDuLieuChamCong.Columns[0].Width = 100;
            dtgvBangDuLieuChamCong.Columns[1].Width = 150; 
            foreach (DataGridViewColumn column in dtgvBangDuLieuChamCong.Columns.Cast<DataGridViewColumn>().Skip(2))
            {
                column.Width = 140;
            }

            var groupData = _duLieuChamCong.DSChamCong.GroupBy(x => new
            {
                x.MaNhanVien,
                x.HoTen
            }).ToList();
            foreach (var group in groupData)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dtgvBangDuLieuChamCong);
                row.Cells[0].Value = group.Key.MaNhanVien;
                row.Cells[1].Value = group.Key.HoTen;

                foreach (var chamCong in group)
                {
                    var cot = GetColumnIndexByDate(chamCong.NgayChamCong);
                    if (cot != -1)
                    {
                        row.Cells[cot].Value = $"{chamCong.CheckIn:hh\\:mm} - {chamCong.CheckOut:hh\\:mm}";
                    }
                }
                for (int i = 2; i < dtgvBangDuLieuChamCong.Columns.Count; i++)
                {
                    var columnDate = GetThuByColumnIndex(i);
                    if (columnDate.DayOfWeek == DayOfWeek.Saturday || columnDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        row.Cells[i].Value = "Không làm việc";
                    }
                    else if (row.Cells[i].Value == null)
                    {
                        row.Cells[i].Value = "Off";
                    }
                }
                dtgvBangDuLieuChamCong.Rows.Add(row);
            }
        }

        private int GetColumnIndexByDate(DateTime date)
        {
            var columnName = date.ToString("dd/MM");
            foreach (DataGridViewColumn column in dtgvBangDuLieuChamCong.Columns)
            {
                if (column.HeaderText == columnName)
                {
                    return column.Index;
                }
            }
            return -1;
        }
        private DateTime GetThuByColumnIndex(int columnIndex)
        {
            var columnName = dtgvBangDuLieuChamCong.Columns[columnIndex].HeaderText;
            return DateTime.ParseExact(columnName, "dd/MM", null);
        }
    }
}
