using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ColorContainerVM VMColora;

        public MainWindow()
        {
            InitializeComponent();
            //VMColor = new();
            DataContext = VMColor;
            VMColor.PropertyChanged += PropChanged;

        }

        private void PropChanged(object sender, PropertyChangedEventArgs e)
        {
            //VMColor.A = (int)Aslider.Value;
            //VMColor.R = (int)Rslider.Value;
            //VMColor.G = (int)Gslider.Value;
            //VMColor.B = (int)Bslider.Value;
            try
            {
                BAdd.Background = new SolidColorBrush(Color.FromArgb((byte)VMColor.A, (byte)VMColor.R, (byte)VMColor.G, (byte)VMColor.B));
            }
            catch { }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var color = new ColorContainer() { R = VMColor.R, G = VMColor.G, B = VMColor.B, A = VMColor.A };

            var data = DataContext as ColorContainerVM;
            data.colorList.Add(new ListBoxItem() { Content = data.model , Background = new SolidColorBrush() { Color = Color.FromArgb((byte) data.A, (byte)data.R, (byte)data.G, (byte)data.B) } });

            //listbox.Items.Clear();
            listbox.Items.Add(VMColor.colorList[VMColor.colorList.Count - 1]);
        }

        private void Rslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }
    }


}
