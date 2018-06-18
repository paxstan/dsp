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
    /// Interaction logic for update.xaml
    /// </summary>
    public partial class update : Page
    {
        public update()
        {
            InitializeComponent();
        }

        private void del_user_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_user.Text == "USER NAME")
            {
                update_user.Text = "";
                update_user.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_user.Text == "")
            {
                update_user.Text = "USER NAME";
                update_user.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void update_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_name.Text == "NAME")
            {
                update_name.Text = "";
                update_name.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_name.Text == "")
            {
                update_name.Text = "NAME";
                update_name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void update_desig_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_desig.Text == "DESIGNATION")
            {
                update_desig.Text = "";
                update_desig.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_desig.Text == "")
            {
                update_desig.Text = "DESIGNATION";
                update_desig.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void update_new_user_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_new_user.Text == "USER NAME")
            {
                update_new_user.Text = "";
                update_new_user.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_new_user.Text == "")
            {
                update_new_user.Text = "USER NAME";
                update_new_user.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void update_pass_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_pass.Text == "PASSWORD")
            {
                update_pass.Text = "";
                update_pass.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_pass.Text == "")
            {
                update_pass.Text = "PASSWORD";
                update_pass.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void update_remark_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (update_remark.Text == "REMARK")
            {
                update_remark.Text = "";
                update_remark.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (update_remark.Text == "")
            {
                update_remark.Text = "REMARK";
                update_remark.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void fetch_user(object sender, RoutedEventArgs e)
        {
            if (update_user.Text == "USER NAME")
            {
                MessageBox.Show("EMPTY USER NAME");
            }
        }

        private void update_call(object sender, RoutedEventArgs e)
        {
            if (update_user.Text == "USER NAME")
            {
                MessageBox.Show("EMPTY USER NAME");
            }
            if ((update_name.Text == "NAME") || (update_desig.Text == "DESIGNATION") || (update_new_user.Text == "USER NAME") || (update_pass.Text == "PASSWORD"))
            {
                MessageBox.Show("EMPTY CREDENTIALS");
            }
            if ((admin_pre.IsChecked == false) && (front_pre.IsChecked == false) && (fb_pre.IsChecked == false) && (hk_pre.IsChecked == false) && (store_pre.IsChecked == false))
            {
                MessageBox.Show("EMPTY PREVILEGE");
            }
        }
    }
}