using System;
using System.Collections.Generic;

namespace MyEShop01.Entities;

public partial class TrangWeb
{
    public int Id { get; set; }

    public string TenTrang { get; set; } = null!;

    public string Url { get; set; } = null!;

    public virtual ICollection<PhanQuyen> PhanQuyens { get; set; } = new List<PhanQuyen>();
}
