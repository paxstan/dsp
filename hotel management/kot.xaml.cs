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
    /// Interaction logic for kot.xaml
    /// </summary>
    public partial class kot : Page
    {
        public kot()
        {
            InitializeComponent();
        }

       


        private void roomgrid(object sender, RoutedEventArgs e)
        {
            if (kot_roomser.IsChecked == true)
            {
                room_grid.Visibility = Visibility.Visible;
            }
            else
            {
                room_grid.Visibility = Visibility.Hidden;
            }
        }

        private void room_no_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (room_no.Text == "ROOM NO")
            {
                room_no.Text = "";
                room_no.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (room_no.Text == "")
            {
                room_no.Text = "ROOM NO";
                room_no.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_tableno_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_tableno.Text == "TABLE NUMBER")
            {
                kot_tableno.Text = "";
                kot_tableno.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_tableno.Text == "")
            {
                kot_tableno.Text = "TABLE NUMBER";
                kot_tableno.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void jot_item1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_item1.Text == "ITEMS")
            {
                kot_item1.Text = "";
                kot_item1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_item1.Text == "")
            {
                kot_item1.Text = "ITEMS";
                kot_item1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_session1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_sessions1.Text == "SESSION")
            {
                kot_sessions1.Text = "";
                kot_sessions1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_sessions1.Text == "")
            {
                kot_sessions1.Text = "SESSION";
                kot_sessions1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_steward1_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_steward1.Text == "STEWARD NAME")
            {
                kot_steward1.Text = "";
                kot_steward1.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_steward1.Text == "")
            {
                kot_steward1.Text = "STEWARD NAME";
                kot_steward1.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void resgrid(object sender, RoutedEventArgs e)
        {
            if (kot_res.IsChecked==true)
            {
                restaurant_grid.Visibility = Visibility.Visible;
            }
            else
            {
                restaurant_grid.Visibility = Visibility.Hidden;
            }
        }

        private void kot_session2_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_session2.Text == "SESSION")
            {
                kot_session2.Text = "";
                kot_session2.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_session2.Text == "")
            {
                kot_session2.Text = "SESSION";
                kot_session2.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_steward2_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_steward2.Text == "STEWARD NAME")
            {
                kot_steward2.Text = "";
                kot_steward2.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_steward2.Text == "")
            {
                kot_steward2.Text = "STEWARD NAME";
                kot_steward2.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_items2_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_items2.Text == "ITEMS")
            {
                kot_items2.Text = "";
                kot_items2.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_items2.Text == "")
            {
                kot_items2.Text = "ITEMS";
                kot_items2.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kot_room2_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (kot_room2.Text == "ROOM NUMBER")
            {
                kot_room2.Text = "";
                kot_room2.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (kot_room2.Text == "")
            {
                kot_room2.Text = "ROOM NUMBER";
                kot_room2.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void kotsubmit_call(object sender, RoutedEventArgs e)
        {
            if((room_no.Text=="ROOM NO") || ((kot_res.IsChecked == false) && (kot_roomser.IsChecked == false)))
            {
                MessageBox.Show("EMPTY CREDENTIALS");
            }
            if (kot_res.IsChecked == true)
            {
                if((kot_tableno.Text=="TABLE NUMBER")||(kot_item1.Text=="ITEMS")||(kot_sessions1.Text=="SESSION")||(kot_steward1.Text=="STEWARD NAME"))
                {
                    MessageBox.Show("EMPTY FEILD IN RESTAURANT KOT");
                }
            }
            if (kot_roomser.IsChecked == true)
            {
                if ((kot_room2.Text == "ROOM NUMBER") || (kot_items2.Text == "ITEMS") || (kot_session2.Text == "SESSION") || (kot_steward2.Text == "STEWARD NAME"))
                {
                    MessageBox.Show("EMPTY FIELD IN ROOM KOT");
                }
            }
        }
    }
}
