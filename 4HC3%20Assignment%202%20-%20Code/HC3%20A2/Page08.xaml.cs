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
    public partial class Page8 : Page
    {
        List<string> accountOptions;

        public Page8()
        {
            InitializeComponent();

            accountOptions = new List<string>();
            accountOptions.Add("Chequings - $ 123,456,789.01");
            accountOptions.Add("Savings 1 - $ 123,456,789.01");
            accountOptions.Add("Savings 2 - $ 111,111,111.11");
            /*
            accountOptions.Add("Pay bill - CREDIT CARD COMPANY");
            accountOptions.Add("Pay bill - GAS AND HYDRO COMPANY");
            accountOptions.Add("Email money - NAME@DOMAIN.COM");
            accountOptions.Add("Email money - NAME2@DOMAIN.COM");
            */

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
                this.NavigationService.Navigate(new HC3_A2.Page9( fromAccount.ToString(), toAccount.ToString() ));
            else
                // Display error
                errorMsg.Visibility = Visibility.Visible;
        }
        private void back_click(object sender, RoutedEventArgs e) {
            // Navigate to main page
            this.NavigationService.Navigate(new HC3_A2.Page4());
        }
        /*
        private void newPayee_click(object sender, RoutedEventArgs e) {
            // Navigate to add payee page
            this.NavigationService.Navigate(new HC3_A2.Page12());
        }
        private void newEmail_click(object sender, RoutedEventArgs e) {
            // Navigate to add email page
        }
        */

        // After choosing a from account, to account dropdown adjusts
        // from account list always complete, to account list changes
        private void fromSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            List<string> toOptions = new List<string>(accountOptions);
            string selectedOption = (sender as ComboBox).SelectedItem as string;
            toOptions.Remove(selectedOption);
            toDropdown.ItemsSource = toOptions;
        }
    }
}
