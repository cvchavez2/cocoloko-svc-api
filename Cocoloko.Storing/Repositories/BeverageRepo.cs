using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cocoloko.Storing.Models;
using Microsoft.EntityFrameworkCore;

namespace Cocoloko.Storing.Repositories
{
  public class BeverageRepo : Repository<Beverage>
  {
    public BeverageRepo(CocolokoDbContext context) : base(context)
    {

    }
    public override async Task<IEnumerable<Beverage>> SelectAsync() => await _db
      .Include(r => r.Ingredients)
      .ToListAsync();
 
    public override async Task<Beverage> SelectAsync(int id) => await _db
      .Include(i => i.Ingredients)
      .FirstOrDefaultAsync(x => x.Id == id);
  }
}