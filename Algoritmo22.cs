using System;
namespace Al500CSharp
{
    /*
    prog teste        imprima "\nTESTANDO HIERARQUIA";        imprima "\n\n18/6 % 2 é igual a: ", 18 / 6 % 2;        imprima "\nUma operação de divisão fora de parênteses não pode ser um        dos operandos de uma expressão com %.";#continuacao        imprima "\n\n20 / 4 div 2 é igual a: ", 20 / 4 div 2;        imprima "\nÉ IGUAL a (20 / 4) div 2 : ",(20 / 4) div , 2," logo div tem a        MESMA HIERARQUIA ";#continuacao        imprima " da        imprima "\n\n30 / 4 div 2 é igual a: ", 3014 div 2;        imprima "\nÉ IGUAL a (30 / 4) div 2 : ",(30 / 4) div 2," logo div tem        a MESMA HIERARQUIA ";#continuacao        imprima " da / "; 33        imprima " \n\n 7 . div 4: h1,7• div 4;        imprima \n7 div 4: 11,7 div 4;        imprima "\n6. div 4: ",6. div 4;        imprima \n6 div 4: ",6 div 4;        imprima "\n";        fim prog
     */

    public class Algoritmo22
    {
        private void Logic()
        {

            double[] calculo = new double[9];

            calculo[0] = 18 / 6 % 2;
            calculo[1] = 20 / 4 / 2;
            calculo[2] = (20 / 4) / 2;
            calculo[3] = 30 / 4 / 2;
            calculo[4] = (30.0 / 4.0) / 2.0;
            calculo[5] = 7.0 / 4;
            calculo[6] = 7 / 4;
            calculo[7] = 6.0 / 4;
            calculo[8] = 6 / 4;


            Console.WriteLine("\nTestando Hierarquia\n");

            Console.WriteLine($"\n\n18 / 6 % 2 é igual a: {calculo[0]}");
            Console.WriteLine($"\nUma operação de divisão fora de parênteses não pode ser um " +
                $"dos operandos de uma expressão com %");

            Console.WriteLine($"\n\n20 / 4 div 2 é igual a: {calculo[1]}");
            Console.WriteLine($"\nÉ IGUAL a (20 / 4) div 2: {calculo[2]} logo div tem a MESMA HIERARQUIA da /");

            Console.WriteLine($"\n\n30 / 4 div 2 é igual a: {calculo[3]}");
            Console.WriteLine($"\nÉ IGUAL a (30 / 4) div 2: {calculo[4]} logo div tem a MESMA HIERARQUIA da /");

            Console.WriteLine($"\n\n7. div 4: {calculo[5]}");
            Console.WriteLine($"7  div 4: {calculo[6]}");
            Console.WriteLine($"6. div 4: {calculo[7]}");
            Console.WriteLine($"6  div 4: {calculo[8]}");


        }
        public void Run() => Logic();


    }
}
