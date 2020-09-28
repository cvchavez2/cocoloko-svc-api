using System.Collections.Generic;

namespace Cocoloko.Storing.Models
{
  public class Beverage : AComponent
  {
    public Beverage()
    {
      Ingredients = new HashSet<Ingredient>();
    }
    public string ImageUrl { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }

    // public virtual User Customer { get; set; }
  }
}