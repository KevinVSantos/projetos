using System;

namespace Exercicio_1
{
    class Program
    {

        public class Calculadora{

            static public void menu(int status=0)
            {
                if(status!=0)
                Console.Clear();
                Console.WriteLine("\tSelecione uma das seguintes operações disponivel:");
                Console.WriteLine("\t\t + (Soma)");
                Console.WriteLine("\t\t - (Subtração)");
                Console.WriteLine("\t\t * (Multiplicação)");
                Console.WriteLine("\t\t / (Divisão)");
                Console.WriteLine("\t\t ^ (Potência)");
                Console.WriteLine("\t\t % (Resto da Divisão)");
                Console.WriteLine("\t\t . (Sair)");

            }
            static public void Soma() {
                decimal x, y;
                
                Console.Clear();
                Console.WriteLine("Você escoulheu: Soma.");
                Console.WriteLine("Digite Dois numeros para serem somados:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());
                    
                    Console.WriteLine("O resultado da soma {0}+{1} é : {2}", x, y, checked (x + y));

                }
                catch (FormatException) {
                    Console.WriteLine("Formato Inválido. Digite números válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }

                Console.ReadKey();
            }
            static public void Subtração()
            {
                decimal x, y;

                Console.Clear();
                Console.WriteLine("Você escoulheu: Subtração.");
                Console.WriteLine("Digite Dois numeros para serem Subtraidos:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("O resultado da subtração {0}-{1} é : {2}", x, y, checked(x - y));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido. Digite NÚMEROS válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }

                Console.ReadKey();
            }
            static public void Multi()
            {
                decimal x, y;

                Console.Clear();
                Console.WriteLine("Você escoulheu: Multiplicação.");

                Console.WriteLine("Digite Dois numeros para serem Multiplicados:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("O resultado da multiplicação {0}*{1} é : {2}", x, y, checked(x * y));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido. Digite NÚMEROS válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }

                Console.ReadKey();
            }
            static public void Divi()
            {
                decimal x, y;   
                Console.Clear();
                Console.WriteLine("Você escoulheu: Divisão.");

                Console.WriteLine("Digite Dois numeros para serem Divididos:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("O resultado da Divisão {0}/{1} é : {2}", x, y, checked(x / y));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido. Digite NÚMEROS válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }
                catch (DivideByZeroException) {
                    Console.WriteLine("O segundo número não pode ser 0. Sua divisão tenderia à infinito!");
                }

                Console.ReadKey();
            }
            static public void Potencia()
            {
                int i;
                decimal x, y, res=1;
                Console.Clear();
                Console.WriteLine("Você escoulheu: Potenciação.");

                Console.WriteLine("Digite Dois numeros. O primeiro será elevado ao segundo:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());

                    for (i = 0; i < y; i++)
                    { res = checked (res * x); }

                    Console.WriteLine("O resultado da potenciação {0}^{1} é : {2}", x, y, res);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido. Digite NÚMEROS válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }
                Console.ReadKey();
            }
            static public void Resto()
            {
                decimal x, y;
                Console.Clear();
                Console.WriteLine("Você escoulheu: Resto de Divisão.");

                Console.WriteLine("Digite Dois numeros para encontrar o resto:");
                try
                {
                    x = Convert.ToDecimal(Console.ReadLine());
                    y = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("O resto da divisão {0}/{1} é : {2}", x, y, checked(x % y));

                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato Inválido. Digite NÚMEROS válidos");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Esses numero são grandes demais! Digite numeros válidos.");
                }

                Console.ReadKey();
            }
        }




        static void Main(string[] args)
        {
            string operação;
            int status=0;
            Console.WriteLine("\tOlá, isso é uma calculadora.");

            do
            {
                Calculadora.menu(status);
                status = 1;
                operação = Console.ReadLine();
                switch (operação)
                {
                    case "+":
                        Calculadora.Soma();
                        break;
                    case "-":
                        Calculadora.Subtração();

                        break;
                    case "*":
                        Calculadora.Multi();

                        break;
                    case "/":
                        Calculadora.Divi();

                        break;
                    case "^":
                        Calculadora.Potencia();

                        break;
                    case "%":
                        Calculadora.Resto();

                        break;
                    case ".":
                        break;
                    default:
                        Console.WriteLine("Operação invalida. Precione para escolher novamente.");
                        Console.ReadKey();
                        break;
                }
                
            } while (!operação.Equals("."));
            Console.Clear();
            Console.WriteLine("Até mais.");



        }
    }
}
