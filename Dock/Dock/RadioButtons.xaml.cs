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
    /// Interaction logic for RadioButtons.xaml
    /// </summary>
    public partial class RadioButtons : Window
    {
        public RadioButtons()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Pink;
        }
    }
}
