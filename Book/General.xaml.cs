using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для General.xaml
    /// </summary>
    public partial class General : Window
    {
        public int CounterProgressTest;
        public int ProgressTest;
        public int CounterProgressLection;
        public int CounterLection;
        public int Counter;

        List<Test> tests = new List<Test>();
        public General()
        {
            InitializeComponent();
        }

        
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Visibility = Visibility.Visible;
            Menu.Visibility = Visibility.Hidden;
            StackPanel2.Visibility = Visibility.Hidden;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Visibility = Visibility.Hidden;
            Menu.Visibility = Visibility.Visible;
            StackPanel2.Visibility = Visibility.Visible;
        }

        
        private void lek1_Click(object sender, RoutedEventArgs e) 
        {
            CounterLection = 1;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[0].Questions;
            answerButText1.Text = tests[0].answerOption_1;
            answerButText2.Text = tests[0].answerOption_2;
            answerButText3.Text = tests[0].answerOption_3;
        }

        private void lek2_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 2;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            
            question.Text  = tests[4].Questions;
            answerButText1.Text = tests[4].answerOption_1;
            answerButText2.Text = tests[4].answerOption_2;
            answerButText3.Text = tests[4].answerOption_3;
           
            
        }

        private void lek3_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 3;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[1].Questions;
            answerButText1.Text = tests[1].answerOption_1;
            answerButText2.Text = tests[1].answerOption_2;
            answerButText3.Text = tests[1].answerOption_3;
        }

        private void lek4_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 4;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[2].Questions;
            answerButText1.Text = tests[2].answerOption_1;
            answerButText2.Text = tests[2].answerOption_2;
            answerButText3.Text = tests[2].answerOption_3;
        }

        private void lek5_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 5;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[3].Questions;
            answerButText1.Text = tests[3].answerOption_1;
            answerButText2.Text = tests[3].answerOption_2;
            answerButText3.Text = tests[3].answerOption_3;
        }

        private void lek6_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 6;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[5].Questions;
            answerButText1.Text = tests[5].answerOption_1;
            answerButText2.Text = tests[5].answerOption_2;
            answerButText3.Text = tests[5].answerOption_3;
        }

        private void lek7_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 7;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[6].Questions;
            answerButText1.Text = tests[6].answerOption_1;
            answerButText2.Text = tests[6].answerOption_2;
            answerButText3.Text = tests[6].answerOption_3;
        }

        private void lek8_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 8;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[7].Questions;
            answerButText1.Text = tests[7].answerOption_1;
            answerButText2.Text = tests[7].answerOption_2;
            answerButText3.Text = tests[7].answerOption_3;
        }

        private void lek9_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 9;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[8].Questions;
            answerButText1.Text = tests[8].answerOption_1;
            answerButText2.Text = tests[8].answerOption_2;
            answerButText3.Text = tests[8].answerOption_3;
        }

        private void lek10_Click(object sender, RoutedEventArgs e)
        {
            CounterLection = 10;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Hidden;
            StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            question.Text = tests[9].Questions;
            answerButText1.Text = tests[9].answerOption_1;
            answerButText2.Text = tests[9].answerOption_2;
            answerButText3.Text = tests[9].answerOption_3;
        }

        private void Vixod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow general = new MainWindow();
            this.Hide();
            general.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void lk_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account();
            this.Hide();
            acc.ShowDialog();

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Counter++;
            CounterLection ++;
            if (CounterLection == 10)
            {
                Enter.Visibility = Visibility.Hidden;
                question.Text = tests[9].Questions;
                answerButText1.Text = tests[9].answerOption_1;
                answerButText2.Text = tests[9].answerOption_2;
                answerButText3.Text = tests[9].answerOption_3;
            }
            if (CounterLection == 9)
            {
                question.Text = tests[8].Questions;
                answerButText1.Text = tests[8].answerOption_1;
                answerButText2.Text = tests[8].answerOption_2;
                answerButText3.Text = tests[8].answerOption_3;
            }
            else if (CounterLection == 8)
            {
                question.Text = tests[7].Questions;
                answerButText1.Text = tests[7].answerOption_1;
                answerButText2.Text = tests[7].answerOption_2;
                answerButText3.Text = tests[7].answerOption_3;
            }
            else if (CounterLection == 7)
            {
                question.Text = tests[6].Questions;
                answerButText1.Text = tests[6].answerOption_1;
                answerButText2.Text = tests[6].answerOption_2;
                answerButText3.Text = tests[6].answerOption_3;
            }
            else if (CounterLection == 6)
            {
                question.Text = tests[5].Questions;
                answerButText1.Text = tests[5].answerOption_1;
                answerButText2.Text = tests[5].answerOption_2;
                answerButText3.Text = tests[5].answerOption_3;
            }
            else if (CounterLection == 5)
            {
                question.Text = tests[3].Questions;
                answerButText1.Text = tests[3].answerOption_1;
                answerButText2.Text = tests[3].answerOption_2;
                answerButText3.Text = tests[3].answerOption_3;
            }
            else if (CounterLection == 4)
            {
                question.Text = tests[2].Questions;
                answerButText1.Text = tests[2].answerOption_1;
                answerButText2.Text = tests[2].answerOption_2;
                answerButText3.Text = tests[2].answerOption_3;
            }
            else if (CounterLection == 3)
            {
                question.Text = tests[1].Questions;
                answerButText1.Text = tests[1].answerOption_1;
                answerButText2.Text = tests[1].answerOption_2;
                answerButText3.Text = tests[1].answerOption_3;
            }
            else if (CounterLection == 2)
            {
                question.Text = tests[4].Questions;
                answerButText1.Text = tests[4].answerOption_1;
                answerButText2.Text = tests[4].answerOption_2;
                answerButText3.Text = tests[4].answerOption_3;
            }
            if (CounterLection < 11)
            {
                StreamReader sr = new StreamReader($@"le\{CounterLection}.txt");
                TextLecture.Text = sr.ReadToEnd();
            }
            if (CounterLection > CounterProgressLection)
            {
                CounterProgressLection = CounterLection;
            }
            usersData.ProgressLection = CounterProgressLection-1;
            context.User.Where(x => x.idUser.Equals(usersData.idUser)).First().ProgressLection = usersData.ProgressLection;
            context.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tests.AddRange(context.Test.ToList());
        }

        private void pas_Click(object sender, RoutedEventArgs e)
        {
           
            if (Counter == 0)
            {
                Counter = CounterLection-1;
            }
            if (Counter == 9)
            {
                if (tests[9].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            if (Counter == 8)
            {
                if (tests[8].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                    ProgressTest++;
                }

            }
            else if (Counter == 7)
            {
                if (tests[7].Answer == 3 && answerBut3.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 6)
            {
                if (tests[6].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }

            }
            else if (Counter == 5)
            {
                if (tests[5].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 4)
            {
                if (tests[3].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 3)
            {
                if (tests[2].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 2)
            {
                if (tests[1].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 1)
            {
                if (tests[4].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (Counter == 0)
            {
                if (tests[0].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }

            if ( ProgressTest > CounterProgressTest)
            {
                CounterProgressTest = ProgressTest;
            }
            usersData.ProgressTest = CounterProgressTest;
            context.User.Where(x => x.idUser.Equals(usersData.idUser)).First().ProgressTest = usersData.ProgressTest;
            context.SaveChanges();
        }
    }
}
