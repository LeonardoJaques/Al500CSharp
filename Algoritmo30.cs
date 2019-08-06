using System;
namespace Al500csharp
{
    public class Algoritmo30
    {
        /* DESAFIO
            "Criar um algoritmo que imprima o produto entre 28 e 43.". 
        */

        private void Logic() {
            int numero1, numero2, produto;


            Console.WriteLine("\nDigite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            produto = numero1 * numero2;

            Console.WriteLine($"\nO produto do primeiro e segundo número é {produto}");
            
        }
        public void Run() => Logic();

    }
}
