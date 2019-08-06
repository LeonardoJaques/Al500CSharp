using System;
namespace Al500csharp
{
    public class Algoritmo35
    {
        /* DESAFIO
            Ler nome, endereço e telefone e imprimi-los.
        */

        private void Logic() {
            string nome, endereco, telefone;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o endereço: ");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine($"\nO nome: {nome}\nO endereço {endereco}\nO telefone {telefone}");

        }
        public void Run() => Logic();

    }
}
