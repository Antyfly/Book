﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            Back.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            StackPanel1.Visibility = Visibility.Hidden;
            Menu.Visibility = Visibility.Visible;
            StackPanel2.Visibility = Visibility.Visible;
            Back.Visibility = Visibility.Hidden;
        }


        private void lek1_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 1;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek2_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 2;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek3_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 3;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek4_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 4;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            
        }

        private void lek5_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 5;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek6_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 6;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek7_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 7;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            
        }

        private void lek8_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 8;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
        }

        private void lek9_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 9;
            Questions.Visibility = Visibility.Hidden;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            
        }

        private void lek10_Click(object sender, RoutedEventArgs e)
        {
            var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            CounterLection = 10;
            TextLect.Visibility = Visibility.Visible;
            Enter.Visibility = Visibility.Visible;
            Questions.Visibility = Visibility.Hidden;
            StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
            TextLecture.Text = sr.ReadToEnd();
            
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
            CounterLection++;
            CounterProgressLection++;
            TextLect.Visibility = Visibility.Hidden;
            Questions.Visibility = Visibility.Visible;
            if (CounterLection == 11)
            {
                CounterProgressLection++;
                question.Text = tests[9].Questions;
                answerButText1.Text = tests[9].answerOption_1;
                answerButText2.Text = tests[9].answerOption_2;
                answerButText3.Text = tests[9].answerOption_3;
            }
            else if (CounterLection == 10)
            {
                CounterProgressLection++;
                question.Text = tests[8].Questions;
                answerButText1.Text = tests[8].answerOption_1;
                answerButText2.Text = tests[8].answerOption_2;
                answerButText3.Text = tests[8].answerOption_3;
            }
            else if (CounterLection == 9)
            {
                CounterProgressLection++;
                question.Text = tests[7].Questions;
                answerButText1.Text = tests[7].answerOption_1;
                answerButText2.Text = tests[7].answerOption_2;
                answerButText3.Text = tests[7].answerOption_3;
            }
            else if (CounterLection == 8)
            {
                CounterProgressLection++;
                question.Text = tests[6].Questions;
                answerButText1.Text = tests[6].answerOption_1;
                answerButText2.Text = tests[6].answerOption_2;
                answerButText3.Text = tests[6].answerOption_3;
            }
            else if (CounterLection == 7)
            {
                CounterProgressLection++;
                question.Text = tests[5].Questions;
                answerButText1.Text = tests[5].answerOption_1;
                answerButText2.Text = tests[5].answerOption_2;
                answerButText3.Text = tests[5].answerOption_3;
            }
            else if (CounterLection == 6)
            {
                CounterProgressLection++;
                question.Text = tests[3].Questions;
                answerButText1.Text = tests[3].answerOption_1;
                answerButText2.Text = tests[3].answerOption_2;
                answerButText3.Text = tests[3].answerOption_3;
            }
            else if (CounterLection == 5)
            {
                CounterProgressLection++;
                question.Text = tests[2].Questions;
                answerButText1.Text = tests[2].answerOption_1;
                answerButText2.Text = tests[2].answerOption_2;
                answerButText3.Text = tests[2].answerOption_3;
            }
            else if (CounterLection == 4)
            {
                CounterProgressLection++;
                question.Text = tests[1].Questions;
                answerButText1.Text = tests[1].answerOption_1;
                answerButText2.Text = tests[1].answerOption_2;
                answerButText3.Text = tests[1].answerOption_3;
            }
            else if (CounterLection == 3)
            {
                CounterProgressLection++;
                question.Text = tests[4].Questions;
                answerButText1.Text = tests[4].answerOption_1;
                answerButText2.Text = tests[4].answerOption_2;
                answerButText3.Text = tests[4].answerOption_3;
            }

            else if (CounterLection == 2)
            {
                CounterProgressLection++;
                question.Text = tests[0].Questions;
                answerButText1.Text = tests[0].answerOption_1;
                answerButText2.Text = tests[0].answerOption_2;
                answerButText3.Text = tests[0].answerOption_3;

            }
            if (CounterLection < 11)
            {
                var appDir = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                StreamReader sr = new StreamReader($@"{appDir}\le\{CounterLection}.txt");
                TextLecture.Text = sr.ReadToEnd();
            }
            if (CounterProgressLection > usersData.ProgressLection)
            {
                usersData.ProgressLection = CounterProgressLection;
                context.User.Where(x => x.idUser.Equals(usersData.idUser)).First().ProgressLection = usersData.ProgressLection;
                context.SaveChanges();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tests.AddRange(context.Test.ToList());
        }

        private void pas_Click(object sender, RoutedEventArgs e)
        {
            
            if (CounterLection == 11)
            {
                    if (tests[9].Answer == 2 && answerBut2.IsChecked == true)
                    {
                        MessageBox.Show("Ответ верный!!!");
                        ProgressTest++;
                        Questions.Visibility = Visibility.Hidden;
                        TextLect.Visibility = Visibility.Hidden;
                    }
                    else
                        MessageBox.Show("Ответ неверный!!!");
            }
             else if (CounterLection == 10)
             {
                if (tests[8].Answer == 1 && answerBut1.IsChecked == true)
                    {
                        MessageBox.Show("Ответ верный!!!");
                        ProgressTest++;
                        Questions.Visibility = Visibility.Hidden;
                        TextLect.Visibility = Visibility.Visible;
                    }
                    else
                        MessageBox.Show("Ответ неверный!!!");
             }
             else  if (CounterLection == 9)
             {
                    if (tests[7].Answer == 3 && answerBut3.IsChecked == true)
                    {
                        MessageBox.Show("Ответ верный!!!");
                        ProgressTest++;
                        Questions.Visibility = Visibility.Hidden;
                        TextLect.Visibility = Visibility.Visible;
                    }
                    else
                        MessageBox.Show("Ответ неверный!!!");
            }
            else if (CounterLection == 8)
            {
                if (tests[6].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("Ответ неверный!!!");

            }
            else if (CounterLection == 7)
            {
                if (tests[5].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (CounterLection == 6)
            {
                if (tests[3].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (CounterLection == 5)
            {
                if (tests[2].Answer == 2 && answerBut2.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (CounterLection == 4)
            {
                if (tests[1].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (CounterLection == 3)
            {
                if (tests[4].Answer == 1 && answerBut1.IsChecked == true)
                {
                    MessageBox.Show("Ответ верный!!!");
                    ProgressTest++;
                    Questions.Visibility = Visibility.Hidden;
                    TextLect.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Ответ неверный!!!");
                }
            }
            else if (CounterLection == 2)
            {
                    if (tests[0].Answer == 1 && answerBut1.IsChecked == true)
                    {
                        MessageBox.Show("Ответ верный!!!");
                        Questions.Visibility = Visibility.Hidden;
                        TextLect.Visibility = Visibility.Visible;
                        ProgressTest++;
                }
                    else
                        MessageBox.Show("Ответ неверный!!!");
            }
            if (ProgressTest > 10)
            {
                ProgressTest = 10;
            }
            if (ProgressTest > usersData.ProgressTest)
            {
                usersData.ProgressTest = ProgressTest;
                context.User.Where(x => x.idUser.Equals(usersData.idUser)).First().ProgressTest = usersData.ProgressTest;
                context.SaveChanges();
            }

        }   

    }
}
