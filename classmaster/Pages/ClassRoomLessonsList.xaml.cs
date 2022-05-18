using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classmaster.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace classmaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClassroomLessonsList.xaml
    /// </summary>
    public partial class ClassroomLessonsList : Page
    {
        DB DB { get; set; } = new DB();
        public ClassroomLessonsList()
        {
            InitializeComponent();
            DataGridCRL.ItemsSource = DB.ClassroomLessons.ToList();
        }
        private void DataGridCRL_SelectionChanged(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClassroomLessons(DataGridCRL.CurrentItem as Model.ClassroomLessons));
        }
    }
}
