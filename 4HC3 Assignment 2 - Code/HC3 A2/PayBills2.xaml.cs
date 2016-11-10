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
    public partial class PayBills2 : Page
    {
        private string fromAccount;
        private string toAccount;

        public PayBills2(string fromAccount, string toAccount )
        {
            InitializeComponent();

            this.fromAccount = fromAccount;
            this.toAccount = toAccount;

            textLabel.Text = "From " + fromAccount + "\nTo " + toAccount;
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e)
        {
            string amount = digitDisplay.Text;

            string[] testAmount = amount.Split('.');
            // Null and muliple decimal check
            if (amount.Length > 2 && testAmount.Length <= 2)
                // Continue to confirm page
                this.NavigationService.Navigate(new HC3_A2.PayBills3(fromAccount, toAccount, amount));
            else
                errorMsg.Visibility = Visibility.Visible;
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            // Return to account selection page
            this.NavigationService.Navigate(new HC3_A2.PayBills1());
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            bool containsDecimal = digitDisplay.Text.Contains('.');

            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "BACK":
                    errorMsg.Visibility = Visibility.Hidden;
                    if (digitDisplay.Text.Length > 2)
                        digitDisplay.Text = digitDisplay.Text.Remove(digitDisplay.Text.Length - 1);
                    break;

                case "NUMPAD.":
                    if (!containsDecimal)
                        digitDisplay.Text += button.Content.ToString();
                    else
                        errorMsg.Visibility = Visibility.Visible;
                    break;

                default:
                    if (!containsDecimal || digitDisplay.Text.Split('.')[1].Length < 2)
                    {
                        digitDisplay.Text += button.Content.ToString();
                        errorMsg.Visibility = Visibility.Hidden;
                    }
                    else
                        errorMsg.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }
        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }
    }
}
