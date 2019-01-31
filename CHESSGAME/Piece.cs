using System;
using System.Collections.Generic;
using System.Text;

namespace CHESSGAME
{
    public abstract class Piece
    
    {

        private string pieceType = "";
        public bool IsBlanc { get; set; }
        public string Nom { get; set; }

        public abstract void isValidMouv(int xd, int yd, int xa, int ya);
        public virtual void isTrajectoireLibre(int xd, int yd, int xa, int ya, string piece) {
             
            }
        }
}
