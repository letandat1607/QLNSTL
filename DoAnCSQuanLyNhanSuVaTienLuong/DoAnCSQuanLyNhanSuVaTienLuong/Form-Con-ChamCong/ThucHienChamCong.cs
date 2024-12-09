﻿using System;
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

namespace DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong
{
    public partial class ThucHienChamCong : Form
    {
        private MongoDataAccess _mongoDataAccess;
        public ThucHienChamCong()
        {
            InitializeComponent();
            _mongoDataAccess = new MongoDataAccess();
            dtpNgayChamCong.Value = DateTime.Now;
            Const.chamCong.NgayChamCong = DateTime.Now;
            btnCheckOut.Enabled = false;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
            Const.chamCong.CheckIn = vietnamTime.TimeOfDay;
            rtbCheckIn.Text = vietnamTime.ToString("HH:mm:ss");
            btnCheckOut.Enabled = true;
            btnCheckIn.Enabled = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DateTime vietnamTime = ConvertToVietnamTime(DateTime.UtcNow);
            Const.chamCong.CheckOut = vietnamTime.TimeOfDay;
            rtbCheckOut.Text = vietnamTime.ToString("HH:mm:ss");
        }
        private DateTime ConvertToVietnamTime(DateTime utcDateTime)
        {
            var vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, vietnamTimeZone);
        }
    }
}
