using Fuel.DAL.EF6.Anonymous;
using Fuel.DAL.EF6.Infrastructure;
using FuelApplication.MainViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fuel.DAL.EF6;

namespace FuelApplication.ViewModelClasses
{
    public class StaticticsViewModel : ViewModelBase
    {
        private int _entriescount;

        public int EntriesCount
        {
            get
            {
                return _entriescount;
            }
            set
            {
                _entriescount = GetNumberOfEntries();
                OnPropertyChanged("EntriesCount");
            }
        }

        private int _carscount;

        public int CarsCount
        {
            get
            {
                return _carscount;
            }
            set
            {
                _carscount = GetNumberOfCars();
                OnPropertyChanged("CarsCount");
            }
        }

        
        private float _averageconsumption;
        public float AverageConsumption
        {
            get
            {
                return _averageconsumption;
            }

            set
            {
                _averageconsumption = GetAverageConsumption();
                OnPropertyChanged("AverageConsumption");
            }
        }
        

        private string _carnamewithhighestconsumption;

        public string CarNameWithHighestConsumption
        {
            get
            {
                return _carnamewithhighestconsumption;
            }
            set
            {
                _carnamewithhighestconsumption = CarsWithAverageConsumption().OrderBy(x => x.averageconsumption).Select(x => x.groupname).LastOrDefault();
                //_carnamewithhighestconsumption = GetHighestConsumption().carname;
                OnPropertyChanged("CarNameWithHighestConsumption");
            }
        }


        private string _carnamewithlowestconsumption;

        public string CarNameWithLowestConsumption
        {
            get
            {
                return _carnamewithlowestconsumption;
            }
            set
            {
                //_carnamewithlowestconsumption = GetLowestConsumption().carname;
                _carnamewithlowestconsumption = CarsWithAverageConsumption().OrderBy(x => x.averageconsumption).Select(x => x.groupname).FirstOrDefault();
                OnPropertyChanged("CarNameWithLowestConsumption");
            }
        }


        private float _highestconsumption;

        public float HighestConsumption
        {
            get
            {
                return _highestconsumption;
            }
            set
            {
                _highestconsumption = GetHighestConsumption().consumption;
                OnPropertyChanged("HighestConsumption");
            }
        }

        private float _lowestconsumption;

        public float LowestConsumption
        {
            get
            {
                return _lowestconsumption;
            }
            set
            {
                _lowestconsumption = GetLowestConsumption().consumption;
                OnPropertyChanged("LowestConsumption");
            }
        }

        private List<CarGroup> _carswithconsumption; // zmienic na observable collection!

        public List<CarGroup> CarsWithConsumption
        {
            get
            {
                return _carswithconsumption;
            }
            set
            {
                _carswithconsumption = CarsWithAverageConsumption();
            }
        }

        public StaticticsViewModel()
        {
            AverageConsumption = GetAverageConsumption();
            CarNameWithHighestConsumption = GetHighestConsumption().carname;
            HighestConsumption = GetHighestConsumption().consumption;
            CarNameWithLowestConsumption = GetLowestConsumption().carname;
            LowestConsumption = GetLowestConsumption().consumption;
            EntriesCount = GetNumberOfEntries();
            CarsCount = GetNumberOfCars();
            CarsWithConsumption = CarsWithAverageConsumption();
            Name = "Statystyki";
        }
 
        public float GetAverageConsumption()
        {
            float averageconsumption;

            using (UnitOfWork uof = new UnitOfWork(new FuelContext()))
            {
                averageconsumption = uof.RefuelingRepository.GetRefuelingHistory().Average(x => x.consumption);
            }


            return averageconsumption;
        }
        
        public RefuelingEntry GetHighestConsumption()
        {
            RefuelingEntry refuelingentry = new RefuelingEntry();

            using (UnitOfWork uof = new UnitOfWork(new Fuel.DAL.EF6.FuelContext()))
            {
                refuelingentry = uof.RefuelingRepository.GetRefuelingHistory().Select(x => x).OrderByDescending(x => x.consumption).FirstOrDefault();
            }

            return refuelingentry;
        }

        public RefuelingEntry GetLowestConsumption()
        {
            RefuelingEntry refuelingentry = new RefuelingEntry();

            using (UnitOfWork uof = new UnitOfWork(new Fuel.DAL.EF6.FuelContext()))
            {
                refuelingentry = uof.RefuelingRepository.GetRefuelingHistory().Select(x => x).OrderByDescending(x => x.consumption).LastOrDefault();
            }

            return refuelingentry;
        }

        public List<CarGroup> CarsWithAverageConsumption()
        {
            List<RefuelingEntry> r;
            List<CarGroup> groupslist = new List<CarGroup>();

            using (UnitOfWork uof = new UnitOfWork(new Fuel.DAL.EF6.FuelContext()))
            {
                r = uof.RefuelingRepository.GetRefuelingHistory();
            }

            var collection = r.GroupBy(x => x.carname);

            foreach (var group in collection)
            {
                CarGroup cargroup = new CarGroup();
                cargroup.groupname = group.Key;
                cargroup.averageconsumption = group.ToList().Average(x => x.consumption);

                groupslist.Add(cargroup);
            }

            return groupslist;
        }

        public int GetNumberOfEntries()
        {
            using (UnitOfWork uof = new UnitOfWork(new FuelContext()))
            {
                return uof.RefuelingRepository.GetRefuelingHistory().Count;
            }
        }

        public int GetNumberOfCars()
        {
            using (UnitOfWork uof = new UnitOfWork(new FuelContext()))
            {
                return uof.CarRepository.GetAll().Count();
            }
        }
    }
}
