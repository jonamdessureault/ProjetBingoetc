using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    class BingoController
    {
        private int partiesJouees = 0;
        private int partiesGagnees = 0;

        public BingoController()
        {
        }

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }

        public void NouvellePartie()
        {
            Boulier boulier = new Boulier();

            for (int i = 1; i <= 15; i++)
            {
                BingoBall B = new BingoBall('B', i);
                boulier.add(B);
            }


            for (int i = 16; i <= 30; i++)
            {
                BingoBall I = new BingoBall('I', i);
                boulier.add(I);
            }

            for (int i = 31; i <= 45; i++)
            {
                BingoBall N = new BingoBall('N', i);
                boulier.add(N);
            }

            for (int i = 46; i <= 60; i++)
            {
                BingoBall G = new BingoBall('G', i);
                boulier.add(G);
            }

            for (int i = 61; i <= 75; i++)
            {
                BingoBall O = new BingoBall('O', i);
                boulier.add(O);
            }

        }

        public void RefairePartie()
        {
            Console.WriteLine("Voulez-vous refaire une partie ? O/N");
            string choixPartie = Console.ReadLine();
            if(choixPartie == "O")
            {
                PartiesJouees++;
                NouvellePartie();
            }
            else if(choixPartie == "N")
            {
               
            }
        }

    }
 }