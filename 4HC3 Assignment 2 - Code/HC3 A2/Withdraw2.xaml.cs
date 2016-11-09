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
    public partial class Withdraw2 : Page
    {
        public Withdraw2()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

  


            private void number1_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 1;
        }

        private void number2_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 2;
        }

        private void number3_click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 3;
        }
        
        private void number4_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 4; 
        }

        private void number5_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 5;
        }

      

        private void number6_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 6;
        }

        private void number7_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 7;
        }

        private void number8_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 8;
        }

        private void number9_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 9;
        }

        private void number0_Click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + 0;
        }

        }

        private void number_click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text + "."; 
        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            digitDisplay.Text = digitDisplay.Text.Remove(digitDisplay.Text.Length - 1);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.Withdraw1()); 
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string amount = digitDisplay.Text; 
            this.NavigationService.Navigate(new HC3_A2.Withdraw3(amount));
        }

        private void TextFold(object sender, TextChangedEventArgs e)
        {

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
