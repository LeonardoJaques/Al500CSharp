using System;
namespace Al500csharp
{
    public class Algoritmo59
    {
        /* DESAFIO

            Entrar com os valores dos catetos de um triângulo retângulo e imprimira hipotenusa
            formula h2 = ca2 + co2

        */

        private void Logic() {
            double catetoAdjacente, catetoOposto, hipotenusa;

            Console.WriteLine("Entre com o valor do cateto adjacente: ");
            catetoAdjacente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do cateto oposto: ");
            catetoOposto = Convert.ToDouble(Console.ReadLine());

            hipotenusa = Math.Sqrt((catetoAdjacente*catetoAdjacente)+ (catetoOposto * catetoOposto));

            Console.WriteLine($"O valor da hipotenusa do triângulo retângulo é de {hipotenusa}");
        }
        public void Run() => Logic();

    }
}
