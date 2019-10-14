using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        Player player1, player2;
        Ball CircleThing;
        public Form1()
        {
            InitializeComponent();

            TopMost = true;                                //Đưa form ra đằng trước
            Bounds = Screen.PrimaryScreen.Bounds;          //Chế độ toàn màn hình

            player1 = new Player(Racket1, Player1Scored);
            player2 = new Player(Racket2, Player2Scored);

            SetGame();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1.ProcessMove(PlayGround);
            player2.ProcessMove(PlayGround);
            CircleThing.ProcessMove();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Check_Keys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Check_Keys(e, false);
        }

        private void Check_Keys(KeyEventArgs e, bool checker)
        {
            switch(e.KeyCode)
            {
                case Keys.F2:
                    if(timer1.Enabled && checker == true)
                    {
                        timer1.Enabled = false;
                    }
                    else if(timer1.Enabled == false && checker == true)
                    {
                        timer1.Enabled = true;
                    }
                    break;
                case Keys.F1:
                    if(checker == true)
                    {
                        player1.scored = 0;
                        player2.scored = 0;
                        CircleThing.ResetBall();
                    }
                    break;
                case Keys.Escape:
                    Close();
                    break;
                case Keys.A:
                    player1.isLeftPress = checker;
                    break;
                case Keys.D:
                    player1.isRightPress = checker;
                    break;
                case Keys.Left:
                    player2.isLeftPress = checker;
                    break;
                case Keys.Right:
                    player2.isRightPress = checker;
                    break;
                default:
                    break;
            }
        }

        public void SetGame()
        {
            Player1Label.Location = new Point(this.ClientSize.Width / 2 - Player1Label.Size.Width / 2 - this.ClientSize.Width * 17 / 40, 
                                                this.ClientSize.Height / 2 - Player1Label.Size.Height / 2 - this.ClientSize.Height * 19 / 40);
            Player2label.Location = new Point(this.ClientSize.Width / 2 - Player1Label.Size.Width / 2 - this.ClientSize.Width * 17 / 40,
                                                this.ClientSize.Height / 2 - Player1Label.Size.Height / 2 + this.ClientSize.Height * 19 / 40);
            Player1Scored.Location = new Point(Player1Label.Location.X + Player1Label.Width, Player1Label.Location.Y);
            Player2Scored.Location = new Point(Player2label.Location.X + Player2label.Width, Player2label.Location.Y);

            int RacketXPos = this.ClientSize.Width / 2 - player1.racket.Size.Width / 2;
            int Racket1YPos = this.ClientSize.Height / 2 - player1.racket.Size.Height / 2 - this.ClientSize.Height * 17 / 40;
            int Racket2YPos = this.ClientSize.Height / 2 - player1.racket.Size.Height / 2 + this.ClientSize.Height * 17 / 40;
            int BallXPos = this.ClientSize.Width / 2 - Ball.Size.Width / 2;
            int BallYPos = this.ClientSize.Height / 2 - Ball.Size.Height / 2;

            CircleThing = new Ball(Ball, PlayGround, player1, player2, RacketXPos, Racket1YPos, Racket2YPos, BallXPos, BallYPos);

            player1.racket.Location = new Point(RacketXPos, Racket1YPos);
            player2.racket.Location = new Point(RacketXPos, Racket2YPos);
            CircleThing.ball.Location = new Point(BallXPos, BallYPos);

        }
    }
}
