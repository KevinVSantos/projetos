using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Models
{
    public  class LoginList
    {
        public static List<Login> Acesso = new List<Login>();
        public static int status=0;

        public static void  IniciarLista()
        {
            if (status == 0)
            {
                Acesso.Add(new Login("123", "123", "Primeiro", "123@gmail.com"));
                Acesso.Add(new Login("456", "456", "Segundo", "456@gmail.com"));
                Acesso.Add(new Login("789", "789", "Inicial", "789@gmail.com"));
                status++;
            }

        }
    }
}
