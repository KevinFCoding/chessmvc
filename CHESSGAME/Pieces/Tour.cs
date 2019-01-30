using System;
namespace CHESSGAME.Pieces {
    public class Tour : Piece{

        public Tour(bool color, string nom) {

        this.couleur = color;
        this.nom = nom;


        }

        public override void IsValidMouv(int xd, int yd, int xa, int ya) {
        throw new NotImplementedException();
        }
    }
    }
