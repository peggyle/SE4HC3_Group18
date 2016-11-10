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
    /// Interaction logic for changePin4.xaml
    /// </summary>
    public partial class changePin5 : Page
    {
        string pin1, pin2, pin3, pin4, pin;
        string oldpin;

        public changePin5(string oldpin)
        {
            InitializeComponent();

            this.oldpin = oldpin;
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            MainPage back = new MainPage();
            this.NavigationService.Navigate(back);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                errorMsgWrongPIN.Visibility = Visibility.Hidden;
                errorMsgWrongNum.Visibility = Visibility.Visible;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                pin = pin1 + pin2 + pin3 + pin4;
                if (oldpin == pin)
                {
                    errorMsgWrongNum.Visibility = Visibility.Hidden;
                    errorMsgWrongPIN.Visibility = Visibility.Visible;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                } else
                {
                    this.NavigationService.Navigate(new HC3_A2.changePin4(pin));
                }
                
            }
        }

        // Number pad
        private void number_click(object sender, RoutedEventArgs e)
        {
            errorMsgWrongNum.Visibility = Visibility.Collapsed;
            errorMsgWrongPIN.Visibility = Visibility.Collapsed;

            Button button = sender as Button;

            if (button.CommandParameter.ToString() == "BACK")
            {
                if (textBox4.Text.Length > 0)
                {
                    textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                    pin4 = "";
                }
                else if (textBox3.Text.Length > 0)
                {
                    textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                    pin3 = "";
                }
                else if (textBox2.Text.Length > 0)
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    pin2 = "";
                }
                else if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    pin1 = "";
                }
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
                pin1 = button.Content.ToString();
            }
            else if (textBox2.Text.Length == 0)
            {
                // textBox2.Text += button.Content.ToString();
                textBox2.Text += "♦";
                pin2 = button.Content.ToString();
            }
            else if (textBox3.Text.Length == 0)
            {
                // textBox3.Text += button.Content.ToString();
                textBox3.Text += "♦";
                pin3 = button.Content.ToString();
            }
            else if (textBox4.Text.Length == 0)
            {
                // textBox4.Text += button.Content.ToString();
                textBox4.Text += "♦";
                pin4 = button.Content.ToString();
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
        private void buttonReleased2(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            b.Effect = new System.Windows.Media.Effects.DropShadowEffect();
            TranslateTransform trans = new TranslateTransform(0, 0);
            b.RenderTransform = trans;
        }
    }
}
