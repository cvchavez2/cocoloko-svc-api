using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cocoloko.Storing.Repositories
{
  public interface IRepository<TEntity> where TEntity : class
  {
    Task<IEnumerable<TEntity>> SelectAsync();

    Task<TEntity> SelectAsync(int id);
  }
}