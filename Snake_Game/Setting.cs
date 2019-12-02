using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    };
    class Setting
    {
        
        public int Width { get; set; }
        public int Height{ get; set;}
        public int Speed { get; set; }
        public int Score { get; set; }
        public int Point { get; set; }
        public bool GameOver { get; set; }
        public Direction direction { get; set; }

        public Setting()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            Point = 100;
            GameOver = false;
            direction = Direction.Down;
        }

    }
}
