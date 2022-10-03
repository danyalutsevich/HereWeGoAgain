using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
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

        UIElementCollection KeyboardKeys;
        List<Brush> colors;
        DispatcherTimer timer = new();

        int CharCounter = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            colors = new();
            KeyboardKeys = KeyBoard.Children;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            foreach (Border control in KeyboardKeys)
            {
                colors.Add((control.Child as TextBlock).Background.Clone());
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TextCPS.Text = "CPS: " + CharCounter;
            CharCounter = 0;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
                                    CharCounter++;
            foreach (var control in KeyBoard.Children)
            {
                var border = control as Border;

                if (border is not null)
                {
                    var textBlock = border.Child as TextBlock;

                    if (textBlock is not null)
                    {
                        if (textBlock.Tag.ToString() == e.Key.ToString())
                        {
                            textBlock.Background = Brushes.Coral;

                            try
                            {
                                if (textBlock.Text.ToLower()[0] == TrainingText.Text.ToLower()[0])
                                {
                                    TrainingText.Text = TrainingText.Text.Remove(0, 1);
                                }
                            }
                            catch { }

                        }
                    }
                }
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Border control in KeyboardKeys)
            {
                (control.Child as TextBlock).Background = colors[KeyboardKeys.IndexOf(control)];
            }
        }
    }
}
