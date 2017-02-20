using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Fuel.DAL.EF6.Contracts;

namespace Fuel.DAL.EF6.Repositories
{
    internal sealed class CarRepository : Repository<Car>, ICarRepository
    {

        public CarRepository(DbContext ctx)
            : base(ctx)
        {
        
        }

        public IQueryable<Car> CarsWithServiceDate()
        {
            return _set.Where(x => x.NextService != null);
        }


        

        
           
    }
}
