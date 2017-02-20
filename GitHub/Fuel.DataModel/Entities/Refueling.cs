using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.DataModel.Entities
{
    public class Refueling
    {
        public Refueling()
        {
           
        }

        public int Id { get; set; }
        public float Distance { get; set; }
        public float Numberofliters { get; set; }
        public float Fuelconsumption
        {
            get
            {
                return GetFuelconsumption();
            }

            set
            {

            }
        }


        public int CarId { get; set; }
 
        public Car Car { get; set; }

        public float GetFuelconsumption()
        {
            return Numberofliters / Distance * 100;
        }

        

    }
}
