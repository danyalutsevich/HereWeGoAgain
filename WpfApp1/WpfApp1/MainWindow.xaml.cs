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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(ChangeColor);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,10);
            dispatcherTimer.Start();

            MessageBox.Show("Test");
        }

        StackPanel panel;
        double offset = 0;
        


        private void ChangeColor(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if(panel is not null)
            {

            offset += 0.1;
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush();
            myLinearGradientBrush.StartPoint = new Point(0, 0);
            myLinearGradientBrush.EndPoint = new Point(1, 1);
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, offset%1));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.Red, (0.25+ offset)%1));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, (0.75+ offset)%1));
            myLinearGradientBrush.GradientStops.Add(new GradientStop(Colors.LimeGreen, (1.0+ offset)%1));
            panel.Background = myLinearGradientBrush;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("123");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("234");

        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mouse");
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            panel = sender as StackPanel;
            
        }
    }
}
