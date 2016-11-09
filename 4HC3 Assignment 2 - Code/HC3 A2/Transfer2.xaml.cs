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
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Transfer2 : Page
    {
        private string fromAccount;
        private string toAccount;

        public Transfer2(string fromAccount, string toAccount )
        {
            InitializeComponent();

            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e) {
            string amount = digitDisplay.Text;

            // Null check
            if (amount.Length > 2)
                // Continue to confirm page
                this.NavigationService.Navigate(new HC3_A2.Transfer3(fromAccount, toAccount, amount));
            else
                errorMsg.Visibility = Visibility.Visible;
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            // Return to account selection page
            this.NavigationService.Navigate(new HC3_A2.Transfer1());
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "BACK":
                    if (digitDisplay.Text.Length > 2)
                        digitDisplay.Text = digitDisplay.Text.Remove(digitDisplay.Text.Length - 1);
                    break;

                default:
                    digitDisplay.Text += button.Content.ToString();
                    break;
            }
        }
    }
}
