using System;
using System.Collections.Generic;
using System.Text;

namespace tableau
{
    public class Piece
    
    {

        public static char[,] pieces;

        public Piece()
        {
            pieces = new char[Echiquier.Dimension, Echiquier.Dimension];
            CreatioPiece();
        }

        private void CreatioPiece()
        {
            for (int Colo = 0; Colo < Echiquier.Dimension; Colo++)
            {
                for (int ligne = 0; ligne < Echiquier.Dimension; ligne++)
                {
                    if (Colo == 0 || Colo == 1 || Colo == 6 || Colo == 7)
                        pieces[Colo, ligne] = 'O';
                    else
                        pieces[Colo, ligne] = ' ';
                }
            }
        }
    }
}
