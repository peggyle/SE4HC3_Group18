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
    public partial class InsertCard : Page
    {
        public InsertCard()
        {
            InitializeComponent();

            System.Windows.Media.Animation.DoubleAnimation anim = new System.Windows.Media.Animation.DoubleAnimation();
            anim.From = 75;
            anim.To = 0;
            anim.Duration = new Duration(TimeSpan.FromSeconds(2));
            anim.RepeatBehavior = System.Windows.Media.Animation.RepeatBehavior.Forever;

            TranslateTransform trans = new TranslateTransform();
            Arrow.RenderTransform = trans;

            trans.BeginAnimation(TranslateTransform.YProperty, anim);
        }

        private void beep(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer beepSound = new System.Media.SoundPlayer(Properties.Resources.Beep);
            beepSound.Play();
        }

        private void insertCardClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.MainPage());
        }
        private void bankEntryClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HC3_A2.EnterPIN());
        }
    }
}
