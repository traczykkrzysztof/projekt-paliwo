using Fuel.DAL.EF6.Contracts;
using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Fuel.DAL.EF6.Anonymous;

namespace Fuel.DAL.EF6.Repositories
{
    public class RefuelingRepository : Repository<Refueling>, IRefuelingRepository
    {
        public RefuelingRepository(DbContext ctx)
            : base(ctx)
        {
        }

        public List<RefuelingEntry> GetRefuelingHistory()
        {
            List<RefuelingEntry> refuelingentrylist = new List<RefuelingEntry>();

            var list = _set.Select(x => new { distance = x.Distance, numberofliters = x.Numberofliters, consumption = x.Fuelconsumption, carname = x.Car.Name });

            foreach (var element in list)
            {
                RefuelingEntry obj = new RefuelingEntry();
                obj.distance = element.distance;
                obj.numberofliters = element.numberofliters;
                obj.consumption = element.consumption;
                obj.carname = element.carname;
                refuelingentrylist.Add(obj);
            }

            return refuelingentrylist;

        }
    }
}
