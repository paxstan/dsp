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
using System.Windows.Shapes;

namespace hotel_management
{
    /// <summary>
    /// Interaction logic for cform.xaml
    /// </summary>
    public partial class cform : Window
    {
        public cform()
        {
            InitializeComponent();
        }

        private void submit_cfrom(object sender, RoutedEventArgs e)
        {
            if((cform_passport.Text=="PASSPORT NUMBER")||(date_of_issue1.SelectedDate==null)||(cform_issue.Text=="PLACE OF ISSUE")||(date_india.SelectedDate==null)||(date_visa.SelectedDate==null)||(cform_issue_visa.Text=="PLACE OF ISSUE")||(cform_arrived.Text=="ARRIVED FROM")||(cform_stay.Text=="DURATION OF STAY"))
            {
                MessageBox.Show("EMPTY CREDENTIALS");
            }
        }
    }
}
