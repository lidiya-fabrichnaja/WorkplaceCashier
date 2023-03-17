using DAL.Commons;
using Models;
using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{
    public class CommonRepository<TEntity> where TEntity : class,IEntity,IGridRow,new()
    {

        DbContext _context;

        DbSet<TEntity> _dbSet;

        public CommonRepository()
        {
            _context = DataContainer.GetContext();
            _dbSet = _context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Update(TEntity item)
        {                                     
            if (_context.Entry(item).State != EntityState.Detached)
            {
                _context.Entry(item).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }
        public void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public TEntity New()
        {
            return new TEntity();
        }
        
        public void RollBack()
        {
      
            var changedEntries = _context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }
    }
}
