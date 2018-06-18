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
    /// Interaction logic for front_desk.xaml
    /// </summary>
    public partial class front_desk : Page
    {
        public front_desk()
        {
            InitializeComponent();
            username_txt.Text += entrypg.name;
            date.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void infopg_call(object sender, RoutedEventArgs e)
        {
            frontdesk_frame.Content = new info1();
        }

        private void checkinpg_call(object sender, RoutedEventArgs e)
        {
            frontdesk_frame.Content = new checkin1();
        }

        private void checkout_pg(object sender, RoutedEventArgs e)
        {
            frontdesk_frame.Content = new checkout1();
        }

        private void ocuupancypg_call(object sender, RoutedEventArgs e)
        {
            frontdesk_frame.Content = new occupancy_front();
        }

        private void mainpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/main_pg.xaml", UriKind.RelativeOrAbsolute));
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entrypg.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
