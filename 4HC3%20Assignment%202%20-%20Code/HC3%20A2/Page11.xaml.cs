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
    /// Interaction logic for Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();
        }

        // Buttons
        private void print_click(object sender, RoutedEventArgs e) {
            // Open new window, simulates printing
            MessageBox.Show("Simulated printing of receipt");
        }
        private void logout_click(object sender, RoutedEventArgs e) { 
            // To logout/farewell page
        }
        private void more_click(object sender, RoutedEventArgs e) {
            // Return to main page
            this.NavigationService.Navigate(new HC3_A2.Page4());
        }
    }
}
