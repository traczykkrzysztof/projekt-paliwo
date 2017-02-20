using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6
{
    public class FuelContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Refueling> Refuelings { get; set; }
    }
}
