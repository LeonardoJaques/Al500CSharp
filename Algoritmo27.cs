using System;
namespace Al500csharp
{
    public class Algoritmo27
    {
        /* DESAFIO
            Utilizando operadores ++ --
        */
        
        private void Logic() {
            int x, y;
            x = 2;
            y = 5;

            Console.WriteLine($"\nX = {x}");
            x++;
            Console.WriteLine($"\n\nY = {y}");
            y--;
            Console.WriteLine($"\nO novo valor de X = {x}");
            Console.WriteLine($"\nO novo valor de Y = {y}\n");
        }
        public void Run() => Logic();

    }
}
