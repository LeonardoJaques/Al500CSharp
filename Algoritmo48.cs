﻿using System;
namespace Al500csharp
{
    public class Algoritmo48
    {
        /* DESAFIO

            Antes de o racionamento de energia ser decretado, quase ninguém falava em

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