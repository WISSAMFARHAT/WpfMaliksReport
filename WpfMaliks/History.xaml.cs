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
        ArrayList check = new ArrayList();
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
                path = path + "\\" + subfolder;
                if (Directory.Exists(path))
                {
                    var foundFiles = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
                    
                    foreach (var file in foundFiles)
                    {
                        string r = (System.IO.Path.GetDirectoryName(file));
                        string[] split = r.Split('\\');
                        string subfolders = split[split.Length - 1].ToString();
                        if (check.Count != 0)
                        {
                            if (!check.Contains(subfolders))
                            {
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
                                check.Add(subfolders);
                                newBtn.Click += new RoutedEventHandler(clicksub);
                                newBtn.CommandParameter = subfolders;
                            }
                        }
                        else
                        {
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
                            check.Add(subfolders);
                            newBtn.Click += new RoutedEventHandler(clicksub);
                            newBtn.CommandParameter = subfolders;

                        }


                    }
                }
            }
        }

        private void refe(object sender, RoutedEventArgs e)
        {
            check.Clear();
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
                path = path + "\\" + subfolder;
                if (Directory.Exists(path))
                {
                    var foundFiles = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);

                    foreach (var file in foundFiles)
                    {
                        string r = (System.IO.Path.GetDirectoryName(file));
                        string[] split = r.Split('\\');
                        string subfolders = split[split.Length - 1].ToString();
                        if (check.Count != 0)
                        {
                            if (!check.Contains(subfolders))
                            {
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
                                check.Add(subfolders);
                                newBtn.Click += new RoutedEventHandler(clicksub);
                                newBtn.CommandParameter = subfolders;
                            }
                        }
                        else
                        {
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
                            check.Add(subfolders);
                            newBtn.Click += new RoutedEventHandler(clicksub);
                            newBtn.CommandParameter = subfolders;

                        }


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
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);

            Thickness margin = this.Margin;
            margin.Left = 10;
            margin.Right = 10;
           
            margin.Top = 0;
            string folder = "Report";

            string subfolder = MainWindow.user;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = "" + desktopPath + "\\" + folder;
            path = path + "\\" + subfolder;
            path = path + "\\" + value;
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] Files = d.GetFiles("*.pdf"); //Getting Text files

            foreach (var file in Files)
            {
                
                string subfolders = file.Name;
                Button newBtn = new Button();
                margin = this.Margin;
                margin.Left = 10;
                margin.Right = 10;
                StackPanel sp1 = new StackPanel();
                sp1.VerticalAlignment = VerticalAlignment.Center;
                sp1.Orientation = Orientation.Vertical;

                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"/Images/pdf.png", UriKind.Relative));
                img.Width = 100;
                img.Height = 100;
                sp1.Children.Add(img);
                newBtn.Content = subfolders;
                newBtn.Margin = margin;
                sp1.Children.Add(newBtn);
                sp.Children.Add(sp1);
                newBtn.Click += new RoutedEventHandler(open);
                newBtn.CommandParameter = subfolders+"!"+ value;

            }



            }

        private void back(object sender, RoutedEventArgs e)
        {
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

            newBtn1.Content = "Refresh ";
            newBtn1.Margin = margin1;
            newBtn1.Width = 150;
            newBtn1.HorizontalAlignment = HorizontalAlignment.Left;
            newBtn1.Click += new RoutedEventHandler(refe);
            prefresh.Children.Add(newBtn1);
            sp.Children.Add(prefresh);

            for (int i=0;i<check.Count;i++)
            {
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
                newBtn.Content = check[i];
                newBtn.Margin = margin;
                sp1.Children.Add(newBtn);
                sp.Children.Add(sp1);
                newBtn.Click += new RoutedEventHandler(clicksub);
                newBtn.CommandParameter = check[i];
            }
        }

        private void open(object sender, RoutedEventArgs e)
        {
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            string[] split = value.Split('!');
            string folder = "Report";

            string subfolder = MainWindow.user;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = "" + desktopPath + "\\" + folder;
            path = path + "\\" + subfolder;
            path = path + "\\" + split[1] + "\\" + split[0];

            System.Diagnostics.Process.Start(path);



        }   
    }

    

}
