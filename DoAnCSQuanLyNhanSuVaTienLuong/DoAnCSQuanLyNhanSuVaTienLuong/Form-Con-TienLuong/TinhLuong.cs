using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCSQuanLyNhanSuVaTienLuong.DataAccess;
using DoAnCSQuanLyNhanSuVaTienLuong.Doi_tuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Doituong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_BangLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_ChiTraLuong;
using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong.Form_Con_DuLieuTienLuong;
using static DoAnCSQuanLyNhanSuVaTienLuong.DataAccess.MongoDataAccess;

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_TienLuong
{
    public partial class TinhLuong : Form
    {
        private MongoDataAccess mongoDataAccess;
        private BangLuong DanhSachBangLuong;
        //private IEnumerable<HopDong> 
        private List<KhenThuong> danhSachKhenThuong;
        private List<NgayNghi> DanhSachNgayNghi;

        public TinhLuong()
        {
            InitializeComponent();
            mongoDataAccess = new MongoDataAccess();
            InitializeDataGridView();
            LoadData();
        }
        private void InitializeDataGridView()
        {
        //    SoNgayNghi { get; set; }
        //public int SoNgayNghiPhep { get; set; }
        //public int SoNgayKhongPhep
            LoadData();
        }


        //private void LoadData()
        //{
        //    InitializeDataGridView();

        //    var danhSachNgayNghi = mongoDataAccess.GetTatCaNgayNghi();

        //    // Xử lý dữ liệu ngày nghỉ
        //    foreach (var nn in danhSachNgayNghi)
        //    {
        //        // Dữ liệu tổng hợp số ngày phép và không phép theo tháng
        //        var monthsData = new Dictionary<int, (int soNgayCoPhep, int soNgayKhongPhep)>();
        //        for (DateTime currentDate = nn.TuNgay; currentDate <= nn.DenNgay; currentDate = currentDate.AddDays(1))
        //        {
        //            int month = currentDate.Month;
        //            if (!monthsData.ContainsKey(month))
        //                monthsData[month] = (0, 0);

        //            // Cập nhật số ngày nghỉ có phép và không phép
        //            if (nn.LoaiNghi == "CoPhep")
        //                monthsData[month] = (monthsData[month].soNgayCoPhep + 1, monthsData[month].soNgayKhongPhep);
        //            else
        //                monthsData[month] = (monthsData[month].soNgayCoPhep, monthsData[month].soNgayKhongPhep + 1);
        //        }

        //        // Thêm hoặc cập nhật dữ liệu vào DataGridView
        //        foreach (var monthData in monthsData)
        //        {
        //            int month = monthData.Key;
        //            var data = monthData.Value;

        //            // Tìm hàng tồn tại
        //            var existingRow = dtgvtinhluong.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(row =>
        //                    row.Cells["MaNhanVien"].Value?.ToString() == nn.MaNhanVien &&
        //                    row.Cells["Thang"].Value is int existingMonth && existingMonth == month);

        //            if (existingRow != null)
        //            {
        //                // Cập nhật dữ liệu
        //                existingRow.Cells["SoNgayPhep"].Value =
        //                    (existingRow.Cells["SoNgayPhep"].Value == null ? 0 : (int)existingRow.Cells["SoNgayPhep"].Value) + data.soNgayCoPhep;
        //                existingRow.Cells["SoNgayKhongPhep"].Value =
        //                    (existingRow.Cells["SoNgayKhongPhep"].Value == null ? 0 : (int)existingRow.Cells["SoNgayKhongPhep"].Value) + data.soNgayKhongPhep;
        //            }
        //            else
        //            {
        //                // Thêm mới dòng
        //                dtgvtinhluong.Rows.Add(nn.MaNhanVien, nn.HoTen, nn.ChucVu, month, data.soNgayCoPhep, data.soNgayKhongPhep);
        //            }
        //        }
        //    }


        //    var DanhSachBangLuong = mongoDataAccess.GetBangLuong(month , cp, kp);
        //       foreach(var bl in DanhSachBangLuong)
        //    {
        //        dtgvtinhluong.Rows.Add(
        //          bl.MaNhanVien, bl.TenNhanVien, bl.ChucVu, bl.LuongCoBan, bl.TienKhenThuong,
        //          bl.NgayNghiBiTruLuong, bl.NgayNghiKhongBiTruLuong, month,
        //          bl.KhauTru
        //        );
        //    }

        //}


        //private void LoadData()
        //{
        //    InitializeDataGridView();
        //    dtgvtinhluong.Rows.Clear(); // Xóa các hàng cũ

        //    var danhSachNgayNghi = mongoDataAccess.GetTatCaNgayNghi();

        //    // Xử lý danh sách ngày nghỉ
        //    foreach (var nn in danhSachNgayNghi)
        //    {
        //        var monthsData = new Dictionary<int, (int soNgayKhongPhep, int soNgayCoPhep)>();

        //        // Tính toán số ngày nghỉ theo từng tháng
        //        for (DateTime currentDate = nn.TuNgay; currentDate <= nn.DenNgay; currentDate = currentDate.AddDays(1))
        //        {
        //            int month = currentDate.Month;

        //            if (!monthsData.ContainsKey(month))
        //                monthsData[month] = (0, 0);

        //            if (nn.LoaiNghi == "KhongPhep")
        //                monthsData[month] = (monthsData[month].soNgayKhongPhep + 1, monthsData[month].soNgayCoPhep);
        //            else
        //                monthsData[month] = (monthsData[month].soNgayKhongPhep, monthsData[month].soNgayCoPhep + 1);
        //        }

        //        foreach (var monthData in monthsData)
        //        {
        //            int month = monthData.Key;
        //            var data = monthData.Value;

        //            // Kiểm tra nếu không có ngày nghỉ thì bỏ qua
        //            if (data.soNgayKhongPhep == 0 && data.soNgayCoPhep == 0)
        //                continue;

        //            // Tìm hàng tồn tại trong DataGridView
        //            var existingRow = dtgvtinhluong.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(row =>
        //                    row.Cells["MaNhanVien"].Value?.ToString() == nn.MaNhanVien &&
        //                    row.Cells["Thang"].Value is int existingMonth && existingMonth == month);

        //            if (existingRow != null)
        //            {

        //                // Cập nhật giá trị cộng dồn vào hàng đã tồn tại
        //                existingRow.Cells["NgayNghiBiTruLuong"].Value =
        //                    Convert.ToInt32(existingRow.Cells["NgayNghiBiTruLuong"].Value ?? 0) + data.soNgayKhongPhep;
        //                existingRow.Cells["NgayNghiKhongBiTruLuong"].Value =
        //                    Convert.ToInt32(existingRow.Cells["NgayNghiKhongBiTruLuong"].Value ?? 0) + data.soNgayCoPhep;
        //            }
        //            else
        //            {
        //                // Lấy dữ liệu từ bảng lương
        //                var danhSachBangLuong = mongoDataAccess.GetBangLuong(nn.MaNhanVien, data.soNgayKhongPhep, data.soNgayCoPhep, month);

        //                foreach (var bl in danhSachBangLuong)
        //                {
        //                    if (bl != null && !string.IsNullOrEmpty(bl.MaNhanVien))
        //                    {
        //                        dtgvtinhluong.Rows.Add(
        //                            bl.MaNhanVien,
        //                            bl.TenNhanVien,
        //                            bl.ChucVu,
        //                            bl.LuongCoBan,
        //                            bl.TienKhenThuong,
        //                            data.soNgayKhongPhep,
        //                            data.soNgayCoPhep,
        //                            month,
        //                            bl.KhauTru
        //                        );
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    dtgvtinhluong.Refresh(); // Làm mới giao diện
        //}
        private void LoadData()
        {
            dtgvtinhluong.Columns.Clear();
            dtgvtinhluong.Columns.Add("MaNhanVien", "Mã Nhân Viên");
            dtgvtinhluong.Columns.Add("HoTen", "Tên Nhân Viên");
            dtgvtinhluong.Columns.Add("ChucVu", "Chức Vụ");
            dtgvtinhluong.Columns.Add("LuongCoBan", "Lương Cơ Bản");
            dtgvtinhluong.Columns.Add("TienKhenThuong", "Tiền Khen Thưởng");
            dtgvtinhluong.Columns.Add("SoNgayKhongPhep", "Ngày Nghỉ Bị Trừ Lương");
            dtgvtinhluong.Columns.Add("SoNgayNghiPhep", "Ngày Nghỉ Không Bị Trừ Lương");
            dtgvtinhluong.Columns.Add("Thang", "Tháng");
            dtgvtinhluong.Columns.Add("KhauTru", "Khấu Trừ");
            dtgvtinhluong.Columns.Add("LuongChamCong", "Lương Chấm Công");
            dtgvtinhluong.Columns.Add("LuongTruocThue", "Lương Trước Thuế");
            dtgvtinhluong.Columns.Add("LuongSauThue", "Lương Sau Thuế");
            dtgvtinhluong.Columns.Add("LuongThucTe", "Lương Thực Tế");
            //var danhSachNgayNghi = mongoDataAccess.GetTatCaNgayNghi();

            var danhSachBangLuong = mongoDataAccess.GetBangLuong();

                foreach (var bl in danhSachBangLuong)
                {
                    if (bl != null && !string.IsNullOrEmpty(bl.MaNhanVien))
                    {
                        dtgvtinhluong.Rows.Add(
                            bl.MaNhanVien,
                            bl.HoTen,
                            bl.ChucVu,
                            bl.LuongCoBan,
                            bl.TienKhenThuong,
                            bl.SoNgayKhongPhep,
                            bl.SoNgayNghiPhep,
                            bl.Thang,
                            bl.KhauTru
                        );
                    }
                }




                //foreach (var monthData in monthsData)
                //{
                //    int month = monthData.Key;
                //    var data = monthData.Value;

                //    if (data.soNgayKhongPhep == 0 && data.soNgayCoPhep == 0)
                //        continue; // Không cập nhật nếu không có ngày nghỉ

                //    // Kiểm tra nếu hàng đã tồn tại trong DataGridView
                //    var existingRow = dtgvtinhluong.Rows
                //        .Cast<DataGridViewRow>()
                //        .FirstOrDefault(row =>
                //            row.Cells["MaNhanVien"].Value?.ToString() == nn.MaNhanVien &&
                //            row.Cells["Thang"].Value != null &&
                //            (int)row.Cells["Thang"].Value == month);

                //    if (existingRow != null)
                //    {
                //        // Lấy giá trị hiện tại
                //        int currentValueNghiBiTru = Convert.ToInt32(existingRow.Cells["NgayNghiBiTruLuong"].Value ?? 0);
                //        int currentValueKhongBiTru = Convert.ToInt32(existingRow.Cells["NgayNghiKhongBiTruLuong"].Value ?? 0);

                //        // Cập nhật giá trị chỉ khi có dữ liệu hợp lệ
                //        if (data.soNgayKhongPhep > 0)
                //            existingRow.Cells["NgayNghiBiTruLuong"].Value = currentValueNghiBiTru + data.soNgayKhongPhep;

                //        if (data.soNgayCoPhep > 0)
                //            existingRow.Cells["NgayNghiKhongBiTruLuong"].Value = currentValueKhongBiTru + data.soNgayCoPhep;
                //    }
                //else
                //{
                //    // Chỉ thêm nếu có số ngày nghỉ hợp lệ
                //    if (data.soNgayKhongPhep > 0 || data.soNgayCoPhep > 0)
                //    {
                //        var danhSachBangLuong = mongoDataAccess.GetBangLuong(nn.MaNhanVien, data.soNgayKhongPhep, data.soNgayCoPhep, month);

                //        foreach (var bl in danhSachBangLuong)
                //        {
                //            if (bl != null && !string.IsNullOrEmpty(bl.MaNhanVien))
                //            {
                //                dtgvtinhluong.Rows.Add(
                //                    bl.MaNhanVien,
                //                    bl.TenNhanVien,
                //                    bl.ChucVu,
                //                    bl.LuongCoBan,
                //                    bl.TienKhenThuong,
                //                    data.soNgayKhongPhep,
                //                    data.soNgayCoPhep,
                //                    month,
                //                    bl.KhauTru
                //                );
                //            }
                //        }
                //    }
                //}
                //}


            dtgvtinhluong.Refresh(); // Làm mới giao diện
        }

        //private void LoadData()
        //{
        //    InitializeDataGridView(); // Khởi tạo bảng
        //    dtgvtinhluong.Rows.Clear(); // Xóa các hàng cũ

        //    var danhSachNgayNghi = mongoDataAccess.GetTatCaNgayNghi(); // Lấy danh sách ngày nghỉ của nhân viên

        //    foreach (var nn in danhSachNgayNghi) // Duyệt qua từng nhân viên và ngày nghỉ của họ
        //    {
        //        // Duyệt qua từng ngày từ TuNgay đến DenNgay
        //        DateTime currentDate = nn.TuNgay;
        //        while (currentDate <= nn.DenNgay)
        //        {
        //            int month = currentDate.Month; // Lấy tháng hiện tại

        //            int soNgayKhongPhep = 0; // Biến đếm số ngày nghỉ không phép
        //            int soNgayCoPhep = 0; // Biến đếm số ngày nghỉ có phép

        //            // Tính số ngày nghỉ theo loại
        //            if (nn.LoaiNghi == "KhongPhep")
        //                soNgayKhongPhep++;
        //            else
        //                soNgayCoPhep++;

        //            // Kiểm tra nếu có dữ liệu cho tháng này
        //            var existingRow = dtgvtinhluong.Rows
        //                .Cast<DataGridViewRow>()
        //                .FirstOrDefault(row =>
        //                    row.Cells["MaNhanVien"].Value?.ToString() == nn.MaNhanVien &&
        //                    row.Cells["Thang"].Value != null &&
        //                    (int)row.Cells["Thang"].Value == month);

        //            if (existingRow != null) // Nếu đã có dữ liệu, cộng dồn số ngày nghỉ
        //            {
        //                int currentValueNghiBiTru = Convert.ToInt32(existingRow.Cells["NgayNghiBiTruLuong"].Value ?? 0);
        //                int currentValueKhongBiTru = Convert.ToInt32(existingRow.Cells["NgayNghiKhongBiTruLuong"].Value ?? 0);

        //                if (soNgayKhongPhep > 0)
        //                    existingRow.Cells["NgayNghiBiTruLuong"].Value = currentValueNghiBiTru + soNgayKhongPhep;

        //                if (soNgayCoPhep > 0)
        //                    existingRow.Cells["NgayNghiKhongBiTruLuong"].Value = currentValueKhongBiTru + soNgayCoPhep;
        //            }
        //            else // Nếu chưa có dữ liệu, thêm mới vào bảng
        //            {
        //                if (soNgayKhongPhep > 0 || soNgayCoPhep > 0)
        //                {
        //                    var danhSachBangLuong = mongoDataAccess.GetBangLuong(nn.MaNhanVien, soNgayKhongPhep, soNgayCoPhep, month);

        //                    foreach (var bl in danhSachBangLuong)
        //                    {
        //                        if (bl != null && !string.IsNullOrEmpty(bl.MaNhanVien))
        //                        {
        //                            dtgvtinhluong.Rows.Add(
        //                                bl.MaNhanVien,
        //                                bl.TenNhanVien,
        //                                bl.ChucVu,
        //                                bl.LuongCoBan,
        //                                bl.TienKhenThuong,
        //                                0,
        //                                0,
        //                                month,
        //                                bl.KhauTru
        //                            );
        //                        }
        //                    }
        //                }
        //            }

        //            // Tiến tới ngày tiếp theo
        //            currentDate = currentDate.AddDays(1);
        //        }
        //    }

        //    dtgvtinhluong.Refresh(); // Làm mới bảng để hiển thị kết quả
        //}



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void thànhPhầnLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhPhanLuong thanhPhanLuong = new ThanhPhanLuong();
            this.Hide();
            thanhPhanLuong.Show();
        }

        private void mấuBảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MauBangLuong mauBangLuong = new MauBangLuong();
            this.Hide();
            mauBangLuong.Show();
        }

        private void BangLuongTheoThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BangLuongTheoThang bangLuongTheoThang = new BangLuongTheoThang();
            this.Hide();
            //bangLuongTheoThang.Show();
        }

        private void BangLuongTheoNamToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}