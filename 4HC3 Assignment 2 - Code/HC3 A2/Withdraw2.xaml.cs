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

        private void back_click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            if (digitDisplay.Text.Length > 2)
            {
                string amount = digitDisplay.Text;
                this.NavigationService.Navigate(new HC3_A2.Withdraw3(amount, account));
            }

            else
                errorMsg.Visibility = Visibility.Visible; 
           
        }
       
    }
}