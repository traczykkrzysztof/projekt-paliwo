using Fuel.DAL.EF6.Anonymous;
using Fuel.DAL.EF6.Infrastructure;
using Fuel.DataModel.Entities;
using Fuel.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventTest
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            

            DateTime date1 = new DateTime(2017, 01, 02);

            DateTime? date2 = new DateTime(2017, 12, 12);

          

            Console.WriteLine(date1.Date);

            Console.WriteLine(date1.ToShortDateString());

          

            /*
            using (var uof = new UnitOfWork(new Fuel.DAL.EF6.FuelContext()))
            {
                Console.WriteLine(uof.CarRepository.IsEmpty()); 
            }
            */
                Console.ReadKey();
        }

    }


    public enum EngineType
    {
        Benzyna,
        Diesel,
        LPG,
    }

}
