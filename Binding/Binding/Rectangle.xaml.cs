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
using System.Windows.Shapes;

namespace Binding
{
    /// <summary>
    /// Interaction logic for Rectangle.xaml
    /// </summary>
    public partial class Rectangle : Window
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        bool mouseDown = false;

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {

            mouseDown = false;
        }

        int x = 0;
        int y = 0;

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                top.Text = (e.GetPosition(this).Y - 35 - y).ToString();
                left.Text = (e.GetPosition(this).X - x).ToString();
            }
        }

        private void Rectangle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mouseDown = false;
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (mouseDown == false)
            {

                x = (int)e.GetPosition(Rect).X;
                y = (int)e.GetPosition(Rect).Y;
                this.Title = x.ToString() + " " + y.ToString();
            }
            mouseDown = true;
        }
    }
}
