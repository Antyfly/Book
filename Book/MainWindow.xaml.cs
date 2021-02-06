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

namespace Book
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EntitiesBook context = new EntitiesBook();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.ShowDialog();

        }

        private void log_GotFocus(object sender, RoutedEventArgs e)
        {
            log.Text = "";
        }

        private void log_LostFocus(object sender, RoutedEventArgs e)
        {
            if (log.Text == "")
            {
                log.Text = "Введите логин";
            }
        }

        private void pas_GotFocus(object sender, RoutedEventArgs e)
        {
                pas.Text = "";
        }

        private void pas_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pas.Text == "")
            {
                pas.Text = "Введите пароль";
            }
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            /*
            var qwery = context.Users.Where(i => i.Login == log.Text && i.Password == pas.Text).ToList();
            if (qwery.Count>0)
            {
                General general = new General();
                this.Hide();
                general.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такой пользователь не зарегистрирован.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            */
            if (log.Text == "Admin" && pas.Text == "admin")
            {
                General general = new General();
                this.Hide();
                general.ShowDialog();
            }
            else
            {
                MessageBox.Show("Такой пользователь не зарегистрирован.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
