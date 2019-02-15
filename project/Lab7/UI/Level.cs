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
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Method that creates the form in which the n will be read.
         * (the picture 1 will be divided into n x n tiles)
         */ 
        private void Picture1_Click(object sender, EventArgs e)
        {
            UsernameTiles usernameTiles = new UsernameTiles(this, 1);
            usernameTiles.Show();
        }

        /**
        * Method that creates the form in which the n will be read.
        * (the picture 2 will be divided into n x n tiles)
        */
        private void Picture2_Click(object sender, EventArgs e)
        {
            UsernameTiles usernameTiles = new UsernameTiles(this, 2);
            usernameTiles.Show();

        }
        /**
       * Method that creates the form in which the n will be read.
       * (the picture 3 will be divided into n x n tiles)
       */
        private void Picture3_Click(object sender, EventArgs e)
        {
            UsernameTiles usernameTiles = new UsernameTiles(this, 3);
            usernameTiles.Show();
        }
        /**
       * Method that creates the form in which the n will be read.
       * (the picture 4 will be divided into n x n tiles)
       */
        private void Picture4_Click(object sender, EventArgs e)
        {
            UsernameTiles usernameTiles = new UsernameTiles(this, 4);
            usernameTiles.Show();
        }

        /**
         * Method that sets the button's background image if the puzzle containing the pictureNr is completed.
         */
        public void Passvalue(bool var, int pictureNr)
        {
            if (var == true)
            {
                if (pictureNr == 1)
                    picture1.BackgroundImage = Image.FromFile("picture1.png");
                else if (pictureNr == 2)
                    picture2.BackgroundImage = Image.FromFile("picture2.png");
                else if (pictureNr == 3)
                    picture3.BackgroundImage = Image.FromFile("picture3.png");
                else
                    picture4.BackgroundImage = Image.FromFile("picture4.png");

            }

        }
    }
}