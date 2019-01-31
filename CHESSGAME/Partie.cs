using System;
using CHESSGAME.Pieces;
namespace CHESSGAME {



    public class Partie {

        //Mise en place de la main courante; true  = tour des blancs, on inverse pour le tour des noirs.
        public bool Maincourante = true;
        Piece[,] echiquier = new Piece[8, 8];



        public void Jouer(int xd, int yd, int xa, int ya) {

        }

        // aff incrémentation

        //Mise en place de l'échiquier et des pièces.
        public void Game() {

            // côté blanc
            echiquier[0, 0] = new Roi(true, "Tour");
            echiquier[1, 0] = new Reine(true, "Cavalier");
            echiquier[2, 0] = new Roi(true, "Fou");
            echiquier[3, 0] = new Roi(true, "Roi");
            echiquier[4, 0] = new Roi(true, "Reine");
            echiquier[5, 0] = new Roi(true, "Fou");
            echiquier[6, 0] = new Roi(true, "Cavalier");
            echiquier[7, 0] = new Roi(true, "Tour");

            for (int i = 0; i < 8; i++) {
                echiquier[i, 1] = new Pion(true, "Pion");
                }

            // côté noir
            echiquier[0, 7] = new Roi(false, "Tour");
            echiquier[1, 7] = new Reine(false, "Cavalier");
            echiquier[2, 7] = new Roi(false, "Fou");
            echiquier[3, 7] = new Roi(false, "Roi");
            echiquier[4, 7] = new Roi(false, "Reine");
            echiquier[5, 7] = new Roi(false, "Fou");
            echiquier[6, 7] = new Roi(false, "Cavalier");
            echiquier[7, 7] = new Roi(false, "Tour");
            
            for (int i = 0; i< 8; i++) {
                echiquier[i, 6] = new Pion(false, "Pion");
            }
    }


    }
}
