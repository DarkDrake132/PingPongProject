using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame
{
    public class Ball
    {
        public PictureBox ball;
        private Panel playground;
        private Player Player1, Player2;

        Random rand = new Random();

        int xSpeed = 3;
        int ySpeed = 4;

        private int racketx, racket1y, racket2y, ballx, bally;

        public Ball(PictureBox ball, Panel playground, Player play1, Player play2, int RacketX, int Racket1Y, int Racket2Y, int BallX, int BallY)
        {
            this.ball = ball;
            this.playground = playground;
            Player1 = play1;
            Player2 = play2;
            racketx = RacketX;
            racket1y = Racket1Y;
            racket2y = Racket2Y;
            ballx = BallX;
            bally = BallY;
        }

        internal void ProcessMove()
        {
            ball.Location = new Point(ball.Location.X + xSpeed, ball.Location.Y + ySpeed);

            if(ball.Left <= playground.Left || ball.Right >= playground.Right)
            {
                xSpeed *= -1;
            }

            if(ball.Bottom >= Player2.racket.Top && ball.Bottom <= Player2.racket.Bottom
                && ball.Left > Player2.racket.Left && ball.Right < Player2.racket.Right)    
            {
                int temp = Math.Abs(ySpeed) + 1;
                ySpeed = -temp;
                temp = Math.Abs(xSpeed) + 1;
                if(xSpeed < 0)
                {
                    xSpeed = -temp;
                }
                else
                {
                    xSpeed = temp;
                }
            }

            if(ball.Top <= Player1.racket.Bottom && ball.Top >= Player1.racket.Top
                && ball.Left > Player1.racket.Left && ball.Right < Player1.racket.Right)
            {
                int temp = Math.Abs(ySpeed) + 1;
                ySpeed = temp;
                temp = Math.Abs(xSpeed) + 1;
                if (xSpeed < 0)
                {
                    xSpeed = -temp;
                }
                else
                {
                    xSpeed = temp;
                }
            }

            if(ball.Bottom >= playground.Bottom || ball.Top <= playground.Top)
            {
                if(ball.Bottom >= playground.Bottom)
                {
                    Player1.scored++;
                }
                else
                {
                    Player2.scored++;
                }
                ResetBall();
            }
        }

        public void ResetBall()
        {
            do
            {
                xSpeed = rand.Next(-5, 5);
            } while (Math.Abs(xSpeed) < 2);
            do
            {
                ySpeed = rand.Next(-5, 5);
            } while (Math.Abs(ySpeed) < 2);

            Player1.racket.Location = new Point(racketx, racket1y);
            Player2.racket.Location = new Point(racketx, racket2y);

            ball.Location = new Point(ballx, bally);
        }
    }
}
