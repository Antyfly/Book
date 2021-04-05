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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        List<User> useri = new List<User>();

        public Admin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            useri.AddRange(context.User.Where(i => i.idRole == 2).ToList());

            List<View> views = new List<View>();
            for (int i = 0; i < useri.Count; i++)
            {
                int idUs = useri[i].idUser;
                View view = new View();
                view.name = useri[i].Name;
                view.surname = useri[i].Surname;
                view.patronymic = useri[i].Patronymic;
                view.progressLector = Convert.ToInt32(context.User.Where(c => c.idUser == idUs).Select(j => j.ProgressLection).FirstOrDefault());
                view.procentLector =  Convert.ToInt32(((context.User.Where(c => c.idUser == idUs).Select(j => j.ProgressLection).FirstOrDefault())*100)/10);
                view.progressTest = Convert.ToInt32(context.User.Where(c => c.idUser == idUs).Select(j => j.ProgressTest).FirstOrDefault());
                view.procentTest = Convert.ToInt32(((context.User.Where(c => c.idUser == idUs).Select(j => j.ProgressTest).FirstOrDefault()) *100)/10);
                views.Add(view);
            }

            listUsers.ItemsSource = views;

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



    }
}
        
    
