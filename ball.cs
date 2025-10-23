using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    class ball
    {
        int posY, posX, velocityY, velocityX;

        public ball(int posY, int posX)
        {
            posY = this.posY;
            posX = this.posX;
        }
        public void Move()
        {

        }

        public void Draw()
        {

        }

        public void checkCollisions(Paddle p1, Paddle p2, int width, int height)
        {
            //collision walls
            if (posY == height || posY == 0)
            {
                velocityX *= -1;
            }

            //collission paddles
            if(posX)
        }


    }

    
}
