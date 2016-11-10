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
    /// Interaction logic for LogOut.xaml
    /// </summary>
    public partial class WrongPIN : Page
    {
        string bankNumber, pin, balance1, balance2, balance3;
        int bankNumberFlag;
        System.Windows.Threading.DispatcherTimer timer;
        int count = 10;

        public WrongPIN(int bankNumberFlag)
        {
            InitializeComponent();
            this.bankNumberFlag = bankNumberFlag;

            timerLabel.Text = String.Format("Exiting in {0} seconds.", count);
            count--;

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            //bankNumberFlag = Convert.ToInt32(file.ReadLine());
            file.Close();

            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += timerTick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.Start();

        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            if (bankNumberFlag == 1)
                this.NavigationService.Navigate(new HC3_A2.LogOut2());
            else
                this.NavigationService.Navigate(new HC3_A2.LogOut());
        }

        private void buttonPressed(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = null;
            TranslateTransform trans = new TranslateTransform(3, 3);
            b.RenderTransform = trans;
        }
        private void buttonReleased(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(-3, -3);
            b.RenderTransform = trans;
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                timer.Stop();

                if (bankNumberFlag == 1)
                    this.NavigationService.Navigate(new HC3_A2.LogOut2());
                else
                    this.NavigationService.Navigate(new HC3_A2.LogOut());
            }
            else
            {
                if (count == 1)
                {
                    timerLabel.Text = String.Format("Exiting in {0} second.", count);
                }
                else
                {
                    timerLabel.Text = String.Format("Exiting in {0} seconds.", count);
                }
                count--;
            }

        }
    }
}
