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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMColors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<ListBoxItem> colorList = new();

        public MainWindow()
        {
            InitializeComponent();
            flag = true;
        }

        bool flag = false;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var color = new ColorContainer() { R = (int)Rslider.Value, G = (int)Gslider.Value, B = (int)Bslider.Value, A = (int)Aslider.Value };
           

            colorList.Add(new ListBoxItem {Background= new SolidColorBrush(Color.FromArgb((byte)color.A, (byte)color.R, (byte)color.G, (byte)color.B)), Content = color });
            //listbox.Items.Clear();
            listbox.Items.Add(colorList[colorList.Count-1]);

        }

        private void Rslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(flag)
            BAdd.Background = new SolidColorBrush(Color.FromArgb((byte)Aslider.Value, (byte)Rslider.Value, (byte)Gslider.Value, (byte)Bslider.Value));
        }
    }

    class ColorContainer
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int A { get; set; }

        public override string ToString()
        {
            return $"R:{R}G:{G}B:{B}A:{A}";
        }


    }
}
