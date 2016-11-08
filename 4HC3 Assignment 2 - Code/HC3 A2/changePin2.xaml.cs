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
    /// Interaction logic for changePin2.xaml
    /// </summary>
    public partial class changePin2 : Page
    {
        public changePin2()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            changePin1 back = new changePin1();
            this.NavigationService.Navigate(back);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            changePin3 confirm = new changePin3();
            this.NavigationService.Navigate(confirm);
        }
        private void number_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "ENTER":
                    changePin3 p3 = new changePin3();
                    this.NavigationService.Navigate(p3);
                    break;

                case "BACK":
                    changePin3 p1 = new changePin3();
                    this.NavigationService.Navigate(p1);
                    break;

                default:
                   
                    break;
            }
        }
    }
}
