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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class EnterBankNumber : Page
    {
        string bankNumber;
        int bankNumberFlag;

        public EnterBankNumber()
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            file.ReadLine();
            file.ReadLine();
            file.ReadLine();
            file.ReadLine();
            bankNumberFlag = Convert.ToInt32(file.ReadLine());
            bankNumberFlag = 1;
            file.Close();
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            if (digitDisplay.Text.Length  == 12 )
            {
                if (digitDisplay.Text == bankNumber)
                    this.NavigationService.Navigate(new HC3_A2.EnterPIN(bankNumberFlag));
                else
                {
                    errorMsgWrongAcc.Visibility = Visibility.Visible;
                    digitDisplay.Text = "";
                }
            }
            else
            {
                errorMsgEmpty.Visibility = Visibility.Visible;
                //digitDisplay.Text = "";
            }
            
           
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            // Return to welcome page
            this.NavigationService.Navigate(new HC3_A2.InsertCard());
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            errorMsgEmpty.Visibility = Visibility.Collapsed;
            errorMsgWrongAcc.Visibility = Visibility.Collapsed;


            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "BACK":
                    if (digitDisplay.Text.Length > 0)
                        digitDisplay.Text = digitDisplay.Text.Remove(digitDisplay.Text.Length - 1);
                    break;

                default:
                    if (digitDisplay.Text.Length < 12)
                        digitDisplay.Text += button.Content.ToString();
                    break;
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
