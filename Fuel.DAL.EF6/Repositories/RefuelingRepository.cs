using Fuel.DAL.EF6.Contracts;
using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Fuel.DAL.EF6.Anonymous;
using System.Collections.ObjectModel;
using System.Collections;

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
       

        public ObservableCollection<RefuelingEntry> GetObservableRefuelingHistory()
        {
            ObservableCollection<RefuelingEntry> refuelinglist = new ObservableCollection<RefuelingEntry>();

            var list = _set.Select(x => new { distance = x.Distance, numberofliters = x.Numberofliters, consumption = x.Fuelconsumption, carname = x.Car.Name, refuelingdate = x.RefuelingDate });

            foreach (var element in list)
            {
                RefuelingEntry obj = new RefuelingEntry();
                obj.distance = element.distance;
                obj.numberofliters = element.numberofliters;
                obj.consumption = element.consumption;
                obj.carname = element.carname;
                obj.date = element.refuelingdate;

                if (element.refuelingdate != null)
                {
                    obj.refuelingdate = element.refuelingdate.Value.ToShortDateString();
                }
                else
                {
                    obj.refuelingdate = "";
                }
                
                refuelinglist.Add(obj);
            }

            return refuelinglist;
        }


        public List<RefuelingEntry> Costam()
        {
            List<RefuelingEntry> r = new List<RefuelingEntry>();

            foreach (var element in _set)
            {
                r.Add(new RefuelingEntry() { carname = element.CarId.ToString(), consumption = element.Fuelconsumption });
            }

            var list = _set.GroupBy(x => x.CarId);


            foreach (var group in list)
            {
                Console.WriteLine("Group key: {0}", group.Key);
                Console.WriteLine("Average consumption for group: {0}",group.Average(x => x.Fuelconsumption));
            }

            return r;
        }


    }
}
