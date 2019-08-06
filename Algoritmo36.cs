using System;
using System.Linq;

namespace Al500csharp
{
    public class Algoritmo36
    {
        /* DESAFIO
        Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer        a mensagem: Soma.
      
        */

        private void Logic() {
            int[] numero = new int[2];

            Console.WriteLine("\nDigite o primeiro número: ");
            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            numero[1] = Convert.ToInt32(Console.ReadLine());

            int soma = numero.Sum();
            Console.WriteLine($"\nA soma {soma}");


        }
        public void Run() => Logic();

    }
}
