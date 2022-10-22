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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int index = 0;

        List<Animatable> c;

        DoubleAnimation swipeAnimation;

        public MainWindow()
        {
            InitializeComponent();

            c = new() { G11, G12, G21, G22, G31, G32, G41, G42 };

            swipeAnimation = new();
            swipeAnimation.From = 0.0;
            swipeAnimation.To = 1.0;
            swipeAnimation.Duration = TimeSpan.FromSeconds(2);
            swipeAnimation.Completed += new EventHandler(Animation_Handler);


            c[index].BeginAnimation(GradientStop.OffsetProperty, swipeAnimation);
            c[index + 1].BeginAnimation(GradientStop.OffsetProperty, swipeAnimation);
        }

        private void Animation_Handler(object sender, EventArgs e)
        {
            index += 2;

            if (index < c.Count)
            {
                c[index].BeginAnimation(GradientStop.OffsetProperty, swipeAnimation);
                c[index + 1].BeginAnimation(GradientStop.OffsetProperty, swipeAnimation);
            }
        }
    }
}
