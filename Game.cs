using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle p0Paddle = new Paddle(1, Console.WindowHeight / 2, 5);
        Paddle p1Paddle = new Paddle(Console.WindowWidth-1, Console.WindowHeight / 2, 5);


        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;
        }


        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            p0Paddle.Draw();
            p1Paddle.Draw();

            if (Input.IsPressed(ConsoleKey.UpArrow) && p1Paddle.y != 0)
            {
                p1Paddle.Move(-1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow) && p1Paddle.y != height-p1Paddle.size)
            {
                p1Paddle.Move(1);
            }

            if (Input.IsPressed(ConsoleKey.W) && p0Paddle.y != 0)
            {
                p0Paddle.Move(-1);
            }
            if (Input.IsPressed(ConsoleKey.S) && p0Paddle.y != height-p0Paddle.size)
            {
                p0Paddle.Move(1);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
