using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_game_2
{
    class Tile : PictureBox
    {
        static internal List<Tile> Ground = new List<Tile>();
        static internal List<Tile> GroundToDisplay = new List<Tile>();

        static internal int tileWidth = 40; // pixels
        static internal int tileHeight = 40;


        Image middleBlock; 
        Image smallTopBlock;
        Image floatingBlock; 

        internal Tile(int x, int y, List<string> map, Form1 form, int length)
        {
            middleBlock = new Bitmap(GetPath("Images\\Middle Block 2.png"));
            smallTopBlock = new Bitmap(GetPath("Images\\Small top block 2.png"));
            floatingBlock = new Bitmap(GetPath("Images\\Floating Block 2.png"));

            this.SizeMode = PictureBoxSizeMode.Normal;
            this.Location = new Point(x, y);
            this.Size = new Size(tileWidth * length, tileHeight);
            this.BackgroundImage = this.GetImage(map, x / tileWidth, y / tileHeight, form);
            this.BackgroundImageLayout = ImageLayout.Tile;
            this.Name = $"{x}, {y}";

            Ground.Add(this);
            form.Controls.Add(this);
        }

        public string GetPath(string name)
        {
            string executablePath = Application.ExecutablePath;
            string[] arr = executablePath.Split('\\');
            string directoryPath = String.Join("\\", arr.Where(x => Array.IndexOf(arr, x) != arr.Length - 1));
            return directoryPath + '\\' + name;
        }

        Image GetImage(List<string> map, int x, int y, Form1 form)
        {
            Image image;

            // doesn't collide anywhere
            if (0 < y && 0 < x && y < 15 && x < 63 &&
                map[y + 1][x] != '#' && map[y - 1][x] != '#' && map[y][x + 1] != '#' && map[y][x - 1] != '#')
                image = floatingBlock;
            // doesn't collide top
            else if (0 < y && y < 15 && (map[y - 1][x] != '#' || y * tileHeight >= form.Height) && !(map[y - 1][x] == '#'))
                image = smallTopBlock;
            else
                image = middleBlock;
            return image;
        }
        
        static string GenerateMapLvl1()
        {
            // 64 x 16 grid, use '/' to split

            string map = "";

            map += "................................................................/";
            map += ".............e.00.............................................../";
            map += "........0..######.............................................../";
            map += "....0...#........#............................................../";
            map += "....#....0.......##0............................................/";
            map += ".........#........##............................................/";
            map += "...0...............##.......000................................./";
            map += "...#...#............##0....0...0................................/";
            map += ".....................##...0.....0.000.e.000...................../";
            map += "....#..0..............###################0#...00................/";
            map += ".......#..............#....000........000.#...##0..0............/";
            map += "....0.................#.###################..####0..00..000...../";
            map += "....#.................#..000.e.....#....000.######0....0...0..../";
            map += ".....................e####..###...000.#############...0e...e0.../";
            map += "###########################.000.###############################./";
            map += "################################################################/";

            return map;
        }

        static string GenerateMapLvl2()
        {
            // 64 x 16 grid, use '/' to split

            string map = "";

            map += "................................................................/";
            map += "................................................................/";
            map += "................................................................/";
            map += "................................................................/";
            map += "................................................................/";
            map += "...............0....000....000................................../";
            map += "...............##################...0.........................../";
            map += "............0.....0.............##0............................./";
            map += "............#.....#.............###............................./";
            map += ".........0.....0.....0..........####0.e.....e.......e.....e....0/";
            map += ".........#.....#.....#..........#########0######0#######0####0##/";
            map += "......0.....0.....0.....0.......################################/";
            map += "......#.....#.....#.....#......................................./";
            map += ".....e000........e000.........e000........e000........e000....../";
            map += "###########.#####.#####.#####.#####.#####.#####.#####.#####.###./";
            map += "################################################################/";

            return map;
        }
        
        static string GenerateMapLvl3()
        {
            // 64 x 16 grid, use '/' to split

            string map = "";

            map += "..................00................000........................./";
            map += ".................0...0.......0.....0...0......................../";
            map += ".....00000000#..#..e..0#..#.....#..#..e.0#..###..#0............./";
            map += ".....#########..########..#######..#######..###..##......#....../";
            map += ".........0000......000....0000....000...0000...00....#.....0..../";
            map += "..........##################################.#####.........#..../";
            map += ".......#...#......00.e.......00..e..00...00.....0#............../";
            map += ".....0...#.#..#.###.###.###.###.###.###.###.######.......#....../";
            map += ".....#.....#..####################################....#....0..../";
            map += "..#.....#..#...000..000..000..000..000..000..00..#.........#..../";
            map += "...........####################################..#............../";
            map += ".....#.....#.....................................#..........#.../";
            map += "...........#00..e....00........00.....e.....00...#........#...../";
            map += "#########################...#########################...######../";
            map += "##########################.......000........000.......#########./";
            map += "################################################################/";

            return map;
        }

        static string GenerateMapLvl4()
        {
            // 64 x 16 grid, use '/' to split

            string map = "";

            map += ".......0000....0000....0000....0000....0000....0000....0000...../";
            map += "....#########################################################.../";
            map += ".#...0000......0...0.0.00000.0000..0.0........0000............../";
            map += "..#.#######.....0#0..0#.#0#.#0000#..0#....000.########........../";
            map += ".................0...0..00...0..0..0.....0...0......000#......../";
            map += ".......0.###############################################......../";
            map += ".......................0.0.000..0.00000.0..0..0................./";
            map += ".....#.#00............#00..0#.0.0.#.0.#.0000.#0................./";
            map += "....#########..........00.#000#.0#.#0#.#0000##0................./";
            map += ".............##########0.0.0..0.0...0...0..0..0................./";
            map += "......................##################################......../";
            map += "....00000000000..000000000000000...0000000000.........0..#....../";
            map += "....############################################......##......../";
            map += ".00#................................................##........../";
            map += "###############################################################./";
            map += "################################################################/";

            return map;
        }

        static string GenerateMapLvl5()
        {
            // 64 x 16 grid, use '/' to split

            string map = "";

            map += "................................................................/";
            map += "..........................................0...........0...0....0/";
            map += "......................................#...#...#...#...#..###...#/";
            map += "...................................0........................0.../";
            map += ".............0.....................##.......................#.../";
            map += ".............#..................#.............................0./";
            map += "............###..................0............................#./";
            map += "..........0#####0................#.......................0....../";
            map += "..........#######........................................#....../";
            map += ".........##.e000..................#..........................0../";
            map += ".......0###.###.###0...........0.............................#../";
            map += ".......####.########...........#................................/";
            map += "......#####.e000................................................/";
            map += "....0##########.######0.....#.e......e......e0....e.....e......./";
            map += "###############################################################./";
            map += "################################################################/";

            return map;
        }

        static internal void GenerateGround(Form1 form)
        {
            List<string> map = new List<string>();

            if (form.level == 1) 
                map = GenerateMapLvl1().Split('/').ToList();
            else if (form.level == 2) 
                map = GenerateMapLvl2().Split('/').ToList();
            else if (form.level == 3)
                map = GenerateMapLvl3().Split('/').ToList();
            else if (form.level == 4)
                map = GenerateMapLvl4().Split('/').ToList();
            else if (form.level == 5)
                map = GenerateMapLvl5().Split('/').ToList();

            List<string> processedMap = ProcessMap(map);
            
            int x = 0;
            int y = 0;
            int tempCount = 0; // use to increase x value within an item in list, so that mulitple coins can be created next to eachother

            foreach (string obj in processedMap)
            {

                if (obj.Contains('#'))
                {
                    new Tile(x * tileWidth, y * tileHeight, map, form, obj.Length);
                }
                if (obj.Contains('0'))
                {
                    foreach (char coin in obj)
                    {
                        new Coin((x + tempCount) * tileWidth, y * tileHeight, form);
                        tempCount++;
                    }
                    tempCount = 0;
                }
                if (obj.Contains('e'))
                {
                    foreach (char enemy in obj)
                    {
                        new Enemy((x + tempCount) * tileWidth, y * tileHeight, form);
                        tempCount++;
                    }
                    tempCount = 0;
                }

                x += obj.Length;
                if (x >= 64)
                {
                    y += x / 64;
                    x = (x % 64);
                }            
            }
        }

        static internal List<string> ProcessMap(List<string> map)
        {
            List<string> processedMap = new List<string>();
            string currentCharacters = "";

            
            foreach (string row in map)
            {
                foreach (char obj in row)
                {
                    if (currentCharacters.Length == 0)
                    {
                        currentCharacters += obj;
                    }
                    else if (currentCharacters.Contains(obj))
                    {
                        currentCharacters += obj;
                    }
                    else
                    {
                        processedMap.Add(currentCharacters);
                        currentCharacters = "";
                        currentCharacters += obj;
                    }
                }
            }
            if (currentCharacters.Length != 0) processedMap.Add(currentCharacters);
            return processedMap;
        }

        static internal void DisplayGround(int cameraPosX, int cameraPosY, Form1 form)
        {
            for (int i = 0; i < Tile.Ground.ToArray().Length; i++)
            {
                Tile tile = Tile.Ground[i];
                if (tile.Left >= form.Width || tile.Bottom <= 0 || tile.Right <= 0 || tile.Top >= form.Height) // outside
                {
                    form.Controls.Remove(tile);
                }
                else
                {
                    if (!form.Controls.Contains(tile))
                    {
                        form.Controls.Add(tile);
                    }
                }
            }
        }
    }
}
