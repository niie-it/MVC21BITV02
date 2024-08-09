using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class ChuDe
{
    public int Id { get; set; }

    public string? TenCd { get; set; }

    public string? MaNv { get; set; }

    public virtual ICollection<GopY> Gopies { get; set; } = new List<GopY>();
}
