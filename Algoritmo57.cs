using System;
namespace Al500csharp
{
    public class Algoritmo57
    {
        /* DESAFIO
        Entrar com as notas da PR 1 e PR2 e imprimir a média final:        truncada:        arredondada:


        */

        private void Logic() {
            double pr1, pr2, media;


            Console.WriteLine("Entre com a nota da primeira prova: ");
            pr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a nota da segunda prova: ");
            pr2 = Convert.ToDouble(Console.ReadLine());

            media = pr1 + pr2 / 2;

            Console.WriteLine($"Media Final: \n\n truncada: { media }\n\n arredondada: { Math.Round(media) }");

        }
        public void Run() => Logic();

    }
}
