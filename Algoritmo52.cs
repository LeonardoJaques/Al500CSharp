using System;
namespace Al500csharp
{
    public class Algoritmo52
    {
        /* DESAFIO

        Entrar com o lado de um quadrado e imprimir:        perimetro:        area:        diagonal:

        formula do perimetro = P = L + L + L + L ou P = L x 4
        formula de area = A = Lados * lado ou A = base * altura
        formula da diagonal = A2 = b2 + c2; (hipotenusa)

        */

        private void Logic() {

            double lado, area, perimetro, diagonal;

            Console.WriteLine("Insira a altura do quadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());

            perimetro = lado * 4;
            area = Math.Pow (lado,2) ;
            diagonal = Math.Sqrt( lado* lado + lado * lado);

            Console.WriteLine($"Perimetro: {perimetro}\nÁrea: {area}\nDiagonal: {diagonal} ");

        }
        public void Run() => Logic();

    }
}
