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
using static Book.AppData;

namespace Book
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            if (log.Text == "Введите логин")
            {
                log.Text = "";
            }
            
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
            if (pas.Text == "Введите пароль")
            {
                pas.Text = "";
            }
                
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
            
            var qwery = context.User.Where(i => i.login == log.Text && i.password == pas.Text).FirstOrDefault();
            int idRole = context.User.Where(i => i.login == log.Text).Select(j => j.idRole).FirstOrDefault();
           
            if (qwery != null && idRole == 2)
            {
                usersData = qwery;
                General general = new General();
                this.Hide();
                general.ShowDialog();
            }
            else if (qwery != null && idRole == 1)
            {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
            }
            else if (log.Text == "Введите логин" || pas.Text == "Введите пароль")
            {
                    MessageBox.Show("ВВЕДИТЕ ДАННЫЕ ДЛЯ ВХОДА!!!", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Такой пользователь не зарегистрирован.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
