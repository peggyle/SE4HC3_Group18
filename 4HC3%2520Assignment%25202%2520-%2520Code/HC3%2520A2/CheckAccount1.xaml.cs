﻿using System;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CheckAccount1 : Page
    {
        public CheckAccount1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            CheckAccount2 p2 = new CheckAccount2();
            this.NavigationService.Navigate(p2);
        }
        private void button_click_1(object sender, RoutedEventArgs e)
        {
            CheckAccount2 p2 = new CheckAccount2();
            this.NavigationService.Navigate(p2);
        }
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

    }
}