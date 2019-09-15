using System;
namespace Al500csharp
{
    public class Algoritmo56
    {
        /* DESAFIO
        Entrar com nome e idade. Imprimir a seguinte saída:            nome:            idade:
        
        */

        private void Logic() {

            Console.WriteLine("Entre com o nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("\nEntre com a idade:");
            Int32 idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nNome: {nome}\n\nIdade: {idade}");

        }
        public void Run() => Logic();

    }
}
