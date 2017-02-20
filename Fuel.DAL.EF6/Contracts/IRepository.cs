using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Contracts
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity item);
        IQueryable<TEntity> GetAll();
        int Commit();
        TEntity GetItem(int id);
        void Delete(int id);
        ObservableCollection<TEntity> GetObservableCollection();
        void Reload();
        bool IsEmpty();

    }
}
