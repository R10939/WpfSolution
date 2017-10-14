using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfDempApp.Bindings
{
    public class Person: INotifyPropertyChanged
    {
        int _age;
        string _name;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public string Name{get{return _name;}
            set {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
