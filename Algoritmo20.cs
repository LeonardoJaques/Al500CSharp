﻿using System;
namespace Al500CSharp
{
    /*
    prog funcoes
         */


    public class Algoritmo20
    {

        private void Logic(){

            string c, c1, d, d1;
            string strtam, strconcat, strprim;
            string strult, strresto, strelem;
            string strnprim, strnresto;


            Console.WriteLine("\nDigite a primeira palavra: ");
            c = Console.ReadLine();

            Console.WriteLine("\nDigite a segunda palavra: ");
            c1 = Console.ReadLine();

            strtam = Convert.ToString(c.Length);
            strconcat = c + c1;
            d1 = string.Concat(c,c1);
            d = string.Copy(c);

            strprim = c.Substring(0,1);
            strult = c.Substring(c.Length - 1,1);
            strresto = c.Substring(1,c.Length - 1);
            strelem = c.Substring(3,1);
            strnprim = c.Substring(0, 3);
            strnresto = c.Substring(c.Length - 3);


            Console.WriteLine($"\nO tamanho da primeira palavra é: {strtam}");
            Console.WriteLine($"\nConcatenando a primeira e a segunda palavra: {strconcat}");
            Console.WriteLine($"\nCopiando a primeira palavra é: {d}");
            Console.WriteLine($"\nConcatenando a primeira e a segunda palavra com concat: {d1}");
            Console.WriteLine($"\nImprimindo a letra inicial da primeira palavra: {strprim}");
            Console.WriteLine($"\nImprimindo a letra final da primeira palavra: {strult}");
            Console.WriteLine($"\nTodas as letras menos a inicial da primeira palavra: {strresto}");
            Console.WriteLine($"\nO terceiro elemento da primeira palavra: {strelem}");
            Console.WriteLine($"\nOs três elementos iniciais da primeira palavra: {strnprim}");
            Console.WriteLine($"\nOs três elementos finais da primeira palavra: {strnresto}");
        }
        public void Run() => Logic();


    }
}