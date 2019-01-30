using System;


namespace CHESSGAME.Pieces {
    public class Pion : Piece {

        public Pion(bool color, string nom) {

        this.couleur = color;
        this.nom = nom;


        }
        /*
        public  bool IsValidMouv(int xd, int yd,int xa, int ya, string piece) {

        }
        */
        public override void IsValidMouv(int xd, int yd, int xa, int ya) {
        throw new NotImplementedException();
        }
    }
    }
