using System;
namespace Al500csharp
{
    public class Algoritmo44
    {
        /* DESAFIO

            Entrar com o número e a base em que se deseja calcular o logaritmo desse número            e imprimi-lo.

        */

        private void Logic() {
            double numero, newBase, calculo;

            Console.WriteLine("\nDigite o número que deseja calcular o logaritmo");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite a base para o calculo");
            newBase = Convert.ToDouble(Console.ReadLine());

            calculo = Math.Log(numero,newBase);

            Console.WriteLine($"O logaritmo do número {numero} na base {newBase} é calculo {calculo}");
        }
        public void Run() => Logic();

    }
}
