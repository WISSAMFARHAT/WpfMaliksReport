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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4(ArrayList im)
        {
            InitializeComponent();
            for (int i = 0; i < im.Count; i++)
            {
                string[] sp= im[i].ToString().Split('!');
                if(i==0)
                {
                    image1.Source = new BitmapImage(new Uri(@"" + sp[1].ToString()));

                }
                else if(i==1)
                {
                    image2.Source = new BitmapImage(new Uri(@"" + sp[1].ToString()));

                }
                else if(i==2)
                {
                    image3.Source = new BitmapImage(new Uri(@"" + sp[1].ToString()));


                }
                else if(i==3)
                {
                    image4.Source = new BitmapImage(new Uri(@"" + sp[1].ToString()));

                }
                
            }
        }
    }
}
