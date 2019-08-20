using System;
namespace Al500csharp
{
    public class Algoritmo48
    {
        /* DESAFIO

            Antes de o racionamento de energia ser decretado, quase ninguém falava em            quilowatts; mas, agora, todos incorporaram essa palavra em seu vocabulário. Sabendo-            se que 100 quilowatts de energia custa um sétimo do salário mínimo,            fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts            gasta por uma residência e calcule. Imprima:            o valor em reais de cada quilowatt            m o valor em reais a ser pago            o novo valor a ser pago por essa residência com um desconto de 10%.

        */

        private void Logic() {
            double sm, qtdade, preco, vp, vd;

            Console.WriteLine("\nEntre com o salario mínimo: ");
            sm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEntre com a quandtidade de quilowatts: ");
            qtdade = Convert.ToDouble(Console.ReadLine());

            preco = sm / 700;

            vp = preco * qtdade;
            vd = vp * 0.9;

            Console.WriteLine($"\nPreço do quilowatts: {preco}\nValor a ser pago: {vp}\nValor com desconto: {vd}");

        }
        public void Run() => Logic();

    }
}
