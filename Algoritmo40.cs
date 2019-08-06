using System;
namespace Al500csharp
{
    public class Algoritmo40
    {
        /* DESAFIO
        Entrar com dois numeros inteiros e imprimir a seguinte saída:        dividendo:        divisor:        quociente:        resto:
        
        */

        private void Logic() {
            int dividendo, divisor, quociente, resto;

            Console.WriteLine("\nDigite o dividendo: ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            quociente = dividendo / divisor;
            resto = dividendo % divisor;

            Console.WriteLine($"\nDividendo: {dividendo}\nDivisor: {divisor}\nQuociente: {quociente}\nResto: {resto}\n");

        }
        public void Run() => Logic();

    }
}
