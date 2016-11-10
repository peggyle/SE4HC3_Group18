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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Withdraw1 : Page
    {
        string bankNumber, pin;
        int balance1, balance2, balance3;

        public Withdraw1()
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = Convert.ToInt32(file.ReadLine());
            balance2 = Convert.ToInt32(file.ReadLine());
            balance3 = Convert.ToInt32(file.ReadLine());

            chequing.Content = String.Format("CHEQUING ACCOUNT - 4645516846 - {0:C2}", balance1);
            saving.Content = String.Format("SAVINGS ACCOUNT - 123654128 - {0:C2}", balance2);
            other.Content = String.Format("OTHER ACCOUNT - 678456484 - {0:C2}", balance3);
        }


        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (comboBox.SelectedItem == saving)
            {
                //this.NavigationService.Navigate(new HC3_A2.Wsaving());
                this.NavigationService.Navigate(new HC3_A2.Withdraw2(saving.Content.ToString()));
            }

            if (comboBox.SelectedItem == chequing)
            {
                this.NavigationService.Navigate(new HC3_A2.Withdraw2(chequing.Content.ToString()));
            }

            if (comboBox.SelectedItem == other)
            {
                //this.NavigationService.Navigate(new HC3_A2.Wother());
                this.NavigationService.Navigate(new HC3_A2.Withdraw2(other.Content.ToString()));
            }

            else

                errorMsg.Visibility = Visibility.Visible; 
          
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            
        }

       


    }

}
