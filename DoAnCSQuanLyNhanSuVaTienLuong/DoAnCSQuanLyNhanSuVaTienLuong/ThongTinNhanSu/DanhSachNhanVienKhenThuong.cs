using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong.ThongTinNhanSu
{
    public partial class DanhSachNhanVienKhenThuong : Form
    {
        private DanhSachNhanVienDuocKhenThuong dsnvdkt;
        private MongoDataAccess _mongoDataAccess;
        private int cbbLoaikhenThuongIndex;
        private int cbbHinhThucKhenThuongIndex;
        private int z;
        private string mkt;

        public DanhSachNhanVienKhenThuong(DanhSachNhanVienDuocKhenThuong danhSach, int x, int y, int z)
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            dsnvdkt = danhSach;
            cbbLoaikhenThuongIndex = x;
            cbbHinhThucKhenThuongIndex = y;
            this.z = z;
            btnXongDSNVKT.Click += btnXongDSNVKT_Click;
            btnThemDSNVKT.Click += btnThemDSNVKT_Click;
            btnXoaDSNVKT.Click += btnXoaDSNVKT_Click;
            dgvDSNVKT.CellClick += dgvDSNVKT_CellClick;
            this.Load += DanhSachNhanVienKhenThuong_Load;
        }
        public DanhSachNhanVienKhenThuong(string maKhenThuong)
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            this.Load += DanhSachNhanVienKhenThuong_Load1;
            mkt = maKhenThuong;
            dgvDSNVKT.CellClick += dgvDSNVKT_CellClick1;
            btnXongDSNVKT.Click += btnXongDSNVKT_Click1;
        }
        private void DanhSachNhanVienKhenThuong_Load1(object sender, EventArgs e)
        {
            btnThemDSNVKT.Visible = false;
            btnXoaDSNVKT.Visible = false;

            var danhSachNhanVien = _mongoDataAccess.GetTatCaKhenThuong().FirstOrDefault(kt => kt.MaKhenThuong == mkt);

            dgvDSNVKT.MultiSelect = false;
            dgvDSNVKT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSNVKT.ReadOnly = true;

            dgvDSNVKT.Rows.Clear();
            dgvDSNVKT.Columns.Clear();

            dgvDSNVKT.Columns.Add("TienThuong", "Tiền thưởng ban đầu");
            dgvDSNVKT.Columns.Add("LuongCoBan", "Lương cơ bản");
            dgvDSNVKT.Columns.Add("LuongChinhSua", "Tiền thưởng mới mới");
            dgvDSNVKT.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvDSNVKT.Columns.Add("TenNhanVien", "Tên Nhân Viên");
            dgvDSNVKT.Columns.Add("ChucVu", "Chức vụ");

            foreach (DataGridViewColumn column in dgvDSNVKT.Columns)
            {
                column.Width = 200;
            }

            foreach (var nhanVien in danhSachNhanVien.DanhSachNhanVien)
            {
                string luongCoBan = "";
                foreach (var hopDong in _mongoDataAccess.GetTatCaHopDong())
                {
                    if (nhanVien.MaHopDong == hopDong.MaHopDong)
                    {
                        luongCoBan = hopDong.LuongCoBan.ToString();
                    }
                }
                dgvDSNVKT.Rows.Add(
                     nhanVien.TienThuong,
                     luongCoBan,
                     "",
                     nhanVien.MaNhanVien,
                     nhanVien.HoTen,
                     nhanVien.ChucVu
                 );
            }
        }
        private void DanhSachNhanVienKhenThuong_Load(object sender, EventArgs e)
        {
            dgvDSNVKT.MultiSelect = true;
            dgvDSNVKT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDSNVKT.ReadOnly = true;

            dgvDSNVKT.Rows.Clear();
            dgvDSNVKT.Columns.Clear();

            dgvDSNVKT.Columns.Add("TienThuong", "Tiền thưởng");
            dgvDSNVKT.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dgvDSNVKT.Columns.Add("TenNhanVien", "Tên Nhân Viên");
            dgvDSNVKT.Columns.Add("ChucVu", "Chức vụ");

            foreach (DataGridViewColumn column in dgvDSNVKT.Columns)
            {
                column.Width = 200;
            }

            foreach (var nhanVien in dsnvdkt.LayDanhSachNhanVien())
            {
                string ngaySinhString = nhanVien.NgaySinh != null ? nhanVien.NgaySinh.ToShortDateString() : "N/A"; // or ""
                dgvDSNVKT.Rows.Add(nhanVien.TienThuong, nhanVien.MaNhanVien, nhanVien.HoTen, nhanVien.ChucVu);
            }


            if (cbbLoaikhenThuongIndex == 2 && cbbHinhThucKhenThuongIndex == 1)
            {
                btnThemDSNVKT.Visible = false;

                btnXoaDSNVKT.Visible = false;
            }
            if (z == 0)
            {
                btnThemDSNVKT.Visible = false;
                btnXoaDSNVKT.Visible = false;
            }
        }

        private void btnXongDSNVKT_Click(object sender, EventArgs e)
        {
            if (cbbLoaikhenThuongIndex == 2)
            {
                this.Close();
            }
            if (cbbLoaikhenThuongIndex == 1 && cbbHinhThucKhenThuongIndex == 1)
            {
                var danhSachNhanVien = dsnvdkt.LayDanhSachNhanVien();
                var danhSachHopDong = _mongoDataAccess.GetTatCaHopDong();


                foreach (DataGridViewRow row in dgvDSNVKT.Rows)
                {
                    var maNhanVien = row.Cells["MaNhanVien"].Value?.ToString();

                    var mnv = _mongoDataAccess.GetTatCaNhanVien().FirstOrDefault(x => x.MaNhanVien == maNhanVien);

                    var maHopDong = mnv.MaHopDong;

                    var stringTienThuong = row.Cells["TienThuong"].Value?.ToString() ?? "0";
                    var stringTienThuongAfterReplace = stringTienThuong.Replace("% lương", "");

                    double tienThuong = Convert.ToDouble(stringTienThuongAfterReplace);


                    foreach (var a in dsnvdkt.LayDanhSachNhanVien())
                    {
                        foreach (var hopDongs in danhSachHopDong)
                        {
                            if (hopDongs.MaHopDong == maHopDong)
                            {
                                a.TienThuong = (hopDongs.LuongCoBan * tienThuong) / 100;
                            }
                        }
                    }
                }
                this.Close();
            }
            if (cbbLoaikhenThuongIndex == 0 && cbbHinhThucKhenThuongIndex == 1)
            {
                var danhSachNhanVien = dsnvdkt.LayDanhSachNhanVien();
                var danhSachHopDong = _mongoDataAccess.GetTatCaHopDong();


                foreach (DataGridViewRow row in dgvDSNVKT.Rows)
                {
                    var maNhanVien = row.Cells["MaNhanVien"].Value?.ToString();

                    var mnv = _mongoDataAccess.GetTatCaNhanVien().FirstOrDefault(x => x.MaNhanVien == maNhanVien);

                    var maHopDong = mnv.MaHopDong;

                    var stringTienThuong = row.Cells["TienThuong"].Value?.ToString() ?? "0";
                    var stringTienThuongAfterReplace = stringTienThuong.Replace("% lương", "");

                    double tienThuong = Convert.ToDouble(stringTienThuongAfterReplace);


                    foreach (var a in dsnvdkt.LayDanhSachNhanVien())
                    {
                        foreach (var hopDongs in danhSachHopDong)
                        {
                            if (hopDongs.MaHopDong == maHopDong)
                            {
                                a.TienThuong = (hopDongs.LuongCoBan * tienThuong) / 100;
                            }
                        }
                    }
                }
                this.Close();
            }
        }
        private void dgvDSNVKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {

                if (cbbLoaikhenThuongIndex == 0 && cbbHinhThucKhenThuongIndex == 1 && z == 0)
                {
                    ComboBox cbbTienThuong = new ComboBox();
                    cbbTienThuong.Items.Add("2% lương");
                    cbbTienThuong.Items.Add("5% lương");
                    cbbTienThuong.Items.Add("10% lương");
                    cbbTienThuong.Items.Add("25% lương");

                    if (!dgvDSNVKT.Controls.Contains(cbbTienThuong))
                    {
                        Rectangle cellRectangle = dgvDSNVKT.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        cbbTienThuong.SetBounds(cellRectangle.X, cellRectangle.Y, cellRectangle.Width, cellRectangle.Height);

                        dgvDSNVKT.Controls.Add(cbbTienThuong);
                        cbbTienThuong.DropDownStyle = ComboBoxStyle.DropDownList;

                        cbbTienThuong.SelectedIndexChanged += (s, ev) =>
                        {
                            dgvDSNVKT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbbTienThuong.SelectedItem.ToString();
                            dgvDSNVKT.Controls.Remove(cbbTienThuong);
                        };

                        cbbTienThuong.Focus();
                    }
                }
                else if (cbbLoaikhenThuongIndex == 1 && cbbHinhThucKhenThuongIndex == 1 && z == 0)
                {
                    ComboBox cbbTienThuong = new ComboBox();
                    cbbTienThuong.Items.Add("25% lương");
                    cbbTienThuong.Items.Add("50% lương");
                    cbbTienThuong.Items.Add("100% lương");
                    if (!dgvDSNVKT.Controls.Contains(cbbTienThuong))
                    {
                        Rectangle cellRectangle = dgvDSNVKT.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        cbbTienThuong.SetBounds(cellRectangle.X, cellRectangle.Y, cellRectangle.Width, cellRectangle.Height);

                        dgvDSNVKT.Controls.Add(cbbTienThuong);
                        cbbTienThuong.DropDownStyle = ComboBoxStyle.DropDownList;

                        cbbTienThuong.SelectedIndexChanged += (s, ev) =>
                        {
                            dgvDSNVKT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbbTienThuong.SelectedItem.ToString();
                            dgvDSNVKT.Controls.Remove(cbbTienThuong);
                        };

                        cbbTienThuong.Focus();
                    }
                }
            }
        }
        private void dgvDSNVKT_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                var danhSachNhanVien = _mongoDataAccess.GetTatCaKhenThuong().FirstOrDefault(kt => kt.MaKhenThuong == mkt);
                if (danhSachNhanVien.LoaiKhenThuong == "Thưởng hiệu suất làm việc")
                {
                    ComboBox cbbTienThuong = new ComboBox();
                    cbbTienThuong.Items.Add("2% lương");
                    cbbTienThuong.Items.Add("5% lương");
                    cbbTienThuong.Items.Add("10% lương");
                    cbbTienThuong.Items.Add("25% lương");


                    if (!dgvDSNVKT.Controls.Contains(cbbTienThuong))
                    {
                        Rectangle cellRectangle = dgvDSNVKT.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        cbbTienThuong.SetBounds(cellRectangle.X, cellRectangle.Y, cellRectangle.Width, cellRectangle.Height);

                        dgvDSNVKT.Controls.Add(cbbTienThuong);
                        cbbTienThuong.DropDownStyle = ComboBoxStyle.DropDownList;

                        cbbTienThuong.SelectedIndexChanged += (s, ev) =>
                        {
                            dgvDSNVKT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbbTienThuong.SelectedItem.ToString();
                            dgvDSNVKT.Controls.Remove(cbbTienThuong);
                        };

                        cbbTienThuong.Focus();
                    }
                }
                else if (danhSachNhanVien.LoaiKhenThuong == "Thưởng cuối năm (lương tháng 13)")
                {
                    ComboBox cbbTienThuong = new ComboBox();
                    cbbTienThuong.Items.Add("25% lương");
                    cbbTienThuong.Items.Add("50% lương");
                    cbbTienThuong.Items.Add("100% lương");

                    if (!dgvDSNVKT.Controls.Contains(cbbTienThuong))
                    {
                        Rectangle cellRectangle = dgvDSNVKT.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                        cbbTienThuong.SetBounds(cellRectangle.X, cellRectangle.Y, cellRectangle.Width, cellRectangle.Height);

                        dgvDSNVKT.Controls.Add(cbbTienThuong);
                        cbbTienThuong.DropDownStyle = ComboBoxStyle.DropDownList;

                        cbbTienThuong.SelectedIndexChanged += (s, ev) =>
                        {
                            dgvDSNVKT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cbbTienThuong.SelectedItem.ToString();
                            dgvDSNVKT.Controls.Remove(cbbTienThuong);
                        };

                        cbbTienThuong.Focus();
                    }
                }
            }
        }
        private void btnThemDSNVKT_Click(Object sender, EventArgs e)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien(dsnvdkt);
            dsnv.ShowDialog();
            this.Close();
        }

        private void btnXoaDSNVKT_Click(Object sender, EventArgs e)
        {
            if (dgvDSNVKT.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDSNVKT.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        var maNhanVien = row.Cells["MaNhanVien"].Value?.ToString();

                        if (maNhanVien != null)
                        {
                            var nhanVienToRemove = dsnvdkt.LayDanhSachNhanVien().FirstOrDefault(a => a.MaNhanVien == maNhanVien);

                            if (nhanVienToRemove != null)
                            {
                                dsnvdkt.XoaMotNhanVien(nhanVienToRemove);
                            }
                            dgvDSNVKT.Rows.Remove(row);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một hàng để xóa!");
            }
        }
        public void btnXongDSNVKT_Click1(Object sender, EventArgs e)
        {
            var danhSachHopDong = _mongoDataAccess.GetTatCaHopDong();

            foreach (DataGridViewRow Row in dgvDSNVKT.Rows)
            {
                if (!Row.IsNewRow)
                {
                    var maNhanVien = Row.Cells["MaNhanVien"].Value?.ToString();

                    var maHopDong = _mongoDataAccess.GetTatCaNhanVien().FirstOrDefault(x => x.MaNhanVien == maNhanVien).MaHopDong;

                    var stringTienThuong = Row.Cells["LuongChinhSua"].Value?.ToString() ?? "0";
                    var stringTienThuongAfterReplace = stringTienThuong.Replace("% lương", "");

                    double tienThuong = Convert.ToDouble(stringTienThuongAfterReplace);

                    double tienThuongSua = 0;

                    foreach (var hopDongs in danhSachHopDong)
                    {
                        if (maHopDong == hopDongs.MaHopDong)
                        {
                            tienThuongSua = (hopDongs.LuongCoBan * tienThuong) / 100;
                            break;
                        }
                    }
                    _mongoDataAccess.UpdateTienKhenThuong(maNhanVien, tienThuongSua);
                }
            }
            this.Close();
        }

        private void btnXongDSNVKT_Click_1(object sender, EventArgs e)
        {

        }
    }
}
