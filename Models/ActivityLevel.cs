using System;
using System.Collections.Generic;

namespace CatProject.Models;

public partial class ActivityLevel
{
    public int ActivityLevelId { get; set; }

    public string ActivityLevelValue { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
