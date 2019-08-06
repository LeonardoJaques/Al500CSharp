using System;
namespace Al500csharp
{
    public class Algoritmo32
    {
        /* DESAFIO
        Ler um número inteiro e imprimi-lo.
        */

        private void Logic() {
            Console.WriteLine("\nDigite o número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O número digitado foi o {numero}");

        }
        public void Run() => Logic();

    }
}
