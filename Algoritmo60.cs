using System;
namespace Al500csharp
{
    public class Algoritmo60
    {
        /* DESAFIO

           Entrar com a razão de uma PA e o valor do 1º termo. Calcular imprimir o 10º termo           da serie formula PA ( an = a1 + (n – 1) . r)
           
        */

        private void Logic() {
            double termoIni, razaoR, quantTermosN, progAritmetica;

            Console.WriteLine("Insira o termo inicial: ");
            termoIni = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de termos: ");
            quantTermosN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de razões: ");
            razaoR = Convert.ToDouble(Console.ReadLine());

            progAritmetica = termoIni + (quantTermosN - 1) * razaoR;

            Console.WriteLine($"O valor do ultimo termo é { progAritmetica }º ");
        }
        public void Run() => Logic();

    }
}
