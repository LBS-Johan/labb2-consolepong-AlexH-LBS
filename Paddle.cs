using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        public int x, y, size;
        public int points=0;
        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }
        public void Move(int moveValue)
        {
            y += moveValue;
        }
        public void Draw()
        {
            for (int i = 0; i < size; i++)
            {
                //paddle
                Console.SetCursorPosition(x, y+i);
                Console.Write("|");

                //points
                Console.SetCursorPosition(x, 1);
                Console.Write(points);
            }
        }
    }
}
