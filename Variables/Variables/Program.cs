using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int traspas = 1948;
            int anysTraspas = 4;

            string nom = "Joan";
            string cognom1 = "Baza";
            string cognom2 = "Tomas";

            int dia = 04;
            int mes = 03;
            int any = 2000;

            Console.WriteLine("{0} {1} {2}", cognom1, cognom2, nom);
            Console.WriteLine("{0}/{1}/{2}", dia, mes, any);

            int anysTraspasats = 0;

            for (int i = traspas; i < any; i += anysTraspas)
            {
                anysTraspasats++;
            }
            Console.WriteLine("Anys de traspas: {0}", anysTraspasats);
        }
    }
}
