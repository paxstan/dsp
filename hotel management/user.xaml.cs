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
    /// Interaction logic for user_Add.xaml
    /// </summary>
    public partial class user_Add : Page
    {
        public user_Add()
        {
            InitializeComponent();
            username_txt.Text += entrypg.name;
            date.Text = DateTime.Now.ToString("h:mm tt");
        }
        private void mainpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/main_pg.xaml", UriKind.RelativeOrAbsolute));
        }

        private void adduserpg_call(object sender, RoutedEventArgs e)
        {
            user_frame.Content = new add_user();
        }

        private void deletepg_call(object sender, RoutedEventArgs e)
        {
            user_frame.Content = new del_user();
        }

        private void updatepg_call(object sender, RoutedEventArgs e)
        {
            user_frame.Content = new update();
        }
        private void logout(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entrypg.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
