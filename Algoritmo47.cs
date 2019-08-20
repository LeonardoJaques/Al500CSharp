using System;
namespace Al500csharp
{
    public class Algoritmo47
    {
        /* DESAFIO

          Entrar com um número no formato CDU e imprimir invertido: UDC. (Exemplo:          123, sairá 321.) O número deverá ser armazenado em outra variável antes de ser          impresso.

        */

        private void Logic() {
            int num, c, d, u, num1;
            Console.WriteLine("\nEntre com um número de 3 digitos ");
            num = Convert.ToInt32(Console.ReadLine());
            c = num / 100;
            d = num % 100 / 10;
            u = num % 10;

            num1 = u * 100 + d * 10 + c;

            Console.WriteLine($"\nNúmero: {num}\nInvertido: {num1}\n");



        }
        public void Run() => Logic();

    }
}
