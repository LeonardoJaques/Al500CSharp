using System;
namespace Al500csharp
{
    public class Algoritmo45
    {
        /* DESAFIO

         Entrar com um número e imprimir a seguinte saída:         numero:         quadrado:         raiz quadrada:

        */

        private void Logic() {

            double numero, quadrado, raizQuadrada;

            Console.WriteLine("\nDigite o numero desejado");
            numero = Convert.ToDouble(Console.ReadLine());

            quadrado = Math.Pow(numero,2);

            raizQuadrada = Math.Sqrt(quadrado);

            Console.WriteLine($"Resultado do cálculo\nNúmero: {numero};\nQuadrado: {quadrado};\nRaíz quadrada: {raizQuadrada};");

        }
        public void Run() => Logic();

    }
}
