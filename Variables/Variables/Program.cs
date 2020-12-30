using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "Joan";
            string cognom1 = "Baza";
            string cognom2 = "Tomas";

            int dia = 30;
            int mes = 12;
            int any = 2020;

            Console.WriteLine("{0} {1} {2}", cognom1, cognom2, nom);
            Console.WriteLine("{0}/{1}/{2}", dia, mes, any);
        }
    }
}
