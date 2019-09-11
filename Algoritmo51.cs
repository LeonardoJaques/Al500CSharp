using System;
namespace Al500csharp
{
    public class Algoritmo51
    {
        /* DESAFIO

            Entrar com o raio de um circulo e imprimir a seguinte saída:            perimetro:            area:

        */

        private void Logic() {
            double circulo, diametro, perimetro, area, raio;

            Console.WriteLine("Insira o raio do circulo");
            raio = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * (raio * raio);

            diametro = raio * 2;

            perimetro = diametro * Math.PI;

            Console.WriteLine($"Perimetro: {perimetro}\nÁrea: {area}");

        }
        public void Run() => Logic();

    }
}
