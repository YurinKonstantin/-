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
using ЭнергияМюонов.представление_файлов;

namespace ЭнергияМюонов.rezRachet
{
    /// <summary>
    /// Логика взаимодействия для PageRas.xaml
    /// </summary>
    public partial class PageRas : Page
    {
        public PageRas()
        {
            InitializeComponent();
        }
        public ClassFilesView ClassFilesView = new ClassFilesView();
        

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
            

          
            phonesGrid.ItemsSource = ClassFilesView.RazEnDepotnD5565s;

         
            phonesGrid1.ItemsSource = ClassFilesView.RazEnDepotnD6575s;

          
            phonesGrid2.ItemsSource = ClassFilesView.RazEnDepotnD7585s;

           
            phonesGrid3.ItemsSource = ClassFilesView.RazEnDepotnDs;
        }
    }
}
