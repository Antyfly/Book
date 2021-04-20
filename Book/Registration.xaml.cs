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
using System.Windows.Shapes;
using static Book.AppData;
namespace Book
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        

        public Registration()
        {
            InitializeComponent();
        }

        private void logup2_Click(object sender, RoutedEventArgs e)
        {
            if (log2.Text != "Введите логин" && pas2.Text != "Введите пароль" && Sname.Text!="Введите фамилию" && Name.Text!= "Введите имя")
            {
                var result = MessageBox.Show("Вы уверены, что хотите зарегистрироваться???", "Сообщение", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    var qwery = context.User.Where(i => i.login == log2.Text && i.password == pas2.Text).ToList();
                    if (qwery.Count>0)
                    {
                        MessageBox.Show("Такой пользователь уже зарегистрирован.", "Ошибка при входе", MessageBoxButton.OK, MessageBoxImage.Error);
                        log2.Text = "";
                        pas2.Text = "";
                    }
                    else
                    {
                        if (Mname.Text != "Введите отчество" && Mname.Text != "")
                        {
                            context.User.Add(new User
                            {
                                login = log2.Text,
                                password = pas2.Text,
                                Surname = Sname.Text,
                                Name = Name.Text,
                                Patronymic = Mname.Text,
                                idRole = 2,
                                ProgressTest = 0,
                                ProgressLection = 0,
                            });
                        }
                        else
                        {
                            context.User.Add(new User
                            {
                                login = log2.Text,
                                password = pas2.Text,
                                Surname = Sname.Text,
                                Name = Name.Text,
                                Patronymic = null,
                                idRole = 2,
                                ProgressTest = 0,
                                ProgressLection = 0,
                            });
                        }
                        context.SaveChanges();
                        MessageBox.Show("Данные успешно сохранены");
                        MainWindow menu = new MainWindow();
                        this.Hide();
                        menu.ShowDialog();

                    }
                }
                else if (result==MessageBoxResult.No)
                {
                    log2.Text = "Введите логин";
                    pas2.Text = "Введите пароль";
                    Sname.Text = "Введите фамилию";
                    Name.Text = "Введите имя";
                    Mname.Text = "Введите отчество";
                    
                }
            }
            else
            {
                MessageBox.Show("Заполните все Обязательные поля!!!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        
               
        private void log2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (log2.Text == "Введите логин")
            {
                log2.Foreground = Brushes.Black;
                log2.Text = "";
            }
            
        }
        private void log2_LostFocus(object sender, RoutedEventArgs e)
        {
           if (log2.Text == "")
            {
                log2.Foreground = Brushes.Gray;
                log2.Text = "Введите логин";
            }
        }
        private void pas2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pas2.Text == "Введите пароль")
            {
                pas2.Foreground = Brushes.Black;
                pas2.Text = "";
            }
        }

        private void pas2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pas2.Text == "")
            {
                pas2.Foreground = Brushes.Gray;
                pas2.Text = "Введите пароль";
            }
        }

        
        private void Sname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Sname.Text == "Введите фамилию")
            {
                Sname.Foreground = Brushes.Black;
                Sname.Text = "";
            }
           
        }
        private void Sname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Sname.Text == "")
            {
                Sname.Foreground = Brushes.Gray;
                Sname.Text = "Введите фамилию";
            }
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "Введите имя")
            {
                Name.Foreground = Brushes.Black;
                Name.Text = "";
            }
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Foreground = Brushes.Gray;
                Name.Text = "Введите имя";
            }
        }

        
        private void Mname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Mname.Text == "Введите отчество")
            {
                Mname.Foreground = Brushes.Black;
                Mname.Text = "";
            }
        }
        private void Mname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Mname.Text == "")
            {
                Mname.Foreground = Brushes.Gray;
                Mname.Text = "Введите отчество";
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow general = new MainWindow();
            this.Hide();
            general.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
