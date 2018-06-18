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
    /// Interaction logic for rrelease.xaml
    /// </summary>
    public partial class rrelease : Page
    {
        public rrelease()
        {
            InitializeComponent();
        }

        private void rrelease_rnum_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rrelease_rnum.Text == "ROOM NUMBER")
            {
                rrelease_rnum.Text = "";
                rrelease_rnum.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rrelease_rnum.Text == "")
            {
                rrelease_rnum.Text = "ROOM NUMBER";
                rrelease_rnum.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rrelease_sname(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rrelease_sname1.Text == "NAME")
            {
                rrelease_sname1.Text = "";
                rrelease_sname1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rrelease_sname1.Text == "")
            {
                rrelease_sname1.Text = "NAME";
                rrelease_sname1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
