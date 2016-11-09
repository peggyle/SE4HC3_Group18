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
    /// Interaction logic for changePin1.xaml
    /// </summary>
    public partial class changePin1 : Page
    {
        public changePin1()
        {
            InitializeComponent();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }
        private void button_click_1(object sender, RoutedEventArgs e)
        {
            changePin2 next = new changePin2();
            this.NavigationService.Navigate(next);
        }
        private void button_Next(object sender, RoutedEventArgs e)
        {
            changePin2 next = new changePin2();
            this.NavigationService.Navigate(next);
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
