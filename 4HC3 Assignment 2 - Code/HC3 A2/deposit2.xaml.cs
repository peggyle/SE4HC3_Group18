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
    /// Interaction logic for deposit2.xaml
    /// </summary>
    public partial class deposit2 : Page
    {
        string account;
        double depositAmount = 0;
        string bankNumber, pin, balance1, balance2, balance3;

        public deposit2(string account)
        {
            InitializeComponent();

            this.account = account;
            accountLabel.Text = account;

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            file.Close();
        }

        private void back_Button(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.deposit());
        }

        private void OkButton(object sender, RoutedEventArgs e)
        {
            if (depositAmount == 0)
            {
                depositAmount = randomDeposit();
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("./Resources/userinfo.txt");
            file.WriteLine(bankNumber);
            file.WriteLine(pin);

            string account1 = account.Split(' ')[0].ToLower();
            if (account1 == "chequing")
            {
                balance1 = Convert.ToString(Convert.ToDouble(balance1) + depositAmount);
            }
            else if (account1 == "savings")
            {
                balance2 = Convert.ToString(Convert.ToDouble(balance2) + depositAmount);
            }
            else if (account1 == "other")
            {
                balance3 = Convert.ToString(Convert.ToDouble(balance3) + depositAmount);
            }

            file.WriteLine(balance1);
            file.WriteLine(balance2);
            file.WriteLine(balance3);
            file.Close();
            this.NavigationService.Navigate(new HC3_A2.WithdrawDeposit4());
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

        private double randomDeposit()
        {
            Random rnd = new Random();
            double cash = Convert.ToDouble(rnd.Next(1, 50000))/100.0;
            return cash;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            depositAmount = randomDeposit();
            MessageBox.Show(String.Format("{0:C2} is being deposited!", depositAmount));
        }

      
    }

}