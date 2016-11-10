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
    /// Interaction logic for Page8.xaml
    /// </summary>
    public partial class Transfer1 : Page
    {
        List<string> accountOptions;
        string bankNumber, pin;
        double balance1, balance2, balance3;

        public Transfer1()
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
            accountOptions.Add(String.Format("CHEQUING ACCOUNT - 123654128 - {0:C2}", balance1));
            accountOptions.Add(String.Format("SAVINGS ACCOUNT - 4645516846 - {0:C2}", balance2));
            accountOptions.Add(String.Format("OTHER ACCOUNT - 678456484 - {0:C2}", balance3));

            fromDropdown.ItemsSource = accountOptions;
            toDropdown.ItemsSource = accountOptions;
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e) {
            Object fromAccount = fromDropdown.SelectedValue;
            Object toAccount = toDropdown.SelectedValue;

            // Null check
            if (fromAccount != null && toAccount != null)
                // Navigate to next page (choose amount page)
                this.NavigationService.Navigate(new HC3_A2.Transfer2( fromAccount.ToString(), toAccount.ToString() ));
            else
                // Display error
                errorMsg.Visibility = Visibility.Visible;
        }
        private void back_click(object sender, RoutedEventArgs e) {
            // Navigate to main page
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }

        // After choosing a from account, to account dropdown adjusts
        // from account list always complete, to account list changes
        private void fromSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            List<string> toOptions = new List<string>(accountOptions);
            string selectedOption = (sender as ComboBox).SelectedItem as string;
            toOptions.Remove(selectedOption);
            toDropdown.ItemsSource = toOptions;
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
