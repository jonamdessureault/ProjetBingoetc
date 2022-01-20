﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetJeuPOO.Bingo
{
    class BingoController
    {
        private int partiesJouees = 0;
        private int partiesGagnees = 0;
        Boulier boulier = new Boulier();
        private List<BingoCard> listeCards;
        private bool partieEnCours = false;
        
        // Arraylist ou list de bingocard

        public BingoController()
        {

        }

        public int PartiesJouees { get => partiesJouees; set => partiesJouees = value; }
        public int PartiesGagnees { get => partiesGagnees; set => partiesGagnees = value; }
        public bool PartieEnCours { get => partieEnCours; set => partieEnCours = value; }
        internal List<BingoCard> ListeCards { get => ListeCards; set => ListeCards = value; }

        public static void AppuyerEnter()
        {
            Console.WriteLine("Veuillez appuyer sur enter pour poursuivre");
            Console.ReadLine();
        }
        public void NouvellePartie()
        {
            this.PartieEnCours = true;
            boulier.fillBoulier();
            PartiesJouees++;
            ChoixNombre();
        }
        public void NombreCartes()
        {
            Console.WriteLine("Veuillez inscrire le numéro de la carte à consulter");
            string nombreCarte = Console.ReadLine();
            ChoixCartes(nombreCarte);
        }
        public void ChoixCartes(string choix)
        {

            switch (choix)
            {
                case "1":
                    listeCards[1].AfficherCartes();
                    break;
                case "2":
                    listeCards[2].AfficherCartes();
                    break;
                case "3":
                    listeCards[3].AfficherCartes();
                    break;
                case "4":
                    listeCards[4].AfficherCartes();
                    break;
                default:
                    Console.WriteLine("Nombre de cartes invalide");
                    break;
            }

        }

    /*   public void MarquerCartes()
        {
            foreach (BingoCard card in listeCards)
            {
                if(boulier.CarteAnnonceur[i,j] = carteJoueur[i,j])
                {
                    carteJoueur[i, j] = 0;
                }
            }
        }
    */

       /* public void GagnerPartie()
        {
            foreach (BingoCard card in listeCards)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (carteJoueur[0, j] = 0)
                        {
                            ProcessWin();
                        }
                        else if (carteJoueur[1, j] = 0)
                        {
                            ProcessWin();
                        }
                        else if (carteJoueur[2, j] = 0)
                        {
                            ProcessWin();
                        }
                        else if (carteJoueur[3, j] = 0)
                        {
                            ProcessWin();
                        }
                        else if (carteJoueur[4, j] = 0)
                        {
                            ProcessWin();
                        }

                    }
                }
            }
        }*/
        public void ProcessWin()
        { string chien = "chien";
            Console.WriteLine("BINGO sur la carte {0}",chien);
            partiesGagnees++;
            RefairePartie();
        }
        public void RefairePartie()
        {
            Console.WriteLine("Voulez-vous refaire une partie ? O/N");
            string choixPartie = Console.ReadLine();
            if(choixPartie == "O")
            {
                NouvellePartie();
            }
            else if(choixPartie == "N")
            {
                this.PartieEnCours = false;
            }
        }

        public void MenuBingo()
        {
            Console.WriteLine("Bienvenue dans le jeu Bingo!");
            Console.WriteLine("Choisissez une option: ");
            Console.WriteLine("1- Initialiser une nouvelle partie");
            Console.WriteLine("2- Visualiser une des cartes du joueur");
            Console.WriteLine("3- Visualiser la carte de l'annonceur");
            Console.WriteLine("4- Tirez une boule");
            Console.WriteLine("5- Fin de partie");
            string choixBingo = Console.ReadLine();
            ChoixBingo(choixBingo);
        }

        public void ChoixBingo(string choix)
        {
            switch(choix)
            {
                case "1":
                    NouvellePartie();
                    break;
                case "2":
                    NombreCartes();
                    break;
                case "3":
                    boulier.AfficherCarteA();
                    break;
                case "4":
                    boulier.TirerBoule();
                    break;
                case "5":
                    Console.WriteLine("s");
                    break;
            }
        }

        public void ChoixNombre()
        {
            Console.WriteLine("Combien de cartes désirez-vous jouer ? (4 max)");
            int choixCarte = Convert.ToInt32(Console.ReadLine());
            listeCards = new List<BingoCard>();

            for (int i = 0; i < choixCarte; i++)
            {
                BingoCard bingoCard = new BingoCard();
                listeCards.Add(bingoCard);
            }

        }
    }
 }