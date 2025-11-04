using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class Ball
    {
        int posY, posX;
        public int velocityY, velocityX;
        public Ball(int posY, int posX)
        {
            this. posY = posY;
            this.posX = posX;
        }
        public void Move()
        {
            posY += velocityY;
            posX += velocityX;
        }
        public void Draw()
        {
            Console.SetCursorPosition(posX,posY);
            Console.Write("O");
        }
        public void checkCollisions(Paddle p1, Paddle p2, int width, int height)
        {
            //collision walls
            if (posY == height-1 || posY == 0)
            {
                velocityY *= -1;
            }

            //collission paddles
            if (posX == p1.x && posY > p1.y && posY < p1.y+p1.size || posX == p2.x && posY > p2.y && posY < p2.y + p2.size)
            {
                velocityX *= -1;
            }

            //collide wall
            if (posX == 0)
            {
                p2.points += 1;
                posX = width/2;
                posY = height / 2;
            }
            if(posX == width)
            {
                p1.points += 1;
                posX = width / 2;
                posY = height / 2;
            }
        }
    }
}
