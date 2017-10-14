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

namespace WpfDempApp.Events
{
    /// <summary>
    /// Interaction logic for TurningEventWindow.xaml
    /// </summary>
    public partial class TurningEventWindow : Window
    {
        public TurningEventWindow()
        {
            InitializeComponent();
            Button1.PreviewMouseDown += Button1_PreviewMouseDown;
            InnerSt.PreviewMouseDown += InnerSt_PreviewMouseDown;
            RootSt.PreviewMouseDown += RootSt_PreviewMouseDown;
        }

        private void RootSt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("coming from Root ST");
        }

        private void InnerSt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("coming from Inner ST");
        }

        private void Button1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("coming from button");
        }

    }
}
