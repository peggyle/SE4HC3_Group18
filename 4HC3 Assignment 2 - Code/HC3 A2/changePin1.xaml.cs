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
    /// Interaction logic for changePin1.xaml
    /// </summary>
    public partial class changePin1 : Page
    {
        public changePin1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, RoutedEventArgs e)
        {
            CheckAccount1 back = new CheckAccount1();
            this.NavigationService.Navigate(back);
        }
        private void button_click_1(object sender, RoutedEventArgs e)
        {
            
            changePin2 next = new changePin2();
            this.NavigationService.Navigate(next);
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
/*
        private void checkBox_Checked1(object sender, RoutedEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked == false; checkBox3.Checked == false; checkBox4 == false;
            }
        }

        private void checkBox_Checked2(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_Checked3(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_Checked4(object sender, RoutedEventArgs e)
        {

        }*/
    }
}
