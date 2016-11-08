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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class CheckAccount2 : Page
    {
        public CheckAccount2()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            CheckAccount1 back = new CheckAccount1();
            this.NavigationService.Navigate(back);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            CheckAccount3 next = new CheckAccount3();
            this.NavigationService.Navigate(next);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {

        }

    }
}
