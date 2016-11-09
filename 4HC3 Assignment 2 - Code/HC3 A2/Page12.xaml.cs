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
    /// Interaction logic for Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e)
        {
            // Navigate to next page (choose account number)
            this.NavigationService.Navigate(new HC3_A2.Page13());
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            // Navigate to choose accounts page
            this.NavigationService.Navigate(new HC3_A2.Page8());
        }

        private void keypress(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "BACK":
                    if (display.Text.Length > 0)
                        display.Text = display.Text.Remove(display.Text.Length - 1);
                    break;

                case "SPACE":
                    display.Text += " ";
                    break;

                default:
                    display.Text += button.Content.ToString();
                    break;
            }
        }
    }
}
