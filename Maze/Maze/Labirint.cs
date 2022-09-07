using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{
    class Labirint
    {
        public int height; // высота лабиринта (количество строк)
        public int width; // ширина лабиринта (количество столбцов в каждой строке)

        public MazeObject[,] maze;
        public PictureBox[,] images;

        public static Random random = new Random();
        public Form parent;

        Point charCoords;

        private int MedalsGenerated = 0;
        private int MedalsCollected = 0;

        private int Health = 100;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;

            maze = new MazeObject[height, width];
            images = new PictureBox[height, width];

            Generate();
        }

        private void Generate()
        {
            int smileX = 0;
            int smileY = 2;

            charCoords = new Point(smileX, smileY);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

                    // в 1 случае из 5 - ставим стену
                    if (random.Next(5) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    var number = random.Next(250);
                    // в 1 случае из 250 - кладём денежку
                    if (number == 0)
                    {
                        current = MazeObject.MazeObjectType.MEDAL;
                        MedalsGenerated++;
                    }
                    // в 1 случае из 250 - размещаем врага
                    else if (number == 1)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;
                    }
                    // в 1 случае из 250 - размещаем аптеку
                    else if (number == 2)
                    {
                        current = MazeObject.MazeObjectType.AID;
                    }



                    // стены по периметру обязательны
                    if (y == 0 || x == 0 || y == height - 1 | x == width - 1)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // наш персонажик
                    if (x == smileX && y == smileY)
                    {
                        current = MazeObject.MazeObjectType.CHAR;

                    }

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (x == smileX + 1 && y == smileY || x == width - 1 && y == height - 3)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }

                    maze[y, x] = new MazeObject(current);
                    images[y, x] = new PictureBox();
                    images[y, x].Location = new Point(x * maze[y, x].width, y * maze[y, x].height);
                    images[y, x].Parent = parent;
                    images[y, x].Width = maze[y, x].width;
                    images[y, x].Height = maze[y, x].height;
                    images[y, x].BackgroundImage = maze[y, x].texture;
                    images[y, x].Visible = false;
                }
            }
        }

        public void Show()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    images[y, x].Visible = true;
                }
            }
        }

        public bool IsMoveAvailable(MazeObject.MoveDirection dir)
        {
            int x = charCoords.X;
            int y = charCoords.Y;

            switch (dir)
            {
                case MazeObject.MoveDirection.Up:
                    y--;
                    break;
                case MazeObject.MoveDirection.Down:
                    y++;
                    break;
                case MazeObject.MoveDirection.Left:
                    x--;
                    break;
                case MazeObject.MoveDirection.Right:
                    x++;
                    break;
            }
            try
            {
                switch (maze[y, x].type)
                {
                    case MazeObject.MazeObjectType.HALL:
                        return true;
                    case MazeObject.MazeObjectType.MEDAL:
                        MedalsCollected++;
                        return true;
                    case MazeObject.MazeObjectType.AID:
                        if (Health >= 100)
                        {
                            return false;
                        }
                        else
                        {
                            Health += 5;
                            if (Health > 100)
                            {
                                Health = 100;
                            }
                            return true;
                        }
                    case MazeObject.MazeObjectType.ENEMY:
                        Health -= random.Next(20, 25);
                        return true;
                    default:
                        return false;
                }

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool GameStatusCheck()
        {
            parent.Text = "Health: " + Health +"%"+ " Medals: " + MedalsCollected + "/" + MedalsGenerated;

            var status = parent.Controls[1];

            //status. = "Health: " + Health + "%" + " Medals: " + MedalsCollected + "/" + MedalsGenerated;

            //toolStripStatusLabel1

            if (MedalsCollected == MedalsGenerated && MedalsGenerated != 0)
            {
                MessageBox.Show("You've collected all medals!\n\nYou won!");
                return false;
            }
            if (Health <= 0)
            {
                MessageBox.Show("You died!\n\nGame Over!");
                return false;
            }
            return true;
        }

        public void Move(MazeObject.MoveDirection dir)
        {
            if (IsMoveAvailable(dir))
            {
                switch (dir)
                {
                    case MazeObject.MoveDirection.Up:
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        charCoords.Y--;
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        break;
                    case MazeObject.MoveDirection.Down:
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        charCoords.Y++;
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        break;
                    case MazeObject.MoveDirection.Left:
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        charCoords.X--;
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        break;
                    case MazeObject.MoveDirection.Right:
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.HALL;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        charCoords.X++;
                        maze[charCoords.Y, charCoords.X].type = MazeObject.MazeObjectType.CHAR;
                        images[charCoords.Y, charCoords.X].BackgroundImage = maze[charCoords.Y, charCoords.X].texture;
                        break;
                }
            }
            GameStatusCheck();
        }
    }
}
