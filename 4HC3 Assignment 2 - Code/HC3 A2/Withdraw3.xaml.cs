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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Withdraw3 : Page
    {
    
        private string amount; 
        
        public Withdraw3(string amount)
        {
            InitializeComponent();
            
            this.amount = amount; 
            numberLabel.Text = amount; 
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.Withdraw2());
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
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
