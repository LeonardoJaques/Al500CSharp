using System;
namespace Al500csharp
{
    public class Algoritmo55
    {
        /* DESAFIO
            Criar um algoritmo que calcule e imprima a área de um losango.
            formula DiagonalMaior * diagonalMenor / 2

        */

        private void Logic() {
            double diagonalMaior, diagonalMenor, calculoArea;

            Console.WriteLine("Insira o valor da Diagonal Maior: ");
            diagonalMaior = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor da Diagonal Menor: ");
            diagonalMenor = Convert.ToDouble(Console.ReadLine());

            calculoArea = diagonalMaior * diagonalMenor / 2;

            Console.WriteLine($"A área de um losangulo: {calculoArea}");
        }
        public void Run() => Logic();

    }
}
