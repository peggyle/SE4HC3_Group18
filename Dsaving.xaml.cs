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
    /// Interaction logic for Dsaving.xaml
    /// </summary>
    public partial class Dsaving : Page
    {
        public Dsaving()
        {
            InitializeComponent();
        }

        private void back_Button(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.deposit());
        }

        private void OkButton(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.WithdrawDeposit4());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }




        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }
        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }

    }
}
