using Fuel.DAL.EF6;
using Fuel.DAL.EF6.Contracts;
using Fuel.DAL.EF6.Infrastructure;
using Fuel.DAL.EF6.Repositories;
using Fuel.DataModel.Entities;
using FuelApplication.ViewModelClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelApplication.MainViewModel;

namespace FuelApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            var mvm = new MainViewModel.CarsViewModel();
            //var cvm = new ViewModelClasses.CarsViewModel();
            foreach (var item in mvm.viewcars)
            {
                Console.WriteLine(item.Name); 
            }

            Console.ReadKey();

            /*
            Refueling r1 = new Refueling() { CarId = 2, Distance = 1200, Numberofliters = 70 };

            using (var uof = new UnitOfWork(new FuelContext()))
            {
                var lista = uof.CarRepository.CarsWithServiceDate();

                foreach (var element in lista)
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Next Service: {2}", element.Id, element.Name, element.NextService);
                }
            }
            */

            /*
            Console.WriteLine("Hello");

            CarsViewModel v1 = new CarsViewModel();
            List<Car> lista;

           lista = v1.GetAllCars();

            foreach (var item in lista)
            {
                Console.WriteLine("Nazwa: {0}", item.Name);
            }

                Console.ReadKey();
                */

            

        }
    }
}
