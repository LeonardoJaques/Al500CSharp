using System;
using System.Linq;

namespace Al500csharp
{
    public class Algoritmo41
    {
        /* DESAFIO

            Entrar com quatro números e imprimir a média ponderada, sabendo-se que os            pesos são respectivamente: 1, 2, 3 e 4.

        */

        private void Logic()
        {

            int quantidade;

            Console.WriteLine("Insira a quantidade de disciplinas: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            double[] notas = new double[quantidade];
            double[] pesos = new double[quantidade];
            double mediaPonderada;
            double calculoNotaPeso = 0;
            double somaPeso = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"\nDigite a nota da {i + 1}º disciplina: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nDigite o peso da {i + 1}º peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());

                calculoNotaPeso += notas[i] * pesos[i];
                somaPeso = pesos.Sum();
            }
            mediaPonderada = calculoNotaPeso / somaPeso;
            Console.WriteLine($"Media ponderada é de { mediaPonderada }");

        }

        public void Run() => Logic();

    }
}
