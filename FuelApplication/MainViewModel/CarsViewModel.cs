using Fuel.DAL.EF6;
using Fuel.DAL.EF6.Infrastructure;
using Fuel.DataModel.Entities;
using Fuel.DataModel.Enums;
using FuelApplication.ViewModelClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FuelApplication.MainViewModel
{
    public class CarsViewModel : ViewModelBase
    {

       
        private bool _canExecute;

        public bool canExecute { get { return _canExecute; } set{ }}
        

        public CarsViewModel()
        {
            viewcars = GetCollection();
            _canExecute = true;
            NextCarService = DateTime.Today;
            CarName = "wpisz nazwe";
            enginetypes = GetEngineTypeList();
            SelectedEngineType = GetEngineTypeList().FirstOrDefault();
            popupopen = false;
            Name = "Pojazdy";
            AreButtonsActivated = true;
        }


        private bool _popupopen;

        public bool popupopen
        {
            get
            {
                return _popupopen;
            }

            set
            {
                _popupopen = value;
                OnPropertyChanged("popupopen");
            }
        }

        private bool _arebuttonsactivated;

        public bool AreButtonsActivated
        {
            get
            {
                return _arebuttonsactivated;
            }

            set
            {
                _arebuttonsactivated = value;
                OnPropertyChanged("arebuttonsactivated");
            }
        }

        private ObservableCollection<Car> _viewcars { get; set; }
      
        public ObservableCollection<Car> viewcars
        {
            get
            { 
                return _viewcars;
            }

            set
            {
                _viewcars = value;
                OnPropertyChanged("viewcars");
            }
        }

        public IEnumerable<string> enginetypes { get; set; } 

        private string _CarName;
        public string CarName
        {
            get
            {
                return _CarName;
            }

            set
            {
                _CarName = value;
                OnPropertyChanged("CarName");
            }
        }


        private DateTime? _NextCarService;

        public DateTime? NextCarService
        {
            get
            {
                return _NextCarService;
            }

            set
            {
                _NextCarService = value;
                OnPropertyChanged("NextCarService");
            }
        }

        private Car _selectedcar;

        public Car selectedcar
        {
            get
            {
                return _selectedcar;
            }

            set
            {
                _selectedcar = value;
            }
        }
            
        private string _selectedenginetype;

        public string SelectedEngineType
        {
            get
            {
                return _selectedenginetype;
            }

            set
            {
                _selectedenginetype = value; 
                OnPropertyChanged("SelectedEngineType");
            }
        }
               
           


        private ICommand _AddCar;

        public ICommand AddCar
        {
            
            get
            {
                return _AddCar ?? (_AddCar = new CommandHelper(() => AddCartoCollection(CarName, NextCarService, SelectedEngineType), _canExecute));
            }
            

        }

        private ICommand _deletecar;

        public ICommand DeleteCar
        {
            get
            {
                return _deletecar ?? (_deletecar = new CommandHelper(() => DeleteCarFromCollection(), _canExecute));
            }
             
        }

        private ICommand _editcar;

        public ICommand EditCar
        {
            get
            {
                return _editcar ?? (_editcar = new CommandHelper(() => EnableEditPopup(), _canExecute));
            }
        }

        private ICommand _doubleclick;

        public ICommand DoubleClick
        {
            get
            {
                return _doubleclick ?? (_doubleclick = new CommandHelper(() => GridDoubleClick(), _canExecute));
            }
        }

        private ICommand _cancelpopup;

        public ICommand CancelPopup
        {
            get
            {
                return _cancelpopup ?? (_cancelpopup = new CommandHelper(() => CancelButtonPopup(), _canExecute));
            }
        }

        private ICommand _confirmpopup;

        public ICommand ConfirmPopup
        {
            get
            {
                return _confirmpopup ?? (_confirmpopup = new CommandHelper(() => ConfirmButtonPopup(), _canExecute));
            }
        }

        private void EnableButtons()
        {
            AreButtonsActivated = true;
            OnPropertyChanged("AreButtonsActivated");
        }

        private void DisableButtons()
        {
            AreButtonsActivated = false;
            OnPropertyChanged("AreButtonsActivated");
        }


        public ObservableCollection<Car> GetCollection() // laczy sie z repozytorium i zwraca ObservableCollection<Car>.
        {
            using (var uof = new UnitOfWork(new FuelContext()))
            {
                return uof.CarRepository.GetObservableCollection();
            }
        }

        public IEnumerable<string> GetEngineTypeList()
        {
            return Enum.GetNames(typeof(Engine)).ToList();
        }

        private bool IsSelectedCar()
        {
            if (selectedcar == null)
            {
                MessageBox.Show("Zaden pojazd nie zostal zaznaczony");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddCartoCollection(string carName, DateTime? NextCarService, string SelectedEngineType)
        {
            if (carName == null || carName == "")
            {
                MessageBox.Show("Nazwa nie moze byl null", "Paliwko ->> Komunikat");
            }
            else
            {
                Car car = new Car();
                car.Name = carName;
                car.NextService = NextCarService;
                car.EngineType = (Engine)Enum.Parse(typeof(Engine), SelectedEngineType);

                using (var uof = new UnitOfWork(new FuelContext())) 
                {
                    uof.CarRepository.Add(car);
                    uof.Complete();
                }

                viewcars = GetCollection(); // wywoluje funkcje GetCollection i ponownie przypisuje do niej obiekt viewcars

                //MessageBox.Show(viewcars.LastOrDefault().Name);
            }
        }

        public void ShouldCloseApp(bool IsEmpty)
        {
            if (IsEmpty)
            {
                MessageBox.Show("Brak rekordów w bazie. Program zostanie zamknięty. Uruchom aplikację ponownie.");
                Application.Current.Shutdown();
            }
        }

        public void DeleteCarFromCollection()
        {
            bool IsCarListEmpty;

            if(IsSelectedCar())
            {
                using (var uof = new UnitOfWork(new FuelContext()))
                {
                    uof.CarRepository.Delete(selectedcar.Id);
                    uof.Complete();
                    IsCarListEmpty = uof.CarRepository.IsEmpty();
                }
                MessageBox.Show("Pojazd " + selectedcar.Name + " zostal usuniety z bazy ");
                viewcars = GetCollection();
                ShouldCloseApp(IsCarListEmpty);
                
            }
        }

        public void EnableEditPopup()
        {
            if (IsSelectedCar())
            {
                popupopen = true;
                DisableButtons();
                OnPropertyChanged("popupopen");
            }
        }

        public void CancelButtonPopup()
        {
            popupopen = false;
            EnableButtons();
            OnPropertyChanged("popupopen");
        }

        public void ConfirmButtonPopup()
        {
            if (IsSelectedCar())
            {
                using (var uof = new UnitOfWork(new FuelContext()))
                {
                    Car temp = uof.CarRepository.GetItem(selectedcar.Id);
                    temp.Name = CarName;
                    temp.NextService = NextCarService;
                    temp.EngineType = (Engine)Enum.Parse(typeof(Engine), SelectedEngineType);
                    uof.Complete();
                }

                viewcars = GetCollection();
                EnableButtons();
                popupopen = false;
            }
        }

        /*
        public void EditSelectedCar()
        {
            if (IsSelectedCar())
            {
                using (var uof = new UnitOfWork(new FuelContext()))
                {
                  Car temp = uof.CarRepository.GetItem(selectedcar.Id);
                    temp.Name = CarName;
                    temp.NextService = NextCarService;
                    uof.Complete();
                }

                viewcars = GetCollection();
            }
        }
       */
        public void GridDoubleClick()
        {
            CarName = selectedcar.Name;
            NextCarService = selectedcar.NextService;
            SelectedEngineType = selectedcar.EngineType.ToString();

            OnPropertyChanged("CarName");
            OnPropertyChanged("NextCarService");
            OnPropertyChanged("SelectedEngineType");
        }

       

    }
}
