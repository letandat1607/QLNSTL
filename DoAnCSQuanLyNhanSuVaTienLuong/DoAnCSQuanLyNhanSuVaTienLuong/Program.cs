﻿using DoAnCSQuanLyNhanSuVaTienLuong.Form_Con_ChamCong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSQuanLyNhanSuVaTienLuong
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HeThongQuanLy());
            //Application.Run(new DangNhap());
            Application.Run(new ThongKeSoNgayNghi());
        }
    }
}
