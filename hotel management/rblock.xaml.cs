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
    /// Interaction logic for rblock.xaml
    /// </summary>
    public partial class rblock : Page
    {
        public rblock()
        {
            InitializeComponent();
        }

        private void rblock_rnum_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rblock_rnum.Text == "ROOM NUMBER")
            {
                rblock_rnum.Text = "";
                rblock_rnum.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rblock_rnum.Text == "")
            {
                rblock_rnum.Text = "ROOM NUMBER";
                rblock_rnum.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rblock_sname_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rblock_sname.Text == "NAME")
            {
                rblock_sname.Text = "";
                rblock_sname.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rblock_sname.Text == "")
            {
                rblock_sname.Text = "NAME";
                rblock_sname.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void rblock_remark_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (rblock_remark.Text == "REMARK")
            {
                rblock_remark.Text = "";
                rblock_remark.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (rblock_remark.Text == "")
            {
                rblock_remark.Text = "REMARK";
                rblock_remark.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
