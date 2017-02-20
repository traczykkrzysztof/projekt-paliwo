using FuelApplication.Contracts;
using FuelApplication.MainViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FuelApplication.ViewModelClasses
{
    public class FirstRunViewModel : ViewModelBase, IPageViewModel
    {
        public FirstRunViewModel()
        {
            IsCarsViewEnabled = false;
            IsCanvasVisible = true;
            Name = "FirstRun";
        }

        private bool _canExecute = true;

        private bool _iscanvasvisible;

        public bool IsCanvasVisible
        {
            get
            {
                return _iscanvasvisible;
            }

            set
            {
                _iscanvasvisible = value;
                OnPropertyChanged("IsCanvasVisible");
            }
        }

        private bool _iscarsviewenabled;
   
        public bool IsCarsViewEnabled
        {
            get
            {
                return _iscarsviewenabled;
            }

            set
            {
                _iscarsviewenabled = value;
                OnPropertyChanged("IsCarsViewEnabled");
            }
        }

        private ICommand _addfirstcar;

        public ICommand AddFirstCar
        {

            get
            {
                return _addfirstcar ?? (_addfirstcar = new CommandHelper(() => MakeCarsViewVisible(), _canExecute));
            }
        }

        public void MakeCarsViewVisible()
        {
            IsCarsViewEnabled = true;
            IsCanvasVisible = false;
        }


    }
}
