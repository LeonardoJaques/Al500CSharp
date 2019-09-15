using System;
namespace Al500csharp
{
    public class Algoritmo58
    {
        /* DESAFIO
        Entrar com valores para xnum1, xnum2 e xnum3 e imprimir o valor de x, sabendo-        se que:  X = xnum1 + (xnum2/xnum3+xnum1) + 2(xnum1-xnum2) + log2ˆ64
        
        */

        private void Logic() {
            double xnum1, xnum2, xnum3, calculaX;

            Console.WriteLine("Entre com o valor do primeiro numero: ");
            xnum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do segundo numero: ");
            xnum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o valor do terceiro numero: ");
            xnum3 = Convert.ToDouble(Console.ReadLine());

            calculaX = xnum1 + (xnum2 / (xnum3 + xnum1)) + 2 * (xnum1 - xnum2) + Math.Log(64)/ Math.Log(2);

            Console.WriteLine($"O valor de x é {calculaX}");

        }
        public void Run() => Logic();

    }
}
