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
    /// Interaction logic for hk.xaml
    /// </summary>
    public partial class hk : Page
    {
        public hk()
        {
            InitializeComponent();
            username_txt.Text += entrypg.name;
            date.Text = DateTime.Now.ToString("h:mm tt");
        }
        private void mainpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/main_pg.xaml", UriKind.RelativeOrAbsolute));
        }
        private void rblockpg_call(object sender, RoutedEventArgs e)
        {
            hk_frame.Content = new rblock();
        }

        private void occupancypg_call(object sender, RoutedEventArgs e)
        {
            hk_frame.Content = new occupancy_front();
        }

        private void rmaintainpg_call(object sender, RoutedEventArgs e)
        {
            hk_frame.Content = new rmaintain();
        }

        private void releasepg_call(object sender, RoutedEventArgs e)
        {
            hk_frame.Content = new rrelease();
        }

        private void laundrypg_call(object sender, RoutedEventArgs e)
        {
            hk_frame.Content = new laundry();
        }
        private void logout(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entrypg.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
