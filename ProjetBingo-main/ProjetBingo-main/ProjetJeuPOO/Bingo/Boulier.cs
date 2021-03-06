using System;
using System.Collections.Generic;
using System.Text;

// Classe qui représente le boulier. On y retire les boules au hazard.

namespace ProjetJeuPOO.Bingo
{
    class Boulier : IBingoBoulier
    {
        private List<BingoBall> Boules;

        public Boulier()
        {
          this.Boules = new List<BingoBall>();
        }

        public BingoBall getRanbomBall()
        {
            throw new NotImplementedException();
        }

        public void restartBoulier()
        {
            throw new NotImplementedException();
        }

        public void add(BingoBall element)
        {
            //Ajouter les boules dans le boulier
            this.Boules.Add(element);
        }
        public bool isEmpty()
        {
            if (Boules.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getSize()
        {
            return this.Boules.Count;
        }

        public void NouvellePartieBingo()
        {
            
        }

        public void VoirCartes()
        {

        }

        public void VoirCarteAnnonceur()
        {

        }

        public void TirezBoule()
        {

        }

        public void FinPartie()
        {

        }

        public void MenuBingo()
        {
            Console.WriteLine("Bievenue dans le menu Bingo!");
            Console.WriteLine("1- Initialiser une nouvelle partie");
            Console.WriteLine("2- Visualiser une des cartes du joueur");
            Console.WriteLine("3- Visualiser la carte de l'annonceur");
            Console.WriteLine("4- Tirez une boule");
            Console.WriteLine("5- Fin de partie");
            string choixBingo = Console.ReadLine();
            ChoixMenuBingo(choixBingo);

        }

        public void ChoixMenuBingo(string choix)
        {
            switch (choix)
            {
                case "1":
                    NouvellePartieBingo();
                    break;

                case "2":
                    VoirCartes();
                    break;

                case "3":
                    VoirCarteAnnonceur();
                    break;

                case "4":
                    TirezBoule();
                    break;

                case "5":
                    FinPartie();
                    break;

                default:
                    Console.WriteLine("Veuillez entrer un choix valide");
                    break;

            }
        }
    }
}
