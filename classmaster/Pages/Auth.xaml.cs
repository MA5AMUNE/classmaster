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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Введите Логин")
            {
                (sender as TextBox).Text = "";

            }
        }

        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Введите Пароль")
            {
                (sender as TextBox).Text = "";

            }
        }
    }
}
