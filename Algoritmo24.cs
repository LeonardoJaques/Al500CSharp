﻿using System;
namespace Al500csharp
{
    public class Algoritmo24
    {
        /* DESAFIO
               prog teste

        */

        private void Logic() {
            int a, d;
            Console.WriteLine("\nDigite numero de três casa: ");
            a = Convert.ToInt32(Console.ReadLine());
            d = a / 10 % 10;
            Console.WriteLine($"\nOs algorimos na casa da dezenas: {d} ");

        }
        public void Run() => Logic();

    }
}