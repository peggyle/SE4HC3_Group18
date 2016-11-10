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
    public partial class LogOut : Page
    {
        System.Windows.Threading.DispatcherTimer timer;
        System.Windows.Threading.DispatcherTimer timerBeep;
        System.Media.SoundPlayer beepSound;

        public LogOut()
        {
            InitializeComponent();

            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += timerTick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            timer.Start();

            timerBeep = new System.Windows.Threading.DispatcherTimer();
            timerBeep.Tick += timerBeepTick;
            timerBeep.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timerBeep.Start();

            System.Windows.Media.Animation.DoubleAnimation anim = new System.Windows.Media.Animation.DoubleAnimation();
            anim.From = 0;
            anim.To = 75;
            anim.Duration = new Duration(TimeSpan.FromSeconds(2));
            anim.RepeatBehavior = System.Windows.Media.Animation.RepeatBehavior.Forever;

            TranslateTransform trans = new TranslateTransform();
            Arrow.RenderTransform = trans;

            trans.BeginAnimation(TranslateTransform.YProperty, anim);

        }

        private bool blink = false;
        private void timerTick(object sender, EventArgs e)
        {
            if (blink)
            {
                cardReminderLabel.Foreground = Brushes.Black;
            }
            else
            {
                cardReminderLabel.Foreground = Brushes.Red;
            }
            blink = !blink;
        }

        private void timerBeepTick(object sender, EventArgs e)
        {
            beepSound = new System.Media.SoundPlayer(Properties.Resources.beep_10);
            beepSound.Play();
        }

        private void insertCardClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timerBeep.Stop();
            this.NavigationService.Navigate(new HC3_A2.InsertCard());
        }
    }
}
