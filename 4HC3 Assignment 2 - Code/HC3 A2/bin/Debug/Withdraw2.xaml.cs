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

  


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 1; 
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 2; 
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 3;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 4;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 5;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 6;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 7;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 8;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 9;
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textbox.Text + 0;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            textbox.Clear();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.Withdraw3()); 
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.Withdraw3());
        }

        private void TextFold(object sender, TextChangedEventArgs e)
        {

        }
    }
}
