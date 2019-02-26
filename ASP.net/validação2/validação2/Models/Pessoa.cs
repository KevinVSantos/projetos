using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace validação2.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage ="O nome deve ser preenchido.")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength =5, ErrorMessage ="A observação deve ter entre 5 e 50 caracteres.")]
        public string Observaçoes { get; set; }
        [Range(18,50, ErrorMessage ="A idade da pessoa deve ser de 18 a 50 anos.")]
        public int Idade { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage ="Login é obrigatorio.")]
        public string Login { get; set; }
        [Required(ErrorMessage ="A senha deve ser informada.")]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage ="As senhas não conferem.")]
        public string ConfirmarSenha { get; set; }

    }
}
