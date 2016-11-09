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

namespace TEST
{
    /// <summary>
    /// Interaction logic for changePin2.xaml
    /// </summary>
    public partial class changePin2 : Page
    {
        //int rowNum;
        public changePin2()
        {
           // this.rowNum = Int32.Parse(rowNum) - 1;
            InitializeComponent();
        }

        private void button2_click(object sender, RoutedEventArgs e)
        {
            changePin1 back = new changePin1();
            this.NavigationService.Navigate(back);
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            changePin3 confirm = new changePin3();
            this.NavigationService.Navigate(confirm);
        }
        private void number_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch (button.CommandParameter.ToString())
            {
                case "ENTER":
                    changePin3 p3 = new changePin3();
                    this.NavigationService.Navigate(p3);
                    break;

                case "BACK":
                    if (textBox1.Text.Length > 0)
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    if (textBox2.Text.Length > 0)
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    if (textBox3.Text.Length > 0)
                        textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                    if (textBox4.Text.Length > 0)
                        textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                    if (textBox5.Text.Length > 0)
                        textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                    if (textBox6.Text.Length > 0)
                        textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                    if (textBox7.Text.Length > 0)
                        textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                    if (textBox8.Text.Length > 0)
                        textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
                    break;

                default:
                    textBox1.Text += button.Content.ToString();
                    textBox2.Text += button.Content.ToString();
                    textBox3.Text += button.Content.ToString();
                    textBox4.Text += button.Content.ToString();
                    textBox5.Text += button.Content.ToString();
                    textBox6.Text += button.Content.ToString();
                    textBox7.Text += button.Content.ToString();
                    textBox8.Text += button.Content.ToString();
                    break;
            }
        }
    }
}
