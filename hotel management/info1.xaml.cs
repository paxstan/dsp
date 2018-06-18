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
    /// Interaction logic for info1.xaml
    /// </summary>
    public partial class info1 : Page
    {
        public info1()
        {
            InitializeComponent();
        }

        private void CFORM_CALL(object sender, RoutedEventArgs e)
        {
            cform w2 = new cform();
            w2.Show();
        }

        private void info_ph_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_ph.Text == "PHONE NUMBER")
            {
                info_ph.Text = "";
                info_ph.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_ph.Text == "")
            {
                info_ph.Text = "PHONE NUMBER";
                info_ph.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_name.Text == "NAME")
            {
                info_name.Text = "";
                info_name.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_name.Text == "")
            {
                info_name.Text = "NAME";
                info_name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_str_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_str.Text == "STREET ADDRESS")
            {
                info_str.Text = "";
                info_str.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_str.Text == "")
            {
                info_str.Text = "STREET ADDRESS";
                info_str.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_dist_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_dist.Text == "DISTRICT NAME")
            {
                info_dist.Text = "";
                info_dist.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_dist.Text == "")
            {
                info_dist.Text = "DISTRICT NAME";
                info_dist.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_state_keyfocu(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_state.Text == "STATE NAME")
            {
                info_state.Text = "";
                info_state.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_state.Text == "")
            {
                info_state.Text = "STATE NAME";
                info_state.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_country_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_country.Text == "COUNTRY NAME")
            {
                info_country.Text = "";
                info_country.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_country.Text == "")
            {
                info_country.Text = "COUNTRY NAME";
                info_country.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_pincode_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_pincode.Text == "PIN CODE")
            {
                info_pincode.Text = "";
                info_pincode.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_pincode.Text == "")
            {
                info_pincode.Text = "PIN CODE";
                info_pincode.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_mail_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_mail.Text == "MAIL ID")
            {
                info_mail.Text = "";
                info_mail.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_mail.Text == "")
            {
                info_mail.Text = "MAIL ID";
                info_mail.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_oid_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_other_id.Text == "OTHERS")
            {
                info_other_id.Text = "";
                info_other_id.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_other_id.Text == "")
            {
                info_other_id.Text = "OTHERS";
                info_other_id.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_id_num_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (info_id_num.Text == "ID NUMBER")
            {
                info_id_num.Text = "";
                info_id_num.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (info_id_num.Text == "")
            {
                info_id_num.Text = "ID NUMBER";
                info_id_num.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void create_info(object sender, RoutedEventArgs e)
        {
            if((info_ph.Text=="PHONE NUMBER")|| (info_name.Text == "NAME") || (info_str.Text == "STREET ADDRESS") || (info_dist.Text == "DISTRICT NAME") || (info_state.Text == "STATE NAME") || (info_country.Text == "COUNTRY NAME")||(info_pincode.Text == "PIN CODE") || (info_id_num.Text == "ID NUMBER") ||( (info_id.SelectedItem == null) && (info_other_id.Text == "OTHERS")) || (info_dob.SelectedDate == null)){
                MessageBox.Show("EMPTY CREDENTIALS");
            }
        }
    }
}
