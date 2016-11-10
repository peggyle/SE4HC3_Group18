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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        string bankNumber, pin, balance1, balance2, balance3;
        int bankNumberFlag;

        public MainPage()
        {
            InitializeComponent();
            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            bankNumberFlag = Convert.ToInt32(file.ReadLine());
            file.Close();
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            // Withdraw
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }
        private void click2(object sender, RoutedEventArgs e)
        {
            // Deposit
            this.NavigationService.Navigate(new HC3_A2.deposit());
        }
        private void click3(object sender, RoutedEventArgs e)
        {
            // Transfer
            this.NavigationService.Navigate(new HC3_A2.Transfer1());
        }
        private void click4(object sender, RoutedEventArgs e)
        {
            // Pay Bills
            this.NavigationService.Navigate(new HC3_A2.PayBills1());
        }
        private void click5(object sender, RoutedEventArgs e)
        {
            // Check Accounts
            this.NavigationService.Navigate(new HC3_A2.CheckAccount1());
        }
        private void click6(object sender, RoutedEventArgs e)
        {
            // Change PIN
            this.NavigationService.Navigate(new HC3_A2.changePin2());
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            if (bankNumberFlag == 1)
            {
                this.NavigationService.Navigate(new HC3_A2.LogOut2());
            } else
            {
                // Exit to farewell page
                this.NavigationService.Navigate(new HC3_A2.LogOut());
            }
            
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
