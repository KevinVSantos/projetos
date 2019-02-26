using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Testes.Models;

namespace Testes.Controllers
{
    public class HomeController:Controller
    {
        
        public ActionResult Index() {
            LoginList.IniciarLista();

            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection Formulario)
        {
            ViewData["login"] = Convert.ToString(Formulario["login"]);
            ViewData["senha"] = Convert.ToString(Formulario["senha"]);
            if (Formulario["enviar"] == "Enviar")
                return View("Resultado");
            else if (Formulario["enviar"] == "Registrar-se")
                return RedirectToAction("Index", "Registro");

            return null;
        }
    }
}
