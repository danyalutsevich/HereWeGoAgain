using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR, AID };
        public enum MoveDirection { Up, Down, Left, Right }

        public Bitmap[] images = {
            new Bitmap(@"C:\1\hall.png"),
            new Bitmap(@"C:\1\wall.png"),
            new Bitmap(@"C:\1\medal.png"),
            new Bitmap(@"C:\1\enemy.png"),
            new Bitmap(@"C:\1\player.png"),
            new Bitmap(@"C:\1\aid.png"),
        };

        public MazeObjectType type;
        public int width;
        public int height;
        private Image _texture;
        public Image texture
        {
            get
            {
                return images[(int)type];
            }
        }

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            _texture = images[(int)type];
        }

    }
}
