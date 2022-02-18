using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
    /// Interaction logic for Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        bool check = true;
        home home = new home();
        Report rp = new Report();
        History ht = new History();
           
        public Index()
        {
           
            InitializeComponent();
            user.Text = MainWindow.user;
            navbar.Width = 200;
            image.Visibility = Visibility.Visible;
            main.Width = System.Windows.SystemParameters.PrimaryScreenWidth - 200;
            
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
          
            if (MainWindow.user == "Services Department")
            {
               

               
                     img1.Source = new BitmapImage(new Uri(@"/Images/user1.png", UriKind.Relative));


                

            }
            else if(MainWindow.user == "Stationery Department")
            {
               
            }else if(MainWindow.user == "Operation Department")
            {
                

            }

            frame.Navigate(home);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(check==false)
            {
                navbar.Width = 200;
                image.Visibility = Visibility.Visible;
                main.Width = System.Windows.SystemParameters.PrimaryScreenWidth - 200;
                check = true;
            }
            else
            {
                navbar.Width = 70;
                image.Visibility = Visibility.Collapsed;
                main.Width = System.Windows.SystemParameters.PrimaryScreenWidth - 70;
                check = false;
            }
            
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            MainWindow main = new MainWindow();
            main.Show();
            Close();

        }
        private void button_exit(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
        }
        
        private void Power_off(object sender, RoutedEventArgs e)
        {

           
            Close();

        }
        private void Minimise(object sender, RoutedEventArgs e)
        {
            WindowState= WindowState.Minimized;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frame.Navigate(home);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frame.Navigate(rp);
        }
        private void button_3(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                frame.Navigate(rp);
        }
        private void button_2(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                frame.Navigate(home);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frame.Navigate(ht);
        }
        private void button_4(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                frame.Navigate(ht);
        }

        private void Bu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (bu.Toggle==true)
            {
                colorrow1.Background = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#E61F4B"));
                frame.Background= (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#031E28"));
                Application.Current.Resources["colortext"] = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#FFFFFF")); 
                Application.Current.Resources["colorrating"] = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#FFD700")); 

            }
            else
            {
                colorrow1.Background= (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#031E28"));
                frame.Background = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#FFFFFF"));
                Application.Current.Resources["colortext"] = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#E61F4B"));
                Application.Current.Resources["colorrating"] = (System.Windows.Media.Brush)(new BrushConverter().ConvertFrom("#031E28")); ;

            }
        }
    }
}
