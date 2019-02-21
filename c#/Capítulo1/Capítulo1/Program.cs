using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Capítulo1
{
    class Program
    {
        public enum TipoComida { Carnivoro, Onivoro, Herbivoro, Mamar, Carne = Carnivoro };


        public static void  nick<T, U, V>(T Te, U Uu, V Ve){
            Console.WriteLine(Te +" "+ Uu + " "+ Ve);
            }

        public abstract class Mamiferos
        {
            protected string Especie="Mamifero Qualquer";
            public TipoComida Alimento= TipoComida.Mamar;
            protected double Peso= 0;


        }
        public class Dog : Mamiferos {
            public string especie
            {
                get{ return this.Especie; }
                set{ this.Especie = value; }
            }
            public double peso
            {
                get { return this.Peso; }
                set { this.Peso = value; }
            }

            public string alimento
            {
                get { return this.Alimento.ToString("g"); }
                set { this.Alimento = (TipoComida)(Convert.ToInt32(value)) ; }
            }
        }
        static void Main(string[] args)
        {
            Dog cachorro = new Dog();

            cachorro.especie= "Bonito";
            cachorro.alimento= "4";
            cachorro.peso = 5.50;
            nick(12, "Kevin", 2.02);
            Console.WriteLine(cachorro.alimento);

            

            Console.ReadKey();
        }
    }
}
