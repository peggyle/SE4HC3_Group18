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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CheckAccount1 : Page
    {
        List<string> accountOptions;
        string bankNumber, pin;
        double balance1, balance2, balance3;

        public CheckAccount1()
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = Convert.ToDouble(file.ReadLine());
            balance2 = Convert.ToDouble(file.ReadLine());
            balance3 = Convert.ToDouble(file.ReadLine());
            file.Close();

            accountOptions = new List<string>();
            accountOptions.Add(String.Format("CHEQUING ACCOUNT - 4645516846 - {0:C2}", balance1));
            accountOptions.Add(String.Format("SAVINGS ACCOUNT - 123654128 - {0:C2}", balance2));
            accountOptions.Add(String.Format("OTHER ACCOUNT - 678456484 - {0:C2}", balance3));

            accountDropdown.ItemsSource = accountOptions;
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            MainPage p2 = new MainPage();
            this.NavigationService.Navigate(p2);
        }
        private void button_click_1(object sender, RoutedEventArgs e)
        {
            Object account = accountDropdown.SelectedValue;

            // Null check
            if (account != null)
                // Navigate to next page (view statement)
                this.NavigationService.Navigate(new HC3_A2.CheckAccount2(account.ToString()));
            else
                // Display error
                errorMsg.Visibility = Visibility.Visible;
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
