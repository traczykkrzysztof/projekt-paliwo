using Fuel.DAL.EF6;
using Fuel.DAL.EF6.Anonymous;
using Fuel.DAL.EF6.Infrastructure;
using Fuel.DataModel.Entities;
using FuelApplication.MainViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FuelApplication.ViewModelClasses
{
    public class RefuelingViewModel : MainViewModel.CarsViewModel
    {

        public RefuelingViewModel()
        {
            Combolist = GetCarsList();
            Distance = 100;
            NumberOfLiters = 6;
            _canExecute = true;
            RefuelingList = GetRefuelingList();
            Name = "Tankowanie";
        }
        private bool _canExecute { get; set; }
        private string _servicereminder;
        public string ServiceReminder
        {
            get
            {
                return _servicereminder;
            }
            set
            {
                _servicereminder = value;
            }
        }
        private float _distance;
        public float Distance
        {
            get
            {
                return _distance;
            }

            set
            {
                _distance = value;
                OnPropertyChanged("Distance");
            }
        }

        private DateTime? _refuelingdate;

        public DateTime? RefuelingDate
        {
            get
            {
                return _refuelingdate;
            }
            
            set
            {
                _refuelingdate = value;
                OnPropertyChanged("RefuelingDate");
            }
        }

        private float _numberofliters;
        public float NumberOfLiters
        {
            get
            {
                return _numberofliters;
            }
            set
            {
                _numberofliters = value;
                OnPropertyChanged("NumberOfLiters");
            }
        }

        private Car _selectedcar;
        public Car SelectedCar
        {
            get
            {
                return _selectedcar;
            }
            set
            {
                _selectedcar = value;
                ServiceReminder = NextServiceReminder();
                OnPropertyChanged("ServiceReminder");

            }
        }

        private ObservableCollection<RefuelingEntry> _refuelinglist = new ObservableCollection<RefuelingEntry>();

        public ObservableCollection<RefuelingEntry> RefuelingList
        {
            get
            {
                return _refuelinglist;
            }

            set
            {
                _refuelinglist = value;
                OnPropertyChanged("RefuelingList");
            }
        }

        private ICommand _addrefueling;

        public ICommand AddRefueling
        {

            get
            {
                return _addrefueling ?? (_addrefueling = new CommandHelper(() => SaveRefueling(), _canExecute));
            }


        }


        public ObservableCollection<RefuelingEntry> GetRefuelingList()
        {

            using (var uof = new UnitOfWork(new FuelContext()))
            {
                return uof.RefuelingRepository.GetObservableRefuelingHistory();
            }
        }

        public string GetSelectedCarName()
        {
            return SelectedCar.Name;
        }

        public string NextServiceReminder()
        {
            DateTime? time2 = SelectedCar.NextService;

            if (!time2.HasValue)
            {
                return "";
            }
            else
            {
                DateTime time1 = DateTime.Now;
                TimeSpan? result = time2 - time1;

                if (result.Value.TotalDays < 30)
                {
                    return "Przypomnienie: \n do przegladu zostalo mniej niz 30 dni";
                }
                else
                {
                    return "";
                }
            }
        }

        private ObservableCollection<Car> _combolist;

        public ObservableCollection<Car> Combolist
        {
            get
            {
                return _combolist;
            }

            set
            {
                _combolist = value;
                OnPropertyChanged("Combolist");
            }
        }

        public ObservableCollection<Car> GetCarsList()
        {
            using (var uof = new UnitOfWork(new FuelContext()))
            {
                return uof.CarRepository.GetObservableCollection();
            }
        }

        public bool IsSelectedCar()
        {
            if (SelectedCar == null)
            {
                MessageBox.Show("Wybierz pojazd");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SaveRefueling()
        {
            if (IsSelectedCar())
            {
                Refueling refueling = new Refueling();
                refueling.Distance = this.Distance;
                refueling.CarId = _selectedcar.Id;
                refueling.Numberofliters = this.NumberOfLiters;
                refueling.RefuelingDate = this.RefuelingDate;

                using (var uof = new UnitOfWork(new FuelContext()))
                {
                    uof.RefuelingRepository.Add(refueling);
                    uof.Complete();
                    MessageBox.Show("Tankowanie zapisane do bazy");
                }

                RefuelingList = GetRefuelingList();
                OnPropertyChanged("RefuelingList");
            }
        }
    }
}
