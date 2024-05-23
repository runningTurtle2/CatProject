using System;
using System.Collections.Generic;

namespace CatProject.Models;

public partial class Color
{
    public int ColorId { get; set; }

    public string ColorValue { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
