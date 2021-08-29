using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _2dplatformer
{
    public partial class Form1 : Form
    {
        bool isJumping = false;
        bool leftMove = false;

        List<Coin> cList = new List<Coin>();
        int score = 0;
        int highscore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayerGravity_Tick(object sender, EventArgs e)
        {
            if (!pbPlayer.Bounds.IntersectsWith(pbGround.Bounds) && isJumping == false)
                pbPlayer.Top += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left -= 10;               
        }

        private void Right_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left += 10;
        }

        private void Up_Tick(object sender, EventArgs e)
        {
            
            
            pbPlayer.Top -= 10;
            isJumping = true;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left.Start(); 
            }
            else if(e.KeyCode == Keys.Right) 
            {
                Right.Start();
            }
            else if(e.KeyCode == Keys.Up) 
            {
                isJumping = true;
                Up.Start();
            }
        }
         
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Left.Stop();
            }
            else if (e.KeyCode == Keys.Right)
            {
                Right.Stop();
            }
            else if (e.KeyCode == Keys.Up)
            {
                isJumping = false;
                Up.Stop();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbGround.Hide();
            pbPlayer.Hide();
            lbScore.Hide();
            lbhscore.Hide();
            pbEnemy1.Hide();
            pbRetry.Hide();

            this.BackColor = Color.FromArgb(255, 255, 255); // nebe 30,144,255
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            int cXpos = rand1.Next(100, 1000);
            int cYpos = rand1.Next(100, 500);

            foreach(Coin c in cList) 
            {
                if (pbPlayer.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(cXpos, cYpos);
                    score++;
                    lbScore.Text = "Score: " + score; 
                }
            }
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            pbPlay.Hide();
            pbExit.Hide();

            pbGround.Show();
            pbEnemy1.Show();
            pbPlayer.Show();
            lbScore.Show();
            lbhscore.Show();

            lbScore.Font = new Font("Arial", 17, FontStyle.Bold);
            lbhscore.Font = new Font("Arial", 17, FontStyle.Bold);
            this.BackColor = Color.FromArgb(30, 144, 255);

            Coin c1 = new Coin();
            c1.DrawTo(this);
            cList.Add(c1);
            c1.setPos(100, 100);
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Walls_Tick(object sender, EventArgs e)
        {
            if (pbEnemy1.Bounds.IntersectsWith(pbLWall.Bounds)) 
            {
                leftMove = false;
            }
            else if (pbEnemy1.Bounds.IntersectsWith(pbRWall.Bounds))
            {
                leftMove = true;
            }

        }

        private void MoveEnemy1_Tick(object sender, EventArgs e)
        {
            if (leftMove == false) 
            {
                pbEnemy1.Left += 10;
            }
            if (leftMove == true) 
            {
                pbEnemy1.Left -= 10;
            }
        }

        private void Death_Tick(object sender, EventArgs e)
        {
            if (pbEnemy1.Bounds.IntersectsWith(pbPlayer.Bounds)) 
            {
                PlayerGravity.Stop();
                Up.Stop();
                Right.Stop();
                Left.Stop();
                MoveEnemy1.Stop();

                pbRetry.Show();
                lbScore.Location = new Point(556, 281);
            }
        }

        private void pbRetry_Click(object sender, EventArgs e)
        {
            score = 0;
            lbScore.Location = new Point(12, 9);
            pbPlayer.Location = new Point(229, 224);
            pbEnemy1.Location = new Point(982, 342);

            pbRetry.Hide();

            MoveEnemy1.Start();
            PlayerGravity.Start();
        }

        private void Hscore_Tick(object sender, EventArgs e)
        {
            if (score > highscore) 
            {
                highscore = score;
                lbhscore.Text = "High score: " + highscore;
            }
        }
    }
}
