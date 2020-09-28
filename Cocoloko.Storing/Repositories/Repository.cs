using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cocoloko.Storing.Repositories
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
  {
    public readonly DbSet<TEntity> _db;

    public Repository(CocolokoDbContext context)
    {
      _db = context.Set<TEntity>();
    }
    public virtual async Task<IEnumerable<TEntity>> SelectAsync() => await _db.ToListAsync();
    public virtual async Task<TEntity> SelectAsync(int id) => await _db.FindAsync(id).ConfigureAwait(true);

  }
}