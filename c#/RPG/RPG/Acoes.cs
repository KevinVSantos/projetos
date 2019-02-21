using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public interface IAcoes
    {
        void atacar<U>(U x, U y) where U:IPersonagens;


        void defender<U>(U origem) where U : IPersonagens;


        void Curar_Vida<U>(U alvo) where U : IPersonagens;


        void Curar_Mana();


        void Stunar<U>(int x , U y) where U: IPersonagens;
        
        
        

        

    }
}
