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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            backButton.PreviewMouseDown += backButtonPressed;
            backButton.PreviewMouseUp += backButtonReleased;
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            // Withdraw
            this.NavigationService.Navigate(new HC3_A2.Withdraw1());
        }
        private void click2(object sender, RoutedEventArgs e)
        {
            // Deposit
            this.NavigationService.Navigate(new HC3_A2.deposit());
        }
        private void click3(object sender, RoutedEventArgs e)
        {
            // Transfer
            this.NavigationService.Navigate(new HC3_A2.Transfer1());
        }
        private void click4(object sender, RoutedEventArgs e)
        {
            // Pay Bills
            this.NavigationService.Navigate(new HC3_A2.PayBills1());
        }
        private void click5(object sender, RoutedEventArgs e)
        {
            // Change PIN
            this.NavigationService.Navigate(new HC3_A2.changePin1());
        }
        private void click6(object sender, RoutedEventArgs e)
        {
            // Check Accounts
            this.NavigationService.Navigate(new HC3_A2.CheckAccount1());
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            
            // Exit to farewell page
            //this.NavigationService.Navigate(new HC3_A2.Page4());
        }

        private void backButtonPressed(object sender, RoutedEventArgs e)
        {
            backButton.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            backButton.RenderTransform = trans;
        }

        private void backButtonReleased(object sender, RoutedEventArgs e)
        {
            backButton.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            backButton.RenderTransform = trans;
        }
    }
}
