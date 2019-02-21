using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Magia : IAcoes
    {
        public int Turnos_Stunado;
        public int AddVida;
        public int AddMana;
        public int AddDef;
        public int Atk;

        public void atacar<U>(U origem, U alvo)where U: IPersonagens {

            int Atk = origem.MostrarPoder();

            alvo.Vida_Atual -= Convert.ToInt32(Atk*2.2);


        }
        public void defender<U>(U origem) where U : IPersonagens {

            if (origem.Vocacao == Vocação.Guerreiro)
            {
                origem.Defesa_Atual += 4;
            }
            else if (origem.Vocacao == Vocação.Mago) {
                origem.Defesa_Atual += 2;
            }


        }
        public void Curar_Vida<U>(U alvo) where U : IPersonagens {

            AddVida = alvo.MostrarPoder();
            if (alvo.Vocacao == Vocação.Mago) {
                alvo.Vida_Atual += Convert.ToInt32(AddVida * 0.6);

            }
            else if(alvo.Vocacao == Vocação.Guerreiro){
                alvo.Vida_Atual += Convert.ToInt32(AddVida * 0.8);
            }

        }
        public void Curar_Mana() { }

        public void Stunar<U>(int Stun, U alvo)
            where U : IPersonagens
        {
            alvo.StunTime = Stun;

        }

    }
    class Congelamento : Magia
    {
            
        public void Congelar<o, a>(o Origem, a Alvo)
            where a: IPersonagens
        {
            Turnos_Stunado = 2;
            Stunar(Turnos_Stunado, Alvo);
        }
    }
    class Defensivo : Magia {
        public void Armadura<U>(U origem) where U : IPersonagens {

            defender(origem);

        }


    }
    class Curar : Magia {
        public void Healing<U>(U Alvo) where U : IPersonagens
        {

            Curar_Vida(Alvo);

        }

    }

    class Ataque : Magia
    {
        public void Fire<U>(U origem, U alvo) where U : IPersonagens
        {

            atacar(origem, alvo);

        }


    }

}
