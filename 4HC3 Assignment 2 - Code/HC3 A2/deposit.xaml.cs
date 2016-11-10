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
    /// Interaction logic for deposit.xaml
    /// </summary>
    public partial class deposit : Page
    {
        List<string> accountOptions;

        public deposit()
        {
            InitializeComponent();

            accountOptions = new List<string>();
            accountOptions.Add("SAVINGS ACCOUNT 123654128 - $2000.00");
            accountOptions.Add("CHEQUING ACCOUNT 4645516846 - $30000.00");
            accountOptions.Add("OTHER ACCOUNT 678456484 - $2554.00");

            comboBox.ItemsSource = accountOptions;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Object account = comboBox.SelectedValue;

            /*
            if (comboBox.SelectedItem == saving)
            {
                this.NavigationService.Navigate(new HC3_A2.Dsaving());
            }


            if(comboBox.SelectedItem == chequing)
            {
                this.NavigationService.Navigate(new HC3_A2.deposit2());
            }

            if(comboBox.SelectedItem == other)
            {
                this.NavigationService.Navigate(new HC3_A2.Dother());
            }
            */
            if (account != null)
                this.NavigationService.Navigate(new HC3_A2.deposit2(account.ToString()));
            else
                errorMsg.Visibility = Visibility.Visible;
        }


        private void back_Button(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());

        }



        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }
        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void saving_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void other_Selected(object sender, RoutedEventArgs e)
        {
            
        }


    }
}
