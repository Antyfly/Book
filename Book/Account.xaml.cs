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
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {

        public Account()
        {

            InitializeComponent();
            surName.Text = usersData.Surname;
            furtName.Text = usersData.Name;
            Patr.Text = usersData.Patronymic;
            ProgressLector.Value = (Convert.ToDouble(usersData.ProgressLection)*100)/10;
            ProgressTest.Value = (Convert.ToDouble(usersData.ProgressTest)*100) / 10;
            
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            General gen = new General();
            this.Hide();
            gen.ShowDialog();
        }
    }
    
}
