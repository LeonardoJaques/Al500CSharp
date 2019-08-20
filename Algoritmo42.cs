using System;
namespace Al500csharp
{
    public class Algoritmo42
    {
        /* DESAFIO

            Entrar com um ângulo em graus e imprimir: seno, co-seno, tangente, secante,            co-secante e co-tangente deste ângulo.

        */

        private void Logic() {

            double seno, coseno, tangente;
            double secante, cosecante, cotangente;
            double angulo, rang;

            //double catetoAdj, catetoOps;
            //double hipotenusa;

            //Console.WriteLine("\nDigite o cateto adjacente: ");
            //catetoAdj = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite o cateto oposto: ");
            //catetoOps = Convert.ToDouble(Console.ReadLine());
                        
            Console.WriteLine("Digite o angulo º: ");
            angulo = Convert.ToDouble(Console.ReadLine());

            //hipotenusa = Math.Sqrt((catetoAdj*catetoAdj)+(catetoOps*catetoOps));
            //seno = catetoOps / hipotenusa;
            //coseno = catetoAdj / hipotenusa;
            //tangente = catetoOps / catetoAdj;

            rang = angulo * Math.PI / 180;

            seno = Math.Sin(rang);
            coseno = Math.Cos(rang);
            tangente = Math.Tan(rang);

            cosecante = 1 / seno;
            secante = 1 / coseno;
            cotangente = 1 / tangente;

            //Console.WriteLine($"\nA Hipotenusa: {hipotenusa}");

            Console.WriteLine($"\nO seno: {Math.Round(seno,2)}");
            Console.WriteLine($"\nO co-seno: {Math.Round(coseno, 2)}");
            Console.WriteLine($"\nA tangente: {Math.Round(tangente, 2)}");
            Console.WriteLine($"\nA co-secante: {Math.Round(cosecante, 2)}");
            Console.WriteLine($"\nA secante: {Math.Round(secante, 2)}");
            Console.WriteLine($"\nA co-tangente: {Math.Round(cotangente, 2)}");

        }
        public void Run() => Logic();

    }
}
