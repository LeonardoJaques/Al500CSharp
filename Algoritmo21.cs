using System;
namespace Al500CSharp
{
    public class Algoritmo21
    {

        /* DESAFIO
        prog teste        imprima "\nTESTANDO HIERARQUIA\n";        imprima \n12+5/2é igual a: ", 12+5/2;        imprima "\nÉ DIFERENTE DE (12 + 5)/2 que é igual a: ", (12 + 5)/2 9,"        logo / tem HIERARQUIA MAIOR do que + ou -";#continuacao        imprima h'\n\n64**1/4 é igual a: ",64**1/4        imprima "\nÉ DIFERENTE de 64**(1/4)que é igual a: 11,64**(1/4), logo **        tem HIERARQUIA MAIOR do que * ou / " ;#continuacao        imprima hI\\3*7 % 5 é igual a: ", 3*7 % 5;        imprima "\nÉ DIFERENTE de (3 * 7) % 5 que é igual a: ",(3 * 7) % 5 9        logo % tem HIERARQUIA MAIOR do que * " ;#continuacao        imprima "\n\n3 * 7 div 5 é igual a: ", 3*7 div 5;        imprima "\nÉ IGUAL a (3 * 7) div 5 : " (3 * 7) div 5," logo div tem a        MESMA HIERARQUIA da * ou / ";#continuacao        imprima "\n";        fimprog
        
        */

        private void Logic()
        {
            double[] calculo = new double [8];
            calculo[0] = 12.0+5.0/2.0;
            calculo[1] = (12.0 + 5.0) / 2.0;
            calculo[2] = Math.Pow(64,0.25);
            calculo[3] = 64 * 0.25;
            calculo[4] = 3.0 * 7.0 % 5.0;
            calculo[5] = 3.0 * 7.0 / 5.0;
            calculo[6] = (3.0 * 7.0) / 5.0;


            Console.WriteLine("\nTestando Hierarquia\n");

            Console.WriteLine($"\n12+5/2é igual a: {calculo[0]}");

            Console.WriteLine($"\nÉ DIFERENTE DE (12 + 5)/2 que é igual a: {calculo[1]} " +
                $"logo / tem HIERARQUIA MAIOR do que + ou -");

            Console.WriteLine($"\n64**1/4 é igual a: {calculo[3]}");
            Console.WriteLine($"\nÉ DIFERENTE de 64**(1/4)que é igual a: {calculo[2]} logo **" +
                $" tem HIERARQUIA MAIOR do que* ou /;" );

            Console.WriteLine($"\n3 * 7 div 5 é igual a: {calculo[4]}");
            Console.WriteLine($"\n É DIFERENTE de(3 * 7) % 5 que é igual a: {calculo[5]}"+
                " logo % tem HIERARQUIA MAIOR do que * ");
            
            Console.WriteLine($"\nÉ IGUAL a (3 * 7) div 5 : {calculo[6]} "+                "logo div tem a MESMA HIERARQUIA da * ou / ;");

        }
        public void Run() => Logic();

    }
}
