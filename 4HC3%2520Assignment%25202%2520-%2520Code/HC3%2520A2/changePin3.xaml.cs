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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TEST
{
    /// <summary>
    /// Interaction logic for changePin3.xaml
    /// </summary>
    public partial class changePin3 : Page
    {
        public changePin3()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            changePin2 logout = new changePin2();
            this.NavigationService.Navigate(logout);
        }

        private void button_click_1(object sender, RoutedEventArgs e)
        {
            CheckAccount1 MoreActions = new CheckAccount1();
            this.NavigationService.Navigate(MoreActions);
        }

    }
}
