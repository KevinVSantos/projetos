using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    enum Sexo { M, F }
    class Program
    {
        public class Pessoas {
            public string nome;
            public string sobrenome;
            public int idade;
            public Sexo Sexo;
        }
        static void Main(string[] args)
        {
            List<Pessoas> Lista = new List<Pessoas>();

            Lista.Add(new Pessoas { nome="Kevin", sobrenome="Santos", idade=19, Sexo=Sexo.M  });
            Lista.Add(new Pessoas { nome = "Maria", sobrenome = "Barbosa", idade = 19, Sexo = Sexo.F });
            Lista.Add(new Pessoas { nome = "Sophia", sobrenome = "Santos", idade = 10, Sexo = Sexo.F });
            Lista.Add(new Pessoas { nome = "Lucas", sobrenome = "Barbosa", idade = 10, Sexo = Sexo.M });


            Lista.RemoveAll(x=>x.idade <=18);

            foreach (Pessoas y in Lista) {
                Console.WriteLine("{0}, {1}, {2}, {3}", y.nome, y.sobrenome, y.idade, y.Sexo);
            }
            Console.ReadKey();
        }
    }
}
