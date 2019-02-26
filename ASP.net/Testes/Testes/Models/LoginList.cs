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

        public static void IniciarLista()
        {
            if (status == 0)
            {
                Acesso.Add(new Login() { login = "123", senha = "123", NomeUsuario = "Primeiro", Email = "123@gmail.com" });
                Acesso.Add(new Login(){ login = "456", senha = "456", NomeUsuario = "Segundo", Email = "456@gmail.com"});
            Acesso.Add(new Login(){ login = "789", senha = "789", NomeUsuario = "Inicial", Email = "789@gmail.com"});
                status++;
            }

        }
    }
}
