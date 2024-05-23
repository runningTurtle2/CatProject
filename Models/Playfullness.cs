using System;
using System.Collections.Generic;

namespace CatProject.Models;

public partial class Playfullness
{
    public int PlayfullnessId { get; set; }

    public string PlayfullnessValue { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
