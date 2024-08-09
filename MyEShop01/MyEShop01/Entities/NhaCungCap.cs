using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class NhaCungCap
{
    public int Id { get; set; }

    public string MaNcc { get; set; } = null!;

    public string TenNcc { get; set; } = null!;

    public string Logo { get; set; } = null!;

    public string? NguoiLienLac { get; set; }

    public string Email { get; set; } = null!;

    public string? DienThoai { get; set; }

    public string? DiaChi { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
}
