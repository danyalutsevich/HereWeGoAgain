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
using Microsoft.Win32;

namespace MediaPlayer
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
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
        }
        
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Slider.Value = MediaElement.Position.TotalSeconds;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaElement.Position = TimeSpan.FromSeconds(Slider.Value);

        }


        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            Slider.Maximum = MediaElement.NaturalDuration.TimeSpan.TotalSeconds;
            dispatcherTimer.Start();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MediaElement.Pause();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MediaElement.Stop();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.ShowDialog();

            MediaElement.Source = new Uri(openFileDialog.FileName);

        }
    }
}
