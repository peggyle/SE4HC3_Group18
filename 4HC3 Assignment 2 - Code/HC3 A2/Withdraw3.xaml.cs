﻿using System;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Withdraw3 : Page
    {

        string bankNumber, pin, balance1, balance2, balance3, bankNumberFlag;
        private string amount;
        private string account;
        
        public Withdraw3(string amount, string account)
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            bankNumberFlag = file.ReadLine();
            file.Close();

            this.amount = amount;
            this.account = account;
            numberLabel.Text = String.Format("{0:C2}", Convert.ToDouble(amount.Substring(2)));
            accountLabel.Text = account;
            /*
            if (account == "chequing")
            {
                accountLabel.Text = "Chequing Account";
            }
            else if (account == "savings")
            {
                accountLabel.Text = "Savings Account";
            }
            else if (account == "other")
            {
                accountLabel.Text = "Other Account";
            }
            */
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.Withdraw2(account));
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("./Resources/userinfo.txt");
            file.WriteLine(bankNumber);
            file.WriteLine(pin);

            string accountString = account.Split(' ')[0].ToLower();

            if (accountString == "chequing")
            {
                file.WriteLine(Convert.ToDouble(balance1) - Convert.ToDouble(amount.Substring(2)));
                file.WriteLine(balance2);
                file.WriteLine(balance3);
            }
            else if (accountString == "savings")
            {
                file.WriteLine(balance1);
                file.WriteLine(Convert.ToDouble(balance2) - Convert.ToDouble(amount.Substring(2)));
                file.WriteLine(balance3);
            }
            else if (accountString == "other")
            {
                file.WriteLine(balance1);
                file.WriteLine(balance2);
                file.WriteLine(Convert.ToDouble(balance3) - Convert.ToDouble(amount.Substring(2)));
            }
            file.WriteLine(bankNumberFlag);
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


    }
}
