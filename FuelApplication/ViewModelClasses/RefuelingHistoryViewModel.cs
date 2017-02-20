using Fuel.DAL.EF6.Infrastructure;
using Fuel.DAL.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuel.DAL.EF6.Anonymous;

namespace FuelApplication.ViewModelClasses
{
    public class RefuelingHistoryViewModel
    {

        public List<RefuelingEntry> GetRefuelingHistory()
        {
          using (var uof = new UnitOfWork(new FuelContext()))
          {
                return uof.RefuelingRepository.GetRefuelingHistory();
          } 
                
        }
        
    
    }
}
