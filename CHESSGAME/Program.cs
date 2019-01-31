using System;

namespace tableau
{
    class Program
    {

        static void Main(string[] args)
        {
            Echiquier echiquier = new Echiquier();
            echiquier.AffichageEchiquier();
        }
    }
    /*
    //Program program;
    private int tableauTailleX;
    private int tableauTailleY;
    private string color;

    //int[,] tableau = new int[, 2];
    public int Colo { get => tableauTailleX; set => tableauTailleX = value; }
    public int Ligne { get => tableauTailleY; set => tableauTailleY = value; }
    public string Color { get => color; set => color = value; }

    static void Main()
    {
        Console.WriteLine("Hello World!");
        int[,] array = new int[8, 8];
        for (int Colo = 1; Colo < 9; Colo++)
        {          
            for (int Ligne = 1; Ligne < 9; Ligne++)
            {

                /*if ((Colo + Ligne )%2 == 0)
                {

                    //Couleur("white");
                    //Console.Write("O");
                    Console.Write(Ligne + Colo); 
                }
                else
                {
                    //Couleur("black");
                    //Console.Write("X");
                    Console.Write(Ligne + Colo);

                }
            }
            Console.WriteLine(" ");
        }
        Console.ReadLine();




    }



    static string  Couleur(string color)
    {
        string laCouleur = color ;
        if(laCouleur == "black")
        {
            laCouleur = "#000000";
            Console.WriteLine(laCouleur);
        }
        else if(laCouleur == "white")
        {
            laCouleur = "#FFFFFF";
            Console.WriteLine(laCouleur);
        }
        else
        {
            laCouleur = "Couleur chelou";
            Console.WriteLine(laCouleur);
        }
        Console.WriteLine(color);
        return laCouleur;
    }
}*/
}
   
