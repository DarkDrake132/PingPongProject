using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PingPongGame
{
    public class Player
    {
        const int racket_speed = 10;

        public bool isLeftPress, isRightPress;
        public PictureBox racket;
        Panel playground;
        Label Scored;

        int _scored;
        public int scored
        {
            get
            {
                return _scored;
            }
            set
            {
                _scored = value;
                Scored.Text = scored.ToString();
            }
        }

        public Player(PictureBox racket, Label Scored)
        {
            this.racket = racket;
            this.Scored = Scored;
        }

        internal void ProcessMove(Panel PlayGround)
        {
            playground = PlayGround;

            if(isLeftPress && isLeftPress != isRightPress && racket.Left >= playground.Left)
            {
                racket.Location = new Point(racket.Location.X - racket_speed, racket.Location.Y);
            }
            else if (isRightPress && isLeftPress != isRightPress && racket.Right <= playground.Right)
            {
                racket.Location = new Point(racket.Location.X + racket_speed, racket.Location.Y);
            }
        }
    }


}
