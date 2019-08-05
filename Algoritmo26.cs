using System;
namespace Al500csharp
{
    public class Algoritmo26
    {
        /* DESAFIO

            Entrar com uma data no formato ddmmaa e imprimir no formato mmddaa.

        */

        private void Logic() {

            int data, dia, mes, ano, ndata;
            Console.WriteLine("\nDigite data no formato DDMMAA:");
            data = Convert.ToInt32(Console.ReadLine());

            dia = data / 10000;
            mes = data % 10000 / 100;
            ano = data % 100;
            ndata  = mes * 10000 + dia * 100 + ano;
            Console.WriteLine($"\nDia: {dia}");
            Console.WriteLine($"\nMes: {mes}");
            Console.WriteLine($"\nAno: {ano}");
            Console.WriteLine($"\n\nData no formato MMDDAA: {ndata}\n");



        }
        public void Run() => Logic();

    }
}
