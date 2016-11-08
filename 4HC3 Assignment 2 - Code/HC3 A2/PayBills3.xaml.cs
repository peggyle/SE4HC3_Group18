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
    /// Interaction logic for Page10.xaml
    /// </summary>
    public partial class PayBills3 : Page
    {
        private string fromAccount;
        private string toAccount;
        private string amount;

        public PayBills3(string fromAccount, string toAccount, string amount)
        {
            InitializeComponent();

            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.amount = amount;

            amountLabel.Text = amount;
            fromAccountLabel.Text = fromAccount;
            toAccountLabel.Text = toAccount;
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e) {
            // Continue to success page
            this.NavigationService.Navigate(new HC3_A2.Page11());
        }
        private void back_click(object sender, RoutedEventArgs e) {
            // Return to amount selection page
            this.NavigationService.Navigate(new HC3_A2.Page9(fromAccount, toAccount));
        }
    }
}
