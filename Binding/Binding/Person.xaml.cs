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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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
