using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Text.Json.Serialization;
using System.Windows.Threading;
using System.IO;
using System.Text.Json;

namespace Binding
{
    /// <summary>
    /// Interaction logic for Person.xaml
    /// </summary>
    public partial class Person : Window
    {
        private PersonTest person;

        public Person()
        {
            person = new PersonTest();
            person.PropertyChanged += OnPropertyChanged;
            InitializeComponent();
        }

        DispatcherTimer timer;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        bool fileFlag = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            fileFlag = true;
            try
            {

                if (File.Exists("person.json"))
                {
                    using (var sr = new StreamReader("person.json"))
                    {

                        var name = sr.ReadLine();
                        var surname = sr.ReadLine();
                        var age = sr.ReadLine();

                        person.name = name;
                        person.surname = surname;
                        person.age = Int32.Parse(age);
                    }
                }

            }
            catch(IOException)
            {
                MessageBox.Show("File is opened by another app!");
            }
            fileFlag = false;
        }

        private void Button_Show_Click(object sender, RoutedEventArgs e)
        {
            var p = stackpanel.Resources["source"] as PersonTest;

            surname.Text = p.surname;
            name.Text = p.name;
            age.Text = p.age.ToString();
        }

        private void Button_Refresh_Click(object sender, RoutedEventArgs e)
        {
            surname.Text = "";
            name.Text = "";
            age.Text = "";
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            stackpanel.Resources["source"] = person;

            if (!fileFlag)
            {
                try
                {
                    using (var sw = new StreamWriter("person.json"))
                    {
                        sw.WriteLine(person.name);
                        sw.WriteLine(person.surname);
                        sw.WriteLine(person.age);
                    }
                }
                catch { }
            }
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text))
            {
                person.name = name.Text;
            }
        }

        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(surname.Text))
            {
                person.surname = surname.Text;
            }
        }

        private void age_TextChanged(object sender, TextChangedEventArgs e)
        {
            person.age = Int32.Parse(age.Text);
        }


    }


}
