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

        public CheckAccount1()
        {
            InitializeComponent();

            accountOptions = new List<string>();
            accountOptions.Add("SAVINGS ACCOUNT 123654128 - $2000.00");
            accountOptions.Add("CHEQUING ACCOUNT 4645516846 - $30000.00");
            accountOptions.Add("OTHER ACCOUNT 678456484 - $2554.00");

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
