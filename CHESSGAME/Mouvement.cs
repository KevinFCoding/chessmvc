using System;
using System.Collections.Generic;
using System.Text;

namespace tableau
{
    public class Mouvement : Piece
    {
            private int a;
            private int b;
            private int destinationX;
            private int destinationY;

            public bool Exit { get; set; }

            public void MakeMove()
            {
                Start();

                if (!Exit)
                Update();
            }

            private void Start()
            {
                Console.WriteLine("Position  X");
                Exit = ChoixValide(int.TryParse(Console.ReadLine(), out a));

                if (!Exit)
                {
                    Console.WriteLine("Position Y");
                    Exit = ChoixValide(int.TryParse(Console.ReadLine(), out b));
                }

           
                if (!Exit)
                {
                    Console.WriteLine("Destination X");
                    Exit = ChoixValide(int.TryParse(Console.ReadLine(), out destinationX));
                }
           
                if (!Exit)
                {
                    Console.WriteLine("Destination Y");
                    Exit = ChoixValide(int.TryParse(Console.ReadLine(), out destinationY));
                }

            
                        
                    
                
            }

            private bool ChoixValide(bool parsed)
            {
                bool error = false;

                if (!parsed)
                {
                    error = true;
                }

                else if (a < 0 || b < 0 || destinationX < 0 || destinationX > Echiquier.Dimension - 1 || destinationY < 0 || destinationY > Echiquier.Dimension - 1)
                {
                    if (a > Echiquier.Dimension || b > Echiquier.Dimension)
                    {
                        error = true;
                    }
                    else
                    {
                        error = true;
                    }
                }
                return error;
            }

            private void Update()
            {
            pieces[a, b] = ' ';
            pieces[destinationX, destinationY] = pieces[a, b];

            }
        }
    }
