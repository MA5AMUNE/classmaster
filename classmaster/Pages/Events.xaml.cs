using classmaster.Model;
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
    /// Логика взаимодействия для Events.xaml
    /// </summary>
    public partial class Events : Page
    {
        DB DB { get; set; } = new DB();
        public ClassEvents ClassEvent { get; set; } = new ClassEvents();
        public Events(ClassEvents classEvent)
        {
            ClassEvent = DB.ClassEvents.FirstOrDefault(c => c.Id == classEvent.Id); 
            InitializeComponent();
        }
        public Events()
        {
            DB.ClassEvents.Add(ClassEvent);
            InitializeComponent();
        }


        private void CheckAllSob(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EventTable());
        }

        private void SaveChanges(object sender, RoutedEventArgs e)
        {

            DB.SaveChanges();

        }

        private void CreateNew(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Events());

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            DB.ClassEvents.Remove(ClassEvent);
            SaveChanges(null, null);
            NavigationService.Navigate(new EventTable());  
        }
    }
}
