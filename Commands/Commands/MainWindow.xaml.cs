﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CommandsWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            random = new();
        }

        private Random random;

        private void RedColor(object sender, ExecutedRoutedEventArgs e)
        {
            Button1.Background = Brushes.Red;
        }

        private void GreenColor(object sender, ExecutedRoutedEventArgs e)
        {
            Button1.Background = Brushes.Green;
        }

        private void BlueColor(object sender, ExecutedRoutedEventArgs e)
        {
            Button1.Background = Brushes.Blue;
        }
        Control focusedControl;

        private void RandomColor(object sender, ExecutedRoutedEventArgs e)
        {
            Control element = (Control)FocusManager.GetFocusedElement(this);

            if (focusedControl != null)
            {
                focusedControl.Background = new SolidColorBrush(Color.FromRgb((byte)random.Next(1, 255), (byte)random.Next(1, 255), (byte)random.Next(1, 255)));
            }
        }

        private void StackPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            focusedControl = e.Source as Control;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            new Commands.RichTEXTBOXExample().Show();
        }
    }

    public class ColorCommands
    {
        static ColorCommands()
        {
            RedCommand = new RoutedCommand("RedCommand", typeof(ColorCommands));
            GreenCommand = new RoutedCommand("GreenCommand", typeof(ColorCommands));
            BlueCommand = new RoutedCommand("BlueCommand", typeof(ColorCommands));
            RandomCommand = new RoutedCommand("RandomCommand", typeof(ColorCommands));
        }
        public static RoutedCommand RedCommand { get; set; }
        public static RoutedCommand GreenCommand { get; set; }
        public static RoutedCommand BlueCommand { get; set; }
        public static RoutedCommand RandomCommand { get; set; }
    }
}
