using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DataModel.Entities
{
    public class Car
    {
        public Car()
        {
            Refuelings = new List<Refueling>();
        }

        public int Id { get; set; }
        public DateTime? NextService { get; set; }

        [Required]
        public string Name { get; set; }

        ICollection<Refueling> Refuelings { get; set; }
    }
}
