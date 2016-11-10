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
    public partial class Transfer3 : Page
    {
        private string fromAccount;
        private string toAccount;
        private string amount;
        string bankNumber, pin, balance1, balance2, balance3;

        public Transfer3(string fromAccount, string toAccount, string amount)
        {
            InitializeComponent();

            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
            this.amount = amount;

            amountLabel.Text = String.Format("{0:C2}",Convert.ToDouble(amount.Substring(2)));
            fromAccountLabel.Text = fromAccount;
            toAccountLabel.Text = toAccount;

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            file.Close();
        }

        // Buttons
        private void ok_click(object sender, RoutedEventArgs e) {
            System.IO.StreamWriter file = new System.IO.StreamWriter("./Resources/userinfo.txt");
            file.WriteLine(bankNumber);
            file.WriteLine(pin);

            string account1 = fromAccount.Split(' ')[0].ToLower();
            string account2 = toAccount.Split(' ')[0].ToLower();
            if (account1 == "chequing")
            {
                balance1 = Convert.ToString(Convert.ToInt32(balance1) - Convert.ToInt32(amount.Substring(2)));
            }
            else if (account1 == "savings")
            {
                balance2 = Convert.ToString(Convert.ToInt32(balance2) - Convert.ToInt32(amount.Substring(2)));
            }
            else if (account1 == "other")
            {
                balance3 = Convert.ToString(Convert.ToInt32(balance3) - Convert.ToInt32(amount.Substring(2)));
            }

            if (account2 == "chequing")
            {
                balance1 = Convert.ToString(Convert.ToInt32(balance1) + Convert.ToInt32(amount.Substring(2)));
            }
            else if (account2 == "savings")
            {
                balance2 = Convert.ToString(Convert.ToInt32(balance2) + Convert.ToInt32(amount.Substring(2)));
            }
            else if (account2 == "other")
            {
                balance3 = Convert.ToString(Convert.ToInt32(balance3) + Convert.ToInt32(amount.Substring(2)));
            }

            file.WriteLine(balance1);
            file.WriteLine(balance2);
            file.WriteLine(balance3);
            file.Close();
            // Continue to success page
            this.NavigationService.Navigate(new HC3_A2.WithdrawDeposit4());
        }
        private void back_click(object sender, RoutedEventArgs e) {
            // Return to amount selection page
            this.NavigationService.Navigate(new HC3_A2.Transfer2(fromAccount, toAccount));
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
