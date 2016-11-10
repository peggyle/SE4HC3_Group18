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
    public partial class EnterPIN : Page
    {
        public EnterPIN()
        {
            InitializeComponent();
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                errorMsg.Visibility = Visibility.Visible;

            else
                this.NavigationService.Navigate(new HC3_A2.MainPage());
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
            // Return to welcome page
            this.NavigationService.Navigate(new HC3_A2.InsertCard());
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button.CommandParameter.ToString() == "BACK")
            {
                if (textBox4.Text.Length > 0) textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                else if (textBox3.Text.Length > 0) textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                else if (textBox2.Text.Length > 0) textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                else if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                /*
                else
                {
                    MessageBox.Show("No more to delete",
               "Important Message");
                }
                */
            }
            else if (textBox1.Text.Length == 0)
            {
                // textBox1.Text += button.Content.ToString();
                textBox1.Text += "♦";
            }
            else if (textBox2.Text.Length == 0)
            {
                // textBox2.Text += button.Content.ToString();
                textBox2.Text += "♦";
            }
            else if (textBox3.Text.Length == 0)
            {
                // textBox3.Text += button.Content.ToString();
                textBox3.Text += "♦";
            }
            else if (textBox4.Text.Length == 0)
            {
                // textBox4.Text += button.Content.ToString();
                textBox4.Text += "♦";
            }
            /*
            else
            {
                MessageBox.Show("PIN can only be 4 digits.", "Message");
            }
            */
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
