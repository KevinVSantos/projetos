using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Testes.Models;

namespace Testes.Controllers
{
    public class RegistroController:Controller
    {
        public ActionResult Index()
        {
            var Formulario = new FormCollection();

            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection Formulario) {

            
            if(string.IsNullOrEmpty(Formulario["NomeUsuario"]))
            {
                ModelState.AddModelError("NomeUsuario", "O nome esta vazio. Preencha-o.");
                
            }
            if (string.IsNullOrEmpty(Formulario["Email"]))
            {
                ModelState.AddModelError("Email", "O email esta vazio. Preencha-o.");
            }
            if (string.IsNullOrEmpty(Formulario["Senha"]))
            {
                ModelState.AddModelError("Senha", "A senha esta vazia. Preencha-a.");
            }
            if (string.IsNullOrEmpty(Formulario["Login"]))
            {
                ModelState.AddModelError("Login", "O login esta vazio. Preencha-o.");
            }
            if (ModelState.IsValid){

                var Novo = new Login() { login=Formulario["Login"], senha=Formulario["Senha"], Email=Formulario["Email"], NomeUsuario=Formulario["NomeUsuario"]};
                
                return View("Sucess", Novo);
            }

            return View();
        }
    }
}
