using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _2dplatformer
{
    class Coin
    {
        private PictureBox pbCoin = new PictureBox();

        public Coin() 
        {
            pbCoin.Width = 10;
            pbCoin.Height = 10;
            pbCoin.BackColor = Color.Yellow;
        }

        public void DrawTo(Form f) 
        {
            f.Controls.Add(pbCoin); 
        }
        public Rectangle getBounds() 
        {
            return pbCoin.Bounds;
        }


        public void setPos(int x, int y) 
        {
            pbCoin.Location = new Point(x, y);
        }

    }
}
