using System;
using System.Runtime;
using System.Runtime.InteropServices;

namespace Al500csharp
{
    public class Algoritmo53
    {
        /* DESAFIO

            Entrar com os lados a, b, c de um paralelepípedo. Calcular e imprimir a diagonal.
            formulas:
                Área da Base: Ab = a.b
                Área Total: At = 2ab+2bc+2ac
                Volume: V = a.b.c
                Diagonais: D = √a2 + b2 + c2

                Para calcular a área lateral de um paralelepípedo retângulo utiliza-se a fórmula:
                Al = 2(ac+bc)
        */

        private void Logic() {

            double diagonais, ladoA, ladoB, ladoC;

            Console.WriteLine("Insira o lado A");
            ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o lado B");
            ladoB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o lado C");
            ladoC = Convert.ToDouble(Console.ReadLine());

            diagonais = Math.Sqrt((ladoA *ladoA) + (ladoB * ladoB) + (ladoC * ladoC)) ;

            Console.WriteLine($"A diagonal é {diagonais}");

        }
        public void Run() => Logic();

    }
}
