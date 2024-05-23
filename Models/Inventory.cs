using System;
using System.Collections.Generic;

namespace CatProject.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public int BreedId { get; set; }

    public int ColorId { get; set; }

    public int PlayfullnessId { get; set; }

    public int ActivityLevelId { get; set; }

    public virtual ActivityLevel ActivityLevel { get; set; } = null!;

    public virtual Breed Breed { get; set; } = null!;

    public virtual Color Color { get; set; } = null!;

    public virtual Playfullness Playfullness { get; set; } = null!;
}
