using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace DeGokkers
{
    public class Animal
    {
        public int RaceTrackLength;             //De lengte van de renbaan     
        public PictureBox MyPictureBox = null;
        public Random Randomizer;               //Een instantie van Random (= Willekeurig)  
        public bool finish;

        public bool Run()
        {
            Randomizer = new Random();

            this.MyPictureBox.Location = new Point(this.MyPictureBox.Location.X + Randomizer.Next(1, 5), this.MyPictureBox.Location.Y); //Werk de positie van PictureBox bij op het formulier. Ga willekeurig 1, 2, 3 of 4 posities naar voren.
            this.MyPictureBox.Refresh();
            if (this.MyPictureBox.Location.X > RaceTrackLength)
            {
                finish = true;
                return true;        //Geef de waarde ‘true’ terug als ik de race win. 
            }
            else
            {
                finish = false;
                return false;
            }
        } 

        public void TakeStartingPosition()
        {
            this.MyPictureBox.Location = new Point(2, this.MyPictureBox.Location.Y);          
        } 
    }
}
