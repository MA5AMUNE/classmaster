using System;
using classmaster.Model;
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

namespace classmaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClassroomLessons.xaml
    /// </summary>
    public partial class ClassroomLessons : Page
    {
        DB DB { get; set; } = new DB();
        public Model.ClassroomLessons ClassroomLesson { get; set; }
        public ClassroomLessons(Model.ClassroomLessons classroomLesson)
        {
            ClassroomLesson = classroomLesson;
            InitializeComponent();
        }

        private void CheckAllCRL(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClassroomLessonsList());
        }

        private void CreateNew(object sender, RoutedEventArgs e)
        {
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
        }
    }
}
