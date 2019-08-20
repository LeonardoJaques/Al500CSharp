using System;
namespace Al500csharp
{
    public class Algoritmo49
    {
        /* DESAFIO
            Entrar com um nome e imprimir:            todo nome:            primeiro caractere:            ultimo caractere:            do primeiro ate o terceiro:            quarto caractere:            todos menos o primeiro:            os dois ultimos:

        */

        private void Logic() {
            string nome, primCaracter, ultCarcter, primAteTeceirom, quartoCarac, todosMenosPrim, todosMenosDoisUlti;
            Console.WriteLine("\nEntre com o nome completo");
            nome = Console.ReadLine();

            primCaracter = nome.Substring(0, 1);
            ultCarcter = nome.Substring(nome.Length - 1, 1);
            primAteTeceirom = nome.Substring(0, 3);
            quartoCarac = nome.Substring(3, 1);
            todosMenosPrim = nome.Substring(1, nome.Length-1);
            todosMenosDoisUlti = nome.Substring(0,nome.Length-2);

            Console.WriteLine($"Nome completo: {nome}");
            Console.WriteLine($"Primeiro caracter: {primCaracter}");
            Console.WriteLine($"Ultimo caracter: {ultCarcter}");
            Console.WriteLine($"Do primeiro até o terceiro: {primAteTeceirom}");
            Console.WriteLine($"O quarto caracter {quartoCarac}");
            Console.WriteLine($"Todos menos o primeiro {todosMenosPrim}");
            Console.WriteLine($"Todos menos os dois ultimos {todosMenosDoisUlti}");


        }
        public void Run() => Logic();

    }
}
