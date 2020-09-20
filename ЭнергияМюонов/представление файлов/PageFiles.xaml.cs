using System;
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
using ЭнергияМюонов.представление_файлов.stringFile;

namespace ЭнергияМюонов.представление_файлов
{
    /// <summary>
    /// Логика взаимодействия для PageFiles.xaml
    /// </summary>
    public partial class PageFiles : Page
    {
        public PageFiles()
        {
            InitializeComponent();
        }
        public ClassFilesView ClassFilesView = new ClassFilesView();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var f= ClassFilesView.classFiles.ElementAt(0) as ClassFileEnDepotnD5565;
            phonesGrid.ItemsSource = f.classstringDepotn5565s;

            var f1 = ClassFilesView.classFiles.ElementAt(1) as ClassFileEnDepotnD6575;
            phonesGrid1.ItemsSource = f1.classstringDepotn5565s;

            var f2 = ClassFilesView.classFiles.ElementAt(2) as ClassFileEnDepotnD7585;
            phonesGrid2.ItemsSource = f2.classstringDepotn5565s;

            var f3 = ClassFilesView.classFiles.ElementAt(3) as ClassFileEngDepthotn;
            phonesGrid3.ItemsSource = f3.classstringDepotn5565s;

            var f4 = ClassFilesView.classFiles.ElementAt(4) as ClassFileGMSdEdX;
            phonesGrid4.ItemsSource = f4.classstringDepotn5565s;

        }
    }
}
