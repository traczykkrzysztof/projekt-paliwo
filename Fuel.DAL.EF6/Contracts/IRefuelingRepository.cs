using Fuel.DAL.EF6.Anonymous;
using Fuel.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Contracts
{
    public interface IRefuelingRepository : IRepository<Refueling>
    {
        List<RefuelingEntry> GetRefuelingHistory();
        ObservableCollection<RefuelingEntry> GetObservableRefuelingHistory();

        List<RefuelingEntry> Costam();

    }
}
