using Lab7.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class UsernameTiles : Form
    {
        private int pictureIndex;
        private int nrOfTiles;
        private Level levelForm = null;

        public UsernameTiles(Level levelForm, int pictureIndex)
        {
            this.levelForm = levelForm;
            InitializeComponent();
            this.pictureIndex = pictureIndex;
        }

        public void ShowForm()
        {
            this.Show();
        }

        /**
         * Method that starts the game.
         * The picture with index pictureIndex and the nr of tiles is sent to another form,
         * where the picture will be divided into nr x nr tiles.
         */ 
        private void Button1_Click(object sender, EventArgs e)
        {
            String pictureName;
            pictureName = "picture" + this.pictureIndex + ".png";
            Image img = new Bitmap(pictureName);

            String nr = this.nrTilesTextBox.Text;
            this.nrOfTiles = Int32.Parse(nr);
            PuzzleForm puzzleForm = new PuzzleForm(levelForm, this.pictureIndex, img, this.nrOfTiles);
            puzzleForm.Show();
            this.Hide();
        }
    }
}
