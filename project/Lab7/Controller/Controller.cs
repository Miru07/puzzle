using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab7.Model;

namespace Lab7.Controller
{
    class PuzzleController
    {
        private List<Tile> tiles = new List<Tile>();
        private int nrOfTiles;

        public PuzzleController(Image img, int numberOfTiles)
        {
            this.nrOfTiles = numberOfTiles;
            this.BreakImage(img, numberOfTiles);
          
        }
        /*
         * Setter for the list of tiles.
         */

        public void SetTiles(List<Tile> tileList)
        {
            this.tiles = tileList;
        }

        /*
         * Getter for the list of tiles.
         */

        public List<Tile> GetTiles()
        {
            return this.tiles;
        }

        /*
         * Method that splits the picture into numberOfTiles * numberOfTiles tiles.
         * The empty tile is placed randomly inside the list of tiles.
        */

        public void BreakImage(Image img, int numberOfTiles)
        {
            int tileWidth = (int)((double)img.Width / numberOfTiles + 0.5);
            int tileHeight = (int)((double)img.Height / numberOfTiles + 0.5);
            int initialPos = 0;

            Random r = new Random();
            int emptyPos = r.Next(0, numberOfTiles*numberOfTiles);

            for (int i = 0; i < numberOfTiles; i++)
            {
                for(int j = 0; j < numberOfTiles; j++)
                {
                    Bitmap tileImage = new Bitmap(tileWidth, tileHeight);
                    Tile t = new Tile(null, false, initialPos, initialPos);

                    if (initialPos == emptyPos)
                    {
                        tileImage = (Bitmap)Image.FromFile("empty.png");
                        t.SetEmpty(true);
                    }
                    else
                    {
                        Graphics g = Graphics.FromImage(tileImage);
                        g.DrawImage(img, new Rectangle(0, 0, 100, 100), new Rectangle(i * tileWidth, j * tileHeight, tileWidth, tileHeight), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                   
                    t.SetTileImage(tileImage);
                    initialPos++;
                    tiles.Add(t);
                }
            }

        }

        /*
         * Method that shuffles the tiles.
         */
        public void RandomizeTiles()
        {
            int i = this.nrOfTiles * this.nrOfTiles - 1;
            int totalOfTiles = this.nrOfTiles * this.nrOfTiles - 1;
            Random r = new Random();
            while (i > 0)
            {
                int newPos1 = r.Next(0, totalOfTiles);
                int newPos2 = r.Next(0, totalOfTiles);
                this.SwapTiles(newPos1, newPos2);

                i--;
            }
        }

        /*
         * Method that swaps the tile on the position pos1 with the one on the position pos2.
         */ 
        public void SwapTiles(int pos1, int pos2)
        {
            int newPos1 = this.SearchTile(pos1);
            int newPos2 = this.SearchTile(pos2);

            Tile aux = new Tile();

            aux = this.tiles[newPos1];
            this.tiles[newPos1] = this.tiles[newPos2];
            this.tiles[newPos2] = aux;


        }

        /*
         * Method that returns the tile with the initial position = pos. 
         */
        public int SearchTile(int pos)
        {
            for (int i = 0; i < this.tiles.Count; i++)
            {
                if (this.tiles[i].GetInitialPosition() == pos)
                    return i;
            }
            return -1;
        }

        /*
         * Method that counts the inversions of a tile.
         */
        public int CountInversions(int pos)
        {
            int inversions = 0;

            for (int i = pos; i < this.tiles.Count; i++)
            {
                int x = this.tiles[pos].GetInitialPosition();
                int y = this.tiles[i].GetInitialPosition();
                if (x > y)
                    inversions++;
            }

            return inversions;
        }


        /*
         * Method that sums all the inversions of the tiles from the list.
         */ 
        public int SumOfInversions()
        {
            int inversions = 0;

            for (int i = 0; i < this.tiles.Count; i++)
            {
                inversions += this.CountInversions(i);
            }

            return inversions;

        }

        /*
         * Method that returns the row on which the empty tile exists.
         */
        public int GetEmptyRow()
        {
            
            return this.GetEmptyPosition() % this.nrOfTiles + 1;
        }

        /*
         * Method that returns the empty tile position.
         */
        public int GetEmptyPosition()
        {
            for (int i = 0; i < this.tiles.Count; i++)
            {
                if (this.tiles[i].GetEmpty() == true)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
 
