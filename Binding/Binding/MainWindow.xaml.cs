using System;
using System.Collections.Generic;
using System.IO;
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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            foreach(var f in Directory.GetFiles("img"))
            {
                Listbox.Items.Add(@"C:\Users\luche\Desktop\HereWeGoAgain\Binding\Binding\bin\Debug\net6.0-windows\"+f);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Rectangle().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Person().Show();
        }
    }
}
