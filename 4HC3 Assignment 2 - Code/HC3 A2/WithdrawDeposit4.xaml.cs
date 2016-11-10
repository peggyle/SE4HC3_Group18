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
    public partial class WithdrawDeposit4 : Page
    {
        string bankNumber, pin, balance1, balance2, balance3;
        int bankNumberFlag;

        public WithdrawDeposit4()
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
  

        private void print(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The receipt has been printed out!");
        }

        private void transaction(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            if (bankNumberFlag == 1)
            {
                this.NavigationService.Navigate(new HC3_A2.LogOut2());
            }
            else
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
