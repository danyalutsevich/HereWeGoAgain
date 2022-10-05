using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Binding
{
    public class PersonTest : INotifyPropertyChanged
    {
        public string? _name = "name from class";
        public string? _surname = "surname form class";
        public int _age = 32;

        public string? name
        {
            get { return _name; }
            set
            {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("name"));
            }
        }
        public string? surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                PropertyChanged(this, new PropertyChangedEventArgs("surname"));
            }
        }
        public int age
        {
            get { return _age; }
            set
            {
                _age = value;
                PropertyChanged(this, new PropertyChangedEventArgs("age"));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return name + " " + surname + " " + age;
        }
    }
}
