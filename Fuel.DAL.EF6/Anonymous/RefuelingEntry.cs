using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DAL.EF6.Anonymous
{
    public class RefuelingEntry
    {
        public DateTime? date { get; set; }
        public float distance { get; set; }
        public float numberofliters { get; set; }
        public float consumption { get; set; }
        public string carname { get; set; }
        public string refuelingdate { get; set; }
    }
}
