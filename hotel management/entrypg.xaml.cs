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

namespace hotel_management
{
    /// <summary>
    /// Interaction logic for entrypg.xaml
    /// </summary>
    public partial class entrypg : Page
    {
        public static String name; 
        public entrypg()
        {
            InitializeComponent();
            
           
        }

        private void main_pg_call(object sender, RoutedEventArgs e)
        {
            entrypg.name = usernam.Text;
            NavigationService.Navigate(new Uri("/main_pg.xaml", UriKind.RelativeOrAbsolute));
        }

       
    }
}
