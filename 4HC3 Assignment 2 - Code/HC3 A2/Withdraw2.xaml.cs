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
    public partial class Withdraw2 : Page
    {
        private string account;

        public Withdraw2(string account)
        {
            InitializeComponent();

            this.account = account;
            accountLabel.Text = account;
        }

        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }
        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }
        private void buttonReleased2(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(0,0);
            b.RenderTransform = trans;
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

        private void back_click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            string amount = digitDisplay.Text;

            string[] testAmount = amount.Split('.');
            // Null and muliple decimal check
            if (amount.Length > 2 && testAmount.Length <= 2)
                // Continue to confirm page
                this.NavigationService.Navigate(new HC3_A2.Withdraw3(amount, account));
            else
                errorMsg.Visibility = Visibility.Visible;
        }
    }
}