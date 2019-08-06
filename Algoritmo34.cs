using System;
namespace Al500csharp
{
    public class Algoritmo34
    {
        /* DESAFIO
           Ler um número inteiro e imprimir seu sucessor e seu antecessor.
        */

        private void Logic() {
            int numero, sucessor, antecessor;

            Console.WriteLine($"\nDigite o primeiro número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;

            Console.WriteLine($"O numero antecessor é {antecessor};\nO numero é {numero};\nO sucessor é {sucessor}; \n");
            
        }
        public void Run() => Logic();

    }
}
