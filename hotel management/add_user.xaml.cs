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
    /// Interaction logic for add_user.xaml
    /// </summary>
    public partial class add_user : Page
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void add_user_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (add_user_name.Text == "NAME")
            {
                add_user_name.Text = "";
                add_user_name.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (add_user_name.Text == "")
            {
                add_user_name.Text = "NAME";
                add_user_name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void add_user_desig_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (add_user_desig.Text == "DESIGNATION")
            {
                add_user_desig.Text = "";
                add_user_desig.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (add_user_desig.Text == "")
            {
                add_user_desig.Text = "DESIGNATION";
                add_user_desig.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void add_user_user_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (add_user_user.Text == "USER NAME")
            {
                add_user_user.Text = "";
                add_user_user.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (add_user_user.Text == "")
            {
                add_user_user.Text = "USER NAME";
                add_user_user.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void add_user_pass_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (add_user_pass.Text == "PASSWORD")
            {
                add_user_pass.Text = "";
                add_user_pass.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (add_user_pass.Text == "")
            {
                add_user_pass.Text = "PASSWORD";
                add_user_pass.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void add_user_remark(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (add_user_remark1.Text == "REMARK")
            {
                add_user_remark1.Text = "";
                add_user_remark1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (add_user_remark1.Text == "")
            {
                add_user_remark1.Text = "REMARK";
                add_user_remark1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void create_user_call(object sender, RoutedEventArgs e)
        {
            if((add_user_name.Text=="NAME")|| (add_user_desig.Text == "DESIGNATION") || (add_user_user.Text == "USER NAME") || (add_user_pass.Text == "PASSWORD")){
                MessageBox.Show("EMPTY CREDENTIALS");
            }
            if((admin_pre.IsChecked==false)&& (front_pre.IsChecked == false) && (fb_pre.IsChecked == false) && (hk_pre.IsChecked == false) && (store_pre.IsChecked == false))
            {
                MessageBox.Show("EMPTY PREVILEGE");
            }
        }
    }
}
