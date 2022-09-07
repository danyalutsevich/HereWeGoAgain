using System.Drawing;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
        }

        Labirint labirint;
        int stepsCount = 0;

        public void Options()
        {
            Text = "Maze";

            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40+22;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame()
        {
            labirint = new Labirint(this, 40, 20);
            labirint.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                labirint.Move(MazeObject.MoveDirection.Up);
            }
            else if (e.KeyCode == Keys.S)
            {
                labirint.Move(MazeObject.MoveDirection.Down);
            }
            else if (e.KeyCode == Keys.A)
            {
                labirint.Move(MazeObject.MoveDirection.Left);
            }

            else if (e.KeyCode == Keys.D)
            {
                labirint.Move(MazeObject.MoveDirection.Right);
            }
            
            stepsCount++;
            toolStripStatusLabel1.Text = "Steps: " + stepsCount;
        }
    
    }
}
