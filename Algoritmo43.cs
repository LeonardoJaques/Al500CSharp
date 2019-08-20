using System;
namespace Al500csharp
{
    public class Algoritmo43
    {
        /* DESAFIO

            Entrar com um número e imprimir o logaritmo desse número na base 10.

        */

        private void Logic() {
            double numero, resultado;

            Console.WriteLine("\nDigite o numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Log10(numero);
            Console.WriteLine($"O log base 10 do numero {numero} é {resultado}");

        }
        public void Run() => Logic();

    }
}
