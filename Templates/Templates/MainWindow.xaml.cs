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

namespace Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Grid grid = new();

            Random random = new();


            for (int i = 0; i < 10; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                for (int j = 0; j < 10; j++)
                {
                    var button = new Button();
                    button.Template = (ControlTemplate)this.Resources["ButtonTemplate"];
                    button.Content = j + i;

                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);

                    button.IsEnabled = random.Next(2) == 1;

                    grid.Children.Add(button);

                }

            }

            this.Content = grid;

        }
    }
}
