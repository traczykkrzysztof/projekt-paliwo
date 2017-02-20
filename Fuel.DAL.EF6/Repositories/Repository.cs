using Fuel.DAL.EF6.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DbContext _ctx { get; set; }
        public DbSet<TEntity> _set { get; set; }

        public Repository(DbContext ctx)
        {
            _ctx = ctx;
            _set = ctx.Set<TEntity>();
        }

        public void Add(TEntity item)
        {
            _set.Add(item);
        }

        public int Commit()
        {
            return _ctx.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _set;
        }

        public TEntity GetItem(int id)
        {
            return _set.Find(id);
        }

        public void Delete(int id)
        {
            TEntity temp = _set.Find(id);
            _set.Remove(temp);  
        }

        public ObservableCollection<TEntity> GetObservableCollection()
        {
            _set.Load();
            return _set.Local;
        }

        public void Reload()
        {
            _set.Load();
        }

        public bool IsEmpty()
        {
            return _set.Count() == 0 ? true : false;    
        }
    }
}
