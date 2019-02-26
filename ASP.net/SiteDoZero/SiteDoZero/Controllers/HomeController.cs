using SiteDoZero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SiteDoZero.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {

            var pessoa = new Pessoa();

            pessoa.Id = 1;
            pessoa.Nome = "Kevin";
            pessoa.Email = "KVS@gmail.com";

            ViewData["PessoaId"] = pessoa.Id;
            ViewData["PessoaNome"] = pessoa.Nome;
            ViewData["PessoaEmail"] = pessoa.Email;



            return View(pessoa);
        }

        public ActionResult Sobre() {
            return View();
        }
        [HttpPost]
        public ActionResult Lista(FormCollection formulario) {
            ViewData["PessoaId"] = formulario["PessoaId"];
            ViewData["PessoaNome"] = formulario["PessoaNome"];
            ViewData["PessoaEmail"] = formulario["PessoaEmail"];
            return View();
        }

            
    }
}
