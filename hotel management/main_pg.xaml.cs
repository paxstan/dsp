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
    /// Interaction logic for main_pg.xaml
    /// </summary>
    public partial class main_pg : Page
    {
        public main_pg()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString("h:mm tt");
            username_txt.Text+=entrypg.name;
        }

        private void frontdesk_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/front desk.xaml", UriKind.RelativeOrAbsolute));
        }

        private void fbpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/f_b.xaml", UriKind.RelativeOrAbsolute));
        }

        private void hkpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/hk.xaml", UriKind.RelativeOrAbsolute));
        }

        private void storepg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/stores.xaml", UriKind.RelativeOrAbsolute));
        }

        private void user_addpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/user.xaml", UriKind.RelativeOrAbsolute));
        }

        private void reportpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/report.xaml", UriKind.RelativeOrAbsolute));
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entrypg.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
