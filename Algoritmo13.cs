using System;
namespace Al500CSharp {
/*prog imp3
imprima 11Aprendendo Algoritmo!!!";
imprima "\nCom Anita e Guto";
fimprog */
    public class Algoritmo13 {
        private void Logic () {
            string[] imprima = { "Aprendendo Algoritmo!!!", "\nCom Anita Lopes e Guto Garcia." };
            Console.WriteLine ($"\n{imprima[0]+imprima[1]}");

        }

        public void Run () => Logic ();

    }
}