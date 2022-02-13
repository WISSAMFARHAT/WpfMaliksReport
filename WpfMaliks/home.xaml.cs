using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
            user.Text = MainWindow.user;
           
            if(MainWindow.user== "Services Department")
            {

                imge.Source = new BitmapImage(new Uri(@"/Images/user1.png", UriKind.Relative));


                l1.Content = "Allam Al Jurdy";
                l11.Content = "Senior Manager";

                l2.Content = "Ali Yassin";
                l22.Content = "Senior Officer";

                l3.Content = "Shadi Farhat";
                l33.Content = "Supervisor";

                l4.Content = "Mohamad Faraa";
                l44.Content = "Supervisor";

                l5.Content = "Hanadi Abdulbaki";
                l55.Content = "Supporter";

            }else if(MainWindow.user == "Stationery Department")
            {
               
                l1.Content = "Wael Chamandi";
                l11.Content = "Senior Manager";

                l2.Content = "Norma Saiid";
                l22.Content = "Senior Officer";

                l3.Content = "Silvia Baaklini";
                l33.Content = "Senior Officer";

                l4.Content = "Rabih Gh";
                l44.Content = "Supervisor";

                l5.Content = "Hanin Zahwe";
                l55.Content = "Supporter";
            }else if(MainWindow.user == "Operation Department")
            {
               

                l1.Content = "Hassan Naserdine";
                l11.Content = "Senior Manager";

                l2.Content = "Ziad Saad";
                l22.Content = "Senior Officer";

                l3.Content = "Nihal Farchoukh";
                l33.Content = "Supporter";
                border.BorderThickness = new Thickness(0);

                l4.Visibility = Visibility.Hidden;
                l44.Visibility = Visibility.Hidden;

                l5.Visibility = Visibility.Hidden;
                l55.Visibility = Visibility.Hidden;
            }

        }

    }
}
