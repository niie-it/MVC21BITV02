using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class YeuThich
{
    public int Id { get; set; }

    public int? MaHh { get; set; }

    public int? MaKh { get; set; }

    public DateTime? NgayChon { get; set; }

    public int DiemDanhGia { get; set; }

    public string? MoTa { get; set; }

    public virtual HangHoa? MaHhNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }
}
