using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Models
{
    public class Login
    {
       
        public string login;
        public string senha;
        public string NomeUsuario;
        public string Email;

        public Login(string Log, string Sen, string Nome, string Mail) {
            this.login = Log;
            this.senha = Sen;
            this.NomeUsuario = Nome;
            this.Email = Mail;

        }
    }
}
