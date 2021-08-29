
using System;

namespace _2dplatformer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayerGravity = new System.Windows.Forms.Timer(this.components);
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.Timer(this.components);
            this.Right = new System.Windows.Forms.Timer(this.components);
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.Timer(this.components);
            this.pbLWall = new System.Windows.Forms.PictureBox();
            this.pbRWall = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.MoveEnemy1 = new System.Windows.Forms.Timer(this.components);
            this.Death = new System.Windows.Forms.Timer(this.components);
            this.pbRetry = new System.Windows.Forms.PictureBox();
            this.lbhscore = new System.Windows.Forms.Label();
            this.Hscore = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerGravity
            // 
            this.PlayerGravity.Enabled = true;
            this.PlayerGravity.Interval = 10;
            this.PlayerGravity.Tick += new System.EventHandler(this.PlayerGravity_Tick);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbPlayer.Location = new System.Drawing.Point(229, 224);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(71, 70);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.ForestGreen;
            this.pbGround.Location = new System.Drawing.Point(-24, 608);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1928, 92);
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // Left
            // 
            this.Left.Interval = 10;
            this.Left.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Right
            // 
            this.Right.Interval = 10;
            this.Right.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // Up
            // 
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(12, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(41, 13);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score: ";
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Interval = 10;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // pbPlay
            // 
            this.pbPlay.BackColor = System.Drawing.Color.GreenYellow;
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(426, 145);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(319, 149);
            this.pbPlay.TabIndex = 3;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(475, 290);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(242, 207);
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // Enemy
            // 
            this.Enemy.Enabled = true;
            this.Enemy.Interval = 10;
            this.Enemy.Tick += new System.EventHandler(this.Walls_Tick);
            // 
            // pbLWall
            // 
            this.pbLWall.Location = new System.Drawing.Point(-4, -4);
            this.pbLWall.Name = "pbLWall";
            this.pbLWall.Size = new System.Drawing.Size(10, 619);
            this.pbLWall.TabIndex = 5;
            this.pbLWall.TabStop = false;
            // 
            // pbRWall
            // 
            this.pbRWall.Location = new System.Drawing.Point(1210, -4);
            this.pbRWall.Name = "pbRWall";
            this.pbRWall.Size = new System.Drawing.Size(10, 619);
            this.pbRWall.TabIndex = 6;
            this.pbRWall.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Red;
            this.pbEnemy1.Location = new System.Drawing.Point(982, 342);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(65, 61);
            this.pbEnemy1.TabIndex = 7;
            this.pbEnemy1.TabStop = false;
            // 
            // MoveEnemy1
            // 
            this.MoveEnemy1.Enabled = true;
            this.MoveEnemy1.Interval = 10;
            this.MoveEnemy1.Tick += new System.EventHandler(this.MoveEnemy1_Tick);
            // 
            // Death
            // 
            this.Death.Enabled = true;
            this.Death.Interval = 10;
            this.Death.Tick += new System.EventHandler(this.Death_Tick);
            // 
            // pbRetry
            // 
            this.pbRetry.BackColor = System.Drawing.SystemColors.Control;
            this.pbRetry.Image = ((System.Drawing.Image)(resources.GetObject("pbRetry.Image")));
            this.pbRetry.Location = new System.Drawing.Point(491, 329);
            this.pbRetry.Name = "pbRetry";
            this.pbRetry.Size = new System.Drawing.Size(226, 207);
            this.pbRetry.TabIndex = 8;
            this.pbRetry.TabStop = false;
            this.pbRetry.Click += new System.EventHandler(this.pbRetry_Click);
            // 
            // lbhscore
            // 
            this.lbhscore.AutoSize = true;
            this.lbhscore.Location = new System.Drawing.Point(1041, 9);
            this.lbhscore.Name = "lbhscore";
            this.lbhscore.Size = new System.Drawing.Size(62, 13);
            this.lbhscore.TabIndex = 10;
            this.lbhscore.Text = "high score: ";
            // 
            // Hscore
            // 
            this.Hscore.Enabled = true;
            this.Hscore.Interval = 10;
            this.Hscore.Tick += new System.EventHandler(this.Hscore_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1219, 687);
            this.Controls.Add(this.lbhscore);
            this.Controls.Add(this.pbRetry);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbRWall);
            this.Controls.Add(this.pbLWall);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPlayer);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Timer PlayerGravity;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer Left;
        private System.Windows.Forms.Timer Right;
        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Timer Enemy;
        private System.Windows.Forms.PictureBox pbLWall;
        private System.Windows.Forms.PictureBox pbRWall;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.Timer MoveEnemy1;
        private System.Windows.Forms.Timer Death;
        private System.Windows.Forms.PictureBox pbRetry;
        private System.Windows.Forms.Label lbhscore;
        private System.Windows.Forms.Timer Hscore;
    }
}

