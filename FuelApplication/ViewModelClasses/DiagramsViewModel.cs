using Fuel.DAL.EF6;
using Fuel.DAL.EF6.Anonymous;
using Fuel.DAL.EF6.Infrastructure;
using Fuel.DAL.EF6.Contracts;
using Fuel.DataModel.Entities;
using FuelApplication.MainViewModel;
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



// ViewModel dla diagramów. W projekcie z "oknami" jest DiagramsView (GUI), dla którego ta klasa jest DataContextem. ViewModel jest logiką dla widoku i pośrednikiem między nim, a baza. Więcej info -> Wzorzec MVVM 

namespace FuelApplication.ViewModelClasses
{

    public class Punkt
    {
        public DateTime? Date { get; set; }
        public double Spalanie { get; set; }
    }

    public class DiagramsViewModel : RefuelingViewModel
    {
        public ObservableCollection<Punkt> Power { get; set; }
        public DiagramsViewModel()
        {
            canExecute = true;
            Power = new ObservableCollection<Punkt>();
            NextCarService = DateTime.Today;
            Combolist = GetCarsList();
            Name = "Wykresy";
            
        }

        private DateTime _Today = DateTime.Today;

        public DateTime Today { get { return _Today; }
            set
            {
                _Today = value;
            }
        }

        private Car _SelCar;
        public Car SelCar
        {
            get
            {
                return _SelCar;
            }
            set
            {
                _SelCar = value;
                OnPropertyChanged("carsbox1");
            }
        }

        private DateTime _DataPocz;
        public DateTime DataPocz
        {
            get
            {
                return _DataPocz;
            }
            set
            {
                _DataPocz = value;
                OnPropertyChanged("datepocz_text");
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

        public bool IsSelCar()
        {
            if (SelCar == null)
            {
                System.Windows.MessageBox.Show("Wybierz pojazd");
                return false;
            }
            else
            {
                return true;
            }
        }


        public void DodajElementyDoWykresu()
        {
            if (IsSelCar())
            {
                this.Power.Clear();
                RefuelingList = GetRefuelingList();
                foreach (var item in RefuelingList)
                {
                RefuelingEntry obj = item;
                    if (obj.carname == SelCar.Name && obj.date >= DataPocz.Date )
                    {
                        this.Power.Add(new Punkt() { Date = obj.date, Spalanie = obj.consumption });
                    }
                
                }
            }
            //Power.Add(new Punkt() { Date = new DateTime(2017, 1, 2), Spalanie = 6 });
            //Power.Add(new Punkt() { Date = new DateTime(2017, 1, 4), Spalanie = 2 });
            //Power.Add(new Punkt() { Date = new DateTime(2017, 1, 10), Spalanie = 4 });
            //Power.Add(new Punkt() { Date = new DateTime(2017, 1, 15), Spalanie = 6 });
        }

        public ICommand _OnClick;

        public ICommand OnClick
        {
            get
            {
                return _OnClick ?? (_OnClick = new CommandHelper(() => DodajElementyDoWykresu(), canExecute));
            }

        }
        //public ICommand OnClick
        //{
        //    get
        //    {
        //        //do danych wykresu ma przejść kolekcja z serwera

        //    }
        //    set
        //    {

        //    }
        //}


    }
}
