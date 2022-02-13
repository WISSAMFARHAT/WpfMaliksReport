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

namespace WpfMaliks
{
    /// <summary>
    /// Interaction logic for Report3.xaml
    /// </summary>
    public partial class Report3 : Page
    {
        public Report3()
        {
            InitializeComponent();
            date.Content = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ROverall.Clear();
            this.RLeadership.Clear();
            this.RKnow.Clear();
            this.RPerformance.Clear();
            this.RInnovation.Clear();
            this.Rcomunication.Clear();
            this.OverRemarks3.Clear();
            this.Overall.Value = 0;
            this.Leadership.Value = 0;
            this.Know.Value = 0;
            this.Performance.Value = 0;
            this.Innovation.Value = 0;
            this.comunication.Value = 0;
            
            


        }
    }
}
