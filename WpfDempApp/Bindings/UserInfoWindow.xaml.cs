using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Collections.ObjectModel;

namespace WpfDempApp.Bindings
{
    /// <summary>
    /// Interaction logic for UserInfoWindow.xaml
    /// </summary>
    public partial class UserInfoWindow : Window
    {
        ObservableCollection<UserInfo> _userList;

        public UserInfoWindow()
        {
            InitializeComponent();
            Loaded += UserInfoWindow_Loaded;
        }
        private void UserInfoWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _userList = new ObservableCollection<UserInfo>();
            _userList.Add(new Bindings.UserInfo { UserName = "Snowy", Age = 28, FavColor = "Orange" });
            _userList.Add(new Bindings.UserInfo { UserName = "Titan", Age = 21, FavColor = "Red" });
            _userList.Add(new Bindings.UserInfo { UserName = "John", Age = 27, FavColor = "Purple" });

            this.DataContext = _userList;
            
        }

        private void AddNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            _userList.Add(new Bindings.UserInfo { UserName = UserNameTextbox.Text, Age = Convert.ToInt32(AgeTextbox.Text)  , FavColor = FavColorTextbox.Text });
        }

    }
}
