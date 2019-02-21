using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public interface IPersonagens
    {
        string Nome { get; set; }
        Vocação Vocacao { get; set; }

        int Vida_Atual { get; set; }
        int Vida_Maxima { get; set; }

        int Mana_Atual { get; set; }
        int Mana_Maxima { get; set; }

        int Cap_Atual { get; set; }
        int Cap_Maxima { get; set; }

        int Level { get; set; }
        int XpUp { get; set; }

        int Defesa_Maxima { get; set; }
        int Defesa_Atual { get; set; }

        int StunTime { get; set; }


        bool EstaVivo();
        bool Stuned();

        int MostrarDefesa();
        int MostrarPoder();
        int Dano();


    }
}
