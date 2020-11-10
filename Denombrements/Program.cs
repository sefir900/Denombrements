using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {


        static void Main(string[] args)
        {
            string choix;
            choix = "1";
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case "1":
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int n1 = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                // calcul de r
                        long r1 = 1;
                        for (int k = 1; k <= n1; k++)
                            r1 *= k;
                        Console.WriteLine(n1 + "! = " + r1);
                        break;

                    case "2":
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);

                        break;

                    case "0":
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
