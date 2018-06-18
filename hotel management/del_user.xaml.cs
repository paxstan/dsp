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
    /// Interaction logic for del_user.xaml
    /// </summary>
    public partial class del_user : Page
    {
        public del_user()
        {
            InitializeComponent();
        }

        private void del_user_user_keyfocus(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (del_user_user.Text == "USER NAME")
            {
                del_user_user.Text = "";
                del_user_user.Foreground = new SolidColorBrush(Colors.Black);
            }
            else if (del_user_user.Text == "")
            {
                del_user_user.Text = "USER NAME";
                del_user_user.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
