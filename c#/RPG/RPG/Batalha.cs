using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    
       
    
    public class Batalha
    {

        static void turno<T>(T lutador1, T lutador2)
            where T: IPersonagens
        {

            int dano1;
            int dano2;

            if (lutador1.EstaVivo() && !lutador1.Stuned())
            {
                Console.WriteLine("Turno de {0}", lutador1.Nome);
                if ((dano1 = lutador1.Dano()) > lutador2.MostrarDefesa())
                {

                    Console.WriteLine("{0} acertou um golpe. Causou um total de {1} de dano.", lutador1.Nome, (dano1 - lutador2.MostrarDefesa()));
                    lutador2.Vida_Atual -= (dano1 - lutador2.MostrarDefesa());
                }
                else
                {
                    Console.WriteLine("{0} conseguiu se defender, por isso nao sofreu dano do ataque de {1}.", lutador2.Nome, lutador1.Nome);

                }
            }
            if (lutador2.EstaVivo() && !lutador2.Stuned())
            {
                Console.WriteLine("Turno de {0}", lutador2.Nome);

                if ((dano2 = lutador2.Dano()) > lutador1.MostrarDefesa())
                {

                    Console.WriteLine("{0} acertou um golpe. Causou um total de {1} de dano.", lutador2.Nome, (dano2 - lutador1.MostrarDefesa()));
                    lutador1.Vida_Atual -= (dano2 - lutador1.MostrarDefesa());
                }
                else
                {
                    Console.WriteLine("{0} conseguiu se defender, por isso nao sofreu dano do ataque de {1}.", lutador1.Nome, lutador2.Nome);

                }


            }
        }



        public static IPersonagens lutar< T>(T lutador1, T lutador2)
        where T: IPersonagens
        {


            Console.Clear();
            Console.WriteLine("\t"+lutador1.Nome + "\t VS \t" + lutador2.Nome);
            Console.WriteLine("vida:\t" + lutador1.Vida_Atual + " \t\t " + lutador2.Vida_Atual);
            Console.WriteLine("Defesa:\t" + lutador1.MostrarDefesa() + " \t\t " + lutador2.MostrarDefesa());
            Console.WriteLine("Poder:\t" + lutador1.MostrarPoder() + " \t\t " + lutador2.MostrarPoder());


            Console.WriteLine("A batalha iniciou. " + lutador1.Nome + " atacará primeiro.");
            do
            {
                turno(lutador1, lutador2);


            } while (lutador2.EstaVivo() && lutador1.EstaVivo());

            Console.WriteLine("A batalha acabou.");
            if (lutador1.EstaVivo())
            {

                Console.WriteLine("{0} venceu esse combate.", lutador1.Nome);
                Console.WriteLine("Ele terminou a batalha com {0} de vida", lutador1.Vida_Atual);

                Console.ReadKey();
                return lutador1;
            }
            else {
                Console.WriteLine("{0} venceu esse combate.", lutador2.Nome);
                Console.WriteLine("Ele terminou a batalha com {0} de vida", lutador2.Vida_Atual);

                Console.ReadKey();
                return lutador2;

            }
            

        }
    }
}
