﻿using System;
using System.Collections;
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
    /// Interaction logic for Print2.xaml
    /// </summary>
    public partial class Print2 : Page
    {
        int sources = 0;
        int sources1 = 0;
        public Print2(int RSEmployees, string TRSEmployees, int RSorgaSections, string TRSorgaSections, string TOverRemark1,
            int RServiceEmployees, string TRServiceEmployees, int RServiceOrgSections, string TRServiceOrgSections, string TOverRemark2, ArrayList all)
        {
            InitializeComponent();
            RSEmployee.Value=RSEmployees;
            TRSEmployee.Text = TRSEmployees;
            RSOSection.Value = RSorgaSections;
            TSOSection.Text = TRSorgaSections;
            OverRemarks1.Text = TOverRemark1;
            SEmployee.Value = RServiceEmployees;
            TSEmployee.Text = TRServiceEmployees;
            OrgSection.Value = RServiceOrgSections;
            ROrgSection.Text = TRServiceOrgSections;
            OverRemarks2.Text = TOverRemark2;
            Gimage1.Visibility = Visibility.Hidden;
            Gimage2.Visibility = Visibility.Hidden;
            Gimage3.Visibility = Visibility.Hidden;
            Gimage4.Visibility = Visibility.Hidden;
            Gimage5.Visibility = Visibility.Hidden;
            Gimage6.Visibility = Visibility.Hidden;
            Gimage7.Visibility = Visibility.Hidden;
            Gimage8.Visibility = Visibility.Hidden;
            Gimage9.Visibility = Visibility.Hidden;
            Gimage10.Visibility = Visibility.Hidden;
            Cimage1.Visibility = Visibility.Hidden;
            Cimage2.Visibility = Visibility.Hidden;
            Cimage3.Visibility = Visibility.Hidden;
            Cimage4.Visibility = Visibility.Hidden;
            Cimage5.Visibility = Visibility.Hidden;
            Cimage6.Visibility = Visibility.Hidden;
            Cimage7.Visibility = Visibility.Hidden;
            Cimage8.Visibility = Visibility.Hidden;
            Cimage9.Visibility = Visibility.Hidden;
            Cimage10.Visibility = Visibility.Hidden;
            Cimage2.Visibility = Visibility.Hidden;
            Cimage3.Visibility = Visibility.Hidden;
            Cimage4.Visibility = Visibility.Hidden;

            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].ToString().Contains("ISEmplyee") || all[i].ToString().Contains("ISOSection") )
                {
                    string[] split = all[i].ToString().Split('!');
                    if (sources == 0)
                    {
                        Gimage1.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage1.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 1)
                    {
                        Gimage2.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage2.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 2)
                    {
                        Gimage3.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage3.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 3)
                    {
                        Gimage4.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage4.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 4)
                    {
                        Gimage5.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage5.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 5)
                    {
                        Gimage6.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage6.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 6)
                    {
                        Gimage7.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage7.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 7)
                    {
                        Gimage8.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage8.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 8)
                    {
                        Gimage9.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage9.Visibility = Visibility.Visible;
                        sources++;
                    }
                    else if (sources == 9)
                    {
                        Gimage10.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Gimage10.Visibility = Visibility.Visible;
                        sources++;
                    }

                }
                if (all[i].ToString().Contains("ISerEmploye") || all[i].ToString().Contains("ISerOSection"))
                {
                    string[] split = all[i].ToString().Split('!');
                    if (sources1 == 0)
                    {
                        Cimage1.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage1.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 1)
                    {
                        Cimage2.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage2.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 2)
                    {
                        Cimage3.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage3.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 3)
                    {
                        Cimage4.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage4.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 4)
                    {
                        Cimage5.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage5.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 5)
                    {
                        Cimage6.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage6.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 6)
                    {
                        Cimage7.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage7.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 7)
                    {
                        Cimage8.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage8.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 8)
                    {
                        Cimage9.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage9.Visibility = Visibility.Visible;
                        sources1++;
                    }
                    else if (sources1 == 9)
                    {
                        Cimage10.Source = new BitmapImage(new Uri(@"" + split[1].ToString()));
                        Cimage10.Visibility = Visibility.Visible;
                        sources1++;
                    }

                }
            }

        }
    }
}
