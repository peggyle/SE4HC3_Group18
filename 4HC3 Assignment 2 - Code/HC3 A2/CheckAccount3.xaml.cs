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

namespace HC3_A2
{
    /// <summary>
    /// Interaction logic for CheckAccount3.xaml
    /// </summary>
    public partial class CheckAccount3 : Page
    {
        public CheckAccount3()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            LogOut logout = new LogOut();
            this.NavigationService.Navigate(logout);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            MainPage MoreActions = new MainPage();
            this.NavigationService.Navigate(MoreActions);
        }

    }
}
