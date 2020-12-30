﻿using System;

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

            string frase1 = "Es any de traspas!";
            string frase2 = "No es any de traspas";
            bool naixementTraspas = false;

            for (int i = traspas; i <= any; i += anysTraspas)
            {
                anysTraspasats++;
                if (i == any)
                {
                    naixementTraspas = true;
                }
            }
            if (naixementTraspas)
            {
                Console.WriteLine(frase1);
            }
            else
            {
                Console.WriteLine(frase2);
            }
            Console.WriteLine("Anys de traspas: {0}", anysTraspasats);

            string nomComplet = nom + " " + cognom1 + " " + cognom2;
            string anyNaixement = dia + "/" + mes + "/" + any;

            Console.WriteLine("El meu nom es {0}", nomComplet);
            Console.WriteLine("Vaig neixer el {0}", anyNaixement);
            if (naixementTraspas)
            {
                Console.WriteLine("El meu any de naixement es de traspas");
            }
            else
            {
                Console.WriteLine("El meu any de naixement no es de traspas");
            }
        }
        
    }
}
