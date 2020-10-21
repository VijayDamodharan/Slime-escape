using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Practice_game_2
{
    internal class Coin : PictureBox
    {
        static internal List<Coin> Coins = new List<Coin>();
        static internal int value = 1;

        int width = 32;
        int height = 32;
        Image image;

        internal Coin(int x, int y, Form1 form)
        {
            image = new Bitmap(GetPath("Images\\Coin.png"));

            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.Image = image;
            this.SendToBack();

            Coins.Add(this);
            form.Controls.Add(this);
        }

        public string GetPath(string name)
        {
            string executablePath = Application.ExecutablePath;
            string[] arr = executablePath.Split('\\');
            string directoryPath = String.Join("\\", arr.Where(x => Array.IndexOf(arr, x) != arr.Length - 1));
            return directoryPath + '\\' + name;
        }

        static internal void DisplayCoin(int cameraPosX, int cameraPosY, Form1 form)
        {
            for (int i = 0; i < Coin.Coins.ToArray().Length; i++)
            {
                Coin coin = Coin.Coins[i];
                if (coin.Left >= form.Width || coin.Bottom <= 0 || coin.Right <= 0 || coin.Top >= form.Height)
                {
                    form.Controls.Remove(coin);
                }
                else
                {
                    if (!form.Controls.Contains(coin))
                    {
                        form.Controls.Add(coin);
                        coin.SendToBack();
                    }
                }
            }
        }
    }
}
