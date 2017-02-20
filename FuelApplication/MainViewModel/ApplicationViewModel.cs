using Fuel.DAL.EF6.Infrastructure;
using FuelApplication.Contracts;
using FuelApplication.ViewModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Fuel.DAL.EF6;

namespace FuelApplication.MainViewModel
{
    public class ApplicationViewModel : ViewModelBase
    {
        
        private List<IPageViewModel> _viewmodelslist;
        private IPageViewModel _currentviewmodel { get; set; }
        private ICommand _changeviewmodelcommand;

        public ApplicationViewModel()
        {
            OnStart();
        }


       
        public void OnStart()
        {
            bool IsEmptyCarList;
            bool IsEmptyRefuelingList;

            using (var uof = new UnitOfWork(new FuelContext()))
            {
                IsEmptyCarList = uof.CarRepository.IsEmpty();
                IsEmptyRefuelingList = uof.RefuelingRepository.IsEmpty();   
            }

            if (IsEmptyCarList && IsEmptyRefuelingList)
            {
                ViewModelsList.Add(new FirstRunViewModel());
                CurrentViewModel = ViewModelsList.FirstOrDefault(x => x.Name == "FirstRun");
            }
            else if (IsEmptyRefuelingList)
            {
                ViewModelsList.Add(new CarsViewModel());
                ViewModelsList.Add(new RefuelingViewModel());
                CurrentViewModel = ViewModelsList.FirstOrDefault(x => x.Name == "Tankowanie");
            }
            else
            {
                ViewModelsList.Add(new CarsViewModel());
                ViewModelsList.Add(new RefuelingViewModel());
                ViewModelsList.Add(new StaticticsViewModel());
                ViewModelsList.Add(new DiagramsViewModel());
                CurrentViewModel = ViewModelsList.FirstOrDefault(x => x.Name == "Tankowanie");
            }

        }
        

        public List<IPageViewModel> ViewModelsList
        {
            get
            {
                if (_viewmodelslist == null)
                {
                    _viewmodelslist = new List<IPageViewModel>();
                }
                return _viewmodelslist;
            }
        }
        
        public IPageViewModel CurrentViewModel
        {
            get
            {
                return _currentviewmodel;
            }

            set
            {
                _currentviewmodel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public void ChangeViewModel(IPageViewModel viewmodel)
        {
            if (!ViewModelsList.Contains(viewmodel))
            {
                ViewModelsList.Add(viewmodel);
            }
            CurrentViewModel = ViewModelsList.FirstOrDefault(x => x == viewmodel);
        }

        public ICommand ChangeViewModelCommand
        {
            get
            {
                return _changeviewmodelcommand ?? (_changeviewmodelcommand = new RelayCommand(x => ChangeViewModel((IPageViewModel)x), x => x is IPageViewModel));
            }
        }

    }
}
