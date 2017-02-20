using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FuelApplication.MainViewModel
{
    public class CommandHelper : ICommand
    {
        private Action _action;
        private bool _canExecute;

        public CommandHelper(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
            //Execute(this);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action(); 
        }

        public event EventHandler CanExecuteChanged; 

    }
}
