namespace Cocoloko.Storing.Repositories
{
  public class UnitOfWork
  {
    private readonly CocolokoDbContext _context;

    public virtual BeverageRepo Beverage { get; }

    public UnitOfWork(CocolokoDbContext context)
    {
      _context = context;

      Beverage = new BeverageRepo(context);
    }
  }
}