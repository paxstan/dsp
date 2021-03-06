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

namespace hotel_management
{
    /// <summary>
    /// Interaction logic for f_b.xaml
    /// </summary>
    public partial class f_b : Page
    {
        public f_b()
        {
            InitializeComponent();
            username_txt.Text += entrypg.name;
            date.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void mainpg_call(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/main_pg.xaml", UriKind.RelativeOrAbsolute));
        }

        private void kotpg_call(object sender, RoutedEventArgs e)
        {
            fb_frame.Content = new kot();
        }

        private void logout(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/entrypg.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
