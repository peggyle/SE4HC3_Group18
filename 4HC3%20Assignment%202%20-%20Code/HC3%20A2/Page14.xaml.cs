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
    /// Interaction logic for Page14.xaml
    /// </summary>
    public partial class Page14 : Page
    {
        public Page14()
        {
            InitializeComponent();
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            // return to transfer page
            this.NavigationService.Navigate(new HC3_A2.Page8());
        }
    }
}
