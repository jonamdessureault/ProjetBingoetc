using System;
using ProjetJeuPOO.Bingo;
using ProjetJeuPOO.SimiliBlackJack;
using ProjetJeuPOO.SimiliPendu;

namespace ProjetJeuPOO
{
    class Controller
    {
        static void Main(string[] args)
        {
            private bool trudy = true;

        public bool Trudy { get => trudy; set => trudy = value; }

        TableauScore();
        static void TableauScore()
        {
            BingoController bingoController = new BingoController();
            BlackJackController blackJackController = new BlackJackController();
            PenduController penduController = new PenduController();

            Console.WriteLine("Bienvenue dans vos jeux!");
            Console.WriteLine("Veuillez entrer votre nom:");
            string nomJoueur = Console.ReadLine();
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("Nom du joueur: {0}", nomJoueur);
            Console.Write("|"); Console.WriteLine("BINGO: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", bingoController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire:{0}", bingoController.PartiesGagnees);
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("BLACKJACK: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", blackJackController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire: {0}", blackJackController.PartiesGagnees);
            Console.WriteLine("******************************");
            Console.Write("|"); Console.WriteLine("LE PENDU: ");
            Console.Write("|"); Console.WriteLine("Nombre de partie: {0}", penduController.PartiesJouees);
            Console.Write("|"); Console.WriteLine("Nombre de victoire: {0}", penduController.PartiesGagnees);
            Console.WriteLine("******************************");
        }

        static void MenuJeux()
        {
            Console.WriteLine("Veuillez choisir un jeu");
            Console.WriteLine("1- Bingo");
            Console.WriteLine("2- BlackJack");
            Console.WriteLine("3- Le pendu");
            string choixJeux = Console.ReadLine();
            ChoixJeux(choixJeux);
        }
        static void ChoixJeux(string choix)
        {
            switch (choix)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
            }
        }

        static void CalculPartiesBingo()
        {
            int nombrePartie = 0;


        }

        static void CalculPartiesBlackJack()
        {
            int nombrePartie = 0;
        }

        static void CalculPartiesPendu()
        {
            int nombrePartie = 0;
        }
  
        
    }
}
