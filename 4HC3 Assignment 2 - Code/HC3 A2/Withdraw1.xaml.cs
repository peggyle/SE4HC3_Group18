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
        public Withdraw1()
        {
            InitializeComponent();
        }




        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (comboBox.SelectedItem == saving)
            {
                this.NavigationService.Navigate(new HC3_A2.Wsaving());
            }

            if (comboBox.SelectedItem == chequing)
            {
                this.NavigationService.Navigate(new HC3_A2.Withdraw2());
            }

            if (comboBox.SelectedItem == other)
            {
                this.NavigationService.Navigate(new HC3_A2.Wother());
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