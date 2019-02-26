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
        [Required(ErrorMessage ="Login vazio!")]
        public string login;
        [Required(ErrorMessage = "Senha vazio!")]
        public string senha;
        [Required(ErrorMessage = "Nome vazio!")]
        public string NomeUsuario;
        [Required(ErrorMessage = "Email vazio!")]
        public string Email;

        
    }
}
