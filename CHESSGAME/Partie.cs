using System;

namespace CHESSGAME {



    public class Partie {

        public bool Maincourante = true;

        

        public void Jouer(int xd, int yd, int xa, int ya) {

        }
        // aff incrémentation
        public void Chess2() {

        Piece[,] Chess = new Piece[8, 8];

        for (int x = 0; x < 8; x++) {
                for (int y = 0; y < 8; y++) {
                    Console.WriteLine(Chess[8, 8]);
                    Console.WriteLine( x + y );

                }
            }

        }


    }
}
