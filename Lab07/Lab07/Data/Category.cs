using System;
using System.Collections.Generic;

namespace Lab07.Data;

public partial class Category
{
    /// <summary>
    /// Mã loại
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Tên chủng loại
    /// </summary>
    public string NameVn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
