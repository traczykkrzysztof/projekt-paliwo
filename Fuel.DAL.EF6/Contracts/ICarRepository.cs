using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Contracts
{
    public interface ICarRepository : IRepository<Car>
    {
        IQueryable<Car> CarsWithServiceDate();
    }
}
