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
        int x;
        int y;
        int size;

        public Paddle(int x, int y, int size)
        {
            x = this.x;
            y = this.y;
            size = this.size;
        }
        void Move(int moveValue)
        {
            y += moveValue;
        }

        void Draw()
        {
            for (int i = 0; i > size; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write("O");
            }
        }
    }
}
