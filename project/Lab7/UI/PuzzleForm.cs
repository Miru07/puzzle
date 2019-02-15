using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab7.Controller;
using Lab7.Model;

namespace Lab7.UI
{
    public partial class PuzzleForm : Form
    {
        private PuzzleController controller;
        private int nrOfTiles;
        private List<Tile> tiles = new List<Tile>();

        private Level levelForm = null;
        private int pictureIndex;

        public PuzzleForm(Level levelForm, int pictureIndex, Image img, int nr)
        {
            this.levelForm = levelForm;
            this.pictureIndex = pictureIndex;
            InitializeComponent();
            this.nrOfTiles = nr;
            controller = new PuzzleController(img, this.nrOfTiles);

            this.tiles = this.controller.GetTiles();
            List<Tile> solution = this.tiles;
            this.controller.RandomizeTiles();     

            while (this.controller.SumOfInversions() == 0 || (this.nrOfTiles % 2 == 1 && this.controller.SumOfInversions() % 2 == 1) ||
             (this.nrOfTiles % 2 == 0 && (this.controller.SumOfInversions() + this.nrOfTiles - this.controller.GetEmptyRow()) % 2 == 1 && this.controller.SumOfInversions() == 0))
            {
                this.controller.RandomizeTiles();
            }

            this.InitTileImages();

        }

        public void show()
        {
            this.Show();
        }

        /*
         * Method that creates the game's tiles.
         * If the tiles are in ascending order, the sum of inversions is 0 and the game stops.
         */ 
        public void InitTileImages()
        {
            if (this.controller.SumOfInversions() == 0)
            {
                this.Close();
                MessageBox.Show("Succes!");
                levelForm.Passvalue(true, this.pictureIndex);
            }
            else
            {
                int j = 0, k = 0;

                for (int i = 0; i < tiles.Count; i++)
                {

                    if (j == this.nrOfTiles)
                    {
                        j = 0;
                        k = k + 1;
                    }

                    PictureBox picture = new PictureBox
                    {
                        Name = "pictureBox" + i.ToString(),
                        Size = new Size(100, 100),
                        Location = new Point(14 + k * 100, 17 + j * 100),
                        Visible = true
                    };

                    j = j + 1;
                    this.tiles[i].SetChangedPosition(i);
                    picture.Image = tiles.ElementAt(i).GetTileImage();
                    this.Controls.Add(picture);

                }
            }
        }

        /**
         * Method that moves the empty tile in the direction of an arrow key, if the empty tile is not on a border.
         */ 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (this.controller.GetEmptyRow() != 1)
                {
                    this.MoveTile(-1);
                }
                return true;
            }

            if (keyData == Keys.Down)
            {
                if (this.controller.GetEmptyRow() != this.nrOfTiles)
                {
                    this.MoveTile(1);
                }
                return true;
            }

            if (keyData == Keys.Left)
            {
                if (this.controller.GetEmptyPosition() >= this.nrOfTiles)
                {
                    this.MoveTile(-this.nrOfTiles);
                }
                return true;
            }
 
            if (keyData == Keys.Right)
            {
                if (this.controller.GetEmptyPosition() + this.nrOfTiles <= this.nrOfTiles*this.nrOfTiles - 1)
                {
                    this.MoveTile(this.nrOfTiles);
                }
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /**
         * Method that moves the tile.
         * For up, the direction = -1, so the empty tile will be swaped with the one on the empty tile position -1.
         * For down, the direction = 1, so the empty tile will be swaped with the one on the empty tile position +1.
         * For right, the direction = n, so the empty tile will be swaped with the one on the empty tile position +n.
         * For left, the direction = -n, so the empty tile will be swaped with the one on the empty tile position -n.
         */
        private void MoveTile(int direction)
        {
            int emptyPosition = this.controller.GetEmptyPosition();

            Bitmap emptyImage = (Bitmap)Image.FromFile("empty.png");
            Bitmap tileImage = (Bitmap)this.tiles[emptyPosition + direction].GetTileImage();

            int emptyInitialPos = this.tiles[emptyPosition].GetInitialPosition();
            int tileInitialPos = this.tiles[emptyPosition + direction].GetInitialPosition();

            this.tiles[emptyPosition + direction].SetTileImage(emptyImage);
            this.tiles[emptyPosition + direction].SetEmpty(true);
            this.tiles[emptyPosition + direction].SetInitialPosition(emptyInitialPos);


            this.tiles[emptyPosition].SetTileImage(tileImage);
            this.tiles[emptyPosition].SetEmpty(false);
            this.tiles[emptyPosition].SetInitialPosition(tileInitialPos);

            this.Controls.Clear();
            this.InitTileImages();

           
        }
    }
}   
