using System;
namespace Al500CSharp {
    /*
        prog teste
        imprima "raiz: ",raiz(64);
        imprima "\nraiz com exp e log e realint: ,rea1int(exp(1/2*1og(64))) ;
        imprima "\nraiz com exp e log sem realint: h',exp(1/2*log(64)) ;
        imprima "\n", formatar(sen(45*pi/180)+0.0001,3);
        imprima "\npotencia com exp e log e formatar: ",formata r(exp(3*log(8))+0.001,3);
        imprima "\npotencia com exp e log sem formatar: ,exp(3*1og(8)) ;
        imprima "\npotencia com operador ** e formatar: uu,formatar(8**3,3) ;
        imprima "\nraiz cubica: ",exp(1/3*log(8)) ;
        imprima "\nabsoluto: ",abs(-8);
        imprima "\nabsoluto: ",abs(8);
        imprima "\nconvertendo para inteiro 5.5: ",realint(5.5);
        imprima "\nconvertendo para inteiro 6.5: ",realint(6.5);
        imprima "\nconvertendo para inteiro 6.5 + 0.0001: ",realint(6.5+0.0001);
        imprima "\nconvertendo para inteiro 5.45: ",realint(5.45);
        imprima "\nconvertendo para inteiro 5.51: ",realint(5.51);
        imprima "\nconvertendo para real 87: ",intreal(87);
        imprima "\nconvertendo para int 3/4: ",realint(314),"\n";
        fimprog
        */

    public class Algoritmo19 {
        private void Logic () {
            double[] calculo = new double[16];

            calculo[0] = Math.Sqrt (64);
            calculo[1] = Math.Exp (0.5 * Math.Log(64));
            calculo[2] = Math.Sin (45 * Math.PI / 180) + 0.00013;
            calculo[3] = Math.Round (Math.Exp (3 * Math.Log10 (8) + 0.0013), 2);
            calculo[4] = Math.Exp (3 * Math.Log10 (8));
            calculo[5] = Math.Pow (8, 3.3);
            calculo[6] = Math.Exp (0.3333 * Math.Log10 (8));
            calculo[7] = Math.Abs (-8);
            calculo[8] = Math.Abs (8);
            calculo[9] = 5.5;
            calculo[10] = 6.5;
            calculo[11] = 6.5 + 0.0001;
            calculo[12] = 5.45;
            calculo[13] = 5.51;
            calculo[14] = (int) 87;
            calculo[15] = 3 / 4;

            Console.WriteLine ($"\nA raiz quadrada de 64 é: {calculo[0]}");
            Console.WriteLine ($"\nRaiz com exp e log e realint: {Convert.ToInt32(calculo[1])}");
            Console.WriteLine ($"\nRaiz com exp e log sem realint: {calculo[1]}");
            Console.WriteLine ($"\n{calculo[2]}");
            Console.WriteLine ($"\nPotencia com exp e log formatar {calculo[3]}");
            Console.WriteLine ($"\nPotencia com exp e log sem formatar {calculo[4]}");
            Console.WriteLine ($"\nPotencia com operador ** e formatar {calculo[5]}");
            Console.WriteLine ($"\nRaiz Cubica {calculo[6]}");
            Console.WriteLine ($"\nNumero Absoluto com valor negativo {calculo[7]}");
            Console.WriteLine ($"\nNumero Absoluto com valor positivo {calculo[8]}");
            Console.WriteLine ($"\nConvertendo para inteiro 5.5: {Convert.ToInt32(calculo[9])} ");
            Console.WriteLine ($"\nConvertendo para inteiro 6.5: {Convert.ToInt32(calculo[10])} ");
            Console.WriteLine ($"\nConvertendo para inteiro 6.5 + 0.0001: {Convert.ToInt32(calculo[11])}");
            Console.WriteLine ($"\nConvertendo para inteiro 5.45: {Convert.ToInt32(calculo[12])}");
            Console.WriteLine ($"\nConvertendo para inteiro 5.51: {Convert.ToInt32(calculo[13])} ");
            Console.WriteLine ($"\nConvertendo para real 87: {Convert.ToDouble(calculo[14])}");
            Console.WriteLine ($"\nConvertendo para int 3/4: {Convert.ToInt32(calculo[15])}");

        }
        public void Run () => Logic ();

    }
}