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
            if(textBox1.Text.Length==0 || textBox2.Text.Length == 0|| textBox3.Text.Length == 0|| textBox4.Text.Length == 0|| textBox5.Text.Length == 0|| textBox6.Text.Length == 0|| textBox7.Text.Length == 0|| textBox8.Text.Length == 0)
            {
                MessageBox.Show("Change PIN is not complete",
                 "Important Message");

            }else if(textBox1.Text== textBox5.Text&& textBox2.Text== textBox6.Text&& textBox3.Text== textBox7.Text&& textBox4.Text== textBox8.Text)
            {
                MessageBox.Show("You can not change to the same PIN",
                 "Important Message");
            }
            else
            { 
            changePin3 confirm = new changePin3();
            this.NavigationService.Navigate(confirm);
            }
        }
        private void number_click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            if (button.CommandParameter.ToString()== "BACK")
            {
                if(textBox8.Text.Length > 0) textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
                else if(textBox7.Text.Length > 0) textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                else if(textBox6.Text.Length > 0) textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
                else if(textBox5.Text.Length > 0) textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
                else if(textBox4.Text.Length > 0) textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                else if(textBox3.Text.Length > 0) textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
                else if(textBox2.Text.Length > 0) textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                else if(textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                else {
                    MessageBox.Show("No more to delete",
               "Important Message");
                }

            }
            else if (textBox1.Text.Length == 0)
            {
                textBox1.Text += button.Content.ToString();
            }
            else if(textBox2.Text.Length == 0)
            {
                textBox2.Text += button.Content.ToString();
            }
            else if (textBox3.Text.Length == 0)
            {
                textBox3.Text += button.Content.ToString();
            }
            else if (textBox4.Text.Length == 0)
            {
                textBox4.Text += button.Content.ToString();
            }
            else if (textBox5.Text.Length == 0)
            {
                textBox5.Text += button.Content.ToString();
            }
            else if (textBox6.Text.Length == 0)
            {
                textBox6.Text += button.Content.ToString();
            }
            else if (textBox7.Text.Length == 0)
            {
                textBox7.Text += button.Content.ToString();
            }
            else if (textBox8.Text.Length == 0)
            {
                textBox8.Text += button.Content.ToString();
            }
            else
            {
                MessageBox.Show("PIN can only be 4 digits.","Message");
            }
        }
        
    }
}
