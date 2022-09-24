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

namespace Grid_Buttons
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Grid grid = new();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var row = new RowDefinition();
                    row.Height = GridLength.Auto;

                    var col = new ColumnDefinition();
                    col.Width = GridLength.Auto;

                    grid.ColumnDefinitions.Add(col);
                    grid.RowDefinitions.Add(row);

                    var button = new Button();
                    button.Width = 30;
                    button.Height = 30;
                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);
                    grid.Children.Add(button);
                }

            }


            Window.Content = grid;

        }
    }
}
