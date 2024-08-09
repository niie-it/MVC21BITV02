using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class NhanVien
{
    public int Id { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string? MatKhau { get; set; }

    public string HoTen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ICollection<PhanCong> PhanCongs { get; set; } = new List<PhanCong>();
}
