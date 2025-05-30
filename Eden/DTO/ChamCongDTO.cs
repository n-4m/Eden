﻿using System;

public class ChamCongDTO
{
    public int id { get; set; }
    public string MaChamCong { get; set; }
    public string MaNhanVien { get; set; }
    public string TenNguoiDung { get; set; }
    public DateTime? NgayChamCong { get; set; }
    public TimeSpan? GioDangNhap { get; set; }
    public TimeSpan? GioDangXuat { get; set; }
    public string CaLamViec { get; set; }
    public string TrangThai { get; set; }
}