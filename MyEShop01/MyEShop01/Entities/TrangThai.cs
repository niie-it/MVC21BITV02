using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class TrangThai
{
    public int Id { get; set; }

    public string TenTrangThai { get; set; } = null!;

    public string? MoTa { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
