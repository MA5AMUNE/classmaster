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
    /// Логика взаимодействия для EventTable.xaml
    /// </summary>
    public partial class EventTable : Page
    {
        DB DB { get; set; } = new DB();
        public EventTable()
        {
            InitializeComponent();
            DataGridEvents.ItemsSource = DB.ClassEvents.ToList();   
        }

        private void DataGridEvents_SelectionChanged(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Events(DataGridEvents.CurrentItem as ClassEvents));
        }
    }
}
