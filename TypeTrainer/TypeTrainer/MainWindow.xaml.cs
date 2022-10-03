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

namespace TypeTrainer
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

        public event EventHandler<EventArgs> keyDown;
        

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(sender .ToString() +"K "+ e.Key.ToString());
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(sender .ToString() +"P "+ e.Key.ToString());

        }


    }
}
