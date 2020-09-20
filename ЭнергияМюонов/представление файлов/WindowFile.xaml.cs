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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ЭнергияМюонов.представление_файлов
{
    /// <summary>
    /// Логика взаимодействия для WindowFile.xaml
    /// </summary>
    public partial class WindowFile : Window
    {
        public WindowFile()
        {
            InitializeComponent();
        }
        public List<ClassFile> classFiles = new List<ClassFile>();
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                name1.Text = openFileDialog.FileName;
                classFiles.Add(new ClassFile() { Name=openFileDialog.SafeFileName, path= openFileDialog.FileName });
            }
               
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                name2.Text = openFileDialog.FileName;
                classFiles.Add(new ClassFile() { Name = openFileDialog.SafeFileName, path = openFileDialog.FileName });
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                name3.Text = openFileDialog.FileName;
                classFiles.Add(new ClassFile() { Name = openFileDialog.SafeFileName, path = openFileDialog.FileName });
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                name4.Text = openFileDialog.FileName;
                classFiles.Add(new ClassFile() { Name = openFileDialog.SafeFileName, path = openFileDialog.FileName });
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                name5.Text = openFileDialog.FileName;
                classFiles.Add(new ClassFile() { Name = openFileDialog.SafeFileName, path = openFileDialog.FileName });
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

            classFiles.Clear();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {

                var dir = new System.IO.DirectoryInfo(folderBrowser.SelectedPath);
                var d = dir.GetFiles();
                foreach(var f in d)
                {
                   if(f.Name== "EnDepotnD5565.dat")
                    {
                        name1.Text = f.Name;
                        classFiles.Add(new ClassFile() { Name = f.Name, path = f.FullName });
                    }
                }
                foreach (var f in d)
                {
                    if (f.Name == "EnDepotnD6575.dat")
                    {
                        name2.Text = f.Name;
                        classFiles.Add(new ClassFile() { Name = f.Name, path = f.FullName });
                    }
                }
                foreach (var f in d)
                {
                    if (f.Name == "EnDepotnD7585.dat")
                    {
                        name3.Text = f.Name;
                        classFiles.Add(new ClassFile() { Name = f.Name, path = f.FullName });
                    }
                }
                foreach (var f in d)
                {
                    if (f.Name == "EngDepthotn.dat")
                    {
                        name4.Text = f.Name;
                        classFiles.Add(new ClassFile() { Name = f.Name, path = f.FullName });
                    }
                }
                foreach (var f in d)
                {
                    if (f.Name == "GMSdEdX.dat")
                    {
                        name5.Text = f.Name;
                        classFiles.Add(new ClassFile() { Name = f.Name, path = f.FullName });
                    }
                }

            }
        }
    }
}
