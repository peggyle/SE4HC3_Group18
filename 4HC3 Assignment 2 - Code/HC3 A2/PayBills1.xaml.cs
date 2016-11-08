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
    public partial class PayBills1 : Page
    {
        List<string> accountOptions;
        List<string> payeeOptions;

        public PayBills1()
        {
            InitializeComponent();

            accountOptions = new List<string>();
            accountOptions.Add("Chequings - $ 123,456,789.01");
            accountOptions.Add("Savings 1 - $ 123,456,789.01");
            accountOptions.Add("Savings 2 - $ 111,111,111.11");

            payeeOptions = new List<string>();
            payeeOptions.Add("UTILITIES COMPANY - 11111111");
            payeeOptions.Add("MCMASTER UNIVERSITY - 001208224");
            payeeOptions.Add("CREDIT CARD COMPANY - 22222222");
            payeeOptions.Add("OTHER CREDIT CARD COMPANY - 33333333");

            fromDropdown.ItemsSource = accountOptions;
            toDropdown.ItemsSource = payeeOptions;
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
    }
}
