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
    /// Interaction logic for checkout1.xaml
    /// </summary>
    public partial class checkout1 : Page
    {
        public checkout1()
        {
            InitializeComponent();
        }
        private void info_ph_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_ph.Text == "PHONE NUMBER")
            {
                checkout_ph.Text = "";
                checkout_ph.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_ph.Text == "")
            {
                checkout_ph.Text = "PHONE NUMBER";
                checkout_ph.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_name_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_name.Text == "NAME")
            {
                checkout_name.Text = "";
                checkout_name.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_name.Text == "")
            {
                checkout_name.Text = "NAME";
                checkout_name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_str_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_str.Text == "STREET ADDRESS")
            {
                checkout_str.Text = "";
                checkout_str.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_str.Text == "")
            {
                checkout_str.Text = "STREET ADDRESS";
                checkout_str.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_dist_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_dist.Text == "DISTRICT NAME")
            {
                checkout_dist.Text = "";
                checkout_dist.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_dist.Text == "")
            {
                checkout_dist.Text = "DISTRICT NAME";
                checkout_dist.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_state_keyfocu(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_state.Text == "STATE NAME")
            {
                checkout_state.Text = "";
                checkout_state.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_state.Text == "")
            {
                checkout_state.Text = "STATE NAME";
                checkout_state.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_country_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_country.Text == "COUNTRY NAME")
            {
                checkout_country.Text = "";
                checkout_country.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_country.Text == "")
            {
                checkout_country.Text = "COUNTRY NAME";
                checkout_country.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void info_pincode_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_pincode.Text == "PIN CODE")
            {
                checkout_pincode.Text = "";
                checkout_pincode.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_pincode.Text == "")
            {
                checkout_pincode.Text = "PIN CODE";
                checkout_pincode.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void hotel_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_hname.Text == "HOTEL NAME")
            {
                checkout_hname.Text = "";
                checkout_hname.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_hname.Text == "")
            {
                checkout_hname.Text = "HOTEL NAME";
                checkout_hname.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rnum_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_rnum.Text == "ROOM NUMBER")
            {
                checkout_rnum.Text = "";
                checkout_rnum.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_rnum.Text == "")
            {
                checkout_rnum.Text = "ROOM NUMBER";
                checkout_rnum.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void PNUM_KEYFOCUS(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_pnum.Text == "NO.OF PERSONS")
            {
                checkout_pnum.Text = "";
                checkout_pnum.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_pnum.Text == "")
            {
                checkout_pnum.Text = "NO.OF PERSONS";
                checkout_pnum.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void vcount_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_vcount.Text == "COUNT")
            {
                checkout_vcount.Text = "";
                checkout_vcount.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_vcount.Text == "")
            {
                checkout_vcount.Text = "COUNT";
                checkout_vcount.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void discount_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_discount.Text == "DISCOUNT")
            {
                checkout_discount.Text = "";
                checkout_discount.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_discount.Text == "")
            {
                checkout_discount.Text = "DISCOUNT";
                checkout_discount.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void tid1_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_tid1.Text == "TRANSACTION ID")
            {
                checkout_tid1.Text = "";
                checkout_tid1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_tid1.Text == "")
            {
                checkout_tid1.Text = "TRANSACTION ID";
                checkout_tid1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void pay_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_pay.Text == "PAYMENT MODE")
            {
                checkout_pay.Text = "";
                checkout_pay.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_pay.Text == "")
            {
                checkout_pay.Text = "PAYMENT MODE";
                checkout_pay.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void post_ch_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_post_ch.Text == "POST CHARGE")
            {
                checkout_post_ch.Text = "";
                checkout_post_ch.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_post_ch.Text == "")
            {
                checkout_post_ch.Text = "POST CHARGE";
                checkout_post_ch.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void amt_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_amt.Text == "TOTAL AMOUNT")
            {
                checkout_amt.Text = "";
                checkout_amt.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_amt.Text == "")
            {
                checkout_amt.Text = "TOTAL AMOUNT";
                checkout_amt.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void invoice_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (checkout_invoice.Text == "INVOICE NUMBER")
            {
                checkout_invoice.Text = "";
                checkout_invoice.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (checkout_invoice.Text == "")
            {
                checkout_invoice.Text = "INVOICE NUMBER";
                checkout_invoice.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
