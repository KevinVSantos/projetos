using System;

namespace RPG
{
    public enum Vocação { Mago, Guerreiro }

    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int escolha=0;
            Random Aleatorio = new Random();

            Console.WriteLine("Para começar, vamos criar seu personagem.");

            Console.WriteLine("Escolha seu nome:");
            nome=Console.ReadLine();

            IPersonagens Player1 = null;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha umas das opções.Voce será um:");
                Console.WriteLine("1- Mago.");
                Console.WriteLine("2- Gurreiro.");
                try
                {
                    escolha = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(escolha);
                }
                catch
                {
                    Console.WriteLine("Invalido. Tente outro valor");
                    Console.ReadKey();
                }


            } while (escolha != 1 && escolha != 2);

            Console.Clear();
            Console.WriteLine("Geraremos seus atributos aleatoriamente.");
            if (escolha == 1)
            {
                 Player1 = new Mago(nome, Aleatorio.Next(20, 35) , Aleatorio.Next(5, 9), Aleatorio.Next(11, 19));

            }
            else{
                Player1 = new Guerreiro(nome, Aleatorio.Next(30, 45), Aleatorio.Next(8, 13), Aleatorio.Next(8, 12));

            }



            Console.WriteLine("Seu personagem foi criado. Ele se chama:"+ Player1.Nome);
            Console.WriteLine("Voce é um " + Player1.Vocacao + " e seus atributos são:");
            Console.WriteLine("Vida " + Player1.Vida_Maxima );
            Console.WriteLine("Defesa " + Player1.MostrarDefesa());
            Console.WriteLine("Magia ou Força " + Player1.MostrarPoder());
            Console.ReadKey();

            Guerreiro Player2 = new Guerreiro("Spider", Aleatorio.Next(30, 45), Aleatorio.Next(8, 13), Aleatorio.Next(8, 12));
            Batalha.lutar(Player1, Player2);

            Console.Clear();


            Console.ReadKey();

        }

    }
}
