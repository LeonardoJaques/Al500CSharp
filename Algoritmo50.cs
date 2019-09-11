using System;
namespace Al500csharp
{
    public class Algoritmo50
    {
        /* DESAFIO
        Entrar com a base e a altura de um retângulo e imprimir a seguinte saída:        perimetro:        area:        diagonal:
        */

        private void Logic() {
            double altura, tbase, perimetro, area, hipotenusa;

            Console.WriteLine("Entre com a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com a base: ");
            tbase = Convert.ToDouble(Console.ReadLine());

            area = altura * tbase;
            perimetro = 2 * (altura + tbase);
            hipotenusa = Math.Sqrt( (altura * altura) + (tbase * tbase) );

            Console.WriteLine($"\nPerimetro: {perimetro}");
            Console.WriteLine($"\nÁrea: {area}");
            Console.WriteLine($"\nDiagonal: {hipotenusa}");
        }
        public void Run() => Logic();

    }
}
