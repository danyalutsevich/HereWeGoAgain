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
        private string? _name = "name from class";
        private string? _surname = "surname form class";
        private int _age = 32;

        public event PropertyChangedEventHandler? PropertyChanged;
        
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
        public override string ToString()
        {
            return name + " " + surname + " " + age;
        }
    }
}
