using System;
namespace Al500csharp
{
    public class Algoritmo37
    {
        /* DESAFIO

            Ler dois números inteiros e imprimir o produto.

        */

        private void Logic() {
            int[] numero = new int[2];
            int produto;

            Console.WriteLine("\nDigite o 1º número: ");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o 2º número: ");
            numero[1] = Convert.ToInt32(Console.ReadLine());
            produto = numero[0] * numero[1];

            Console.WriteLine($"\nResultado do produto é {produto}");

        }
        public void Run() => Logic();

    }
}
