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
    /// Interaction logic for CheckAccount2.xaml
    /// </summary>
    public partial class CheckAccount2 : Page
    {
        public CheckAccount2()
        {
            InitializeComponent();
        }
        private void button_print_Click(object sender, RoutedEventArgs e)
        {
            CheckAccount3 p3 = new CheckAccount3();
            this.NavigationService.Navigate(p3);
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            CheckAccount1 p1 = new CheckAccount1();
            this.NavigationService.Navigate(p1);
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
