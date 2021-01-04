using System;

namespace PGCD_Egyptien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calcul du pgcd (Méthode Egyptienne)";

            Console.Write("Entrez le premier nombre : ");
            var n1 = Int32.Parse(Console.ReadLine());

            Console.Write("Entrez le premier nombre : ");
            var n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (n1 * n2 != 0)
                Console.WriteLine("pgcd({0};{1}) = {2}", n1, n2, pgcd(n1, n2));
            else
                Console.WriteLine("le pgcd de ces nombres n'existent pas");

        }

        static int pgcd (int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
    }
}
