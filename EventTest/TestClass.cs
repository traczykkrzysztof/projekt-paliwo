using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    public class TestClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler PropertyNotChanged;

        public string SomeProperty
            {
                get
                {
                    return _someProperty;
                }
                set
                {
                    if (value == _someProperty)
                    {
                        OnPropertyNotChanged("_someProperty");
                    }
                    else
                    {
                        _someProperty = value;
                        OnPropertyChanged("_someProperty");
                    }  
                }

            }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyNotChanged(string propertyName)
        {
            PropertyNotChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _someProperty;
        

    }
}
