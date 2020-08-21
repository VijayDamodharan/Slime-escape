using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_game_2
{
    internal class Enemy : PictureBox
    {
        static internal List<Enemy> Enemies = new List<Enemy>();
        static internal int decrementScore = 5; // dec score by this upon collision
        
        int width = 30;
        int height = 30;

        int velX = 3;
        int dirX = 1;

        static Image imgRight = new Bitmap(@"C:\Vijay Stuff\Coding stuff\Visual studio projects\csharp projects\Practice game 2\Enemy right.png");
        static Image imgLeft = new Bitmap(@"C:\Vijay Stuff\Coding stuff\Visual studio projects\csharp projects\Practice game 2\Enemy left.png");

        internal Enemy(int x, int y, Form1 form)
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.BackColor = Color.Transparent;
            this.Image = imgRight;
            this.velX += form.level; // slightly increases enemy velocity with each level
            this.dirX = (Enemies.ToArray().Length % 2 == 0) ? 1 : -1; // alternates starting direction of adjacent enemies
            this.BringToFront();

            Enemies.Add(this);
            form.Controls.Add(this);
        }

        bool IsCollidingRight(Form1 form)
        {
            // enemies can go outside the screen!
            if (this.Location.X + 2 * this.Width >= form.gameWidth * Tile.tileWidth - form.cameraPosX) return true;
            
            for (int i = 0; i < Tile.Ground.ToArray().Length; i++)
            {
                Tile tile = Tile.Ground[i];
                if ((this.Location.Y + this.Height > tile.Location.Y &&
                        this.Location.Y < tile.Location.Y + tile.Height) &&
                    (tile.Location.X <= this.Location.X + this.Width + velX &&
                        this.Location.X + this.Width + velX <= tile.Location.X + tile.Width))
                    return true;
            }

            return false;
        }

        bool IsCollidingLeft(Form1 form)
        {
            if (this.Location.X <= -form.cameraPosX) return true; // enemies can go outside the screen!

            for (int i = 0; i < Tile.Ground.ToArray().Length; i++)
            {
                Tile tile = Tile.Ground[i];
                if ((this.Location.Y + this.Height > tile.Location.Y &&
                        this.Location.Y < tile.Location.Y + tile.Height) &&
                    (tile.Location.X <= this.Location.X - velX &&
                        this.Location.X - velX <= tile.Location.X + tile.Width))
                    return true;
            }

            return false;

        }

        bool IsCollidingDown(Form1 form)
        {

            for (int i = 0; i < Tile.Ground.ToArray().Length; i++)
            {
                Tile tile = Tile.Ground[i];
                if ((this.Location.X + this.Width > tile.Location.X &&
                        this.Location.X < tile.Location.X + tile.Width) &&
                    (tile.Top - this.Top <= 2 * this.Height))
                    return true;
            }

            return false;
        }

        internal void MyMove(Form1 form)
        {
            if (!IsCollidingDown(form) || IsCollidingLeft(form) || IsCollidingRight(form)) 
                dirX *= -1;
            this.Left += this.velX * this.dirX;

            this.Image = (this.dirX == 1) ? imgRight : imgLeft;
        }

        static internal void DisplayEnemy(int cameraPosX, int cameraPosY, Form1 form)
        {
            for (int i = 0; i < Enemy.Enemies.ToArray().Length; i++)
            {
                Enemy enemy = Enemy.Enemies[i];
                if (enemy.Left >= form.Width || enemy.Bottom <= 0 || enemy.Right <= 0 || enemy.Top >= form.Height)
                {
                    form.Controls.Remove(enemy);
                }
                else
                {
                    if (!form.Controls.Contains(enemy))
                    {
                        form.Controls.Add(enemy);
                        enemy.BringToFront();
                    }
                }
            }
        }
    }
}
