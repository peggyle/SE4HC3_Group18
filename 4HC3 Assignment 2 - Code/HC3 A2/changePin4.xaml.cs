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
    public partial class changePin4 : Page
    {
        string pin1, pin2, pin3, pin4;
        string bankNumber, pin, balance1, balance2, balance3;

        public changePin4()
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("./Resources/userinfo.txt");
            bankNumber = file.ReadLine();
            pin = file.ReadLine();
            balance1 = file.ReadLine();
            balance2 = file.ReadLine();
            balance3 = file.ReadLine();
            file.Close();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            changePin2 back = new changePin2();
            this.NavigationService.Navigate(back);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                errorMsgWrongNum.Visibility = Visibility.Visible;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("./Resources/userinfo.txt");

                pin = pin1 + pin2 + pin3 + pin4;

                file.WriteLine(bankNumber);
                file.WriteLine(pin);
                file.WriteLine(balance1);
                file.WriteLine(balance2);
                file.WriteLine(balance3);
                file.Close();

                this.NavigationService.Navigate(new HC3_A2.changePin3());
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
