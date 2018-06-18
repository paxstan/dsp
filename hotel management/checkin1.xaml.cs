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
    /// Interaction logic for checkin1.xaml
    /// </summary>
    public partial class checkin1 : Page
    {
        public checkin1()
        {
            InitializeComponent();
        }
        private void info_ph_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_ph.Text == "PHONE NUMBER")
            {
                checkin_ph.Text = "";
                checkin_ph.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_ph.Text == "")
            {
                checkin_ph.Text = "PHONE NUMBER";
                checkin_ph.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_name.Text == "NAME")
            {
                checkin_name.Text = "";
                checkin_name.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_name.Text == "")
            {
                checkin_name.Text = "NAME";
                checkin_name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_str_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_str.Text == "STREET ADDRESS")
            {
                checkin_str.Text = "";
                checkin_str.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_str.Text == "")
            {
                checkin_str.Text = "STREET ADDRESS";
                checkin_str.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_dist_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_dist.Text == "DISTRICT NAME")
            {
                checkin_dist.Text = "";
                checkin_dist.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_dist.Text == "")
            {
                checkin_dist.Text = "DISTRICT NAME";
                checkin_dist.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_state_keyfocu(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_state.Text == "STATE NAME")
            {
                checkin_state.Text = "";
                checkin_state.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_state.Text == "")
            {
                checkin_state.Text = "STATE NAME";
                checkin_state.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_country_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_country.Text == "COUNTRY NAME")
            {
                checkin_country.Text = "";
                checkin_country.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_country.Text == "")
            {
                checkin_country.Text = "COUNTRY NAME";
                checkin_country.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_pincode_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_pincode.Text == "PIN CODE")
            {
                checkin_pincode.Text = "";
                checkin_pincode.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_pincode.Text == "")
            {
                checkin_pincode.Text = "PIN CODE";
                checkin_pincode.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void advance_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_advance.Text == "ADVANCE PAID")
            {
                checkin_advance.Text = "";
                checkin_advance.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_advance.Text == "")
            {
                checkin_advance.Text = "ADVANCE PAID";
                checkin_advance.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void amt_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkin_amt.Text == "TOTAL AMOUNT")
            {
                checkin_amt.Text = "";
                checkin_amt.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkin_amt.Text == "")
            {
                checkin_amt.Text = "TOTAL AMOUNT";
                checkin_amt.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void checkin(object sender, RoutedEventArgs e)
        {
            if(checkin_ph.Text=="PHONE NUMBER")
            {
                MessageBox.Show("PHONE NUMBER FIELD IS EMPTY");
            }
            if ((checkin_date.SelectedDate == null) || (checkin_out_date.SelectedDate == null))
            {
                MessageBox.Show("EMPTY DATE");
            }
            if((checkin_hname.SelectedItem==null)||(checkin_rtype.SelectedItem==null)||(checkin_rnum.SelectedItem==null)||(checkin_person.Text=="NO.OF PERSON"))
            {
                MessageBox.Show("EMPTY HOTEL FIELDS");
            }
        }

        private void phno_fetch_keydown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("enter pressed");
            }
        }
    }
}
