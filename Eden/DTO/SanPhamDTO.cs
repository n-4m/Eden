﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eden.DTO
{
    public class SanPhamDTO
    {
        public int idSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string MauSac { get; set; }
        public string AnhChiTiet { get; set; }
        public string TenNhaCungCap { get; set; }
        public string TenLoaiSanPham { get; set; }

        public int SoLuongDaBan { get; set; }

    }
}
