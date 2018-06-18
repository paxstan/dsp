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
    /// Interaction logic for laundry.xaml
    /// </summary>
    public partial class laundry : Page
    {
        public laundry()
        {
            InitializeComponent();
        }

        private void laundryin_count_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (laundryin_count.Text == "QUANTITY")
            {
                laundryin_count.Text = "";
                laundryin_count.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (laundryin_count.Text == "")
            {
                laundryin_count.Text = "QUANTITY";
                laundryin_count.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void laundryout_count_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (laundryout_count.Text == "QUANTITY")
            {
                laundryout_count.Text = "";
                laundryout_count.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (laundryout_count.Text == "")
            {
                laundryout_count.Text = "QUANTITY";
                laundryout_count.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void laundryin_call(object sender, RoutedEventArgs e)
        {
            if (items1.SelectedItem == null)
            {
                MessageBox.Show("EMPTY LAUNDRY IN ITEM");
            }
            if (laundryin_count.Text == "QUANTITY")
            {
                MessageBox.Show("EMPTY LAUNDRY IN COUNT");
            }
        }

        private void laundryout_call(object sender, RoutedEventArgs e)
        {
            if (items2.SelectedItem == null)
            {
                MessageBox.Show("EMPTY LAUNDRY IN ITEM");
            }
            if (laundryout_count.Text == "QUANTITY")
            {
                MessageBox.Show("EMPTY LAUNDRY IN COUNT");
            }
        }
    }
}
