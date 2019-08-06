using System;
using System.Linq;

namespace Al500csharp
{
    public class Algoritmo31
    {
        /* DESAFIO
        Criar um algoritmo que imprima a média aritmética entre os números 8, 9 e 7. 
        */

        private void Logic() {
            int media, materias;

            Console.WriteLine("\nDigite a quantidade de matérias: ");
            materias = Convert.ToInt32(Console.ReadLine());

            int[] numero = new int[materias];
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"\nDigite o {i+1}º notas: ");
                numero[i] = Convert.ToInt32(Console.ReadLine());

            }

            media = numero.Sum() / numero.Length;

            Console.WriteLine($"\nA média é {media}");
            
        }

        public void Run() => Logic();

    }
}
