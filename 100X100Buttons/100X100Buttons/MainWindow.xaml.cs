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

namespace _100X100Buttons
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
            ScrollViewer scrollViewer = new();

            scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            
            Grid grid = new Grid();

            Button b = new Button();

            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var row = new RowDefinition();
                    //row.Height = GridLength.Auto;
                    grid.RowDefinitions.Add(row);

                    var column = new ColumnDefinition();
                    //column.Width = GridLength.Auto;
                    grid.ColumnDefinitions.Add(column);

                    Button button = new Button();
                    button.Content = $"{count}";
                    count++;
                    button.Height = 30;
                    button.Width = 30;

                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);

                    grid.Children.Add(button);
                    
                }
            }

            scrollViewer.Content = grid;
            b.Padding = new Thickness(10);
            b.Content = scrollViewer;

            this.Content = b;
            //MainWindow1.Content = b;
            
        }
    }
}
