using System;
using System.Collections.Generic;
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
            {
                PageFiles h = new PageFiles();
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
    }
}
