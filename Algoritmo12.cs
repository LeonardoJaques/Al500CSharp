using System;
namespace Al500CSharp {

    /* DESAFIO
     *prog imp2
     *imprima "Aprendendo Algoritmo
     *imprima "Com Anita e Guto";
     *
     */
    public class Algoritmo12 {

        private void Logic () {
            string[] imprima = { "Aprendendo Algoritmo!!!", "Com Anita Lopes e Guto Garcia" };

            Console.WriteLine ($"\n{imprima[0]+imprima[1]}");

        }

        public void Run () => Logic ();

    }
}