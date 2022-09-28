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

namespace RoutingEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(sender as MainWindow is not null)
            {
                this.Title = Text.Text;
            }
            
            else if(sender as TextBox is not null && ((bool)Check.IsChecked) is true)
            {
                (sender as TextBox).Text += e.Key.ToString();
            }

            e.Handled = (bool)Check.IsChecked;

        }
    }
}
