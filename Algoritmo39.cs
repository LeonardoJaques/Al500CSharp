using System;
using System.Linq;

namespace Al500csharp
{
    public class Algoritmo39
    {
        /* DESAFIO

            Entrar com dois numeros reais e imprimir a media aritmética com a mensagem            media antes do resultado/

        */

        private void Logic() {

            double soma, media;
            int disciplinas;

            Console.WriteLine("\nInsira o número de diciplinas");

            disciplinas = Convert.ToInt32(Console.ReadLine());
            double[] nota = new double [disciplinas];
            
            for (int i = 0; i < nota.Length; i++) {

                Console.WriteLine($"\nDigite o {i+1}º número: ");
                nota[i] = Convert.ToDouble(Console.ReadLine());

            }

            soma = nota.Sum();
            media = soma / nota.Length;

            Console.WriteLine($"\nA média aritmética é de {media}");
        }
        public void Run() => Logic();

    }
}
