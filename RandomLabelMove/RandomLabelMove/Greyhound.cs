using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class Greyhound
    {
        public PictureBox MyPictureBox;
        public Random Randomizer;
        public int StartingPoint;


        public bool Move()
        {
            MyPictureBox.Left += Randomizer.Next(4);
            if(MyPictureBox.Left >= MyPictureBox.Parent.Width - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StartingPosition()
        {
            MyPictureBox.Left = StartingPoint;
        }
    }
}
