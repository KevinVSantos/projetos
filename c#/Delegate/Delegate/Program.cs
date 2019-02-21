using System;

namespace Delegate
{
    public delegate void Comprimentar(string DigaIsso);
    public delegate bool Anonimo(int x);



    class Program
    {
        static public Anonimo Retorno = delegate (int x) {

            return x == 10;
        };
        static void Main(string[] args)
        {

            Comprimentar Falar = new Comprimentar(Oi.DigaOi);
            Falar("KEVIN");
            Console.WriteLine();

            Console.WriteLine(Retorno(10));
            Console.ReadKey();






        }


    }
}
