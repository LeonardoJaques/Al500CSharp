using System;
namespace Al500CSharp
/*prog imp4
imprima "Aprendendo Algoritmo !!!\n
imprima "Com Anita e Guto";
fimprog */

{
    public class Algoritmo14 {
        private void Logic () {

                string[] imprima = { "Aprendendo Algoritmo !!!\n", "Com Anita e Guto" };
                Console.WriteLine ($"{imprima[0] + imprima[1]}");

        }

        public void Run () => Logic ();

    }
}