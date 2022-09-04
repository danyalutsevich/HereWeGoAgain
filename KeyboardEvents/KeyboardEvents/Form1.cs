using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime timeStarted;

        private void Form1_Load(object sender, EventArgs e)
        {
            timeStarted = DateTime.Now;
            CreateButtons();
        }

        private int counter = 0;
        Random random = new Random();
        int X = 0;
        int Y = 0;

        int XClick = 0;
        int YClick = 0;

        Button CurrentButton;

        bool buttonReleased = true;

        int M = 5;
        int N = 5;
        int x = 50;
        int y = 10;

        private void CreateButtons()
        {

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    var button = new Button();
                    button.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    button.Location = new Point(i * x + i * y, j * x + j * y);
                    button.Size = new Size(x, x);
                    button.Text = ((i+1) * (j+1)).ToString();
                    button.Click += new EventHandler(ButtonRemove);
                    this.Controls.Add(button);
                }
            }
        }

        private void ButtonRemove(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            buttonCounter.Text = counter.ToString();
        }

        private void buttonCounter_MouseEnter(object sender, EventArgs e)
        {
            buttonCounter.Location = new Point(random.Next(0, this.Width - buttonCounter.Width), random.Next(0, this.Height - buttonCounter.Height));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            X = 0;
            Y = 0;

            XClick = e.X;
            YClick = e.Y;

            buttonReleased = false;

            CurrentButton = new Button
            {
                Location = new Point(XClick, YClick),
                Size = new Size(X, Y),
                BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)),

            };

            this.Controls.Add(CurrentButton);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!buttonReleased)
            {

                if (CurrentButton != null)
                {

                    var newLocationX = 0;
                    var newLocationY = 0;

                    if (e.X - XClick > 0)
                    {
                        X = e.X - XClick;
                        newLocationX = XClick;
                    }
                    else
                    {
                        newLocationX = e.X;
                        X = Math.Abs(XClick - e.X);
                    }
                    if (e.Y - YClick > 0)
                    {
                        Y = e.Y - YClick;
                        newLocationY = YClick;
                    }
                    else
                    {
                        newLocationY = e.Y;
                        Y = Math.Abs(YClick - e.Y);
                    }

                    CurrentButton.Size = new Size(X, Y);
                    CurrentButton.Location = new Point(newLocationX, newLocationY);
                }
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonReleased = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text += (char)e.KeyValue;

            Point? newLocation = null;

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                newLocation = new Point(this.Location.X, this.Location.Y - 50);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                newLocation = new Point(this.Location.X, this.Location.Y + 50);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                newLocation = new Point(this.Location.X - 50, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                newLocation = new Point(this.Location.X + 50, this.Location.Y);
            }
            if (newLocation != null)
            {
                if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLocation.Value, this.Size)))
                {
                    this.Location = newLocation.Value;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = (DateTime.Now - timeStarted).ToString();
        }


        int r = 0;
        int g = 0;
        int b = 0;

        bool rFlag = false;
        bool gFlag = false;
        bool bFlag = false;


        private void timerRainbow_Tick(object sender, EventArgs e)
        {
            if (r >= 255)
            {
                rFlag = true;
            }
            else if (r <= 0)
            {
                rFlag = false;
            }

            if (g >= 255)
            {
                gFlag = true;
            }
            else if (b <= 0)
            {
                gFlag = false;
            }

            if (b >= 255)
            {
                bFlag = true;
            }
            else if (b <= 0)
            {
                bFlag = false;
            }

            if (!rFlag)
            {
                r++;
            }
            else
            {
                r--;

                if (!gFlag)
                {
                    g++;
                }
                else
                {
                    g--;

                    if (!bFlag)
                    {
                        b++;
                    }
                    else
                    {
                        b--;
                    }
                }
            }





            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
