using Microsoft.Win32;
using System;
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
    /// Interaction logic for Report1.xaml
    /// </summary>
    public partial class Report1 : Page
    {
        public static ArrayList All = new ArrayList();
        bool checkupload = false;
        public Report1()
        {
            InitializeComponent();
            date.Content = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
        }

        public void clear()
        {
            this.Rvitrine.Clear();
            this.RSignage.Clear();
            this.RBranch.Clear();
            this.REmployee.Clear();
            this.ROrgSection.Clear();
            this.OverRemarks.Clear();
            this.OrgSection.Value = 0;
            this.Employee.Value = 0;
            this.Branch.Value = 0;
            this.Signage.Value = 0;
            this.RVitrine.Value = 0;




        }

        private void upload(object sender, RoutedEventArgs e)
        {

            checkupload = false;
            Button _myButton = (Button)sender;
            string value = _myButton.CommandParameter.ToString();
            string[] split = value.Split(' ');
            TextBlock txt = this.FindName(split[0]) as TextBlock;
            
            Label lb = this.FindName(split[1]) as Label;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;

            if (fd.ShowDialog() == true)
            {
                txt.Text = "";
                for  (int i=0;i<All.Count;i++)
                {
                    if (All[i].ToString().Contains(split[2]))
                    {
                        
                        All.RemoveAt(i);
                    }
                }

                if (fd.FileNames.Length > 1)
                { 
                    txt.Text += " " + fd.SafeFileName + " ...";
                    foreach (String files in fd.FileNames)
                    {
                        for(int i=0;i<All.Count;i++)
                        {
                            if(All[i].Equals(split[2] + "!" + files))
                            {
                                checkupload = true;
                            }
                            
                        }
                        if (checkupload == false)
                        {
                            All.Add(split[2] + "!" + files);
                        }
                        checkupload = false;
                    }
                 }
                else
                {
                    txt.Text = fd.SafeFileName;
                    for (int i = 0; i < All.Count; i++)
                    {
                        if (All[i].Equals(split[2] + "!" + fd.FileName))
                        {
                            checkupload = true;
                        }

                    }
                    if (checkupload == false)
                    {
                        All.Add(split[2] + "!" + fd.FileName);
                    }
                    
                    
                }

                    lb.Content = "✔";
                   
                    
            }
           

        }
           
       


    }
}
