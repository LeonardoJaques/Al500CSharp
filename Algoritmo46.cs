using System;
namespace Al500csharp
{
    public class Algoritmo46
    {
        /* DESAFIO

            Fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o            novo saldo, considerando o reajuste de 1%.

        */

        private void Logic() {

            double saldo, novoSaldo, reajuste, calculo;

            Console.WriteLine("\nDigite o saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o valor do reajuste: ");
            reajuste = Convert.ToDouble(Console.ReadLine());

            calculo = saldo * reajuste;
            novoSaldo = saldo + calculo;

            Console.WriteLine($"\n\nO Saldo anterior era de {saldo} com o reajuste de {reajuste*100}%" +
                $" ficou no valor de {novoSaldo}"  );
        }
        public void Run() => Logic();

    }
}
