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
    /// Interaction logic for Print3.xaml
    /// </summary>
    public partial class Print3 : Page
    {
        public Print3(int Overalls,string ROveralls,int Leaderships,string RLeaderships,int Knows,string RKnow,int Performances,string RPerformances,
            int Innovations,string RInnovations,int comunications,string Rcomunications,string OverRemarks)
        {
            InitializeComponent();
            Overall.Value = Overalls;
            ROverall.Text = ROveralls;
            Leadership.Value = Leaderships;
            RLeadership.Text = RLeaderships;
            Know.Value = Knows;
            RRKnow.Text = RKnow;
            Performance.Value = Performances;
            RPerformance.Text = RPerformances;
            Innovation.Value = Innovations;
            RInnovation.Text = RInnovations;
            comunication.Value = comunications;
            Rcomunication.Text = Rcomunications;
            OverRemarks3.Text = OverRemarks;
        }
    }
}
