using System;
namespace CHESSGAME.Pieces {
    public class Reine : Piece{

        public Reine(bool color, string nom) {

        this.couleur = color;
        this.nom = nom;


        }

        public override void IsValidMouv(int xd, int yd, int xa, int ya) {
        throw new NotImplementedException();
        }
    }
}
