using PdfSharp.Pdf;
using System;
using System.Collections;
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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();
            string folder = "Report";
            
            string subfolder = MainWindow.user;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = "" + desktopPath + "\\" + folder;


            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;

            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;
    
            newBtn1.Content = "Refresh ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(refe);
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);


            if (Directory.Exists(path))
            {
                path = path + "\\" + subfolder+"\\";
                if (Directory.Exists(path))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(path);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri(@"/Images/folder.png", UriKind.Relative));
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(clicksub);
                        newBtn.CommandParameter = path+"\\"+subfolders;
                    }
                }

                
            }
        }

        private void refe(object sender, RoutedEventArgs e)
        {
            sp.Children.Clear();
            string folder = "Report";

            string subfolder = MainWindow.user;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = "" + desktopPath + "\\" + folder;


            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;

            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;

            newBtn1.Content = "Refresh ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(refe);
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);


            if (Directory.Exists(path))
            {
                path = path + "\\" + subfolder + "\\";
                if (Directory.Exists(path))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(path);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri(@"/Images/folder.png", UriKind.Relative));
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(clicksub);
                        newBtn.CommandParameter = path+"\\"+subfolders;
                    }
                }


            }
        }

        private void clicksub(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            sp.Children.Clear();
            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;


            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;

            newBtn1.Content = "Back ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(back);
            
            newBtn1.CommandParameter = value;
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);


          

            if (Directory.Exists(value))
            {
                
                if (Directory.Exists(value))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(value);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri(@"/Images/folder.png", UriKind.Relative));
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(clicksubpdf);
                        newBtn.CommandParameter = value+"\\"+subfolders;
                    }
                }


            }


         
            }

        private void clicksubpdf(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            sp.Children.Clear();
            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;


            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;

            newBtn1.Content = "Back ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(backto);
            newBtn1.CommandParameter = value;
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);



           

            if (Directory.Exists(value))
            {

                if (Directory.Exists(value))
                {
                    string[] subdirectoryEntries = Directory.GetFiles(value);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        if (subfolders.Contains(".pdf"))
                        {
                            img.Source = new BitmapImage(new Uri(@"/Images/pdf.png", UriKind.Relative));
                        }else
                        {
                            img.Source = new BitmapImage(new Uri(@"/Images/imgicon.png", UriKind.Relative));
                        }
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(open);
                        newBtn.CommandParameter = value+"\\"+subfolders;
                    }
                }


            }

        }


        private void back(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            sp.Children.Clear();

            string[] s = value.Split('\\');
            string newvalue = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                newvalue = newvalue + "" + s[i] + "\\";
            }

            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;

            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;

            newBtn1.Content = "Refresh ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(refe);
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);


            if (Directory.Exists(newvalue))
            {
                if (Directory.Exists(newvalue))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(newvalue);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri(@"/Images/folder.png", UriKind.Relative));
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(clicksub);
                        newBtn.CommandParameter = newvalue + "\\"+subfolders;
                    }
                }


            }




        }

        private void backto(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            sp.Children.Clear();

            string[] s = value.Split('\\');
            string newvalue = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                newvalue = newvalue + "" + s[i] + "\\";
            }

            StackPanel prefresh = new StackPanel();
            prefresh.Orientation = Orientation.Vertical;
            prefresh.Height = 100;
            prefresh.Width = 1100;
            prefresh.HorizontalAlignment = HorizontalAlignment.Left;

            System.Windows.Controls.Button newBtn1 = new Button();
            newBtn1.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin1 = this.Margin;
            margin1.Left = 10;
            margin1.Right = 10;

            newBtn1.Content = "Back ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(refe);
            newBtn1.CommandParameter = newvalue;
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);


            if (Directory.Exists(newvalue))
            {
                if (Directory.Exists(newvalue))
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(newvalue);
                    foreach (string subdirectory in subdirectoryEntries)
                    {
                        string r = subdirectory;
                        string[] split = r.Split('\\');
                        string subfolders = split.Last().ToString();
                        System.Windows.Controls.Button newBtn = new Button();
                        Thickness margin = this.Margin;
                        margin.Left = 10;
                        margin.Right = 10;
                        StackPanel sp1 = new StackPanel();
                        sp1.Orientation = Orientation.Vertical;
                        sp1.VerticalAlignment = VerticalAlignment.Center;
                        Image img = new Image();
                        img.Source = new BitmapImage(new Uri(@"/Images/folder.png", UriKind.Relative));
                        img.Width = 100;
                        img.Height = 100;
                        sp1.Children.Add(img);
                        newBtn.Content = subfolders;
                        newBtn.Margin = margin;
                        sp1.Children.Add(newBtn);
                        sp.Children.Add(sp1);
                        newBtn.Click += new RoutedEventHandler(clicksubpdf);
                        newBtn.CommandParameter = newvalue + "\\" + subfolders;
                    }
                }


            }




        }

        private void open(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
           

            System.Diagnostics.Process.Start(value);



        }   
    }

    

}
