using System;
namespace CHESSGAME {
    public abstract class Piece {

        public bool couleur;
        public string nom;

        public abstract void IsValidMouv(int xd, int yd, int xa, int ya);

        public virtual void IsTrajectoireLibre(int xd, int yd, int xa, int ya, string piece) {}






    }
}
