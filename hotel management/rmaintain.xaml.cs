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
    /// Interaction logic for rmaintain.xaml
    /// </summary>
    public partial class rmaintain : Page
    {
        public rmaintain()
        {
            InitializeComponent();
        }

        private void rrelease_rnum_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rmaintain_rnum.Text == "ROOM NUMBER")
            {
                rmaintain_rnum.Text = "";
                rmaintain_rnum.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rmaintain_rnum.Text == "")
            {
                rmaintain_rnum.Text = "ROOM NUMBER";
                rmaintain_rnum.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rmaintain_sname_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rmaintain_sname.Text == "NAME")
            {
                rmaintain_sname.Text = "";
                rmaintain_sname.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rmaintain_sname.Text == "")
            {
                rmaintain_sname.Text = "NAME";
                rmaintain_sname.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rmaintain_remark_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rmaintain_remark.Text == "REMARK")
            {
                rmaintain_remark.Text = "";
                rmaintain_remark.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rmaintain_remark.Text == "")
            {
                rmaintain_remark.Text = "REMARK";
                rmaintain_remark.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void lock_maintain(object sender, RoutedEventArgs e)
        {
            if ((rmaintain_rnum.Text == "ROOM NUMBER") || (rmaintain_sname.Text == "NAME") || (rmaintain_bdate.SelectedDate == null) || (rmaintain_btime.SelectedItem == null) || (rmaintain_redate.SelectedDate == null) || (rmaintain_retime.SelectedItem == null))
            {
                MessageBox.Show("EMPTY CREDENTIALS");
            }
        }
    }
}
