using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7.Model
{
    class Tile
    {
        private Image tileImage;
        private bool empty;
        //The initial position of the tile.
        private int initialPos;
        //The position of the tile in the shuffled list of tiles
        private int changePos;

        public Tile(Image img, bool empty, int initialPos, int changePos)
        {
            this.tileImage = img;
            this.empty = empty;
            this.initialPos = initialPos;
            this.changePos = changePos;

        }

        public Tile()
        {
            this.tileImage = null;
            this.empty = false;
            this.initialPos = -1;
            this.changePos = -1;
        }

        /*
         * Getter for the initial position.
         */
        public int GetInitialPosition()
        {
            return this.initialPos;
        }

        /*
         * Setter for the initial position.
         */
        public void SetInitialPosition(int pos)
        {
            this.initialPos = pos;
        }

        /*
         * Getter for the changed position.
         */
        public int GetChangedPosition()
        {
            return this.changePos;
        }

        /*
         * Setter for the changed position.
         */
        public void SetChangedPosition(int pos)
        {
            this.changePos = pos;
        }

        /*
         * Getter for the image.
         */
        public Image GetTileImage()
        {
            return this.tileImage;
        }

        /*
         * Setter for the image.
         */
        public void SetTileImage(Image img)
        {
            this.tileImage = img;
        }

        /*
         * If the tile is empty this.empty = true
         * else this.empty = false.
         */
        public void SetEmpty(bool e)
        {
            this.empty = e;
        }

        /*
         * Returns true if the tile is empty and false otherwise.
         */
        public bool GetEmpty()
        {
            return this.empty;
        }


    }
}
