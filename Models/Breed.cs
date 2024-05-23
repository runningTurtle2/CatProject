using System;
using System.Collections.Generic;

namespace CatProject.Models;

public partial class Breed
{
    public int BreedId { get; set; }

    public string Breed1 { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
}
