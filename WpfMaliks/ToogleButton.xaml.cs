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
    /// Interaction logic for ToogleButton.xaml
    /// </summary>
    public partial class ToogleButton : UserControl
    {
        Thickness leftside = new Thickness(-39,0,0,0);
        Thickness righttside = new Thickness(0, 0, -39, 0);
        SolidColorBrush off = new SolidColorBrush(Color.FromRgb(160,160,160));
        SolidColorBrush on = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        private bool toggle = false;
        public ToogleButton()
        {
            InitializeComponent();
            back.Fill = on;
            toggle = true;
            dot.Margin = righttside;
        }

        public bool Toggle { get => toggle; set => toggle = value; }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(!toggle)
            {
                back.Fill = on;
                toggle = true;
                dot.Margin = righttside;
            }
            else
            {
                back.Fill = off;
                toggle = false;
                dot.Margin = leftside;
            }
        }
    }
}
