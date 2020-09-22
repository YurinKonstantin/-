using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using ЭнергияМюонов.rezRachet;
using ЭнергияМюонов.представление_файлов;

namespace ЭнергияМюонов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public ClassFilesView ClassFilesView = new ClassFilesView();
        private void listProgect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ss = ((ListView)sender).SelectedItem.ToString();
            
            if(ss=="Файл")
            {//gfhfhfh
                PageFiles h = new PageFiles();
                h.ClassFilesView = ClassFilesView;
                frame.NavigationService.Navigate(h);


            }
            if (ss == "РасчетФайлов")
            {
                PageRas h = new PageRas();
                h.ClassFilesView = ClassFilesView;
                frame.NavigationService.Navigate(h);


            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
     
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            WindowFile passwordWindow = new WindowFile();

            if (passwordWindow.ShowDialog() == true)
            {
               List<ClassFile> classFiles = new List<ClassFile> ();
                classFiles = passwordWindow.classFiles;

                ClassFileEnDepotnD5565 g1 = new ClassFileEnDepotnD5565() { Name = classFiles.ElementAt(0).Name, path = classFiles.ElementAt(0).path };
                g1.openFile();
                ClassFilesView.classFiles.Add(g1);

                ClassFileEnDepotnD6575 g2 = new ClassFileEnDepotnD6575() { Name = classFiles.ElementAt(1).Name, path = classFiles.ElementAt(1).path };
                g2.openFile();
                ClassFilesView.classFiles.Add(g2);

                ClassFileEnDepotnD7585 g3 = new ClassFileEnDepotnD7585() { Name = classFiles.ElementAt(2).Name, path = classFiles.ElementAt(2).path };
                g3.openFile();
                ClassFilesView.classFiles.Add(g3);


                ClassFileEngDepthotn g4 = new ClassFileEngDepthotn() { Name = classFiles.ElementAt(3).Name, path = classFiles.ElementAt(3).path };
                g4.openFile();
                ClassFilesView.classFiles.Add(g4);

                ClassFileGMSdEdX g5 = new ClassFileGMSdEdX() { Name = classFiles.ElementAt(4).Name, path = classFiles.ElementAt(4).path };
                g5.openFile();
                ClassFilesView.classFiles.Add(g5);

                listProgect.Items.Add("Файл");
            }
            else
            {
                MessageBox.Show("Файлы не открыты");
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            var f4 = ClassFilesView.classFiles.ElementAt(4) as ClassFileGMSdEdX;


            var f = ClassFilesView.classFiles.ElementAt(0) as ClassFileEnDepotnD5565;
            foreach (var d in f.classstringDepotn5565s)
            {
                ClassFilesView.RazEnDepotnD5565s.Add(new ClassRazEnDepotnD6575() { lgD = d.lgD, otn = d.otn, otnerror = d.otnerror, eventGMS = f4.classstringDepotn5565s });
            }
           

            var f1 = ClassFilesView.classFiles.ElementAt(1) as ClassFileEnDepotnD6575;
            foreach (var d in f1.classstringDepotn5565s)
            {
                ClassFilesView.RazEnDepotnD6575s.Add(new ClassRazEnDepotnD6575() { lgD = d.lgD, otn = d.otn, otnerror = d.otnerror, eventGMS = f4.classstringDepotn5565s });
            }
         

            var f2 = ClassFilesView.classFiles.ElementAt(2) as ClassFileEnDepotnD7585;
            foreach (var d in f2.classstringDepotn5565s)
            {
                ClassFilesView.RazEnDepotnD7585s.Add(new ClassRazEnDepotnD6575() { lgD = d.lgD, otn = d.otn, otnerror = d.otnerror, eventGMS = f4.classstringDepotn5565s });
            }
          

            var f3 = ClassFilesView.classFiles.ElementAt(3) as ClassFileEngDepthotn;
            foreach (var d in f3.classstringDepotn5565s)
            {
                ClassFilesView.RazEnDepotnDs.Add(new ClassRazEnDepotnD() { theta = d.theta, otn = d.otn, otnerror = d.otnerror, eventGMS = f4.classstringDepotn5565s });
            }
            
            listProgect.Items.Add("РасчетФайлов");
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.Title = "EngDepTheta";
            dlg.IsFolderPicker = true;
            //dlg.InitialDirectory = currentDirectory;

            dlg.AddToMostRecentlyUsedList = false;
            dlg.AllowNonFileSystemItems = false;
            // dlg.DefaultDirectory = currentDirectory;
            dlg.EnsureFileExists = true;
            dlg.EnsurePathExists = true;
            dlg.EnsureReadOnly = false;
            dlg.EnsureValidNames = true;
            dlg.Multiselect = false;
            dlg.ShowPlacesList = true;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
               
                
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(dlg.FileName + @"\RazEnDepotnD5565s.dat"))
                    {
                        string s = "lgD" + "\t" + "otn" + "\t" + "otnerror" + "\t" + "X_Em" +"\t"+ "X_EmError1"+ "\t" + "X_EmError2" + "\n";
                        foreach (var f in ClassFilesView.RazEnDepotnD5565s)
                        {
                            s += f.lgD.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otn.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otnerror.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_Em.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError1.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError2.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\n";
                        }
                        byte[] info = new UTF8Encoding(true).GetBytes(s);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }
                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(dlg.FileName + @"\RazEnDepotnD6575s.dat"))
                    {
                        string s = "lgD" + "\t" + "otn" + "\t" + "otnerror" + "\t" + "X_Em" + "\t" + "X_EmError1" + "\t" + "X_EmError2" + "\n";
                        foreach (var f in ClassFilesView.RazEnDepotnD6575s)
                        {
                            s += f.lgD.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otn.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otnerror.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_Em.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError1.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError2.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\n";
                        }
                        byte[] info = new UTF8Encoding(true).GetBytes(s);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(dlg.FileName + @"\RazEnDepotnD7585s.dat"))
                    {
                        string s = "lgD" + "\t" + "otn" + "\t" + "otnerror" + "\t" + "X_Em" + "\t" + "X_EmError1" + "\t" + "X_EmError2" + "\n";
                        foreach (var f in ClassFilesView.RazEnDepotnD7585s)
                        {
                            s += f.lgD.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otn.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otnerror.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_Em.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError1.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError2.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\n";
                        }
                        byte[] info = new UTF8Encoding(true).GetBytes(s);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(dlg.FileName + @"\RazEnDepotnDs.dat"))
                    {
                        string s = "theta" + "\t" + "otn" + "\t" + "otnerror" + "\t" + "X_Em" + "\t" + "X_EmError1" + "\t" + "X_EmError2" + "\n";
                        foreach (var f in ClassFilesView.RazEnDepotnDs)
                        {
                            s += f.theta.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otn.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.otnerror.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_Em.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError1.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\t" + f.X_EmError2.ToString(".00000", System.Globalization.CultureInfo.InvariantCulture) + "\n";
                        }
                        byte[] info = new UTF8Encoding(true).GetBytes(s);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
                MessageBox.Show("Конец");

            }
        }
    }
}
