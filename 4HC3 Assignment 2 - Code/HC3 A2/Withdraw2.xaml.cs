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

        private void delete_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1);

        }


        private void number1_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 1; 
        }

        private void number_2click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 2; 
        }

        private void number3_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 3; 
        }

        private void number4_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 4; 
        }

        private void number5_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 5; 
        }

        private void number6_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 6; 
        }

        private void number7_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 7; 
        }

        private void number8_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 8; 
        }

        private void number9_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 9; 
        }

        private void number0_click(object sender, RoutedEventArgs e)
        {
            display.Text = display.Text + 0; 
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
             
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            string amount = display.Text;
            this.NavigationService.Navigate(new HC3_A2.Withdraw3(amount));
        }











       
    }
}