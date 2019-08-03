using System;
namespace Al500CSharp {

    /*
    prog imp6
    int x;
    X <- 10;
    imprima x
     */

    public class Algoritmo16 {
        private void Logic () {
            int x, imprima;
            Console.WriteLine ("Digite o valor de x: ");
            x = Convert.ToInt32 (Console.ReadLine ());

            imprima = x;
            Console.WriteLine ($"O valor de x: {imprima}");

        }
        public void Run () => Logic ();

    }
}