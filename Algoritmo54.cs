using System;
namespace Al500csharp
{
    public class Algoritmo54
    {
        /* DESAFIO

            Criar um algoritmo que calcule e imprima a área de um triângulo.
            formula base*altura/2
        */

        private void Logic() {
            double xbase, haltura, calculoArea;

            Console.WriteLine("Insira o valor da base: ");
            xbase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor da altura: ");
            haltura = Convert.ToDouble(Console.ReadLine());

            calculoArea = (xbase * haltura) / 2;

            Console.WriteLine($"O calculo de área é {calculoArea}");
        }
        public void Run() => Logic();

    }
}
