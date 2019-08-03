using System;
namespace Al500csharp
{
    public class Algoritmo23
    {
        /* DESAFIO

            Entrar comum número inteiro de 3 casas e imprimir o algarismo da casadas dezenas.
        
        */

        private void Logic() {
            int numero, calculo;

            Console.WriteLine("\nDigite um numero inteiro com 3 casas decimais: ");
            numero = Convert.ToInt32(Console.ReadLine());
            calculo = numero % 100 / 10;

            Console.WriteLine($"O algorismo da casa das dezenas é : {calculo}");
            


        }
        public void Run() => Logic();

    }
}
