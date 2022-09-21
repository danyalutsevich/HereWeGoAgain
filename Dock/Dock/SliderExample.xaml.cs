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

namespace Dock
{
    /// <summary>
    /// Interaction logic for SliderExample.xaml
    /// </summary>
    public partial class SliderExample : Window
    {
        public SliderExample()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                this.Background = new SolidColorBrush(Color.FromRgb((byte)SliderR.Value, (byte)SliderG.Value, (byte)SliderB.Value));
            }
            catch { }

        }
    }
}
