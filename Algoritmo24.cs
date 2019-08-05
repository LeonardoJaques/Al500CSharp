using System;
namespace Al500csharp
{
    public class Algoritmo24
    {
        /* DESAFIO
               prog teste         int a,d;           imprima "\nDigite numero de tres casas:           leia a;           d<-a div 10 % 10;           imprima "\nalgarismo da casa das dezenas: ", d;           imprima "\n";        fimprog

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
