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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Withdraw2 : Page
    {
        private string account;
        string balance1, balance2, balance3;
        double balance;

        public Withdraw2(string account)
        {
            InitializeComponent();

            this.account = account;
            accountLabel.Text = account;

            string accountString = account.Split(' ')[0].ToLower();
            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            file.ReadLine();
            file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            file.Close();

            if (accountString == "chequing")
            {
                balance = Convert.ToDouble(balance1);
            }
            else if (accountString == "savings")
            {
                balance = Convert.ToDouble(balance2);
            }
            else if (accountString == "other")
            {
                balance = Convert.ToDouble(balance3);
            }
            
            
        }

        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }
        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }
        private void buttonReleased2(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(0,0);
            b.RenderTransform = trans;
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            bool containsDecimal = digitDisplay.Text.Contains('.');

            errorMsgValid.Visibility = Visibility.Hidden;
            errorMsgLimit.Visibility = Visibility.Hidden;

            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "BACK":
                    if (digitDisplay.Text.Length > 2)
                        digitDisplay.Text = digitDisplay.Text.Remove(digitDisplay.Text.Length - 1);
                    break;

                case "NUMPAD.":
                    if (!containsDecimal)
                    {
                        if (digitDisplay.Text.Length == 2)
                            digitDisplay.Text += "0";
                        digitDisplay.Text += button.Content.ToString();
                    }
                        
                    break;

                default:
                    if (!containsDecimal || digitDisplay.Text.Split('.')[1].Length < 2)
                    {
                        digitDisplay.Text += button.Content.ToString();
                    }
                    break;
            }
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            string amount = digitDisplay.Text;

            if (amount.Length <= 2)
                // Null
                errorMsgValid.Visibility = Visibility.Visible;
            else if (Convert.ToDouble(amount.Substring(2)) > balance)
                // Higher amount than balance
                errorMsgLimit.Visibility = Visibility.Visible;
            else
                // Continue to confirm page
                this.NavigationService.Navigate(new HC3_A2.Withdraw3(amount, account));
        }
    }
}