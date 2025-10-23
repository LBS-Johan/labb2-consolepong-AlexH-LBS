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
        public int x;
        public  int y;
        public int size;

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
                Console.SetCursorPosition(x, y+i);
                Console.Write("|");
            }
        }
    }
}
