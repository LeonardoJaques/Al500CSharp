using System;
namespace Al500csharp
{
    public class Algoritmo61
    {
        /* DESAFIO
        Entrar com a razão de uma PG e o valor do 1º termo.        Calcular e imprimir o 5º termo da série.
        formula an = a1 . qˆ(n-1)


        */

        private void Logic() {
            double razaoQ, termoIni, quantTermos, progressaoGeo;

            Console.WriteLine("Insira o primeito termo: ");
            termoIni = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a razão do termo: ");
            razaoQ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de termos: ");
            quantTermos = Convert.ToDouble(Console.ReadLine());

            progressaoGeo = termoIni * Math.Pow(razaoQ, quantTermos - 1);

            Console.WriteLine($"O valor do termo em progressao geometrica é {progressaoGeo}º");



        }
        public void Run() => Logic();

    }
}
