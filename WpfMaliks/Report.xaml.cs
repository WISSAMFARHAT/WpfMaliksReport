using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
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
using System.Windows.Xps.Packaging;
using System.Windows.Xps;
using System.Windows.Markup;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using System.Printing;
using System.Collections;


namespace WpfMaliks
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        int page = 0;
       
        static Page r1 = new Report1();
        static Page r2 = new Report2();
        static Page r3 = new Report3();
        public Report()
        {
            InitializeComponent();
            framereport.Navigate(r1);
            framereport.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BPreview.Visibility = Visibility.Hidden;
            canvas.Visibility = Visibility.Hidden;
            page = 1;
        }
        

        private void nextframe(object sender, RoutedEventArgs e)
        {
            if(page<3)
            {
                page++;
            }
            if (page == 1)
            {
                framereport.Navigate(r1);
                BPreview.Visibility = Visibility.Hidden;
                Bnext.Visibility = Visibility.Visible;
                canvas.Visibility = Visibility.Hidden;
                Number.Content = "1/3";

            }
            else if (page == 2)
            {
                framereport.Navigate(r2);
                BPreview.Visibility = Visibility.Visible;
                Bnext.Visibility = Visibility.Visible;
                canvas.Visibility = Visibility.Hidden;
                Number.Content = "2/3";
            }
            else if (page == 3)
            {
                framereport.Navigate(r3);
                BPreview.Visibility = Visibility.Visible;
                Bnext.Visibility = Visibility.Hidden;
                canvas.Visibility = Visibility.Visible;
                Number.Content = "3/3";
            }


        }
        private void previewframe(object sender, RoutedEventArgs e)
        {
            if(page>1)
            {
                page--;
            }
            if (page == 1)
            {
                framereport.Navigate(r1);
                BPreview.Visibility = Visibility.Hidden;
                Bnext.Visibility = Visibility.Visible;
                canvas.Visibility = Visibility.Hidden;
                Number.Content = "1/3";

            }
            else if (page == 2)
            {
                framereport.Navigate(r2);
                BPreview.Visibility = Visibility.Visible;
                Bnext.Visibility = Visibility.Visible;
                canvas.Visibility = Visibility.Hidden;
                Number.Content = "2/3";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           r1 = new Report1();
            r2 = new Report2();
            r3 = new Report3();
            Report1.All.Clear();
            Report2.All.Clear();
            
            framereport.NavigationService.RemoveBackEntry();
            page = 1;
            framereport.Navigate(r1);
            BPreview.Visibility = Visibility.Hidden;
            Bnext.Visibility = Visibility.Visible;
            canvas.Visibility = Visibility.Hidden;
            Number.Content = "1/3";
        }


        void CopyPages(PdfSharp.Pdf.PdfDocument from, PdfSharp.Pdf.PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Report1 input1 = r1 as Report1;
            Report2 input2 = r2 as Report2;
            Report3 input3 = r3 as Report3;
            if (input1.TSBranch.Text.Length != 0)
            {
                try
                {
                    string titlte = "1.pdf";
                    //String timage = "image.pdf";
                    titlte = input1.TSBranch.Text + ".pdf";
                    string folder = "Report";
                    string subfolder = MainWindow.user;
                    string subfolder1 = "" + DateTime.Now.ToString("dd MM yyyy");
                    string subfolder2 = input1.TSBranch.Text;
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string path = "" + desktopPath + "\\" + folder;
                    string pathString = System.IO.Path.Combine(desktopPath, folder);
                    Directory.CreateDirectory(pathString);

                    pathString = System.IO.Path.Combine(path, subfolder);
                    Directory.CreateDirectory(pathString);
                    path = path + "\\" + subfolder;

                    pathString = System.IO.Path.Combine(path, subfolder1);
                    Directory.CreateDirectory(pathString);

                    path = path + "\\" + subfolder1;

                    pathString = System.IO.Path.Combine(path, subfolder2);
                    path = path + "\\" + subfolder2;
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path,true);
                    }
                    Directory.CreateDirectory(pathString);


        
                   

                    string pathpdf = path +"\\" + titlte;
                    MemoryStream lMemoryStream = new MemoryStream();
                    Package package = Package.Open(lMemoryStream, FileMode.OpenOrCreate);
                    XpsDocument doc = new XpsDocument(package);
                    
                    var writer = XpsDocument.CreateXpsDocumentWriter(doc);
                    
                    writer.Write(new Print1(input1.TSBranch.Text, input1.RVitrine.Value, input1.Rvitrine.Text,
                                    input1.Signage.Value, input1.RSignage.Text, input1.Branch.Value, input1.RBranch.Text,
                                    input1.Employee.Value, input1.REmployee.Text, input1.OrgSection.Value, input1.ROrgSection.Text, input1.OverRemarks.Text));

                    doc.Close();
                    package.Close();
                    var pdfXpsDoc = PdfSharp.Xps.XpsModel.XpsDocument.Open(lMemoryStream);
                    PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc, "1.pdf", 3);




                    MemoryStream lMemoryStream1 = new MemoryStream();
                    Package package1 = Package.Open(lMemoryStream1, FileMode.OpenOrCreate);
                    XpsDocument doc1 = new XpsDocument(package1);
                    var writer1 = XpsDocument.CreateXpsDocumentWriter(doc1);
                    writer1.Write(new Print2(input2.SEmployee.Value, input2.RSEmployee.Text, input2.SorgaSection.Value, input2.RSorgaSection.Text,
                        input2.OverRemarks1.Text, input2.ServiceEmployee.Value, input2.RServiceEmployee.Text, input2.ServiceOrgSection.Value,
                        input2.RServiceOrgSection.Text, input2.OverRemarks2.Text));
                    doc1.Close();
                    package1.Close();
                    var pdfXpsDoc1 = PdfSharp.Xps.XpsModel.XpsDocument.Open(lMemoryStream1);
                    PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc1, "2.pdf", 3);



                    MemoryStream lMemoryStream2 = new MemoryStream();
                    Package package2 = Package.Open(lMemoryStream2, FileMode.OpenOrCreate);
                    XpsDocument doc2 = new XpsDocument(package2);
                    var writer2 = XpsDocument.CreateXpsDocumentWriter(doc2);
                    writer2.Write(new Print3(input3.Overall.Value, input3.ROverall.Text, input3.Leadership.Value, input3.RLeadership.Text,
                        input3.Know.Value, input3.RKnow.Text, input3.Performance.Value, input3.RPerformance.Text, input3.Innovation.Value, input3.RInnovation.Text,
                        input3.comunication.Value, input3.Rcomunication.Text, input3.OverRemarks3.Text));
                    doc2.Close();
                    package2.Close();
                    var pdfXpsDoc2 = PdfSharp.Xps.XpsModel.XpsDocument.Open(lMemoryStream2);
                    PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc2, "3.pdf", 3);
                    PdfSharp.Pdf.PdfDocument outPdfs = new PdfSharp.Pdf.PdfDocument();
                    ArrayList merge = new ArrayList();



                    if (Report1.All.Count > 0 || Report2.All.Count > 0)
                    {

                        merge.AddRange(Report1.All);
                        merge.AddRange(Report2.All);

                    }
                    int l = 1;
                    foreach (var mg in merge)
                    {

                        string[] sp = mg.ToString().Split('!');
                        string pathimage = sp[1];
                        string destpath = path + "\\I_" + input1.TSBranch.Text + "_" + l + ".jpg";
                        if (File.Exists(destpath))
                        {
                            File.Delete(destpath);
                            File.Copy(pathimage, destpath);


                        }
                        else
                        {
                            System.IO.File.Copy(pathimage, destpath);

                        }
                        l++;
                    }


                    using (PdfSharp.Pdf.PdfDocument one = PdfReader.Open("1.pdf", PdfDocumentOpenMode.Import))
                    using (PdfSharp.Pdf.PdfDocument two = PdfReader.Open("2.pdf", PdfDocumentOpenMode.Import))
                    using (PdfSharp.Pdf.PdfDocument three = PdfReader.Open("3.pdf", PdfDocumentOpenMode.Import))
                    using (PdfSharp.Pdf.PdfDocument outPdf = new PdfSharp.Pdf.PdfDocument())
                    {
                        CopyPages(one, outPdf);
                        CopyPages(two, outPdf);
                        CopyPages(three, outPdf);
                        File.Delete(Directory.GetCurrentDirectory() + "\\1.pdf");
                        File.Delete(Directory.GetCurrentDirectory() + "\\2.pdf");
                        File.Delete(Directory.GetCurrentDirectory() + "\\3.pdf");
                        outPdf.Save(titlte);
                    }



                    string source = Directory.GetCurrentDirectory() + "\\" + titlte;

                    if (File.Exists(pathpdf))
                    {
                        File.Delete(pathpdf);
                        File.Move(source, pathpdf);

                        MessageBox.Show("Done", "Finished !!");

                    }
                    else
                    {
                        File.Move(source, pathpdf);
                        MessageBox.Show("Done", "Finished !!");

                    }
                    r1 = new Report1();
                    r2 = new Report2();
                    r3 = new Report3();
                    Report1.All.Clear();
                    Report2.All.Clear();

                    framereport.NavigationService.RemoveBackEntry();
                    page = 1;
                    framereport.Navigate(r1);
                    BPreview.Visibility = Visibility.Hidden;
                    Bnext.Visibility = Visibility.Visible;
                    canvas.Visibility = Visibility.Hidden;
                    Number.Content = "1/3";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error !!");
                }
            }
            else
            {


                page = 1;
                framereport.Navigate(r1);
                BPreview.Visibility = Visibility.Hidden;
                Bnext.Visibility = Visibility.Visible;
                canvas.Visibility = Visibility.Hidden;
                Number.Content = "1/3";
                MessageBox.Show("Insert The Branch", "Empty Branch !!");



            }

        }




    }
}
