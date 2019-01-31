using System;
using System.Collections.Generic;
using System.Text;

namespace tableau
{
    public class Echiquier
    {
            public const int Dimension = 8;
            private string[,] echiquier;

            private Mouvement mouvement;



            public Echiquier()
            {
                mouvement = new Mouvement();
                echiquier = new string[Dimension, Dimension];
            }

            public void AffichageEchiquier()
            {
                while (!mouvement.Exit)
                {

                    for (int colo = 0; colo < Dimension; colo++)
                    {
                        Console.Write("  ");
                        for (int ligne = 0; ligne < Dimension; ligne++)
                        {
                            Console.Write("----");
                        }

                        Console.WriteLine(" ");

                        for (int ligne = 0; ligne < Dimension; ligne++)
                        {
                            if (ligne == 0)
                        {
                            Console.Write(colo + " ");


                        }
                        Console.Write("| " + Piece.pieces[colo, ligne] + " ");

                    }

                        Console.WriteLine("| ");
                    }

                    Console.WriteLine(" ");
                    mouvement.MakeMove();
                }
            }

        }
    }
