using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfDempApp.Bindings
{
    class UserInfo : INotifyPropertyChanged
    {
        string _UserName;
        int _Age;
        string _FavColor;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public string FavColor
        {
            get
            {
                return _FavColor;
            }

            set
            {
                _FavColor = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FavColor"));
            }
        }
    }
}
