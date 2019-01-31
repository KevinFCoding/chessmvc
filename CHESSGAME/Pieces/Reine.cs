using System;
namespace CHESSGAME.Pieces {
    public class Reine : Piece{

        public Reine(bool color, string nom) {

            this.IsBlanc = color;
            this.Nom = nom;


            }

        // Vérificaiton si le mouvement de la pièce n'est pas indisposé par des adversaires ou alliés sur sa trajectoire.
        public override void isTrajectoireLibre(int xd, int yd, int xa, int ya, string piece) {

            }

        // Vérif si le mouvement est valide.
        public override void isValidMouv(int xd, int yd, int xa, int ya) {

            }
        }
}
