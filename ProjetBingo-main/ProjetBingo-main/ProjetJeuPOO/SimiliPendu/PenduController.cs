using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.SimiliPendu
{
    class PenduController
    {
       private int partiesJouees = 0;
       private int partiesGagnees = 0;
        public PenduController()
        {
        }

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }
    }
}
