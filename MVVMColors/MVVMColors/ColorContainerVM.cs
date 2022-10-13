using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVVMColors
{
    internal class ColorContainerVM : INotifyPropertyChanged
    {

        public ColorContainer? model;

        public ObservableCollection<ListBoxItem> colorList = new();

        public ColorContainerVM()
        {
            model = new ColorContainer() { A = 255, R = 168, G = 168, B = 168 };
            colorList.Add(new());
            colorList.Add(new());
            colorList.Add(new());
        }

        public int A
        {
            get { return model.A; }
            set
            {
                model.A = value;
                OnPropertyChanged("A");
            }
        }

        public int R
        {
            get { return model.R; }
            set
            {
                model.R = value;
                OnPropertyChanged("R");
            }
        }
        
        public int G
        {
            get { return model.G; }
            set
            {
                model.G = value;
                OnPropertyChanged("G");
            }
        }

        public int B
        {
            get { return model.B; }
            set
            {
                model.B = value;
                OnPropertyChanged("B");
            }   
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
