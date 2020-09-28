using System.Collections.Generic;

namespace Cocoloko.Storing.Models
{
  public class User : AModel
  {
    public List<Beverage> Beverages { get; set; }
  }
}