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

namespace classmaster.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
    
            
        }

        private void AuthClick(object sender, RoutedEventArgs e)
        {

        }

        private void HealthCardClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void ClassroomLessonsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClassroomLessons());
        }

        private void EventsButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Events());
        }

        private void SkipsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Skips());
        }

        private void TeachersClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Teachers());
        }

        private void SubjectsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Subjects());
        }

        private void ParentsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Parents());
        }
    }
}