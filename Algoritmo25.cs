using System;
namespace Al500csharp
{
    public class Algoritmo25
    {
        /* DESAFIO
        Entrar com uma data no formato ddmmaa e imprimir: dia, mês e ano separados.
        */

        private void Logic() {

            int data, dia, mes, ano;
            Console.WriteLine("\nDigite data no formato DDMMAA:");
            data = Convert.ToInt32(Console.ReadLine());

            dia = data / 10000;
            mes = data % 10000 / 100;
            ano = data % 100;
            Console.WriteLine($"\nDia: {dia}");
            Console.WriteLine($"\nMes: {mes}");
            Console.WriteLine($"\nAno: {ano}\n");
            
        }
        public void Run() => Logic();

    }
}
