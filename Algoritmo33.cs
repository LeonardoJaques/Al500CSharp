using System;
namespace Al500csharp
{
    public class Algoritmo33
    {
        /* DESAFIO
        Ler dois número inteiros e imprimi-los.
        */

        private void Logic() {
            int[] numero = new int[2];

            Console.WriteLine($"\nDigite o primeiro número inteiro: ");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDigite o segundo número inteiro: ");
            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O primeiro número digitado é {numero[0]}\n");
            Console.WriteLine($"O segundo número digitado é {numero[1]}\n");
        }
        public void Run() => Logic();

    }
}
