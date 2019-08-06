using System;
namespace Al500csharp
{
    public class Algoritmo38
    {
        /* DESAFIO

            Ler um numero real e imprimir a terça parte deste numero.

        */

        private void Logic() {
            double numero, calculo;

            Console.WriteLine("\nDigite o numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            calculo = numero * 0.33333333333;

            Console.WriteLine($"\nA terça parte do {numero} é {calculo}");


        }
        public void Run() => Logic();

    }
}
