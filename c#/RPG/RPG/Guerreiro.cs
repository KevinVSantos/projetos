using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Guerreiro:IPersonagens
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public int XpUp { get; set; }
        public Vocação Vocacao { get; set; }

        public int Vida_Atual { get; set; }
        public int Vida_Maxima { get; set; }

        public int Mana_Atual { get; set; }
        public int Mana_Maxima { get; set; }

        public int Cap_Atual { get; set; }
        public int Cap_Maxima { get; set; }


        public int Defesa_Maxima { get; set; }
        public int Defesa_Atual { get; set; }

        public int StunTime { get; set; }
        public int Força { get; set; }


        public Guerreiro(string nome, int vida, int defesa, int força)
        {

            this.Vida_Maxima = vida;
            this.Vida_Atual = vida;
            this.Defesa_Atual = defesa;
            this.Defesa_Maxima = defesa;
            this.Força = força;
            this.Nome = nome;
            this.Vocacao = Vocação.Guerreiro;



        }


        public bool EstaVivo()
        {
            if (this.Vida_Atual > 0)
                return true;
            else
                return false;
        }

        public bool Stuned()
        {
            if (StunTime == 0)
            {
                return false;
            }
            else
            {
                StunTime--;
                return true;
            }

        }

        public int MostrarDefesa() {
            if (this.Defesa_Atual > this.Defesa_Maxima)
            {
                int defender = Defesa_Atual;
                this.Defesa_Atual--;
                return defender;
            }
            else {
                return Defesa_Atual;
            }
        }




        public int MostrarPoder()
        {
            return Convert.ToInt32(this.Força);
        }

        public int Dano()
        {
            Random Critico = new Random();

            if (Critico.Next(0, 20) >= 18)
            {
                return 2 * this.Força;
            }
            else
            {
                Random Aleatorio = new Random();
                return Convert.ToInt32(this.Força * (Aleatorio.Next(50, 180) / 100.0));
            }

        }
    }
}
